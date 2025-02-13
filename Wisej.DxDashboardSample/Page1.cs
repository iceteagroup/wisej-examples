using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.DxDashboardSample
{
	public partial class Page1 : Page
	{
		private DashboardConfigurator _configurator;
		private DashboardHelper _dashboardHelper;

		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			this.dxDashboard1.Options.endpoint = $"{this.dxDashboard1.GetServiceURL()}";

			this._configurator = new DashboardConfigurator();
			this._dashboardHelper = new DashboardHelper(this._configurator);

			this._configurator.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
			this._configurator.SetDashboardStorage(new DashboardFileStorage(Application.MapPath("Data/Dashboards")));
		}

		private void dxDashboard1_WebRequest(object sender, WebRequestEventArgs e)
		{
			this._dashboardHelper.ProcessRequest(sender, e);
		}

		private void buttonWorkingMode_Click(object sender, System.EventArgs e)
		{
			var workingMode = this.dxDashboard1.Options.workingMode;
			this.dxDashboard1.Options.workingMode = workingMode == "Designer" ? "viewerOnly" : "Designer";
		}
	}
}
