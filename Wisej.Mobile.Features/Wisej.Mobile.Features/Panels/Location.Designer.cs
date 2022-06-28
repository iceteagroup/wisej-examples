namespace Wisej.Mobile.Features.Panels
{
    partial class Location
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
            this.geolocation1 = new Wisej.Ext.Geolocation.Geolocation(this.components);
            this.buttonGetLocation = new Wisej.Web.Button();
            this.labelLat = new Wisej.Web.Label();
            this.labelLon = new Wisej.Web.Label();
            this.checkBoxUseNativeLocationServices = new Wisej.Web.CheckBox();
            this.SuspendLayout();
            // 
            // geolocation1
            // 
            this.geolocation1.MaximumAge = ((long)(-1));
            this.geolocation1.Timeout = ((long)(-1));
            // 
            // buttonGetLocation
            // 
            this.buttonGetLocation.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonGetLocation.Location = new System.Drawing.Point(178, 150);
            this.buttonGetLocation.Name = "buttonGetLocation";
            this.buttonGetLocation.Size = new System.Drawing.Size(295, 45);
            this.buttonGetLocation.TabIndex = 19;
            this.buttonGetLocation.Text = "Get Location";
            this.buttonGetLocation.Click += new System.EventHandler(this.buttonGetLocation_Click);
            // 
            // labelLat
            // 
            this.labelLat.Anchor = Wisej.Web.AnchorStyles.None;
            this.labelLat.Location = new System.Drawing.Point(178, 259);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(295, 20);
            this.labelLat.TabIndex = 20;
            this.labelLat.Text = "Lat: 0.0";
            // 
            // labelLon
            // 
            this.labelLon.Anchor = Wisej.Web.AnchorStyles.None;
            this.labelLon.Location = new System.Drawing.Point(178, 308);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(295, 20);
            this.labelLon.TabIndex = 21;
            this.labelLon.Text = "Lon: 0.0";
            // 
            // checkBoxUseNativeLocationServices
            // 
            this.checkBoxUseNativeLocationServices.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxUseNativeLocationServices.Location = new System.Drawing.Point(178, 204);
            this.checkBoxUseNativeLocationServices.Name = "checkBoxUseNativeLocationServices";
            this.checkBoxUseNativeLocationServices.Size = new System.Drawing.Size(217, 25);
            this.checkBoxUseNativeLocationServices.TabIndex = 22;
            this.checkBoxUseNativeLocationServices.Text = "Use Native Location Services";
            // 
            // Location
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.checkBoxUseNativeLocationServices);
            this.Controls.Add(this.labelLon);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.buttonGetLocation);
            this.Name = "Location";
            this.Controls.SetChildIndex(this.buttonGetLocation, 0);
            this.Controls.SetChildIndex(this.labelLat, 0);
            this.Controls.SetChildIndex(this.labelLon, 0);
            this.Controls.SetChildIndex(this.checkBoxUseNativeLocationServices, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ext.Geolocation.Geolocation geolocation1;
        private Web.Button buttonGetLocation;
        private Web.Label labelLat;
        private Web.Label labelLon;
        private Web.CheckBox checkBoxUseNativeLocationServices;
    }
}
