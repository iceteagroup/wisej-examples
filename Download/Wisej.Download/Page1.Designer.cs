namespace Wisej.Download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            this.button1 = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 129);
            this.button1.Name = "button1";
            this.button1.Padding = new Wisej.Web.Padding(50, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(459, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "1. Download PDF";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 188);
            this.button2.Name = "button2";
            this.button2.Padding = new Wisej.Web.Padding(50, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(459, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "2. Download and open PDF";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 247);
            this.button3.Name = "button3";
            this.button3.Padding = new Wisej.Web.Padding(50, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(459, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "3. Download PDF with FileStream";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 306);
            this.button4.Name = "button4";
            this.button4.Padding = new Wisej.Web.Padding(50, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(459, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "4. Download ZIP created in memory";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1504, 825);
            this.Text = "Page1";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Button button1;
        private Web.Label label1;
        private Web.Button button2;
        private Web.Button button3;
        private Web.Button button4;
    }
}

