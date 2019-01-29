
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Wisej.Core;
using Wisej.Web;

namespace Integration1
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }       

        /// <summary>
        /// generate data for Pizza store
        /// </summary>
        /// <returns></returns>
        private static string GenerateData()
        {
            string[] Category = { "Salad", "Pasta", "Pizza", "Dessert" };

            string[,] Dish = new string[13, 2] { { "Salad", "Cesars Salad" }, { "Salad", "Green Salad" },
                { "Pasta", "Spaghetti Carbonara" }, { "Pasta", "Spaghetti Bolognese" }, { "Pasta", "Maccheroni all amatriciana" }, { "Pasta", "Lasagne" },
                { "Pizza", "Margherita" }, { "Pizza", "Four Cheese" }, { "Pizza", "Four Seasons" } , {"Pizza",  "Mushroom" },
                { "Dessert", "Tiramisu", }, { "Dessert",  "Panna Cotta" }, {"Dessert", "Ice Cream" } };

            int maxAmount = 200;

            DateTime startDate = new DateTime(2014, 1, 1);            
            DateTime endDate = new DateTime(2016, 12, 31);

            int id = 1;
            DateTime dt = startDate;
            Random random = new Random();

            List<SampleData> AllData = new List<SampleData>();

            while (dt < endDate)
            {

                foreach (string Cat in Category)
                {
                    for (int x = 0; x < Dish.GetLength(0); x++)
                    {
                        if (Dish[x, 0] == Cat)
                        {
                            SampleData aSampleDate = new SampleData();

                            int amount = random.Next(maxAmount + 1);

                            aSampleDate.id = id;
                            aSampleDate.date = dt.Year.ToString() + "/" + dt.Month.ToString() + "/" + dt.Day.ToString();
                            aSampleDate.amount = amount;
                            aSampleDate.category = Cat;
                            aSampleDate.dish = Dish[x, 1];

                            AllData.Add(aSampleDate);

                            id++;
                        }
                    }
                }

                dt = dt.AddDays(1);
            }

            var jsonSerialiser = new JavaScriptSerializer();
            string json = jsonSerialiser.Serialize(AllData);

            return json;
        }

        /// <summary>
        /// sample data structure for Pizza store
        /// </summary>
        private class SampleData
        {
            public int id;
            public string category;
            public string dish;
            public int amount;         
            public string date;
        }

        /// <summary>
        /// provide data for PivotGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void widgetPivotGrid_WebRequest_1(object sender, WebRequestEventArgs e)
        {
            e.Response.ContentType = "application /json";
            e.Response.Write(GenerateData());
        }        

        private void button1_Click(object sender, EventArgs e)
        {            
            widgetCircularGage.Eval(@"this.gauge.value( this.gauge.value() + 10)");
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            widgetCircularGage.Eval(@"this.gauge.value( this.gauge.value() - 10)");
        }

        public int WidgetCircularGage_StartValue = 0;
        public int WidgetCircularGage_EndValue = 0;

        private void widgetCircularGage_WidgetEvent(object sender, WidgetEventArgs e)
        {
            if (e.Type == "Initialized")
            {
                // determine min / max values
                this.widgetCircularGage.Eval("App.MainPage.SetStartValue(this.gauge._options.scale.startValue)");
                this.widgetCircularGage.Eval("App.MainPage.SetEndValue(this.gauge._options.scale.endValue)");
            }
            else if (e.Type == "OptionChanged")
            {
                if (e.Data.optionName == "value")
                {
                    int value = e.Data.optionValue;

                    if (value > WidgetCircularGage_EndValue)
                    {
                        AlertBox.Show("That´s too hot !");
                        this.widgetCircularGage.Eval($"this.gauge.value({WidgetCircularGage_EndValue})");
                    }
                    else if (value < WidgetCircularGage_StartValue)
                    {
                        AlertBox.Show("Come on, guests are hungry, heat up !");
                        this.widgetCircularGage.Eval($"this.gauge.value({WidgetCircularGage_StartValue})");
                    }
                }
            }
        }

        [WebMethod]
        public void SetStartValue (int startValue)
        {
            WidgetCircularGage_StartValue = startValue;
        }

        [WebMethod]
        public void SetEndValue(int endValue)
        {
            WidgetCircularGage_EndValue = endValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = (sender as ComboBox);
            this.widgetBarGauge.Eval($"this.gauge.option('palette', '{cmb.SelectedItem}')");
        }

        
    }
}
