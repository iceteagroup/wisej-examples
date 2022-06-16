using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Alerts")]
	public partial class NativeAlert : TestBase
	{
		public NativeAlert()
		{
			InitializeComponent();
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			var options = new List<DevicePopupOption>();
			try
			{
				Device.Popups.Alert(this.textBoxTitle.Text, this.textBoxMessage.Text);
				AlertBox.Show("Alert closed.", MessageBoxIcon.Information);
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}
	}
}
