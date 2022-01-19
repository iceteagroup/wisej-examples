using Microsoft.Reporting.WebForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.ReportingViewers
{
	public partial class PdfReportViewer : Form, IWisejHandler
	{
		private LocalReport _report;

		public PdfReportViewer()
		{
			InitializeComponent();
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ReportPath
		{
			get;
			set;
		}

		private void PdfReportViewer_Load(object sender, System.EventArgs e)
		{
			// load the data.
			var data = CreateDataSource();

			// load the report.
			var report = new LocalReport();
			report.ReportPath = this.ReportPath;
			report.DataSources.Add(new ReportDataSource("Report1", data));
			this._report = report;
			this.pdfViewer1.PdfSource = Application.StartupUrl + "/" + this.GetPostbackURL();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (this._report == null)
				return;

			Application.Navigate(this.GetPostbackURL("export=word"));
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (this._report == null)
				return;

			Application.Navigate(this.GetPostbackURL("export=excel"));
		}

		private object CreateDataSource()
		{
			var data = new List<Model>();
			data.Add(new Model { Name = "Jack", LastName = "White" });
			data.Add(new Model { Name = "Joe", LastName = "Black" });

			//var data = new DataTable();
			//data.Columns.Add("Name");
			//data.Columns.Add("LastName");
			//data.Rows.Add("Jack", "White");
			//data.Rows.Add("Joe", "Black");

			return data;
		}

		#region IWisejHandler

		bool IWisejHandler.Compress => false;

		void IWisejHandler.ProcessRequest(HttpContext context)
		{
			var request = context.Request;
			var response = context.Response;

			var export = request["export"];
			
			// preview
			if (export == null)
			{
				var bytes = this._report.Render("pdf");
				var filename = Path.GetFileNameWithoutExtension(this._report.ReportPath);
				response.Expires = -1;
				response.ContentType = $"application/pdf";
				response.AppendHeader("Access-Control-Allow-Origin", "*");
				response.AddHeader("Content-Disposition", $"inline; filename=\"{filename}.pdf\"");
				response.AddHeader("Content-Length", bytes.Length.ToString());
				response.OutputStream.Write(bytes, 0, bytes.Length);
			}
			else
			{
				switch (export)
				{
					case "word":
					case "excel":
						var format = export == "word" ? "doc" : "xls";
						var bytes = this._report.Render(export);
						var filename = Path.GetFileNameWithoutExtension(this._report.ReportPath);
						response.Expires = -1;
						response.ContentType = $"application/{format}";
						response.AppendHeader("Access-Control-Allow-Origin", "*");
						response.AddHeader("Content-Disposition", $"attachment; filename=\"{filename}.{format}\"");
						response.AddHeader("Content-Length", bytes.Length.ToString());
						response.OutputStream.Write(bytes, 0, bytes.Length);
						break;
				}
			}

		}

		#endregion

	}
}
