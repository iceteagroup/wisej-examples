using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class Accelerometer : TestBase
	{
		public Accelerometer()
		{
			InitializeComponent();
		}

		private void Accelerometer_Load(object sender, EventArgs e)
		{
			Device.AccelerometerUpdate += Device_AccelerometerUpdate;
		}

		private void Device_AccelerometerUpdate(object sender, DeviceEventArgs e)
		{
			this.labelX.Text = $"X: {e.Data.x}";
			this.labelY.Text = $"Y: {e.Data.y}";
			this.labelZ.Text = $"Z: {e.Data.z}";
		}

		private void Accelerometer_Appear(object sender, EventArgs e)
		{
			try
			{
				Device.Sensors.StartAccelerometer();
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void Accelerometer_Disposed(object sender, EventArgs e)
		{
			Device.Sensors.StopAccelerometer();
		}
	}
}
