/*!
 * SAP UI development toolkit for HTML5 (SAPUI5)
 *  (C) 2014 SAP AG or an SAP affiliate company. All rights reserved.
 */

var sap = sap || {};
sap.ve = sap.ve || {};

/*
 *	This is a non-generic library used to capture and interpret user input from various devices and platforms and translate this input into
 *	jDVL Gestures and interactions.  
 */
sap.ve.Loco = sap.ve.Loco || function(oDvl, target, logEnabled) {
	/**
	 * This object provides support for internal data and operations for input handling
	 */
	var loco = {
		is2d : false,	
		activeScaleRatio : 1, 		// Used to scale coordinates when HiDPI devices are being used
		leftPressed : false, 			// Keeps track of whether the Left mouse button is pressed
		rightPressed : false, 		// Keeps track of whether the right mouse button is pressed
		middlePressed : false, 		// Keeps track of whether the middle scroll button is pressed
		allowRotate : true, 			// Used by touch handling to prevent unintentional rotating when a two finger touch is ending as the user lifts one finger off the canvas
		tapCount : 0, 						// Keeps track of taps for doubleclick, doubletap handling
		touchCount : 0, 					// Keeps track of the number of touches and used to figure out the type of gesture
		touchRefIndex : 0, 				// Keeps track of the bottom-most touch so that we can figure out where the center is going
		tapBlock : false, 				// Prevents tap from firing until the doubletab/doubleclick window has passed
		pointerRefIndex : 0,			// Analogous to touchRefIndex
		pointers : [],						// Analogous to [event].touches - manually managed by code
		pointerIds : [],					// Keeps track of active pointerIds relative to pointers[]
		gestureActive : false, 		// Indicates that the DVL core is currenting in gesturing mode
		rotationLastX : 0, 				// Tracks the last X coordinate relavent to rotation
		rotationLastY : 0, 				// Tracks the last Y coordinate relavent to rotation
		rotationX : 0, 						// Stores the current rotation X value
		rotationY : 0, 						// Stores the current rotation Y value
		panLastX : 0,							// Stores the last X position for a pan gesture
		panLastY : 0,							// Stores the last Y position for a pan gesture
		panX : 0,									// Intermediate X value used during processing of a Pan gesture 
		panY : 0,									// Intermediate Y value used during processing of a Pan gesture 
		zoomLastX : 0,						// Stores the last X position used when evaluating a zoom gesture
		zoomLastY : 0,						// Stores the last Y position used when evaluating a zoom gesture
		zoomLast : 1,							// Stores the last zoom 'value'
		zoom : 1,									// Stores the current zoom 'value'
		rotationLastProcessedX : 0,	// The 'Processed' equivalent of rotationLastX
		rotationLastProcessedY : 0,	// The 'Processed' equivalent of rotationLastY
		panLastProcessedX : 0,		// The 'Processed' equivalent of panLastX
		panLastProcessedY : 0,		// The 'Processed' equivalent of panLastY
		zoomLastProcessedX : 0,		// The 'Processed' equivalent of zoomLastX
		zoomLastProcessedY : 0,		// The 'Processed' equivalent of zoomLastY
		initialTouchSeparation : 0,				// Initial touch separation (when a second touch point is detected)
		lastTouchSeparation : 0,					// Last calculated separation of touches
		lastTouchProcessedSeparation : 0,	// Last processed separation of touches
		tapTimeOut : 150, 					// Sets the milliseconds that a browser should observe mousedown/mouseup before interpretting it as a click
		logEnabled : false,				// If set to true, outputs diagnostic information to the browser console
		target : null,						// Holds a reference to the current viewer canvas element or container
		dvl : null, 							// Holds a reference to the current instance of jDVL
		_timeouts: [],						// Used for synchronizing the rendering loops with user input actions 
		_intervals: [],						// Used for managing high frequency inputs 
		mouseDownTarget : null,		// Holds a reference to the target of the active event target
		targetPosition : {				// Holds dimension information about mouseDownTarget
			minX : 0,
			minY : 0,
			maxX : 0,
			maxY : 0
		},		
		queueCommand: function(command, rendererId) {
			var that = this;
			rendererId = typeof rendererId !== "undefined" ? rendererId : that.dvl.Settings.RendererToken;
			that.dvl.Renderer._queueCommand(command, rendererId);	
		},
		//Log to console if logging enabled
		log : function(m, forceLog) {
			var that = this;
			if (console && (that.logEnabled || forceLog)) {
				console.log(m);
			}
		},		
		//Helper function to decide whether an event occured within the target canvas
		isMoveOutsideTarget : function(ev) {
			var that = this;
			var moveX, moveY, moveX2, moveY2;
			if (that._instanceOfMouseEvent(ev)) {
				moveX = ev.pageX;
				moveY = ev.pageY;
			} else if (ev.touches) {
				moveX = ev.touches[0].pageX;
				moveY = ev.touches[0].pageY;
				if (ev.touches.length > 1) {
					moveX2 = ev.touches[1].pageX;
					moveY2 = ev.touches[1].pageY;
				}
			} else if (that._instanceOfPointerEvent(ev)) {
				moveX = ev.pageX;
				moveY = ev.pageY;
			}

			if ((moveX < that.targetPosition.minX || moveX > that.targetPosition.maxX)
					|| (moveY < that.targetPosition.minY || moveY > that.targetPosition.maxY)) {
				return true;
			} else if ((ev.touches && ev.touches.length > 1)
					&& (moveX2 < that.targetPosition.minX || moveX2 > that.targetPosition.maxX)
					|| (moveY2 < that.targetPosition.minY || moveY2 > that.targetPosition.maxY)) {
				return true;
			}
			return false;
		},

		// Decides whether we should be processing events as gestures
		gesturing : function() { 	
			var that = this;
			return (that.leftPressed 
					|| that.rightPressed 
					|| that.touchCount > 0 
					|| that.pointerIds.length > 0);
		},
		
		// Decides whether the current gesture is a zoom
		zooming : function() {
			var that = this;
			if ((that.rightPressed && !(that.leftPressed || that.middlePressed))
				 || (that.middlePressed && !(that.rightPressed || that.leftPressed))
				 || (that.touchCount == 2)
				 || (that.pointerIds.length == 2))
				 return true;
			
			return false;
		},
		
	  // Decides whether the current gesture is a Pan
		panning : function() { 
			var that = this;
			if ((that.rightPressed && that.leftPressed && !that.middlePressed)
					|| (that.touchCount >= 2) 
					|| (that.pointerIds.length >= 2))
					return true;

			return false;
		},
		
		// Decides whether the current gesture is rotation
		rotating : function() { 
			var that = this;
			if ((that.leftPressed && !(that.rightPressed || that.middlePressed)) 
				|| (that.touchCount == 1) 
				|| (that.pointerIds.length == 1))
				return true;

			return false;
		},
		
		//Cleans up event handlers and objects
		destroy : function(){
			var that = this; 
			that.log("LOCO: destroy");
			
			for ( var keyt in that._timeouts) {
				clearTimeout(that._timeouts[keyt]);
			}

			for ( var keyi in that._intervals) {
				clearInterval(that._intervals[keyi]);
			}
			
			that.dvl = null;
			
			//Unbind all the event listeners that we may have hooked up
			window.removeEventListener('contextmenu', that.contextMenuBlockerProxy);
			window.document.removeEventListener('mousewheel', that.mousewheelProxy);
			window.document.removeEventListener('DOMMouseScroll', that.mousewheelProxy);
			window.document.removeEventListener('touchstart', that.mousedownProxy);
			window.document.removeEventListener('touchmove', that.mousemoveProxy);
			window.document.removeEventListener('touchend', that.mouseupProxy);
			window.document.removeEventListener('mousedown', that.mousedownProxy);
			window.document.removeEventListener('mousemove', that.mousemoveProxy);
			window.document.removeEventListener('mouseup', that.mouseupProxy);
			window.document.removeEventListener('pointerdown', that.mousedownProxy);
			window.document.removeEventListener('pointermove', that.mousemoveProxy);
			window.document.removeEventListener('pointerup', that.mouseupProxy);
		}, 
		
		// Configures the object with a target element to monitor
		configure : function(oDvl, target, logEnabled) {
			var that = this;
			that.log("LOCO: configure");
			that.target = target;
			that.dvl = oDvl; 
			
			var isMSIE = (window.navigator &&  window.navigator.userAgent.toLowerCase().indexOf('msie') > -1) || (window.navigator &&  window.navigator.userAgent.toLowerCase().indexOf('trident') > -1);
			that.tapTimeOut = isMSIE ? 500 : 150;

			// Need to override IE on Win8 default handling for touch action because this interfers with our Viewer input handling
			if (typeof that.target.style.msTouchAction != 'undefined') {
				that.target.style.msTouchAction = "none";
			}

			if (typeof that.target.style.touchAction != 'undefined') {
				that.target.style.touchAction = "none";
			}
			
			//Set the logEnabled property 
			if (logEnabled) {
				that.logEnabled = true;
			}

			//Store the coordinate space for the target so that we can use it to determine whether events occur within this space
			that.targetPosition.minX = that._getOffset(target).left;
			that.targetPosition.minY = that._getOffset(target).top;
			that.targetPosition.maxX = that.targetPosition.minX + that._getDimensions(target).width;
			that.targetPosition.maxY = that.targetPosition.minY + that._getDimensions(target).height;

			//Lock down some more default browser behaviours for our canvas
			that._setCss(target, '-moz-transform', 'scale(1) translate(0px,0px)');
			that._setCss(target, '-webkit-transform', 'scale(1) translate(0px,0px)');
			that._setCss(target, '-o-transform', 'scale(1) translate(0px,0px)');
			that._setCss(target, '-transform', 'scale(1) translate(0px,0px)');
			that._setCss(target, 'user-select', 'none');
			that._setCss(target, '-ms-user-select', 'none');
			that._setCss(target, '-webkit-user-select', 'none');
			that._setCss(target, '-khtml-user-select', 'none');
			that._setCss(target, '-moz-user-select', 'none');
			that._setCss(target, '-webkit-touch-callout', 'none');
			that._setCss(target, '-webkit-user-drag', 'none');
			
			//Add event listeners to handle use input events 
			that.contextMenuBlockerProxy = that._contextmenuBlocker.bind(this);
			that.mouseupProxy = that._onmouseupHandler.bind(this);
			that.mousemoveProxy = that._onmousemoveHandler.bind(this);
			that.mousedownProxy = that._onmousedownTrackHandler.bind(this);
			that.mousewheelProxy = that._onmousewheelHandler.bind(this);
			
			window.addEventListener('contextmenu', that.contextMenuBlockerProxy, false);
			window.document.addEventListener('mousewheel', that.mousewheelProxy, false);
			window.document.addEventListener('DOMMouseScroll', that.mousewheelProxy, false);
			window.document.addEventListener('touchstart', that.mousedownProxy, false);
			window.document.addEventListener('touchend', that.mouseupProxy, false);
			window.document.addEventListener('mousedown', that.mousedownProxy, false);
			window.document.addEventListener('mouseup', that.mouseupProxy, false);
			window.document.addEventListener('pointerdown', that.mousedownProxy, false);
			window.document.addEventListener('pointerup', that.mouseupProxy, false);

			//Block default behaviours for certain browser events targeting the canvas control
			that.target.addEventListener('click', that._preventEventDefaults, false);
			that.target.addEventListener('dragstart', that._preventEventDefaults, false);
			that.target.addEventListener('selectstart', that._preventEventDefaults, false);
		},
		
		//Reset loco variables to a clean state. Should occur after each gesture end
		reset : function(clearButtons) {
			var that = this;
			that.log("LOCO: reset");
			
			that.rotationX = 0;
			that.rotationY = 0;
			that.rotationLastX = 0;
			that.rotationLastY = 0;
			that.panLastX = 0;
			that.panLastY = 0;
			that.rotationLastProcessedX = 0;
			that.rotationLastProcessedY = 0;
			that.panLastProcessedX = 0;
			that.panLastProcessedY = 0;
			that.zoomLastProcessedX = 0;
			that.zoomLastProcessedY = 0;
			that.panX = 0;
			that.panY = 0;
			that.zoomLastX = 0;
			that.zoomLastY = 0;
			that.zoom = 0;
			that.zoomLast = 1.0;
			that.touchRefIndex = 0;
			that.pointerRefIndex = 0;
			that.lastTouchSeparation = 0;
			that.lastTouchProcessedSeparation = 0;
			that.initialTouchSeparation = 0;
			that.mouseDownTarget = null;
			if (clearButtons) {
				that.touchCount = 0;
				that.pointerIds = [];
				that.pointers = [];
				that.leftPressed = false;
				that.rightPressed = false;
				that.middlePressed = false;
			}
		},
		
		//Update loco for button down equivalent user input
		buttonDown : function(id) {
			var that = this;
			switch (id) {
				case 0 :
					that.leftPressed = true;
					that.tapTimer.setStart();
					that.log("LOCO: buttonDown: leftPressed");
					break;
				case 1 :
					that.middlePressed = true;
					that.log("LOCO: buttonDown: middlePressed");
					break;
				case 2 :
					that.rightPressed = true;
					that.log("LOCO: buttonDown: rightPressed");
					break;
				default :
					break;
			}
		},
		
	  //Update loco for button up equivalent user input
		buttonUp : function(id) {
			var that = this;
			switch (id) {
				case 0 :
					that.leftPressed = false;
					that.tapTimer.setEnd();
					that.log("LOCO: buttonUp: leftUp");
					break;
				case 1 :
					that.middlePressed = false;
					that.log("LOCO: buttonUp: middleUp");
					break;
				case 2 :
					that.rightPressed = false;
					that.log("LOCO: buttonUp: rightUp");
					break;
				default :
					break;
			}

		},
		
		//Helper to Calculate the distance between two points 
		getDistance : function(AX, AY, BX, BY) {
			// Calculate distance between touches
			var dx = Math.abs(AX - BX);
			var dy = Math.abs(AY - BY);
			return Math.sqrt(dx * dx + dy * dy); // Hypotenuse
		},
		
		//Block rotation for a short period. This mainly for touch input after two finger gestures where for a fraction of a second one finger remaining in action could unintentionally cause a rotation event to fire
		blockRotate : function(timeouts) {
			var that = this;
			that.allowRotate = false;
			timeouts.blockRotate = setTimeout(function() {
				that.allowRotate = true;
			}, 300);
		},
		
		//Times Tap or click events. The result of which is used to evaluate likely user intent
		tapTimer : {
			_tapTime : 0,
			_tapStart : null,
			getTime : function() {
				var that = this;
				var res = that._tapTime;
				that._tapTime = 0;
				that._tapStart = null;
				return res;
			},
			setStart : function() {
				var that = this;
				that._tapStart = (new Date()).getTime();
			},
			setEnd : function() {
				var that = this;
				if (that._tapStart) {
					that._tapTime = (new Date()).getTime() - that._tapStart;
					that._tapStart = null;
				}
			}
		},
		
		//Queues a zoom  gesture based on mouse wheel data 
		queueWheelZoom : function(x, y, zoomFactor, dvl) {
			var that = this;
			if (!that.gesturing()) {
				that.queueCommand(function() {
					if (zoomFactor > 0) {
						that.blockGestures = true;
						dvl.Renderer.BeginGesture(x * that.activeScaleRatio, y * that.activeScaleRatio);
						that.log("LOCO: queueWheelZoom: BeginGesture(" + x * that.activeScaleRatio + "," + y * that.activeScaleRatio + ")");

						dvl.Renderer.Zoom(zoomFactor);
						that.log("LOCO: queueWheelZoom: Zoom(" + zoomFactor + ")");

						dvl.Renderer.EndGesture();
						that.blockGestures = false;
						that.log("LOCO: queueWheelZoom: EndGesture()");
					}
				});
			}
		},
		
		//Queues a hit test 
		queueHitTest : function(x, y, dvl, callback) {
			var that = this;
			if (that.gesturing()) {
				that.queueCommand(function() {
					dvl.Renderer.EndGesture();
					that.blockGestures = false;
					that.log("LOCO: queueHitTest: EndGesture()");
				});
			}

			that.queueCommand(function() {
				var res = dvl.Renderer.HitTest(x * that.activeScaleRatio, y * that.activeScaleRatio);
				that.log("LOCO: queueHitTest: HitTest(" + x * that.activeScaleRatio + "," + y * that.activeScaleRatio + ")");
				callback(res);
			});
		},
		
		//Queues a Begin Gesture 
		queueBeginGesture : function(dvl) {
			var that = this;
			if (that.gestureActive) {
				that.queueCommand(function() {
					dvl.Renderer.EndGesture();
				});
				that.gestureActive = false;
			}

			if (!that.gestureActive) {
				var x, y;
				that.gestureActive = true;

				if (that.rotating()) {
					x = that.rotationLastX;
					y = that.rotationLastY;
					that.rotationLastProcessedX = x;
					that.rotationLastProcessedY = y;
				} else if (that.touchCount == 0) {
					if (that.zooming()) {
						x = that.zoomLastX;
						y = that.zoomLastY;
						that.zoomLastProcessedX = x;
						that.zoomLastProcessedY = y;
					} else {
						x = that.panLastX;
						y = that.panLastY;
						that.panLastProcessedX = x;
						that.panLastProcessedY = y;
					}
				} else if (that.touchCount > 1 || that.pointers.lenght > 0) { // Note: with touch we prefer the panning x & y
																																			// because these are left button based for mouse and
																																			// the same as zoom for touch.
					x = that.panning() ? that.panLastX : that.zoomLastX;
					y = that.panning() ? that.panLastY : that.zoomLastY;
					that.panLastProcessedX = that.panLastX;
					that.panLastProcessedY = that.panLastY;
					that.zoomLastProcessedX = that.zoomLastX;
					that.zoomLastProcessedY = that.zoomLastY;
				}

				that.queueCommand(function() {
					dvl.Renderer.BeginGesture(x * that.activeScaleRatio, y * that.activeScaleRatio);
					that.log("LOCO: queueBeginGesture: BeginGesture(" + x * that.activeScaleRatio + "," + y * that.activeScaleRatio + ")");
				});
			}
		},
		
		//Queues an end gesture 
		queueEndGesture : function(dvl) {
			var that = this;
			if (that.gestureActive) {
				that.queueCommand(function() {
					dvl.Renderer.EndGesture();
					that.blockGestures = false;
					that.log("LOCO: queueEndGesture: EndGesture()");
				});
			}
			that.gestureActive = false;

		},
		
		//Queues a move gesture 
		queueMoveGesture : function(dvl) {
			var that = this;
			if (!that.blockGestures) {
				if (!that.moveProcessing) {
					that.moveProcessing = true;

					// Pan
					if (that.panning()) {
						that.queueCommand(function() {
							dvl.Renderer.Pan(that.panX, that.panY);
							that.panLastProcessedX = that.panLastX;
							that.panLastProcessedY = that.panLastY;
							that.log("LOCO: queueMoveGesture: Pan(" + that.panX + "," + that.panY + ")");
						});
					}

					// Rotate
					if (that.rotating() && that.allowRotate) {
						that.queueCommand(function() {
							dvl.Renderer.Rotate(that.rotationX, that.rotationY);
							that.rotationLastProcessedX = that.rotationLastX;
							that.rotationLastProcessedY = that.rotationLastY;
							that.log("LOCO: queueMoveGesture: Rotate(" + that.rotationX + "," + that.rotationY + ")");
						});
					}

					// zoom
					if (that.zooming()) {
						that.queueCommand(function() {
							if (that.zoom > 0) {
								dvl.Renderer.Zoom(that.zoom);
								that.zoomLastProcessedX = that.zoomLastX;
								that.zoomLastProcessedY = that.zoomLastY;
								that.lastTouchProcessedSeparation = that.lastTouchSeparation;
								that.log("LOCO: queueMoveGesture: Zoom(" + that.zoom + ")");
							}
						});
					}
				}
				that.moveProcessing = false;
			} else {
				that.log("LOCO: queueMoveGesture: ATTEMPTED MOVE WHILE BLOCKED!");
			}
		}, 
		
		//Set style 
		_setCss: function(element, name, value){
				if("jQuery" in window) {
					jQuery(element).css(name, value);
				}
			else {
				if("style" in element){
						switch(name)
						{
							case "-transform":
								element.style.x = value; 
								break;
							case "-moz-transform":
								element.style.MozTransform = value; 
								break;
							case "-webkit-transform":
								element.style.webkitTransform = value; 
								break;
							case "user-select":
								element.style.userSelect = value; 
								break;
							case "-user-select":
								element.style.userSelect = value; 
								break;
							case "-ms-user-select":
								element.style.userSelect = value; 
								break;
							case "-webkit-user-select":
								element.style.webkitUserSelect = value; 
								break;
							case "-moz-user-select":
								element.style.MozUserSelect = value; 
								break;
							case "-webkit-touch-callout":
								element.style.webkitTouchCallout = value; 
								break;
							case "-webkit-user-drag":
								element.style.webkitUserDrag = value; 
								break;
							default:
								if("setProperty" in element.style){
										element.style.setProperty(name, value);
									}
								break;
						}
					}
			}
			
		},
		
		// Cross-browser element width/height function 
		_getDimensions: function(element){
			var _dims = {
					width: 0,
					height: 0
			}; 
			
			if("jQuery" in window) {
				_dims.width = jQuery(element).width();
				_dims.height = jQuery(element).height(); 
			}
		else {
				if("style" in element){
						_dims.width = parseInt(element.style.width.replace("px",""));
						_dims.height = parseInt(element.style.height.replace("px",""));
					}
				else if("scrollWidth" in element){
					_dims.width = element.scrollWidth; 
					_dims.height = element.scrollHeight;
					}
				else if("offsetWidth" in element){
						_dims.width = element.offsetWidth; 
						_dims.height = element.offsetHeight; 
					}
				else if("clientWidth" in element){
					_dims.width = element.clientWidth; 
					_dims.height = element.clientHeight; 
					}
				}
			return _dims; 
		},
		
		
		// Cross-browser element offset calculation
		_getOffset: function(element){
			if("jQuery" in window) {
					return jQuery(element).offset();
				}
			else {
					var _body = document.body; 
			    var _window = document.defaultView;
			    var _documentElement = document.documentElement;
			    var _boundingBox = document.createElement('div');
			    _boundingBox.style.paddingLeft = _boundingBox.style.width = "1px";
			    _body.appendChild(_boundingBox);
			    
			    //Figure out if the browser has implemented the box model
			    var isBoxModel = _boundingBox.offsetWidth == 2;
			    	_body.removeChild(_boundingBox);
			    	_boundingBox = element.getBoundingClientRect();
			    
			    //Figure out the offsets
			    var clientTop  = _documentElement.clientTop  || _body.clientTop  || 0,
			      clientLeft = _documentElement.clientLeft || _body.clientLeft || 0,
			      scrollTop  = _window.pageYOffset || isBoxModel && _documentElement.scrollTop  || _body.scrollTop,
			      scrollLeft = _window.pageXOffset || isBoxModel && _documentElement.scrollLeft || _body.scrollLeft;
			  return {
			      top : _boundingBox.top  + scrollTop  - clientTop,
			      left: _boundingBox.left + scrollLeft - clientLeft
			      };
					}
		},
		
		//Attempts to block all events related to context menus on the canvas
		_contextmenuBlocker: function(ev) {
			var that = this;
			if (ev.button && ev.button == 2 && that.target == ev.target) {
				if (ev.preventBubble) {
					if (ev.stopPropagation) {
						ev.stopPropagation(); 
					}
					ev.cancelBubble = true; 
				}
				if (ev.preventDefault) {
					if (ev.preventManipulation) {
						ev.preventManipulation(); 
					}
					if (ev.preventDefault) {
						ev.preventDefault(); 
						ev.returnValue = false; 
						that.log("LOCO: _contextmenuBlocker: ContextMenuBlocked");
					}
				}
				return false;
			}
		}, 
		
	  // Private method to encaptulate general code to prevent event bubbling/propagation
		_preventEventDefaults: function(ev) {
			// stop drag start event for the canvas control
			if (ev && ev.stopPropagation)
				ev.stopPropagation();

			// stop default panning and zooming
			if (ev && ev.preventManipulation)
				ev.preventManipulation();

			// we are handling this event
			if (ev && ev.preventDefault)
				ev.preventDefault();

			return false;
		},
		
		// Function is called when touchend/mouseup occurs .
		_onmouseupHandler: function(ev) {
			var that = this;
			that.log("LOCO: _onmouseupHandler");
			
			if (!ev._sapui_handledByControl && !(that._instanceOfPointerEvent(ev) && ev.pointerType == "mouse")) {
				console.log("LOCO: mouseupHandler: PointerId(" + ev.pointerId +")");
				//Check if the targets still match
				if (that.mouseDownTarget == that.target) {
					//Block default browser handlers 
					that._preventEventDefaults(ev);
				}

				// Handle Touch
				if (that._instanceOfTouchEvent(ev)) {
					that.touchCount = 0;
					
					// Momentarily Prevent slight differences in finger up on pan/zoom from rotating
					that.blockRotate(that._timeouts);
				} 
				// Handle Non-mouse Pointer 
				else if (that._instanceOfPointerEvent(ev) && ev.pointerType != "mouse") {
					
					// Release pointer capture if set
					if (that.target.releasePointerCapture) { 
						try {
							that.target.releasePointerCapture(ev.pointerId);
						} catch (e) {
							that.log(e);
						}
					}

					// Remove the pointerId from the Ids array and remove the value from the pointers array
					var pointerIdIndex = that.pointerIds.indexOf(ev.pointerId);
					if (pointerIdIndex != -1) {
						that.pointerIds.splice(pointerIdIndex, 1);
					}

					if (that.pointers[ev.pointerId]) {
						that.pointers.splice(ev.pointerId, 1);
					}

					//If this event is for the primary pointer then reset
					if (ev.isPrimary) {
						that.pointers = [];
						that.pointerIds = [];
						that.pointerRefIndex = 0;
					}
					
					// Momentarily Prevent slight differences in finger up on pan/zoom from rotating
					that.blockRotate(that._timeouts); 
				} 
				// Handle Mouse
				else if (that._instanceOfMouseEvent(ev)) {
					that.buttonUp(ev.button);
					that.touchCount = 0;
				}

				//Clean up listeners 
				ev._sapui_handledByControl = true;
				window.document.removeEventListener('pointermove', that.mousemoveProxy);
				window.document.removeEventListener('touchmove', that.mousemoveProxy);
				window.document.removeEventListener('mousemove', that.mousemoveProxy);

				// Stop processing movements
				clearInterval(that._intervals.move);
				
				// Reset coordinate data, but not button/touch info as this might be used by click
				that.reset(true); 

				// Check that the actions above have terminated input and force if not
				if (!that.gesturing() && that.gestureActive) {
					that.queueEndGesture(that.dvl);
				} 
				// Forcibly end gesturing after a timeout
				else if (that.gestureActive) { 
					that.blockGestures = true;
					that._timeouts.up = setTimeout(function() {
						
						// cancel the event
						that.queueEndGesture(that.dvl);
					}, 300);
				}
				return false;
			}
			return true;
		},
		
		/*
		 * Cross browser helper function to test instance relationship to event types
		 */
		_instanceOfPointerEvent: function(target) {
			if (window.PointerEvent) {
				if (target instanceof window.PointerEvent) {
					return true;
				}
			}
			return false;
		},

		/*
		 * Cross browser helper function to test instance relationship
		 */
		_instanceOfTouchEvent: function(target) {
			if (window.TouchEvent) {
				if (target instanceof window.TouchEvent) {
					return true;
				}
			}
			return false;
		},

		/*
		 * Cross browser helper function to test instance relationship
		 */
		_instanceOfMouseEvent: function(target) {
			if (window.MouseEvent) {
				if (target instanceof window.MouseEvent) {
					return true;
				}
			}
			return false;
		},

		//Handling of the mousewheel events in browsers that use 'event.WheelDelta' - based on an increment around 120
		//http://www.javascriptkit.com/javatutors/onmousewheel.shtml
		_onmousewheelHandler: function(e) {
			var that = this;
			var ev = e.originalEvent ? e.originalEvent : e;

			// See if move event occured outside target. If it was and we are gesturing then end gesture
			if (!that.isMoveOutsideTarget(ev)) {
				var delta = ev.detail ? ev.detail * (-120) : ev.wheelDelta; 

				var x = (ev.offsetX || ev.clientX - that._getOffset(ev.target).left + window.pageXOffset); // Firefox Support
				var y = (ev.offsetY || ev.clientY - that._getOffset(ev.target).top + window.pageYOffset); // Firefox Support
				
				//Scale the mouse wheel data for our zoom ratio
				var zMouse = 1.0 + (delta / 1500);
				if (zMouse < 0.1) {
					zMouse = 0.1;
				} else if (zMouse > 10.0) {
					zMouse = 10.0;
				}
				
				that.queueWheelZoom(x, y, zMouse, that.dvl);
				return false;
			}
			return true;
		},
		
		//Intercept and track all mousedown events so that we can disable browser default zoom and scroll behaviours for events
		//origination from within the canvas
		_onmousedownTrackHandler: function(ev) {
			var that = this;
			var retval = true; 
			that.log("LOCO: _onmousedownTrackHandler: PointerId(" + ev.pointerId +")");
			
			// Record the current target for mouse down so that we can figure out whether to disable behaviour
			that.mouseDownTarget = ev.target;
			
			//If the event is a PointerEvent and it is from a mouse then throw it away because pointer events only fire for the first mouse click and hold which means we
			// don't get a chance to see the second button press and are better off waiting for the mousedown event and handling it with the old code
			if (that._instanceOfPointerEvent(ev) && ev.pointerType == "mouse") {
				retval = true; 
			} else if (that.target == ev.target) { //If it is an event we are interested in and within the correct target then handle it
				
				//Block default browser handlers 
				that._preventEventDefaults(ev);

				// Forward the event to the mouse down handler
				that._onmousedownHandler(ev);
				retval = false;
			}
			
			return retval; //Let the default mechanism handle this
		},
		
		//Handles mouse down events for the canvas object
		//Note: http://www.w3.org/TR/pointerevents/#chorded-button-interactions relevant
		_onmousedownHandler: function(ev) {
			var that = this;

			//Only handle mousedown if the canvas is targeted - doubling up a little here, but we want to be sure
			if (!ev._sapui_handledByControl && that.target == ev.target) { 

				// Keep track of the event targets
				that.mouseDownTarget = ev.target;

				// Shared Variables
				var canvasX = 0;
				var canvasY = 0;

				// cancel the event
				ev._sapui_handledByControl = true;

				//Handle pointer event first because it inherits from MouseEvent so instanceOf check can misreport e.g. instanceOf MouseEvent == true
				if (that._instanceOfPointerEvent(ev) && ev.pointerType != "mouse") {
					
					// If the pointer is primary, then we have a fresh interaction so clear the pointer info
					if (ev.isPrimary) {
						that.pointers = [];
						that.pointerIds = [];
						that.pointerRefIndex = 0;
					}

					//Add it to the array
					that.pointerIds.push(ev.pointerId);
					that.pointers[ev.pointerId] = ev;

					// Set Pointer Capture if supported by element
					if ('setPointerCapture' in that.target) {
						that.target.setPointerCapture(ev.pointerId);
					}

					// Reset other event types - just in case something else hasn't reset them for us
					that.leftPressed = that.rightPressed = that.middlePressed = false; // Ignoring mouse
					that.touches = 0;

					//Check to see if current state indicates that we are rotating 
					if (that.rotating()) {
						
						// Get the location of the event
						that.rotationLastX = that.pointers[ev.pointerId].pageX - that._getOffset(ev.target).left; 
						that.rotationLastY = that.pointers[ev.pointerId].pageY - that._getOffset(ev.target).top; 
					}

					//Check to see if current state indicates that we are zooming or panning 
					if (that.panning() || that.zooming()) {
						
					// set flag to indicate index of touch closest to bottom
						that.pointerRefIndex = (that.pointers[that.pointerIds[0]].pageY >= that.pointers[that.pointerIds[1]].pageY)
								? 0
								: 1; 
						var refPointerId = that.pointerIds[that.pointerRefIndex];
						var otherIndex = that.pointerIds[Math.abs(that.pointerRefIndex - 1)];

						//Calculate the point spacing 
						var dx = that.pointers[otherIndex].pageX - that.pointers[refPointerId].pageX;
						var dy = that.pointers[otherIndex].pageY - that.pointers[refPointerId].pageY;

						//Figure out where the midpoint of a two fingured gesture is 
						var centerX = (that.pointers[refPointerId].pageX - that._getOffset(ev.target).left) + (dx / 2); // Midpoint
						var centerY = (that.pointers[refPointerId].pageY - that._getOffset(ev.target).top) + (dy / 2); // Midpoint

						//Calculate how far apart the two points are 
						that.lastTouchSeparation = that.lastTouchProcessedSeparation = that.initialTouchSeparation = that.getDistance(that.pointers[that.pointerIds[0]].pageX,
										that.pointers[that.pointerIds[0]].pageY, that.pointers[that.pointerIds[1]].pageX,
										that.pointers[that.pointerIds[1]].pageY);
						
						//Use the above info to set the initial values for a zoom or pan gesture 
						that.zoomLastX = centerX;
						that.zoomLastY = centerY;
						
						// Added that.loco.panLastProcessedX because in move it was resulting in massive initial pan as = 0 
						that.panLastX = that.panLastProcessedX = centerX; 
						that.panLastY = that.panLastProcessedY = centerY;
					}

					// Detect if we are dealing with a quick 'tap' and fire click event if we are
					that._timeouts.down = setTimeout(function() {
						if (!that.gesturing()) {
							
							// fire the click handler
							that._onclickHandler(ev, true); 
						} else if (!that.gestureActive) {
							
							//Fire the begin gesture and start tracking movement in the browser 
							that.queueBeginGesture(that.dvl);
							window.document.addEventListener('pointermove', that.mousemoveProxy, false);

						// Move gesture is queued out of sequence in a timer to reduce the load
							that._intervals.move = setInterval(function() { 
								
								// Perform mouse Pan zoom or rotate
								that.queueMoveGesture(that.dvl);
							}, 30);
						}
					}, that.tapTimeOut);
					that.log("LOCO: _onmousedownHandler: Exit Pointer ");
					return false; //exit mouse down handler and prevent event propagation	
				} 
				
				// Handle a mouse down event
				else if (that._instanceOfMouseEvent(ev)) { 
					
					// Get the location of the event
					canvasX = (ev.offsetX || ev.clientX - that._getOffset(ev.target).left + window.pageXOffset); // The || is for Firefox Support
					canvasY = (ev.offsetY || ev.clientY - that._getOffset(ev.target).top + window.pageYOffset); // The || is for Firefox Support

					// Detect left button
					if (ev.button == 0) 
					{
						// rotating
						if (!that.rightPressed) { 
							that.rotationLastX = canvasX;
							that.rotationLastY = canvasY;
						} 
						// panning
						else { 
							that.panLastX = canvasX;
							that.panLastY = canvasY;
						}
					}

					// Detect  middle button and handle as zooming
					if (ev.button == 1) { 
						that.zoomLastX = canvasX;
						that.zoomLastY = canvasY;

					}

					// Detect the right button 
					if (ev.button == 2) {
						
						// zooming
						if (!that.leftPressed) { 
							that.zoomLastX = canvasX;
							that.zoomLastY = canvasY;
						} 
						// panning
						else { 
							that.panLastX = canvasX;
							that.panLastY = canvasY;
						}
					}

					//Tell loco to manage the button event
					that.buttonDown(ev.button);
					
					// Reset / Ignore touch
					that.touchCount = 0; 

					// Detect if we are dealing with a quick 'tap' and fire click event if we are
					that._timeouts.down = setTimeout(function() {
						if (ev.button == 0 && !that.gesturing()) {
							
							// fire the click handler
							that._onclickHandler(ev, true); 
						}
					}, that.tapTimeOut);
				}
				
				// Handle touch events
				else if (that._instanceOfTouchEvent(ev) && ev.touches && ev.touches.length > 0) {
					
					//Tell loco that we are dealing with a touch event
					that.touchCount = ev.touches.length;
					
					// Ignore mouse and reset pointer handling 
					that.leftPressed = that.rightPressed = that.middlePressed = false; 
					that.pointers = that.pointerIds = [];
					that.pointerRefIndex = 0;

					//Check to see if current state indicates that we are rotating 
					if (that.rotating()) {
						
						// Get the location of the event
						that.rotationLastX = ev.touches[0].pageX - that._getOffset(ev.target).left; // Touch X
						that.rotationLastY = ev.touches[0].pageY - that._getOffset(ev.target).top; // Touch Y
					}

					//Check to see if current state indicates that we are panning or zooming  
					if (that.panning() || that.zooming()) {
						
						// set flag to indicate index of touch closest to bottom
						that.touchRefIndex = (ev.touches[0].pageY >= ev.touches[1].pageY) ? 0 : 1; 
						var otherIndex = Math.abs(that.touchRefIndex - 1);

						var dx = ev.touches[otherIndex].pageX - ev.touches[that.touchRefIndex].pageX;
						var dy = ev.touches[otherIndex].pageY - ev.touches[that.touchRefIndex].pageY;

						var centerX = (ev.touches[that.touchRefIndex].pageX - that._getOffset(ev.target).left) + (dx / 2); // Midpoint
						var centerY = (ev.touches[that.touchRefIndex].pageY - that._getOffset(ev.target).top) + (dy / 2); // Midpoint

						that.lastTouchSeparation = that.lastTouchProcessedSeparation = that.initialTouchSeparation = that.getDistance(ev.touches[0].pageX, ev.touches[0].pageY, ev.touches[1].pageX, ev.touches[1].pageY);
						that.zoomLastX = centerX;
						that.zoomLastY = centerY;
						that.panLastX = centerX;
						that.panLastY = centerY;
					}

					// Detect if we are dealing with a quick 'tap' and fire click event if we are
					that._timeouts.down = setTimeout(function() {
						if (!that.gesturing()) {
							
							// fire the click handler
							that._onclickHandler(ev, true); 
						} else if (!that.gestureActive) {
							
							that.queueBeginGesture(that.dvl);
							window.document.addEventListener('touchmove', that.mousemoveProxy, false);
							window.document.addEventListener('mousemove', that.mousemoveProxy, false);

							// Move gesture is queued in a timer to reduce the load
							that._intervals.move = setInterval(function() { 
								
								// Perform mouse Pan zoom or rotate
								that.queueMoveGesture(that.dvl);
							}, 30);
						}
					}, that.tapTimeOut);
					that.log("LOCO: _onmousedownHandler: Exit Touch ");
					return false;
				}

				// Queue mouse based gestures. We do this at the end to allow some processing time to aquire two clicks. 
				if (!that.gestureActive) {
					that.queueBeginGesture(that.dvl);
					window.document.addEventListener('touchmove', that.mousemoveProxy, false);
					window.document.addEventListener('mousemove', that.mousemoveProxy, false);
				}
			}
			return false;
		},
		
		//Function is called when touchmove/mousemove occurs while button pressed.
		_onmousemoveHandler: function(ev) {
			var that = this;
			that.log("LOCO: _onmousemoveHandler");
			
			if(!that.gesturing()){
				that.log("LOCO: _onmousemoveHandler: No gesture active. Stop processing");
				return true;
				}
			
			
			//Block default move actions for touch in the browser
			if ('ontouchstart' in window) {
				if (that.mouseDownTarget == that.target) {
					
					//Block default browser handlers 
					that._preventEventDefaults(ev);
				}
			}

			// See if move event occured outside target. If it was and we are gesturing then end gesture
			if (that.isMoveOutsideTarget(ev)) {
				that._onmouseupHandler(ev);
			}

			//If we haven't already handled this event then do so now
			if (!ev._sapui_handledByControl) {

				// Shared Variables
				var canvasX = 0;
				var canvasY = 0;

				// cancel the event
				ev._sapui_handledByControl = true;

				// Handle pointer events first
				if (that._instanceOfPointerEvent(ev) && ev.pointerType != "mouse") {
					
					// Update the corresponding pointer data
					that.pointers[ev.pointerId] = ev;

					// Rotating
					if (that.rotating()) { 
						canvasX = that.pointers[ev.pointerId].pageX - that._getOffset(ev.target).left;
						canvasY = that.pointers[ev.pointerId].pageY - that._getOffset(ev.target).top;

						that.rotationX = (canvasX - that.rotationLastProcessedX);
						that.rotationY = (canvasY - that.rotationLastProcessedY);
						that.rotationLastX = canvasX;
						that.rotationLastY = canvasY;
					}

					if (that.panning() || that.zooming()) {
						var refPointerId = that.pointerIds[that.pointerRefIndex];
						var otherIndex = that.pointerIds[Math.abs(that.pointerRefIndex - 1)];
						var dx = that.pointers[otherIndex].pageX - that.pointers[refPointerId].pageX;
						var dy = that.pointers[otherIndex].pageY - that.pointers[refPointerId].pageY;

						var centerX = (that.pointers[refPointerId].pageX - that._getOffset(ev.target).left) + (dx / 2); // Midpoint
						var centerY = (that.pointers[refPointerId].pageY - that._getOffset(ev.target).top) + (dy / 2); // Midpoint

						// Panning - the difference in the center x and center y since last move (distance the center has travelled)
						that.panX = (centerX - that.panLastProcessedX);
						that.panY = (centerY - that.panLastProcessedY);
						that.panLastX = centerX;
						that.panLastY = centerY;

						// Zooming - the difference between the last separation of the two touches and the new separation of the two
						// touches (distance between them)
						var thisTouchSeparation = that.getDistance(that.pointers[that.pointerIds[0]].pageX,
								that.pointers[that.pointerIds[0]].pageY, that.pointers[that.pointerIds[1]].pageX,
								that.pointers[that.pointerIds[1]].pageY);

						// //New Approach: Calculate the percentage change since the last movement relative to the initial separation
						var zoomFactor = 1.0 - ((that.lastTouchProcessedSeparation - thisTouchSeparation) * (1 / that.initialTouchSeparation));

						that.lastTouchSeparation = thisTouchSeparation;
						that.zoomLastX = centerX;
						that.zoomLastY = centerY;
						that.zoom = zoomFactor;
					}
					that.zoomLast = zoomFactor;
				} 
				
				// Handle mouse move events
				else if (that._instanceOfMouseEvent(ev)) {
					canvasX = (ev.offsetX || ev.clientX - that._getOffset(ev.target).left + window.pageXOffset); // Firefox Support
					canvasY = (ev.offsetY || ev.clientY - that._getOffset(ev.target).top + window.pageYOffset); // Firefox Support

					if (that.rotating()) {
						that.rotationX = (canvasX - that.rotationLastX);
						that.rotationY = (canvasY - that.rotationLastY);
						that.rotationLastX = canvasX;
						that.rotationLastY = canvasY;
					}

					if (that.panning()) {
						
						// Find the change in the x/y
						that.panX = (canvasX - that.panLastX);
						that.panY = (canvasY - that.panLastY);
						that.panLastX = canvasX;
						that.panLastY = canvasY;
					}

					// Does not yet handle center wheel - need to branch logic for this
					if (that.zooming()) { 
						var yDistance = (canvasY - that.zoomLastY);
						that.zoomLastY = canvasY;

						var zMouse = 1.0 - (yDistance / 150.0);
						if (zMouse < 0.1) {
							zMouse = 0.1;
						} else if (zMouse > 10.0) {
							zMouse = 10.0;
						}
						that.zoom = zMouse;
					}
					
					// Perform mouse Pan zoom or rotate
					that.queueMoveGesture(that.dvl);
				} 
				
				// Handle touch move event
				else if (that._instanceOfTouchEvent(ev)) {
					
					// Rotating
					if (that.rotating()) { 
						canvasX = ev.touches[0].pageX - that._getOffset(ev.target).left;
						canvasY = ev.touches[0].pageY - that._getOffset(ev.target).top;

						that.rotationX = (canvasX - that.rotationLastProcessedX);
						that.rotationY = (canvasY - that.rotationLastProcessedY);
						that.rotationLastX = canvasX;
						that.rotationLastY = canvasY;
					}

					if (that.panning() || that.zooming()) {
						var otherIndex = Math.abs(that.touchRefIndex - 1);
						var dx = ev.touches[otherIndex].pageX - ev.touches[that.touchRefIndex].pageX;
						var dy = ev.touches[otherIndex].pageY - ev.touches[that.touchRefIndex].pageY;

						var centerX = (ev.touches[that.touchRefIndex].pageX - that._getOffset(ev.target).left) + (dx / 2); // Midpoint
						var centerY = (ev.touches[that.touchRefIndex].pageY - that._getOffset(ev.target).top) + (dy / 2); // Midpoint

						// Panning - the difference in the center x and center y since last move (distance the center has travelled)
						that.panX = (centerX - that.panLastProcessedX);
						that.panY = (centerY - that.panLastProcessedY);
						that.panLastX = centerX;
						that.panLastY = centerY;

						// Zooming - the difference between the last separation of the two touches and the new separation of the two
						// touches (distance between them)
						var thisTouchSeparation = that.getDistance(ev.touches[0].pageX, ev.touches[0].pageY, ev.touches[1].pageX,
								ev.touches[1].pageY);

						// //New Approach: Calculate the percentage change since the last movement relative to the initial separation
						var zoomFactor = 1.0 - ((that.lastTouchProcessedSeparation - thisTouchSeparation) * (1 / that.initialTouchSeparation));

						that.lastTouchSeparation = thisTouchSeparation;
						that.zoomLastX = centerX;
						that.zoomLastY = centerY;
						that.zoom = zoomFactor;
					}
					that.zoomLast = zoomFactor;
				}
				return false;
			}
			return true;
		},

		//Function is called when tap occurs on button.
		_onclickHandler: function(ev, isForwarded) {
			var that = this;
			if (that.mouseDownTarget == that.target) {
				
				//Block default browser handlers 
				that._preventEventDefaults(ev);
			}

			if ((!ev._sapui_handledByControl || isForwarded) && that.target == ev.target) {

				// Cancel active gesturing
				if (that.gestureActive) {
					that.queueEndGesture(that.dvl);
					that.log("LOCO: _onclickHandler: End Gesture from click");
					that.reset(true);
				}

				// cancel the event
				ev._sapui_handledByControl = true;

				var clickX, clickY;
				if (that._instanceOfTouchEvent(ev)) {
					clickX = (ev.offsetX || ev.touches[0].clientX - that._getOffset(ev.target).left + window.pageXOffset)
							* that.activeScaleRatio; // Firefox Support
					clickY = (ev.offsetY || ev.touches[0].clientY - that._getOffset(ev.target).top + window.pageYOffset)
							* that.activeScaleRatio; // Firefox Support

				} else {
					clickX = (ev.offsetX || ev.clientX - that._getOffset(ev.target).left + window.pageXOffset)
							* that.activeScaleRatio; // Firefox Support
					clickY = (ev.offsetY || ev.clientY - that._getOffset(ev.target).top + window.pageYOffset)
							* that.activeScaleRatio; // Firefox Support
				}

				if (that.is2d) {
					that.queueCommand(function() {
						that.dvl.Renderer.Tap(clickX, clickY, false, true);
						that.log("LOCO: _onclickHandler: Tap(" + clickX + "," + clickY + "," + false + true +")");
					});
				}
				else 
				{
					// Register the tap
					that.tapCount++;

					// Process the tap
					if (that.tapCount > 1) {
						that.tapBlock = true;
						that.queueCommand(function() {
							that.dvl.Renderer.Tap(clickX, clickY, true, true);
							that.log("LOCO: _onclickHandler: Tap(" + clickX + "," + clickY + "," + true + true +")");
						});
					} else if (that.tapCount == 1) { // We have one confirmed click, so we start listening for another and get
																								// ready to select if another not triggered
						that._timeouts.tap = setTimeout(function() {
							if (!that.tapBlock) {
								that.queueCommand(function() {
									that.dvl.Renderer.Tap(clickX, clickY, false, true);
									that.log("LOCO: _onclickHandler: Tap(" + clickX + "," + clickY + "," + false + true +")");
								});
							}
	
							// 500ms has passed and we have either execute the tap code or not, either way we reset the clock
							that.tapCount = 0;
							that.tapBlock = false;
							that.reset(true);
						}, 500);
					}
				}
			}
			return false;
		}
	};
	
	loco.configure(oDvl, target, logEnabled);
	return loco; 
};

