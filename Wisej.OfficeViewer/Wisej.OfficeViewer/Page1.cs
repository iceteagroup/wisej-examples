
using System;
using System.IO;
using Wisej.Web;

namespace Wisej.OfficeViewer
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.docViewer.FileSource = "Files/word_sample.doc";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// this.docViewer.FileSource = "Files/excel_sample.xls";
			this.docViewer.FileName = "excel_sample.xls";
			this.docViewer.FileStream = File.OpenRead(Application.MapPath("Files/excel_sample.xls"));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.docViewer.FileSource = "Files/powerpoint_sample.ppt";
		}
	}
}
