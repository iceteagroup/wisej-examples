using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Alerts")]
	public partial class NativePopup : TestBase
	{
		public NativePopup()
		{
			InitializeComponent();
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			var options = new List<DevicePopupOption>();

			AddOption(options, this.textBoxName1, this.textBoxOption1, this.comboBoxOption1);
			AddOption(options, this.textBoxName2, this.textBoxOption2, this.comboBoxOption2);
			AddOption(options, this.textBoxName3, this.textBoxOption3, this.comboBoxOption3);

			try
			{
				string result;
				if ((string)this.comboBoxPopupType.SelectedItem == "Prompt")
					result = Device.Popups.Prompt(this.textBoxTitle.Text, this.textBoxMessage.Text, options.ToArray());
				else
					result = Device.Popups.Alert(this.textBoxTitle.Text, this.textBoxMessage.Text, options.ToArray());

				AlertBox.Show($"Popup closed: {result}", MessageBoxIcon.Information);
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void AddOption(List<DevicePopupOption> options, TextBox textBoxName, TextBox textBoxText, ComboBox comboBox)
		{
			if (textBoxName.Text == "")
				return;

			options.Add(new DevicePopupOption(textBoxName.Text, textBoxText.Text)
			{
				Type = (DevicePromptOptionType)Enum.Parse(typeof(DevicePromptOptionType), comboBox.Text)
			});
		}
	}
}
