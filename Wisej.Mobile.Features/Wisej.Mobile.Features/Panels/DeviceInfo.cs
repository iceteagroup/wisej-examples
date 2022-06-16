using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Information")]
	public partial class DeviceInfo : TestBase
	{
		public DeviceInfo()
		{
			InitializeComponent();
		}

		private void Device_ModeChanged(object sender, DeviceEventArgs e)
		{
			this.propertyGridInfo.Refresh();
		}

		private void Device_Orientation(object sender, DeviceEventArgs e)
		{
			this.propertyGridInfo.Refresh();
		}

		private void DeviceInfo_Load(object sender, EventArgs e)
		{
			this.propertyGridInfo.SelectedObject = Device.Info;

			Device.ModeChanged += Device_ModeChanged;
			Device.OrientationChanged += this.Device_Orientation;
			Device.PermissionStateChanged += Device_PermissionStateChanged;
		}

		private void Device_PermissionStateChanged(object sender, DeviceEventArgs e)
		{
			this.propertyGridInfo.Refresh();
		}

		private void DeviceInfo_Disposed(object sender, EventArgs e)
		{
			Device.ModeChanged -= Device_ModeChanged;
			Device.OrientationChanged -= this.Device_Orientation;
			Device.PermissionStateChanged -= Device_PermissionStateChanged;
		}
	}
}
