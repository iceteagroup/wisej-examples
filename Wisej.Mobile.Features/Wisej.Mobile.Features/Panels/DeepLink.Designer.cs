namespace Wisej.Mobile.Features.Panels
{
    partial class DeepLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeepLink));
            this.buttonSafari = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // buttonSafari
            // 
            this.buttonSafari.Dock = Wisej.Web.DockStyle.Top;
            this.buttonSafari.Location = new System.Drawing.Point(16, 261);
            this.buttonSafari.Name = "buttonSafari";
            this.buttonSafari.Size = new System.Drawing.Size(618, 37);
            this.buttonSafari.TabIndex = 19;
            this.buttonSafari.Text = "Open \"Deep Linker\" in Native Browser";
            this.buttonSafari.Click += new System.EventHandler(this.buttonNativeBrowser_Click);
            // 
            // label1
            // 
            this.label1.AllowHtml = true;
            this.label1.Dock = Wisej.Web.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Padding = new Wisej.Web.Padding(0, 0, 0, 16);
            this.label1.Size = new System.Drawing.Size(618, 133);
            this.label1.TabIndex = 20;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // DeepLink
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.buttonSafari);
            this.Controls.Add(this.label1);
            this.Name = "DeepLink";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonSafari, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Button buttonSafari;
        private Web.Label label1;
    }
}
