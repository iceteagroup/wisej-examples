
using System;
using Wisej.Web;
using Wisej.Web.Ext.Html2Canvas;

namespace Html2CanvasSample
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var image = await Html2Canvas.ScreenshotAsync(this);
			this.pictureBox1.Image = image;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Html2Canvas.Screenshot(this.panel1, (Image) =>
		   {
			   this.pictureBox1.Image = Image;
		   });
		}
	}
}
