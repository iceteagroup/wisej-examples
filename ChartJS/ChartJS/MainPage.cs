using System;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace ChartJS
{
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Randomize();
		}

		private void Randomize()
		{
			foreach (Wisej.Web.Ext.ChartJS.ChartJS chart in this.flowLayoutPanel1.Controls)
			{
				if (chart.DataSets.Count == 0)
					chart.DataSets.Add("Data Set");

				CreateRandomData(chart.DataSets[0], 12, 100);
				chart.UpdateData(this.trackBar.Value);
			}
		}

		private void CreateColors(DataSet dataSet)
		{
			switch (dataSet.Type)
			{
				case ChartType.Bar:
					{
						var barDataSet = (BarDataSet)dataSet;
						barDataSet.BackgroundColor = new Color[] {
							Color.FromArgb(49, 255, 0, 0),
							Color.FromArgb(58, 102, 255, 0),
							Color.FromArgb(52, 0, 183, 255),
							Color.FromArgb(53, 247, 0, 255),
							Color.FromArgb(52, 191, 123, 63),
							Color.FromArgb(53, 191, 63, 86),
							Color.FromArgb(104, 255, 0, 118),
							Color.FromArgb(237, 130, 237),
							Color.FromArgb(88, 64, 224, 208),
							Color.FromArgb(84, 255, 98, 70),
							Color.FromArgb(60, 41, 69, 70),
							Color.FromArgb(98, 0, 0, 128)};
					}
					break;

				case ChartType.Doughnut:
					{
						var doughnutDataSet = (DoughnutDataSet)dataSet;
						doughnutDataSet.BackgroundColor = new Color[] {
							Color.FromArgb(49, 255, 0, 0),
							Color.FromArgb(58, 102, 255, 0),
							Color.FromArgb(52, 0, 183, 255),
							Color.FromArgb(53, 247, 0, 255),
							Color.FromArgb(52, 191, 123, 63),
							Color.FromArgb(53, 191, 63, 86),
							Color.FromArgb(104, 255, 0, 118),
							Color.FromArgb(237, 130, 237),
							Color.FromArgb(88, 64, 224, 208),
							Color.FromArgb(84, 255, 98, 70),
							Color.FromArgb(60, 41, 69, 70),
							Color.FromArgb(98, 0, 0, 128)};
					}
					break;

				case ChartType.Line:
					{
						var lineDataSet = (LineDataSet)dataSet;
						lineDataSet.BackgroundColor = Color.FromArgb(72, 79, 191, 63);
						lineDataSet.BorderColor = System.Drawing.Color.Crimson;
					}
					break;

				case ChartType.PolarArea:
					{
						var polarDataSet = (PolarAreaDataSet)dataSet;
						polarDataSet.BackgroundColor = new Color[] {
							Color.FromArgb(49, 255, 0, 0),
							Color.FromArgb(58, 102, 255, 0),
							Color.FromArgb(52, 0, 183, 255),
							Color.FromArgb(53, 247, 0, 255),
							Color.FromArgb(52, 191, 123, 63),
							Color.FromArgb(53, 191, 63, 86),
							Color.FromArgb(104, 255, 0, 118),
							Color.FromArgb(237, 130, 237),
							Color.FromArgb(88, 64, 224, 208),
							Color.FromArgb(84, 255, 98, 70),
							Color.FromArgb(60, 41, 69, 70),
							Color.FromArgb(98, 0, 0, 128)};
					}
					break;

				case ChartType.Radar:
					{
						var radarDataSet = (RadarDataSet)dataSet;
						radarDataSet.BackgroundColor = Color.FromArgb(72, 79, 191, 63);
					}
					break;

				case ChartType.Pie:
					{
						var pieDataSet = (PieDataSet)dataSet;
						pieDataSet.BackgroundColor = new Color[] {
							Color.FromArgb(49, 255, 0, 0),
							Color.FromArgb(58, 102, 255, 0),
							Color.FromArgb(52, 0, 183, 255),
							Color.FromArgb(53, 247, 0, 255),
							Color.FromArgb(52, 191, 123, 63),
							Color.FromArgb(53, 191, 63, 86),
							Color.FromArgb(104, 255, 0, 118),
							Color.FromArgb(237, 130, 237),
							Color.FromArgb(88, 64, 224, 208),
							Color.FromArgb(84, 255, 98, 70),
							Color.FromArgb(60, 41, 69, 70),
							Color.FromArgb(98, 0, 0, 128)};
					}
					break;
			}
		}

		private void CreateRandomData(DataSet dataSet, int count, int maxValue)
		{
			var data = new object[count];
			Random random = new Random();
			for (int i = 0; i < count; i++)
				data[i] = random.Next(maxValue);

			dataSet.Data = data;

			CreateColors(dataSet);
		}

		private void ChartsPage_Load(object sender, EventArgs e)
		{
			Randomize();
		}

		private void chartJS_ChartClick(object sender, Wisej.Web.Ext.ChartJS.ChartClickEventArgs e)
		{
			AlertBox.Show(
				"<br>" + ((Control)sender).Text + ":</b> " + e.Values[0],
				MessageBoxIcon.Information);
		}
	}
}
