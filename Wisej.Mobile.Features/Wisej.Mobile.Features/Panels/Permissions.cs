using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Permissions")]
	public partial class Permissions : TestBase
	{
		public Permissions()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e)
		{
			var button = (Button)sender;
			try
			{
				var permission = (Device.PermissionType)Enum.Parse(typeof(Device.PermissionType), button.Text);
				var result = Device.RequestPermission(permission);
				AlertBox.Show($"{permission}: {result}");
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}
	}
}
