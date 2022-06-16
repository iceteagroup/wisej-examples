using System;
using System.ComponentModel;
using Wisej.Web.Ext.MobileIntegration;
using static Wisej.Web.Ext.MobileIntegration.DeviceScreen;

namespace Wisej.Mobile.Features.Panels
{
	[Category("UI")]
	public partial class DeviceScreen : TestBase
	{
		public DeviceScreen()
		{
			InitializeComponent();
		}

		private void Device_BrightnessChanged(object sender, DeviceEventArgs e)
		{
			this.trackBarBrightness.Value = Device.Screen.Brightness;
		}

		private void DeviceScreen_Load(object sender, EventArgs e)
		{
			Device.BrightnessChanged += this.Device_BrightnessChanged;

			this.trackBarBrightness.Value = Device.Screen.Brightness;

			this.comboBoxOrientation.DataSource = Enum.GetNames(typeof(OrientationType));
			this.comboBoxOrientation.Text = "All";
		}

		private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
		{
			Device.Screen.Brightness = this.trackBarBrightness.Value;
		}

		private void DeviceScreen_Disposed(object sender, EventArgs e)
		{
			Device.Screen.Orientation = OrientationType.All;
			Device.BrightnessChanged -= this.Device_BrightnessChanged;
		}

		private void comboBoxOrientation_SelectedIndexChanged(object sender, EventArgs e)
		{
			Device.Screen.Orientation = (OrientationType) Enum.Parse(typeof(OrientationType), this.comboBoxOrientation.Text);
		}

		private void checkBoxIdle_CheckedChanged(object sender, EventArgs e)
		{
			Device.Screen.IdleTimerDisabled = this.checkBoxIdle.Checked;
		}
	}
}
