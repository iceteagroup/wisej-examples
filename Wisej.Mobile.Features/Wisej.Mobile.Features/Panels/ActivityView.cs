using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;
using static Wisej.Web.Ext.MobileIntegration.Device.Popups;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Popups")]
	public partial class ActivityView : TestBase
	{
		public ActivityView()
		{
			InitializeComponent();
		}

		private void buttonImage_Click(object sender, EventArgs e)
		{
			var url = Application.StartupUrl + "Images/wisej-128x128.png";
			Device.Popups.ShowActivityView(ActivityType.Image, url);
		}

		private void buttonURL_Click(object sender, EventArgs e)
		{
			var url = "http://www.wisej.com/";
			Device.Popups.ShowActivityView(ActivityType.URL, url);
		}

		private void buttonText_Click(object sender, EventArgs e)
		{
			var text = "Hello, World!";
			Device.Popups.ShowActivityView(ActivityType.Text, text);
		}
	}
}
