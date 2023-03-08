using System;
using System.ComponentModel;
using System.IO;
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
				var size = 0L;
				var images = Device.Camera.ScanDocument((float)this.trackBarQuality.Value / 100);
				this.data.DataSource = images.Select((image) =>
				{
					// measure the size of the image.
					using (var ms = new MemoryStream())
					{
						image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
						size += ms.Length;
					}

					return new { image };
				});

				AlertBox.Show($"Size of uploaded images: {size} bytes");
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
