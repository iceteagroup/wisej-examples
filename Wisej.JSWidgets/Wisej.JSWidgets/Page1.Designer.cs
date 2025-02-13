
namespace Wisej.JSWidgets
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
			this.label1 = new Wisej.Web.Label();
			this.button1 = new Wisej.Web.Button();
			this.btnJQueryKnob = new Wisej.Web.Button();
			this.button5 = new Wisej.Web.Button();
			this.linkLabel1 = new Wisej.Web.LinkLabel();
			this.linkLabel2 = new Wisej.Web.LinkLabel();
			this.linkLabel5 = new Wisej.Web.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label1.Location = new System.Drawing.Point(24, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "JSWidgets";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "Bubbles";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnJQueryKnob
			// 
			this.btnJQueryKnob.Location = new System.Drawing.Point(25, 136);
			this.btnJQueryKnob.Name = "btnJQueryKnob";
			this.btnJQueryKnob.Size = new System.Drawing.Size(167, 48);
			this.btnJQueryKnob.TabIndex = 2;
			this.btnJQueryKnob.Text = "JQueryKnob";
			this.btnJQueryKnob.Click += new System.EventHandler(this.btnJQueryKnob_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(25, 204);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(167, 48);
			this.button5.TabIndex = 5;
			this.button5.Text = "CountUp";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(211, 85);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(79, 20);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.Text = "More Details";
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(211, 149);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(79, 20);
			this.linkLabel2.TabIndex = 7;
			this.linkLabel2.Text = "More Details";
			// 
			// linkLabel5
			// 
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.Location = new System.Drawing.Point(211, 221);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(79, 20);
			this.linkLabel5.TabIndex = 10;
			this.linkLabel5.Text = "More Details";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.linkLabel5);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btnJQueryKnob);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1565, 836);
			this.Text = "Page1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.Label label1;
        private Web.Button button1;
        private Web.Button btnJQueryKnob;
        private Web.Button button5;
        private Web.LinkLabel linkLabel1;
        private Web.LinkLabel linkLabel2;
        private Web.LinkLabel linkLabel5;
    }
}

