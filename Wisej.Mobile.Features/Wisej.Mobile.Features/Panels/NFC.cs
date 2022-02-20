using System;
using System.ComponentModel;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class NFC : TestBase
	{
		public NFC()
		{
			InitializeComponent();
		}

		private void buttonReadNFC_Click(object sender, EventArgs e)
		{
			try 
			{
				var json = Device.NFC.ReadNFC();
				var data = JSON.Parse(json);

				AlertBox.Show(data.records);
			} 
			catch (DeviceException ex) 
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void buttonWrite_Click(object sender, EventArgs e)
		{
			try
			{
				var response = Device.NFC.WriteNFC(this.textBoxWritable.Text);
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}
	}
}
