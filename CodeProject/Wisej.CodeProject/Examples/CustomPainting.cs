using System;
using Wisej.Web;

namespace Wisej.CodeProject.Examples
{
	public partial class CustomPainting : Form
	{
		public CustomPainting()
		{
			InitializeComponent();
		}

		private void canvas1_Redraw(object sender, EventArgs e)
		{
			int centerX = this.canvas1.Width / 2;
			int centerY = this.canvas1.Height / 2;
			int radius = 70;
			int eyeRadius = 10;
			int eyeXOffset = 25;
			int eyeYOffset = 20;

			// draw the yellow circle
			var context = this.canvas1;
			context.BeginPath();
			context.Arc(centerX, centerY, radius, 0, 360, false);
			context.FillStyle = "yellow";
			context.Fill();
			context.LineWidth = 5;
			context.StrokeStyle = "black";
			context.Stroke();

			// draw the eyes
			context.BeginPath();
			var eyeX = centerX - eyeXOffset;
			var eyeY = centerY - eyeYOffset;
			context.Arc(eyeX, eyeY, eyeRadius, 0, 360, false);
			eyeX = centerX + eyeXOffset;
			context.Arc(eyeX, eyeY, eyeRadius, 0, 360, false);
			context.FillStyle = "black";
			context.Fill();

			// draw the mouth
			context.BeginPath();
			context.Arc(centerX, centerY, 50, 0, 180, false);
			context.Stroke();

		}
	}
}
