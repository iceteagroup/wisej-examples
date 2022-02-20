using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Pickers")]
	public partial class ColorPicker : TestBase
	{
		public ColorPicker()
		{
			InitializeComponent();
		}

		private void buttonSelect_Click(object sender, EventArgs e)
		{
			try
			{
				Device.Popups.ShowColorPicker(this.panelColor.BackColor, true);
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void ColorPicker_Load(object sender, EventArgs e)
		{
			Device.SelectedColorChanged += Device_SelectedColorChanged;
		}

		private void Device_SelectedColorChanged(object sender, DeviceEventArgs e)
		{
			this.panelColor.BackColor = e.Data.color;
		}

		private void ColorPicker_Disposed(object sender, EventArgs e)
		{
			Device.SelectedColorChanged -= Device_SelectedColorChanged;
		}
	}
}
