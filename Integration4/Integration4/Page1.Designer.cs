namespace Integration4
{
    partial class Page1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package2 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package3 = new Wisej.Web.Widget.Package();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.widgetInput = new Wisej.Web.Widget();
            this.widgetColorPicker = new Wisej.Web.Widget();
            this.label1 = new Wisej.Web.Label();
            this.widgetTreeMap = new Wisej.Web.Widget();
            this.widgetTagCloud = new Wisej.Web.Widget();
            this.SuspendLayout();
            // 
            // widgetInput
            // 
            this.widgetInput.InitScript = resources.GetString("widgetInput.InitScript");
            this.widgetInput.Location = new System.Drawing.Point(27, 45);
            this.widgetInput.Name = "widgetInput";
            this.widgetInput.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "jquery.min.js";
            package1.Source = "https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js";
            package2.Name = "jqx-all.js";
            package2.Source = "https://jqwidgets.com/public/jqwidgets/jqx-all.js";
            package3.Name = "jqx.base.css";
            package3.Source = "https://jqwidgets.com/public/jqwidgets/styles/jqx.base.css";
            this.widgetInput.Packages.Add(package1);
            this.widgetInput.Packages.Add(package2);
            this.widgetInput.Packages.Add(package3);
            this.widgetInput.Size = new System.Drawing.Size(213, 45);
            this.widgetInput.TabIndex = 0;
            this.widgetInput.Text = "widgetInput";
            this.widgetInput.WebRequest += new Wisej.Web.WebRequestHandler(this.widgetInput_WebRequest);
            // 
            // widgetColorPicker
            // 
            this.widgetColorPicker.InitScript = resources.GetString("widgetColorPicker.InitScript");
            this.widgetColorPicker.Location = new System.Drawing.Point(257, 20);
            this.widgetColorPicker.Name = "widgetColorPicker";
            this.widgetColorPicker.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetColorPicker.Packages.Add(package1);
            this.widgetColorPicker.Packages.Add(package2);
            this.widgetColorPicker.Packages.Add(package3);
            this.widgetColorPicker.Size = new System.Drawing.Size(277, 256);
            this.widgetColorPicker.TabIndex = 1;
            this.widgetColorPicker.Text = "widgetColorPicker";
            this.widgetColorPicker.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widgetColorPicker_WidgetEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type a dish name, e.g. Pizza";
            // 
            // widgetTreeMap
            // 
            this.widgetTreeMap.InitScript = resources.GetString("widgetTreeMap.InitScript");
            this.widgetTreeMap.Location = new System.Drawing.Point(27, 282);
            this.widgetTreeMap.Name = "widgetTreeMap";
            this.widgetTreeMap.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetTreeMap.Packages.Add(package1);
            this.widgetTreeMap.Packages.Add(package2);
            this.widgetTreeMap.Packages.Add(package3);
            this.widgetTreeMap.Size = new System.Drawing.Size(900, 600);
            this.widgetTreeMap.TabIndex = 3;
            this.widgetTreeMap.Text = "widgetTreeMap";
            // 
            // widgetTagCloud
            // 
            this.widgetTagCloud.InitScript = resources.GetString("widgetTagCloud.InitScript");
            this.widgetTagCloud.Location = new System.Drawing.Point(523, 22);
            this.widgetTagCloud.Name = "widgetTagCloud";
            this.widgetTagCloud.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetTagCloud.Packages.Add(package1);
            this.widgetTagCloud.Packages.Add(package2);
            this.widgetTagCloud.Packages.Add(package3);
            this.widgetTagCloud.Size = new System.Drawing.Size(403, 254);
            this.widgetTagCloud.TabIndex = 4;
            this.widgetTagCloud.Text = "widget1";
            this.widgetTagCloud.WebRequest += new Wisej.Web.WebRequestHandler(this.widgetTagCloud_WebRequest);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.widgetTagCloud);
            this.Controls.Add(this.widgetTreeMap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widgetColorPicker);
            this.Controls.Add(this.widgetInput);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1793, 676);
            this.Text = "Integration 4 - jQWidgets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.JavaScript javaScript1;
        private Wisej.Web.Widget widgetInput;
        private Wisej.Web.Widget widgetColorPicker;
        private Wisej.Web.Label label1;
        private Wisej.Web.Widget widgetTreeMap;
        private Wisej.Web.Widget widgetTagCloud;
    }
}

