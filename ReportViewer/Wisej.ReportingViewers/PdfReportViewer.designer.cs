namespace Wisej.ReportingViewers
{
	partial class PdfReportViewer
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
			this.pdfViewer1 = new Wisej.Web.PdfViewer();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// pdfViewer1
			// 
			this.pdfViewer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.pdfViewer1.Location = new System.Drawing.Point(28, 53);
			this.pdfViewer1.Name = "pdfViewer1";
			this.pdfViewer1.Size = new System.Drawing.Size(511, 390);
			this.pdfViewer1.TabIndex = 0;
			this.pdfViewer1.ViewerType = Wisej.Web.PdfViewerType.Mozilla;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Word";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(134, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 44);
			this.button2.TabIndex = 2;
			this.button2.Text = "Excel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// PdfReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(563, 461);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pdfViewer1);
			this.Name = "PdfReportViewer";
			this.Text = "PdfReportViewer";
			this.Load += new System.EventHandler(this.PdfReportViewer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.PdfViewer pdfViewer1;
		private Web.Button button1;
		private Web.Button button2;
	}
}