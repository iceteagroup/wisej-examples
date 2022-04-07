namespace DesktopApplication
{
    partial class PrimaryDesktop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new Wisej.Web.Label();
			this.coolClock1 = new Wisej.Web.Ext.CoolClock.CoolClock();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("default", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1272, 84);
			this.label1.TabIndex = 1;
			this.label1.Text = "P R I M A R Y";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// coolClock1
			// 
			this.coolClock1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.coolClock1.AppearanceKey = "coolclock";
			this.coolClock1.Location = new System.Drawing.Point(1170, 90);
			this.coolClock1.Name = "coolClock1";
			this.coolClock1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
			this.coolClock1.Size = new System.Drawing.Size(100, 100);
			this.coolClock1.Text = "coolClock1";
			// 
			// button1
			// 
			this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.FromName("@buttonText");
			this.button1.ForeColor = System.Drawing.Color.FromName("@buttonFace");
			this.button1.Location = new System.Drawing.Point(1170, 220);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = "Click me 1";
			// 
			// button2
			// 
			this.button2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.FromName("@buttonText");
			this.button2.ForeColor = System.Drawing.Color.FromName("@buttonFace");
			this.button2.Location = new System.Drawing.Point(1170, 270);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 26);
			this.button2.TabIndex = 4;
			this.button2.Text = "Click me 2";
			// 
			// PrimaryDesktop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.coolClock1);
			this.Controls.Add(this.label1);
			this.Name = "PrimaryDesktop";
			this.Size = new System.Drawing.Size(1272, 664);
			this.Text = "Primary Desktop";
			this.Load += new System.EventHandler(this.PrimaryDesktop_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Label label1;
        private Wisej.Web.Ext.CoolClock.CoolClock coolClock1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
    }
}
