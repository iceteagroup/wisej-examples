namespace Wisej.ReportingViewers
{
	partial class AspNetReportViewer
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
			this.reportViewer1 = new Wisej.ReportingViewers.AspNetReportViewerControl();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.reportViewer1.Location = new System.Drawing.Point(32, 26);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ScrollBars = false;
			this.reportViewer1.ShowExportControls = true;
			this.reportViewer1.Size = new System.Drawing.Size(611, 471);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Text = "aspNetReportViewerControl1";
			this.reportViewer1.Toggle += new System.ComponentModel.CancelEventHandler(this.reportViewer1_Toggle);
			this.reportViewer1.BookmarkNavigation += new Microsoft.Reporting.WebForms.BookmarkNavigationEventHandler(this.reportViewer1_BookmarkNavigation);
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// AspNetReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 519);
			this.Controls.Add(this.reportViewer1);
			this.Name = "AspNetReportViewer";
			this.Text = "AspNetReportViewer";
			this.Load += new System.EventHandler(this.AspNetReportViewer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.ReportingViewers.AspNetReportViewerControl reportViewer1;
	}
}