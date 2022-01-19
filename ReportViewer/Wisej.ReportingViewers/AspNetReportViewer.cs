using Microsoft.Reporting.WebForms;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Web;

namespace Wisej.ReportingViewers
{
	public partial class AspNetReportViewer : Form
	{
		private object _data;

		public AspNetReportViewer()
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

		private void AspNetReportViewer_Load(object sender, System.EventArgs e)
		{
			// load the data.
			var data = CreateDataSource();

			// load the report.
			this._data = CreateDataSource();
			this.reportViewer1.ReportPath = this.ReportPath;
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

		private void reportViewer1_Load(object sender, System.EventArgs e)
		{
			if (!this.reportViewer1.IsPostBack)
			{
				var report = this.reportViewer1.WrappedControl.LocalReport;
				report.DataSources.Add(new ReportDataSource("Report1", this._data));
			}
		}

		private void aspNetReportViewerControl1_Load(object sender, System.EventArgs e)
		{

		}

		private void reportViewer1_Toggle(object sender, CancelEventArgs e)
		{

		}

		private void reportViewer1_BookmarkNavigation(object sender, BookmarkNavigationEventArgs e)
		{

		}
	}
}
