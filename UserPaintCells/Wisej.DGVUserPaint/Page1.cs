
using System;
using System.Linq;
using System.Drawing;
using System.Web.UI.DataVisualization.Charting;
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
			if (e.ColumnIndex == 2)
			{
				// e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);

				var text = this.dataGridView1[0, e.RowIndex].Value as string;
				if (text != null)
				{
					var values = text.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
					var charType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), (string)this.dataGridView1[1, e.RowIndex].Value);

					DrawChart(e.Graphics, e.ClipRectangle, values, charType);
				}
			}
		}

		private void DrawChart(Graphics g, Rectangle rect, int[] values, SeriesChartType chartType)
		{
			using (var chart = new Chart())
			{
				rect.Inflate(-10, -10);
				chart.Width = rect.Width - 2;
				chart.Height = rect.Height - 2;
				chart.BackColor = Color.Transparent;

				var ca = new ChartArea();
				ca.BackColor = Color.Transparent;
				ca.Position = new ElementPosition(1, 1, 99, 99);

				ca.AxisY.LineWidth = 0;
				ca.AxisY.MajorGrid.LineWidth = 0;
				ca.AxisY.LabelStyle.Enabled = false;
				ca.AxisY.MajorTickMark.Enabled = false;
				ca.AxisY.MinorTickMark.Enabled = false;
				ca.AxisY.IsMarginVisible = false;

				ca.AxisX.LineWidth = 0;
				ca.AxisX.MajorGrid.LineWidth = 0;
				ca.AxisX.LabelStyle.Enabled = false;
				ca.AxisX.MajorTickMark.Enabled = false;
				ca.AxisX.MinorTickMark.Enabled = false;
				ca.AxisX.LineDashStyle = ChartDashStyle.NotSet;
				ca.AxisX.IsMarginVisible = false;

				chart.ChartAreas.Add(ca);

				var s = new Series();
				s.BorderWidth = 2;
				s.ChartType = chartType;

				for (int i = 0; i < values.Length; i++)
				{
					DataPoint p = new DataPoint();
					p.XValue = i;
					p.YValues = new Double[] { values[i] };
					s.Points.Add(p);
				}

				chart.Series.Add(s);

				chart.Paint(g, rect);
			}
		}
	}
}
