using System;
using System.ComponentModel;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class HapticFeedback : TestBase
	{
		public HapticFeedback()
		{
			InitializeComponent();
		}

		private void buttonServerSide_Click(object sender, EventArgs e)
		{
			var vibrationType = this.comboBoxHapticType.SelectedItem.ToString();
			Device.Vibrate((DeviceVibrationType)Enum.Parse(typeof(DeviceVibrationType), vibrationType));
		}
	}
}
