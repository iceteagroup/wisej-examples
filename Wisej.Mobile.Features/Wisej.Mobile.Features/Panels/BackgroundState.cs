using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace Wisej.Mobile.Features.Panels
{
	[Category("UI")]
    public partial class BackgroundState : TestBase
	{
		public BackgroundState()
		{
			InitializeComponent();
		}

		private void BackgroundState_Load(object sender, EventArgs e)
		{
			Device.BackgroundState.Enabled = true;
			Device.BackgroundState.ImageSizeMode = ImageSizeMode.ScaleToFill;
            Device.BackgroundState.ImageSource = this.pictureBoxImage.ImageSource;
            Device.BackgroundState.Color = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
            this.comboBoxImageSizeMode.Items.AddRange(Enum.GetNames(typeof(ImageSizeMode)));
		}

		private void uploadImage_Uploaded(object sender, UploadedEventArgs e)
		{
			var bmp = new Bitmap(e.Files[0].InputStream);
			this.pictureBoxImage.Image = bmp;

            Device.BackgroundState.Image = bmp;
        }

		private void comboBoxImageSizeMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			var mode = (ImageSizeMode)Enum.Parse(typeof(ImageSizeMode), (string)this.comboBoxImageSizeMode.SelectedItem);
			Device.BackgroundState.ImageSizeMode = mode;
		}

		private void BackgroundState_Disposed(object sender, EventArgs e)
		{
            Device.BackgroundState.Enabled = false;
		}

		private void textBoxBackColor_TextChanged(object sender, EventArgs e)
		{
            Device.BackgroundState.Color = ColorTranslator.FromHtml(this.textBoxBackColor.Text);
        }
    }
}
