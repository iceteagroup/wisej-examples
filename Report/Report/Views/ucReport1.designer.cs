using Wisej.Web;

namespace Report.Views
{
    partial class ucReport1
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
            this.flpTop = new Wisej.Web.FlexLayoutPanel();
            this.btnReportFromFile = new Wisej.Web.Button();
            this.btnReport = new Wisej.Web.Button();
            this.flpContent = new Wisej.Web.FlexLayoutPanel();
            this.pdfViewer1 = new Wisej.Web.PdfViewer();
            this.flpTop.SuspendLayout();
            this.flpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTop
            // 
            this.flpTop.Controls.Add(this.btnReportFromFile);
            this.flpTop.Controls.Add(this.btnReport);
            this.flpTop.Dock = Wisej.Web.DockStyle.Top;
            this.flpTop.Location = new System.Drawing.Point(0, 0);
            this.flpTop.Name = "flpTop";
            this.flpTop.Size = new System.Drawing.Size(773, 62);
            this.flpTop.TabIndex = 0;
            this.flpTop.TabStop = true;
            // 
            // btnReportFromFile
            // 
            this.btnReportFromFile.Dock = Wisej.Web.DockStyle.Left;
            this.btnReportFromFile.Location = new System.Drawing.Point(143, 0);
            this.btnReportFromFile.Name = "btnReportFromFile";
            this.btnReportFromFile.Size = new System.Drawing.Size(143, 62);
            this.btnReportFromFile.TabIndex = 1;
            this.btnReportFromFile.Text = "Report from file";
            this.btnReportFromFile.Click += new System.EventHandler(this.btnReportFromFile_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = Wisej.Web.DockStyle.Left;
            this.btnReport.Location = new System.Drawing.Point(0, 0);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(143, 62);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report from RDLC";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // flpContent
            // 
            this.flpContent.Controls.Add(this.pdfViewer1);
            this.flpContent.Dock = Wisej.Web.DockStyle.Fill;
            this.flpContent.Location = new System.Drawing.Point(0, 62);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(773, 468);
            this.flpContent.TabIndex = 1;
            this.flpContent.TabStop = true;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(773, 468);
            this.pdfViewer1.TabIndex = 0;
            // 
            // ucReport1
            // 
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.flpTop);
            this.Name = "ucReport1";
            this.Size = new System.Drawing.Size(773, 530);
            this.flpTop.ResumeLayout(false);
            this.flpContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlexLayoutPanel flpTop;
        private Button btnReport;
        private FlexLayoutPanel flpContent;
        private PdfViewer pdfViewer1;
        private Button btnReportFromFile;
    }
}
