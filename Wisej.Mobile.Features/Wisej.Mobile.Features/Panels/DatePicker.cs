using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Pickers")]
	public partial class DatePicker : TestBase
	{
		public DatePicker()
		{
			InitializeComponent();
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			var picker = this.comboBoxFormat.SelectedItem;
			var minDate = Convert.ToDateTime(this.textBoxMin.Text);
			var maxDate = Convert.ToDateTime(this.textBoxMax.Text);

			try
			{
				var result = Device.Popups.ShowDatePicker((Device.PickerModes)picker, minDate, maxDate, DateTime.Now);
				AlertBox.Show(result.ToString());
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void Picker_Load(object sender, EventArgs e)
		{
			this.comboBoxFormat.DataSource = Enum.GetValues(typeof(Device.PickerModes));

			this.textBoxStart.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
			this.textBoxMin.Text = DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy HH:mm:ss");
			this.textBoxMax.Text = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy HH:mm:ss");
		}
	}
}
