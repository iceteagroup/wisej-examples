using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.CodeProject.Examples
{
	public partial class MandelbrotPanel : Wisej.Web.UserControl
	{
		public MandelbrotPanel()
		{
			InitializeComponent();
		}

		private void MandelbrotPanel_Paint(object sender, PaintEventArgs e)
		{
			m_Xmin = MIN_X;
			m_Xmax = MAX_X;
			m_Ymin = MIN_Y;
			m_Ymax = MAX_Y;
			MaxIterations = 64;

			DrawMandelbrot(e.Graphics, this.Size);

		}

		#region Draw Mandelbrot

		private double m_Xmin, m_Xmax, m_Ymin, m_Ymax;
		public int MaxIterations;
		public double Zr, Zim, Z2r, Z2im;

		private static Color[] Colors = new Color[] {
			Color.Black,
			Color.Red,
			Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
			Color.Yellow,
			Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
			Color.Cyan,
			Color.Blue,
			Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))))
		};

		private const double MIN_X = -2.2;
		private const double MAX_X = 1;
		private const double MIN_Y = -1.2;
		private const double MAX_Y = 1.2;

		private void DrawMandelbrot(Graphics graphics, Size size)
		{
			int count = 0;
			DateTime start = DateTime.Now;

			// Work until the magnitude squared > 4.
			const int MAX_MAG_SQUARED = 4;

			// Make a Bitmap to draw on.
			using (Bitmap bm = new Bitmap(size.Width, size.Height))
			{

				// Clear.
				graphics.Clear(Color.White);

				// Adjust the coordinate bounds to fit picCanvas.
				AdjustAspect();

				// dReaC is the change in the real part
				// (X value) for C. dImaC is the change in the
				// imaginary part (Y value).
				int wid = size.Width;
				int hgt = size.Height;
				double dReaC = (m_Xmax - m_Xmin) / (wid - 1);
				double dImaC = (m_Ymax - m_Ymin) / (hgt - 1);

				// Calculate the values.
				int num_colors = Colors.Length;
				double ReaC = m_Xmin;
				for (int X = 0; X < wid; X++)
				{
					double ImaC = m_Ymin;
					for (int Y = 0; Y < hgt; Y++)
					{
						double ReaZ = Zr;
						double ImaZ = Zim;
						double ReaZ2 = Z2r;
						double ImaZ2 = Z2im;
						int clr = 1;
						while ((clr < MaxIterations) && (ReaZ2 + ImaZ2 < MAX_MAG_SQUARED))
						{
							// Calculate Z(clr).
							ReaZ2 = ReaZ * ReaZ;
							ImaZ2 = ImaZ * ImaZ;
							ImaZ = 2 * ImaZ * ReaZ + ImaC;
							ReaZ = ReaZ2 - ImaZ2 + ReaC;
							clr++;

							count++;
						}

						// Set the pixel's value.
						bm.SetPixel(X, Y, Colors[clr % num_colors]);

						ImaC += dImaC;

						count++;
					}
					ReaC += dReaC;
				}
				TimeSpan elapsed = DateTime.Now - start;

				graphics.DrawImageUnscaled(bm, 0, 0);

				graphics.DrawString(String.Format("{0} Pixels", count.ToString("0,000")), SystemFonts.DefaultFont, Brushes.Black, 50, 50);
				graphics.DrawString(String.Format("{0} Milliseconds", (int)elapsed.TotalMilliseconds), SystemFonts.DefaultFont, Brushes.Black, 50, 80);
			}
		}

		private void AdjustAspect()
		{
			double hgt, wid, mid;

			double want_aspect = (m_Ymax - m_Ymin) / (m_Xmax - m_Xmin);
			double picCanvas_aspect = this.Height / (double)this.Width;
			if (want_aspect > picCanvas_aspect)
			{
				// The selected area is too tall and thin.
				// Make it wider.
				wid = (m_Ymax - m_Ymin) / picCanvas_aspect;
				mid = (m_Xmin + m_Xmax) / 2;
				m_Xmin = mid - wid / 2;
				m_Xmax = mid + wid / 2;
			}
			else
			{
				// The selected area is too short and wide.
				// Make it taller.
				hgt = (m_Xmax - m_Xmin) * picCanvas_aspect;
				mid = (m_Ymin + m_Ymax) / 2;
				m_Ymin = mid - hgt / 2;
				m_Ymax = mid + hgt / 2;
			}
		}

		#endregion

	}
}
