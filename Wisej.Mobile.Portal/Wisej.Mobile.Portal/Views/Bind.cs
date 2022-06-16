using System;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Portal.Views
{
	public partial class Bind : ViewBase
	{
		public Bind()
		{
			InitializeComponent();
		}

		private void buttonBind_Click(object sender, EventArgs e)
		{
			var url = this.textBoxBind.Text;
			if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
			{
				AlertBox.Show($"Invalid url {url}");
				return;
			}

			var result = Device.Popups.Alert($"Bind app to", url, 
				new DevicePopupOption("Yes", "Yes"), new DevicePopupOption("No", "No"));

			if (result == "Yes")
			{
				Device.UserData["savedApp"] = url;
				Application.Navigate(url);
			}
		}
	}
}
