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

        private void ChartsPage_Load(object sender, EventArgs e)
        {
            LineDataSet lineDataSet1 = new LineDataSet();
            LineDataSet lineDataSet2 = new LineDataSet();
            BarDataSet barDataSet1 = new BarDataSet();
            RadarDataSet radarDataSet1 = new RadarDataSet();
            PolarAreaDataSet polarAreaDataSet1 = new PolarAreaDataSet();
            DoughnutDataSet doughnutDataSet1 = new DoughnutDataSet();
            PieDataSet pieDataSet1 = new PieDataSet();

            lineDataSet1.BackgroundColor = Color.FromArgb(70, 255, 189, 0);
            lineDataSet1.BorderColor = Color.FromArgb(255, 46, 0);
            lineDataSet1.Data = new object[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            lineDataSet1.PointBorderColor = new[] {Color.FromArgb(0, 255, 0)};
            lineDataSet1.PointBackgroundColor = new[] {Color.FromArgb(0, 255, 0)};
            lineDataSet1.Fill = true;
            lineDataSet1.Label = "Data Set";
            lineDataSet2.BorderColor = Color.FromArgb(0, 86, 255);
            lineDataSet2.Data = new object[] {1, 2, 4, 8, 16, 32, 64, 32, 16, 8, 4, 2};
            lineDataSet2.Label = "Data Set 2";
            lineDataSet2.PointStyle = new[] {PointStyle.RectRounded};
            lineDataSet2.SteppedLine = SteppedLine.After;
            chartJS1.DataSets.Add(lineDataSet1);
            chartJS1.DataSets.Add(lineDataSet2);

            barDataSet1.BackgroundColor = new[]
            {
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
                Color.FromArgb(98, 0, 0, 128)
            };
            barDataSet1.BorderColor = null;
            barDataSet1.Data = new object[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            barDataSet1.HoverBackgroundColor = null;
            barDataSet1.Label = "Data Set";
            chartJS2.DataSets.Add(barDataSet1);

            radarDataSet1.BackgroundColor = Color.FromArgb(72, 79, 191, 63);
            radarDataSet1.Data = new object[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            radarDataSet1.Label = "Data Set";
            chartJS4.DataSets.Add(radarDataSet1);

            polarAreaDataSet1.BackgroundColor = new[]
            {
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
                Color.FromArgb(98, 0, 0, 128)
            };
            polarAreaDataSet1.BorderColor = null;
            polarAreaDataSet1.Data = new object[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 0};
            polarAreaDataSet1.HoverBackgroundColor = null;
            polarAreaDataSet1.Label = "Data Set";
            chartJS6.DataSets.Add(polarAreaDataSet1);

            doughnutDataSet1.BackgroundColor = new[]
            {
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
                Color.FromArgb(98, 0, 0, 128)
            };
            doughnutDataSet1.BorderColor = null;
            doughnutDataSet1.Data = new object[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 0};
            doughnutDataSet1.HoverBackgroundColor = null;
            doughnutDataSet1.Label = "Data Set";
            chartJS5.DataSets.Add(doughnutDataSet1);

            pieDataSet1.BackgroundColor = new[]
            {
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
                Color.FromArgb(98, 0, 0, 128)
            };
            pieDataSet1.BorderColor = null;
            pieDataSet1.Data = new object[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            pieDataSet1.HoverBackgroundColor = null;
            pieDataSet1.Label = "Data Set";
            chartJS3.DataSets.Add(pieDataSet1);

            Randomize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randomize();
        }

        private void Randomize()
        {
            foreach (Wisej.Web.Ext.ChartJS.ChartJS chart in flowLayoutPanel1.Controls)
            {
                chart.DataSets[0].Data = CreateRandomData(12, 100);
                chart.UpdateData(trackBar.Value);
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

        private void chartJS_ChartClick(object sender, ChartClickEventArgs e)
        {
            AlertBox.Show(
                "<br>" + ((Control) sender).Text + ":</b> " + e.Values[0],
                MessageBoxIcon.Information,
                alignment: ContentAlignment.MiddleRight);
        }
    }
}