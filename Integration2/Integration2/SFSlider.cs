using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Core;
using Wisej.Web;

namespace Integration2
{
    public class SFSlider : Widget
    {
        /// <summary>
        /// Overridden to return our list of script resources.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override List<Package> Packages
        {
            get
            {
                if (base.Packages.Count == 0)
                {
                    // initialize the loader with the required libraries.

                    base.Packages.AddRange(new Package[] {
                        new Package() {
                            Name = "ej.web.all.min.css",
                            Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/flat-azure/ej.web.all.min.css"
                },
                        new Package() {
                            Name = "jquery-1.10.2.min.js",
                            Source = "http://cdn.syncfusion.com/js/assets/external/jquery-1.10.2.min.js"
                },
                        new Package() {
                            Name = "jquery.easing.1.3.min.js",
                            Source = "http://cdn.syncfusion.com/js/assets/external/jquery.easing.1.3.min.js"
                        },
                        new Package() {
                            Name = "ej.web.all.min.js",
                            Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/ej.web.all.min.js"
                        }
                    });
                }
                return base.Packages;
            }
        }

        /// <summary>
        /// Overridden to create our initialization script.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string InitScript
        {
            get { return BuildInitScript(); }
            set { }
        }

        private string BuildInitScript()
        {
            dynamic options = new DynamicObject();

            var script = $@"this.init = function() {{
		        var me = this;
		        $(this.container).ejSlider ({{
			        minValue: 1,
			        maxValue: 25,                                    
			        incrementStep: 1,
			        value: {Value},
			        change: function(e){{ me.fireWidgetEvent(""change"", e.value); }}
	                   }});
		         }};

            this.setValue = function(value){{
	            $(this.container).ejSlider({{value:value}});
                 }};

            ";

            script = script.Replace("$options", options.ToString());
            return script;
        }

        public int Value;
    }
}