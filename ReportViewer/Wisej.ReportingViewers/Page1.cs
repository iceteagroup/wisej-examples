
using System;
using System.IO;
using Wisej.Web;

namespace Wisej.ReportingViewers
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			LoadReports();
		}

		private void LoadReports()
		{
			var path = Application.MapPath("Reports");
			foreach (var file in Directory.GetFiles(path, "*.rdlc"))
			{
				this.listBox1.Items.Add(Path.GetFileName(file));
			}
		}

		private string GetReportPath()
		{
			if (this.listBox1.SelectedIndex == -1)
				return null;

			return Application.MapPath($"Reports\\{this.listBox1.Text}");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var reportPath = GetReportPath();
			if (reportPath != null)
				new PdfReportViewer() { ReportPath = reportPath }.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var reportPath = GetReportPath();
			if (reportPath != null)
				new AspNetReportViewer() { ReportPath = reportPath }.Show();
		}
	}
}
