
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

			for (var index = 0; index < this.dataGridView1.Rows.Count; index++)
			{
				var row = this.dataGridView1.Rows[index];
				switch (index)
				{
						case 0:
							row[0].Value = "12,345,64,57,36,34,363";
							row[1].Value = "Area";
							row.Height = row.Height * 3;
							break;
						case 1:
							row[0].Value = "345,3456,34,363,463,6,3";
							row[1].Value = "Column";
							row.Height = row.Height * 3;
						break;
						case 2:
							row[0].Value = "675,345,145,6,474,76,875,685";
							row[1].Value = "Spline";
							row.Height = row.Height * 3;
						break;
						case 3:
							row[0].Value = "234,234,234,254,25,235,35,23";
							row[1].Value = "Line";
							row.Height = row.Height * 3;
						break;
					default:
						row[0].Value = "1,2,3,4,5,6,7,8,9,10";
						row[1].Value = "Line";
						break;
				}
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
