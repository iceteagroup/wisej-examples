using System;
using System.ComponentModel;
using System.Linq;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Media")]
	public partial class DocumentScanner : TestBase
	{
		private BindingSource data = new BindingSource();

		public DocumentScanner()
		{
			InitializeComponent();
		}

		private void buttonScan_Click(object sender, EventArgs e)
		{
			try
			{
				var images = Device.Camera.ScanDocument();
				this.data.DataSource = images.Select((image) => new { image });
			}
			catch (DeviceException ex)
			{
				AlertBox.Show(ex.Reason);
			}
		}

		private void DocumentScanner_Load(object sender, EventArgs e)
		{
			this.dataRepeaterDocument.DataSource = this.data;
			this.pictureBoxPage.DataBindings.Add(new Binding("Image", this.data, "image"));
		}
	}
}
