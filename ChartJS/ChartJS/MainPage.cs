using System;
using Wisej.Web;

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
				chart.DataSets[0].Data = CreateRandomData(12, 100);
				chart.UpdateData(this.trackBar.Value);
			}
		}

		private object[] CreateRandomData(int count, int maxValue)
		{
			var data = new object[count];
			Random random = new Random();
			for (int i = 0; i < count; i++)
				data[i] = random.Next(maxValue);

			return data;
		}

		private void ChartsPage_Load(object sender, EventArgs e)
		{
			Randomize();
		}

		private void chartJS_ChartClick(object sender, Wisej.Web.Ext.ChartJS.ChartClickEventArgs e)
		{
			AlertBox.Show(
				"<br>" + ((Control)sender).Text + ":</b> " + e.Values[0],
				MessageBoxIcon.Information,
				alignment: System.Drawing.ContentAlignment.MiddleRight);
		}
	}
}
