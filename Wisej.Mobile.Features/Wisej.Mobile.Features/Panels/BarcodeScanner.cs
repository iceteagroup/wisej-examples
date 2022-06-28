using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.Barcode;
using static Wisej.Web.Ext.Camera.Camera;

namespace Wisej.Mobile.Features.Panels
{
	[Category("Hardware")]
	public partial class BarcodeScanner : TestBase
	{
		private Toast toast = new Toast();
		
		public BarcodeScanner()
		{
			InitializeComponent();
		}

		private void BarcodeScanner_Load(object sender, EventArgs e)
		{
			this.barcodeReader1.ScanImage();

			this.comboBoxFacingMode.DataSource = Enum.GetNames(typeof(VideoFacingMode));
			this.comboBoxFacingMode.SelectedItem = "Environment";
		}

        private void BarcodeReader1_ScanSuccess(object sender, ScanEventArgs e)
        {
			if (this.toast.Text == e.Data)
				return;

			this.toast.Text = e.Data;
			this.toast.BackColor = Color.Blue;

			this.toast.Show();
		}

        private void comboBoxFacingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
			var text = (string)this.comboBoxFacingMode.SelectedItem;
			var mode = (VideoFacingMode)Enum.Parse(typeof(VideoFacingMode), text);

			this.camera1.FacingMode = mode;
        }
    }
}
