
using System;
using System.Drawing;
using Wisej.Web;

namespace CustomPainting
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void button1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.Yellow, new Rectangle(10, 10, this.button1.Width / 10, this.button1.Height - 20));
		}
	}
}
