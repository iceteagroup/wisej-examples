namespace Wisej.Mobile.Features.Panels
{
    partial class Links
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
            this.labelMailTo = new Wisej.Web.Label();
            this.labelTel = new Wisej.Web.Label();
            this.labelMaps = new Wisej.Web.Label();
            this.buttonMailTo = new Wisej.Web.Button();
            this.buttonTel = new Wisej.Web.Button();
            this.buttonMaps = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMailTo
            // 
            this.labelMailTo.AllowHtml = true;
            this.labelMailTo.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.labelMailTo.Dock = Wisej.Web.DockStyle.Fill;
            this.labelMailTo.Location = new System.Drawing.Point(16, 16);
            this.labelMailTo.Name = "labelMailTo";
            this.labelMailTo.Size = new System.Drawing.Size(551, 68);
            this.labelMailTo.TabIndex = 19;
            this.labelMailTo.Text = "<a href=\"mailto:someone@yoursite.com\">mailto:someone@yoursite.com</a>  ";
            this.labelMailTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTel
            // 
            this.labelTel.AllowHtml = true;
            this.labelTel.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.labelTel.Dock = Wisej.Web.DockStyle.Fill;
            this.labelTel.Location = new System.Drawing.Point(16, 16);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(551, 68);
            this.labelTel.TabIndex = 20;
            this.labelTel.Text = "<a href=\"tel:123-456-7890\">tel:123-456-7890</a>";
            this.labelTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaps
            // 
            this.labelMaps.AllowHtml = true;
            this.labelMaps.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.labelMaps.Dock = Wisej.Web.DockStyle.Fill;
            this.labelMaps.Location = new System.Drawing.Point(16, 16);
            this.labelMaps.Name = "labelMaps";
            this.labelMaps.Size = new System.Drawing.Size(551, 68);
            this.labelMaps.TabIndex = 21;
            this.labelMaps.Text = "<a href=\"http://maps.apple.com/?saddr=Cupertino&daddr=San+Francisco\">http://maps." +
    "apple.com/?saddr=Cupertino&daddr=San+Francisco</a>";
            this.labelMaps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMailTo
            // 
            this.buttonMailTo.Dock = Wisej.Web.DockStyle.Right;
            this.buttonMailTo.ImageSource = "icon-right";
            this.buttonMailTo.Location = new System.Drawing.Point(567, 16);
            this.buttonMailTo.Name = "buttonMailTo";
            this.buttonMailTo.Size = new System.Drawing.Size(35, 68);
            this.buttonMailTo.TabIndex = 22;
            this.buttonMailTo.Click += new System.EventHandler(this.buttonMailTo_Click);
            // 
            // buttonTel
            // 
            this.buttonTel.Dock = Wisej.Web.DockStyle.Right;
            this.buttonTel.ImageSource = "icon-right";
            this.buttonTel.Location = new System.Drawing.Point(567, 16);
            this.buttonTel.Name = "buttonTel";
            this.buttonTel.Size = new System.Drawing.Size(35, 68);
            this.buttonTel.TabIndex = 23;
            this.buttonTel.Click += new System.EventHandler(this.buttonTel_Click);
            // 
            // buttonMaps
            // 
            this.buttonMaps.Dock = Wisej.Web.DockStyle.Right;
            this.buttonMaps.ImageSource = "icon-right";
            this.buttonMaps.Location = new System.Drawing.Point(567, 16);
            this.buttonMaps.Name = "buttonMaps";
            this.buttonMaps.Size = new System.Drawing.Size(35, 68);
            this.buttonMaps.TabIndex = 24;
            this.buttonMaps.Click += new System.EventHandler(this.buttonMaps_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMailTo);
            this.panel1.Controls.Add(this.buttonMailTo);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(16, 128);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(16);
            this.panel1.Size = new System.Drawing.Size(618, 100);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTel);
            this.panel2.Controls.Add(this.buttonTel);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(16, 228);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(16);
            this.panel2.Size = new System.Drawing.Size(618, 100);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelMaps);
            this.panel3.Controls.Add(this.buttonMaps);
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(16, 328);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(16);
            this.panel3.Size = new System.Drawing.Size(618, 100);
            this.panel3.TabIndex = 27;
            // 
            // Links
            // 
            this.animation1.GetAnimation(this).Duration = 350;
            this.animation1.GetAnimation(this).Event = "appear";
            this.animation1.GetAnimation(this).Name = "slideRightIn";
            this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.animation2.GetAnimation(this).Duration = 350;
            this.animation2.GetAnimation(this).Event = "disappear";
            this.animation2.GetAnimation(this).Name = "slideRightOut";
            this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Links";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Label labelMailTo;
        private Web.Label labelTel;
        private Web.Label labelMaps;
        private Web.Button buttonMailTo;
        private Web.Button buttonTel;
        private Web.Button buttonMaps;
        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.Panel panel3;
    }
}
