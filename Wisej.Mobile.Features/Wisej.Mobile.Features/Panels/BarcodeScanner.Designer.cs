namespace Wisej.Mobile.Features.Panels
{
    partial class BarcodeScanner
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
            this.camera1 = new Wisej.Web.Ext.Camera.Camera();
            this.comboBoxFacingMode = new Wisej.Web.ComboBox();
            this.spacer1 = new Wisej.Web.Spacer();
            this.barcodeReader1 = new Wisej.Web.Ext.Barcode.BarcodeReader(this.components);
            this.SuspendLayout();
            // 
            // camera1
            // 
            this.camera1.Dock = Wisej.Web.DockStyle.Fill;
            this.camera1.FacingMode = Wisej.Web.Ext.Camera.Camera.VideoFacingMode.Environment;
            this.camera1.Location = new System.Drawing.Point(16, 208);
            this.camera1.Name = "camera1";
            this.camera1.ObjectFit = Wisej.Web.ObjectFit.Cover;
            this.camera1.Size = new System.Drawing.Size(618, 254);
            this.camera1.TabIndex = 19;
            this.camera1.Text = "camera1";
            // 
            // comboBoxFacingMode
            // 
            this.comboBoxFacingMode.AutoSize = false;
            this.comboBoxFacingMode.Dock = Wisej.Web.DockStyle.Top;
            this.comboBoxFacingMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxFacingMode.LabelText = "Video Facing Mode";
            this.comboBoxFacingMode.Location = new System.Drawing.Point(16, 128);
            this.comboBoxFacingMode.Name = "comboBoxFacingMode";
            this.comboBoxFacingMode.Size = new System.Drawing.Size(618, 60);
            this.comboBoxFacingMode.TabIndex = 20;
            this.comboBoxFacingMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacingMode_SelectedIndexChanged);
            // 
            // spacer1
            // 
            this.spacer1.Dock = Wisej.Web.DockStyle.Top;
            this.spacer1.Location = new System.Drawing.Point(16, 188);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(618, 20);
            // 
            // barcodeReader1
            // 
            this.barcodeReader1.Camera = this.camera1;
            this.barcodeReader1.ScanSuccess += new Wisej.Web.Ext.Barcode.ScanEventHandler(this.BarcodeReader1_ScanSuccess);
            // 
            // BarcodeScanner
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.camera1);
            this.Controls.Add(this.spacer1);
            this.Controls.Add(this.comboBoxFacingMode);
            this.Name = "BarcodeScanner";
            this.Padding = new Wisej.Web.Padding(16, 0, 16, 16);
            this.Load += new System.EventHandler(this.BarcodeScanner_Load);
            this.Controls.SetChildIndex(this.comboBoxFacingMode, 0);
            this.Controls.SetChildIndex(this.spacer1, 0);
            this.Controls.SetChildIndex(this.camera1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Ext.Camera.Camera camera1;
        private Web.ComboBox comboBoxFacingMode;
        private Web.Spacer spacer1;
        private Web.Ext.Barcode.BarcodeReader barcodeReader1;
    }
}
