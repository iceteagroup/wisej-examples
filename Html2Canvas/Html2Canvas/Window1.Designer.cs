namespace Html2CanvasSample
{
	partial class Window1
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
			this.button1 = new Wisej.Web.Button();
			this.panel1 = new Wisej.Web.Panel();
			this.button2 = new Wisej.Web.Button();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(146, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 43);
			this.button1.TabIndex = 0;
			this.button1.Text = "print window";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromName("@text-placeholder");
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.Location = new System.Drawing.Point(28, 219);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(439, 301);
			this.panel1.TabIndex = 1;
			this.panel1.TabStop = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(146, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(161, 43);
			this.button2.TabIndex = 2;
			this.button2.Text = "print panel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(518, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(230, 182);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 585);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Name = "Window1";
			this.Text = "HTML2Canvas Sample";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button button1;
		private Wisej.Web.Panel panel1;
		private Wisej.Web.Button button2;
		private Wisej.Web.PictureBox pictureBox1;
	}
}

