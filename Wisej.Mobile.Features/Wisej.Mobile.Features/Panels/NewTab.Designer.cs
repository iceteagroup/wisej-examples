namespace Wisej.Mobile.Features.Panels
{
    partial class NewTab
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
            this.buttonNewTab = new Wisej.Web.Button();
            this.buttonNewTabMailTo = new Wisej.Web.Button();
            this.spacer1 = new Wisej.Web.Spacer();
            this.SuspendLayout();
            // 
            // buttonNewTab
            // 
            this.buttonNewTab.Dock = Wisej.Web.DockStyle.Top;
            this.buttonNewTab.Location = new System.Drawing.Point(16, 128);
            this.buttonNewTab.Name = "buttonNewTab";
            this.buttonNewTab.Size = new System.Drawing.Size(618, 45);
            this.buttonNewTab.TabIndex = 19;
            this.buttonNewTab.Text = "Open New Tab (www.wisej.com)";
            this.buttonNewTab.Click += new System.EventHandler(this.buttonNewTab_Click);
            // 
            // buttonNewTabMailTo
            // 
            this.buttonNewTabMailTo.Dock = Wisej.Web.DockStyle.Top;
            this.buttonNewTabMailTo.Location = new System.Drawing.Point(16, 193);
            this.buttonNewTabMailTo.Name = "buttonNewTabMailTo";
            this.buttonNewTabMailTo.Size = new System.Drawing.Size(618, 45);
            this.buttonNewTabMailTo.TabIndex = 20;
            this.buttonNewTabMailTo.Text = "Open New Tab (mailto:info@acme.com)";
            this.buttonNewTabMailTo.Click += new System.EventHandler(this.buttonNewTabMailTo_Click);
            // 
            // spacer1
            // 
            this.spacer1.Dock = Wisej.Web.DockStyle.Top;
            this.spacer1.Location = new System.Drawing.Point(16, 173);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(618, 20);
            // 
            // NewTab
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.buttonNewTabMailTo);
            this.Controls.Add(this.spacer1);
            this.Controls.Add(this.buttonNewTab);
            this.Name = "NewTab";
            this.Controls.SetChildIndex(this.buttonNewTab, 0);
            this.Controls.SetChildIndex(this.spacer1, 0);
            this.Controls.SetChildIndex(this.buttonNewTabMailTo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Button buttonNewTab;
        private Web.Button buttonNewTabMailTo;
        private Web.Spacer spacer1;
    }
}
