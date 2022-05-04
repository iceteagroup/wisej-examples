
using System;
using System.Linq;
using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using Wisej.Web;

namespace Wisej.DGVUserPaint
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			this.dataGridView1.RowCount = 10;

			foreach (var row in this.dataGridView1.Rows)
			{
				row[0].Value = "1,2,3,4,5,6,7,8,9,10";
				row[1].Value = "Line";
			}
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
				{
					this.dataGridView1[2, e.RowIndex].Update();
				}
			}
		}

		private void dataGridView1_CellPaint(object sender, DataGridViewCellPaintEventArgs e)
		{
			if (e.ColumnIndex == 2 && e.RowIndex > -1)
			{
				// e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);

				var text = this.dataGridView1[0, e.RowIndex].Value as string;
				if (text != null)
				{
					var values = text.Split(',').Select(n => Convert.ToInt32(n)).ToArray();

					DrawChart(e.Graphics, e.ClipRectangle, values);
				}
			}
		}

		private void DrawChart(Graphics g,Rectangle rect, int[] values)
		{
			g.SmoothingMode = SmoothingMode.AntiAlias;

			int cx = rect.Width;
			int cy = rect.Height;

			SolidBrush brush = new SolidBrush(Color.Blue);

			Pen pen = new Pen(brush);
			pen.Width = 10F;

			float scale = (float)cy / (float)cx;

			float x = 0;

			for (int i = 0; i < values.Length; i++)
			{
				x = values[i];
				x += 7;
				
				g.DrawLine(pen, 0, (cx - x) * scale, cx - x, cy * (scale*2));
			}
		}
	}
}
