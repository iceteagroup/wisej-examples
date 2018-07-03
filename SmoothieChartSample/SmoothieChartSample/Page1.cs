
using System;
using System.Threading;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.SmoothieChart;

namespace SmoothieChartSample
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}	

		private void Page1_Load(object sender, EventArgs e)
		{		
			// 1
			smoothieChart1.TimeSeries.Add(new TimeSeries() { FillColor = Color.Green });
			smoothieChart1.TimeSeries.Add(new TimeSeries() { FillColor = Color.Red });
			smoothieChart1.TimeSeries.Add(new TimeSeries() { FillColor = Color.Blue });
			// 2
			smoothieChart2.TimeSeries.Add(new TimeSeries() { FillColor = Color.LightGray, LineColor = Color.White, LineWidth = 5 });
			// 3
			smoothieChart3.TimeSeries.Add(new TimeSeries() { FillColor= Color.Red, LineColor= Color.Black,  LineWidth= 2 });
		}

		private static Random rnd = new Random();

		private void smoothieChart1_DataNeeded(object sender, DataNeededEventArgs e)
		{			
			if (e.LineIndex == 0)
			{
				e.Value = rnd.Next(100);
			}
			else if (e.LineIndex == 1)
			{
				e.Value = rnd.Next(50);
			}
			else if (e.LineIndex == 2)
			{
				e.Value = rnd.Next(30);
			}
		}	

		private void smoothieChart2_DataNeeded(object sender, DataNeededEventArgs e)
		{
			e.Value = rnd.Next(1000);
		}

		private void smoothieChart3_DataNeeded(object sender, DataNeededEventArgs e)
		{
			e.Value = rnd.Next(100);
		}
	}
}
