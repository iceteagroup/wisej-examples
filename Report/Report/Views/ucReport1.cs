using System;
using System.IO;
using Wisej.Web;

namespace Report.Views
{
    public partial class ucReport1 : Wisej.Web.UserControl
    {
        public ucReport1()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            repoUtilityRDLC oRepo = new repoUtilityRDLC();

            oRepo.ReportPath = Path.Combine(Application.StartupPath, "Report");
            oRepo.ReportFile = "Report.rdlc";
            oRepo.ReportPathFileXML = Path.Combine(Application.StartupPath, "Report");
            oRepo.ReportDataFileXML = "Data.xml";
            //oRepo.DataSetName = "";
            //oRepo.DataSaource = "";

            this.pdfViewer1.PdfStream = oRepo.ExportPDF();
        }

        private void btnReportFromFile_Click(object sender, EventArgs e)
        {
            this.pdfViewer1.PdfSource = "Files\\Wisej-Datasheet-V2.3.pdf";
        }
    }
}
