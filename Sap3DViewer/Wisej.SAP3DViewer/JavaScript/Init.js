//# sourceURL=Wisej.SAP3DViewer.Init.js


// IE
if (window.Promise == null) {
    Math.imul = function (a, b) {
        return (a * b) | 0;
    }
    Math.clz32 = function (x) {
        var asUint = x >>> 0;
        if (asUint === 0) {
            return 32;
        }
        return 31 - (Math.log(asUint) / Math.LN2 | 0) | 0;
    };
}

/**
 * Initializes the widget.
 *
 * This function is called when the InitScript property of
 * wisej.web.Widget changes.
 *
 * "this" refers to the container which is a wisej.web.Widget instance.
 *
 * The widget has an inner container with id = "container" that can
 * be used referring to this.container.
 *
 */
this.init = function () {

    var me = this;
    var canvasId = this.getId() + "_3dviewer";
    this.container.innerHTML = "<canvas id='" + canvasId + "' oncontextmenu='event.preventDefault()'></canvas>";

    var canvas = document.getElementById(canvasId);
    canvas.width = this.getWidth();
    canvas.height = this.getHeight();

    // autoresize it to fill the widget container.
    this.addListener("resize", function (e) {
        var size = e.getData();
        canvas.width = size.width;
        canvas.height = size.height;

        if (this.dvl)
            this.dvl.Renderer.SetDimensions(size.width, size.height);
    });

    var devicePixelRatio = window.devicePixelRatio || 1;

    this.dvl = null;

    sap.ve.dvl.createRuntime({ totalMemory: 128 * 1024 * 1024, filePackagePrefixURL: "JavaScript/lib/" }).then(function (dvl) {

        me.dvl = dvl;

        var oDvl = dvl;
        oDvl.CreateCoreInstance(canvasId);
        oDvl.Core.Init(oDvl.Core.GetMajorVersion(), oDvl.Core.GetMinorVersion());

        oDvl.Core.CreateWebGLContext(canvas, { antialias: true, alpha: true });

        // Renderer
        oDvl.Core.InitRenderer();
        oDvl.Renderer.SetDimensions(me.getWidth(), me.getHeight());
        oDvl.Renderer.SetBackgroundColor(0.2, 0.2, 0.2, 1, 0.8, 0.8, 0.8, 1);

        oDvl.Renderer.SetOptionF(sap.ve.dvl.DVLRENDEROPTIONF.DVLRENDEROPTIONF_DPI, 96 * devicePixelRatio);
        oDvl.Core.StartRenderLoop();

        oDvl.Client.OnNodeSelectionChanged = function (clientId, sceneId, numberOfSelectedNodes, idFirstSelectedNode) {

            // Notify the widget.
            me.fireWidgetEvent("nodeSelected", {
                sceneId: sceneId,
                numberOfSelectedNodes: numberOfSelectedNodes,
                idFirstSelectedNode: idFirstSelectedNode
            });

        };

        // Basic Gesture Handling using the Loco library
        track = new sap.ve.Loco(oDvl, canvas, true);
        track.activeScaleRatio = devicePixelRatio;
    });
}


/**
 * Loads the specified file name from the server.
 * 
 * @param {String} file Relative safe file path handled by Wisej's file sysem.
 */
this.loadFile = function (file) {

    var me = this;
    var oDvl = this.dvl;
    var url = this.getPostbackUrl() + "&action=load&file=" + encodeURI(file);

    if (url) {
        var xhr = new XMLHttpRequest();

        xhr.onerror = function (event) {
            //TODO: report error
        };

        xhr.onload = function (event) {

            if (xhr.status === 200) {
                //xhr.response
                oDvl.Core.CreateFileFromArrayBuffer(xhr.response, url, "remote");
                var sceneId = oDvl.Core.LoadSceneByUrl(url, null, "remote");
                oDvl.Renderer.AttachScene(sceneId);
                oDvl.Scene.Release(sceneId);

                // notify the widget.
                me.fireWidgetEvent("loaded");

            } else {
                // TODO: report error
                // xhr.status,
                // xhr.statusText
            }
        };

        xhr.onprogress = function (event) {
            //	loaded: event.loaded,
            //	total: event.total
        };

        xhr.open("GET", url, true);
        xhr.responseType = "arraybuffer";
        xhr.send(null);
    }

}

/**
 * Plays the animated step.
 * 
 * @param {String} id ID of the step to play.
 */
this.playStep = function (id) {

    var oDvl = this.dvl;
        oDvl.Scene.ActivateStep(oDvl.Settings.LastLoadedSceneId, id, true, false);
}

/**
 * Returns the list of available procedures.
 */
this.readProcedures = function () {

    var list = [];
    var oDvl = this.dvl;
    var ps = oDvl.Scene.RetrieveProcedures(oDvl.Settings.LastLoadedSceneId);
    for (n = 0; n < ps.procedures.length; n++) {
        list.push({
            id: ps.procedures[n].id,
            name: ps.procedures[n].name
        });
    }

    return list;
}

/**
 * Returns the list of available steps in the procedure.
 * 
 * @param {String} procedureId Procedure Id.
 */
this.readSteps = function (procedureId) {

    var list = [];
    var oDvl = this.dvl;
    var ps = oDvl.Scene.RetrieveProcedures(oDvl.Settings.LastLoadedSceneId);
    for (n = 0; n < ps.procedures.length; n++) {
        if (ps.procedures[n].id == procedureId) {
            var steps = ps.procedures[n].steps;
            for (var i = 0; i < steps.length; i++)
            {
                list.push({
                    id: steps[i].id,
                    name: steps[i].name
                });
            }
            break;
		}
    }

    return list;
}