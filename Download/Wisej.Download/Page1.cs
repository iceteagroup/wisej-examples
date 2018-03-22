
using System;
using System.IO;
using System.IO.Compression;
using System.Net.Mime;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Download
{
	public partial class Page1 : Page, IWisejHandler
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            // provide normal download
            Application.Download("Wisej-Datasheet-V2.2.pdf");
		}

        private void button2_Click(object sender, EventArgs e)
        {
            // provide download and open the file right away
            // use "_blank" to open in new tab - mostly blocked by modern browsers
            Application.DownloadAndOpen("_self", "Wisej-Datasheet-V2.2.pdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // provide download based on a FileStream
            using (Stream stream = new FileStream(Path.Combine(Application.StartupPath, "Wisej-Datasheet-V2.2.pdf"), FileMode.Open))
            {
                Application.Download(stream, "PDF-FileStream-Download.pdf");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // provide dynamic downloads fully handled in memory without temporary files
            // full control over what is returned to the browser
            // the GetPostbackURL is provided by the IWisejHandler interface
            Application.Navigate(this.GetPostbackURL());
        }

        void IWisejHandler.ProcessRequest(HttpContext context)
        {
            // create a ZIP file in memory
            var memStream = new MemoryStream();
            using (var zip = new ZipArchive(memStream, ZipArchiveMode.Create, true))
            {
                zip.CreateEntryFromFile(Path.Combine(Application.StartupPath, "Wisej-Datasheet-V2.2.pdf"), "TestFile.pdf", CompressionLevel.Fastest);
            }
            
            // reset the position in the stream
            memStream.Position = 0;

            // now that we have the ZIP, handle the request individually
            var response = context.Response;
			response.AddHeader("Content-Type", "application/zip");
			response.AppendHeader("Content-Disposition",
				new ContentDisposition()
				{
                    // provide a filename to use
                    FileName = "test.zip",
                    // DispositionType can be "inline" or "attachment"
					DispositionType = "inline"
				}.ToString());

            // now copy the stream with our ZIP file to the response output
            memStream.CopyTo(response.OutputStream);
        }

        bool IWisejHandler.Compress
        {
            // required for the IWisejHandler interface
            get { return false; }
        }
    }
}
