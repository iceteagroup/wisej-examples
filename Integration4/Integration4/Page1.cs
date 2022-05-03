
using System;
using System.Drawing;
using Winforms = System.Windows.Forms;
using Wisej.Web;

namespace Integration4
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void widgetInput_WebRequest(object sender, WebRequestEventArgs e)
        {
            e.Response.ContentType = "application/json";
            e.Response.Write(getData());
        }

        private void widgetColorPicker_WidgetEvent(object sender, WidgetEventArgs e)
        {
            Color color = ColorTranslator.FromHtml("#" + e.Data.color);
            this.label1.ForeColor = color;
            this.widgetTreeMap.Call("setBaseColor", "#" + e.Data.color);

            Color lightColor = ChangeColorBrightness(color, (float) 0.2);
            this.widgetTagCloud.Call("setColors", ColorTranslator.ToHtml(lightColor), ColorTranslator.ToHtml(color));
        }

        private static Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        private string getData ()
        {
            string json = @"[
            {""Dish"":""Pizza Margherita"", ""Price"": ""4""},
            {""Dish"":""Pizza Funghi"", ""Price"": ""5""},
            {""Dish"":""Pizza Quattro Stagioni"", ""Price"": ""5.5""},
            {""Dish"":""Pizza Frutti di Mare"", ""Price"": ""7""},
            {""Dish"":""Spaghetti Bolognese"", ""Price"": ""4""},
            {""Dish"":""Spaghetti Carbonara"", ""Price"": ""5""},
            {""Dish"":""Rigatoni all'Arrabbiata"", ""Price"": ""5.5""},
            {""Dish"":""Rigatoni al Forno"", ""Price"": ""6""},
            {""Dish"":""Pappardelle con Porcini"", ""Price"": ""7""},
            {""Dish"":""Cesars Salad"", ""Price"": ""5.5""}            
            ]";

            return json;
        }

        private void widgetTagCloud_WebRequest(object sender, WebRequestEventArgs e)
        {
            e.Response.ContentType = "application/json";
            e.Response.Write(getData());
        }
    }
}


