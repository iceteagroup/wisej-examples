namespace CustomPainting
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new Wisej.Web.Panel();
			this.button1 = new Wisej.Web.Button();
			this.mandelbrotPanel1 = new CustomPainting.MandelbrotPanel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Double;
			this.panel1.Controls.Add(this.mandelbrotPanel1);
			this.panel1.Location = new System.Drawing.Point(30, 30);
			this.panel1.Name = "panel1";
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(599, 324);
			this.panel1.TabIndex = 2;
			this.panel1.Text = "Mandelbrot Panel (resize the window to see the redraw)";
			// 
			// button1
			// 
			this.button1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(30, 373);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(599, 72);
			this.button1.TabIndex = 1;
			this.button1.Text = "Yes, you can paint here too!";
			this.button1.Paint += new Wisej.Web.PaintEventHandler(this.button1_Paint);
			// 
			// mandelbrotPanel1
			// 
			this.mandelbrotPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.mandelbrotPanel1.Location = new System.Drawing.Point(0, 0);
			this.mandelbrotPanel1.Name = "mandelbrotPanel1";
			this.mandelbrotPanel1.Size = new System.Drawing.Size(597, 294);
			this.mandelbrotPanel1.TabIndex = 3;
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 461);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.MinimizeBox = false;
			this.Name = "Window1";
			this.Text = "Window1";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panel1;
		private Wisej.Web.Button button1;
		private MandelbrotPanel mandelbrotPanel1;
	}
}

