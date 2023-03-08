namespace Wisej.Mobile.Features.Panels
{
    partial class iFrame
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
            this.iFramePanel2 = new Wisej.Web.IFramePanel();
            this.SuspendLayout();
            // 
            // iFramePanel2
            // 
            this.iFramePanel2.Dock = Wisej.Web.DockStyle.Fill;
            this.iFramePanel2.Location = new System.Drawing.Point(16, 128);
            this.iFramePanel2.Name = "iFramePanel2";
            this.iFramePanel2.Size = new System.Drawing.Size(618, 350);
            this.iFramePanel2.TabIndex = 20;
            this.iFramePanel2.Text = "  ";
            this.iFramePanel2.Url = "https://demo.wisej.com/CodeProject";
            // 
            // iFrame
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.iFramePanel2);
            this.Name = "iFrame";
            this.Controls.SetChildIndex(this.iFramePanel2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.IFramePanel iFramePanel2;
    }
}
