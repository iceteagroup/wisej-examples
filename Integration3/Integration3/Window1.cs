
using System;
using Wisej.Web;

namespace Integration3
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.widgetQRfreeText.Call("setValue", textBoxQRfreeText.Text);
        }        
        private void widgetPie_WebRequest(object sender, WebRequestEventArgs e)
        {
            e.Response.ContentType = "application/json";
            e.Response.Write(GetMovieData());
        }

        private string GetMovieData()
        {
            return @"[{""Rank"":1,""Title"":""Captain America: Civil War"",""Studio"":""BV"",""Worldwide"":""1153.3"",""Year"":2016},
{""Rank"":2,""Title"":""Rogue One: A Star Wars Story"",""Studio"":""BV"",""Worldwide"":""1056.1"",""Year"":2016},
{""Rank"":3,""Title"":""Finding Dory"",""Studio"":""BV"",""Worldwide"":""1028.6"",""Year"":2016},
{""Rank"":4,""Title"":""Zootopia"",""Studio"":""BV"",""Worldwide"":""1023.8"",""Year"":2016},
{""Rank"":5,""Title"":""The Jungle Book (2016)"",""Studio"":""BV"",""Worldwide"":""966.6"",""Year"":2016},
{""Rank"":6,""Title"":""The Secret Life of Pets"",""Studio"":""Uni."",""Worldwide"":""875.5"",""Year"":2016},
{""Rank"":7,""Title"":""Batman v Superman: Dawn of Justice"",""Studio"":""WB"",""Worldwide"":""873.3"",""Year"":2016},
{""Rank"":8,""Title"":""Fantastic Beasts and Where To Find Them"",""Studio"":""WB"",""Worldwide"":""814.0"",""Year"":2016},
{""Rank"":9,""Title"":""Deadpool"",""Studio"":""Fox"",""Worldwide"":""783.1"",""Year"":2016},
{""Rank"":10,""Title"":""Suicide Squad"",""Studio"":""WB"",""Worldwide"":""745.6"",""Year"":2016},
{""Rank"":1,""Title"":""Star Wars: The Force Awakens"",""Studio"":""BV"",""Worldwide"":""2,068.2"",""Year"":2015},
{""Rank"":2,""Title"":""Jurassic World"",""Studio"":""Uni."",""Worldwide"":""1671.7"",""Year"":2015},
{""Rank"":3,""Title"":""Furious 7"",""Studio"":""Uni."",""Worldwide"":""1516.0"",""Year"":2015},
{""Rank"":4,""Title"":""Avengers: Age of Ultron"",""Studio"":""BV"",""Worldwide"":""1405.4"",""Year"":2015},
{""Rank"":5,""Title"":""Minions"",""Studio"":""Uni."",""Worldwide"":""1159.4"",""Year"":2015},
{""Rank"":6,""Title"":""Spectre"",""Studio"":""Sony"",""Worldwide"":""880.7"",""Year"":2015},
{""Rank"":7,""Title"":""Inside Out"",""Studio"":""BV"",""Worldwide"":""857.6"",""Year"":2015},
{""Rank"":8,""Title"":""Mission: Impossible - Rogue Nation"",""Studio"":""Par."",""Worldwide"":""682.7"",""Year"":2015},
{""Rank"":9,""Title"":""The Hunger Games: Mockingjay - Part 2"",""Studio"":""LGF"",""Worldwide"":""653.4"",""Year"":2015},
{""Rank"":10,""Title"":""The Martian"",""Studio"":""Fox"",""Worldwide"":""630.2"",""Year"":2015},
{""Rank"":1,""Title"":""Transformers: Age of Extinction"",""Studio"":""Par."",""Worldwide"":""1104.1"",""Year"":2014},
{""Rank"":2,""Title"":""The Hobbit: The Battle of the Five Armies"",""Studio"":""WB (NL)"",""Worldwide"":""956.0"",""Year"":2014},
{""Rank"":3,""Title"":""Guardians of the Galaxy"",""Studio"":""BV"",""Worldwide"":""773.3"",""Year"":2014},
{""Rank"":4,""Title"":""Maleficent"",""Studio"":""BV"",""Worldwide"":""758.5"",""Year"":2014},
{""Rank"":5,""Title"":""The Hunger Games: Mockingjay - Part 1"",""Studio"":""LGF"",""Worldwide"":""755.4"",""Year"":2014},
{""Rank"":6,""Title"":""X-Men: Days of Future Past"",""Studio"":""Fox"",""Worldwide"":""747.9"",""Year"":2014},
{""Rank"":7,""Title"":""Captain America: The Winter Soldier"",""Studio"":""BV"",""Worldwide"":""714.3"",""Year"":2014},
{""Rank"":8,""Title"":""Dawn of the Planet of the Apes"",""Studio"":""Fox"",""Worldwide"":""710.6"",""Year"":2014},
{""Rank"":9,""Title"":""The Amazing Spider-Man 2"",""Studio"":""Sony"",""Worldwide"":""709.0"",""Year"":2014},
{""Rank"":10,""Title"":""Interstellar"",""Studio"":""Par."",""Worldwide"":""675.1"",""Year"":2014},
{""Rank"":1,""Title"":""Frozen"",""Studio"":""BV"",""Worldwide"":""1276.5"",""Year"":2013},
{""Rank"":2,""Title"":""Iron Man 3"",""Studio"":""BV"",""Worldwide"":""1214.8"",""Year"":2013},
{""Rank"":3,""Title"":""Despicable Me 2"",""Studio"":""Uni."",""Worldwide"":""970.8"",""Year"":2013},
{""Rank"":4,""Title"":""The Hobbit: The Desolation of Smaug"",""Studio"":""WB (NL)"",""Worldwide"":""958.4"",""Year"":2013},
{""Rank"":5,""Title"":""The Hunger Games: Catching Fire"",""Studio"":""LGF"",""Worldwide"":""865.0"",""Year"":2013},
{""Rank"":6,""Title"":""Fast & Furious 6"",""Studio"":""Uni."",""Worldwide"":""788.7"",""Year"":2013},
{""Rank"":7,""Title"":""Monsters University"",""Studio"":""BV"",""Worldwide"":""744.2"",""Year"":2013},
{""Rank"":8,""Title"":""Gravity"",""Studio"":""WB"",""Worldwide"":""723.2"",""Year"":2013},
{""Rank"":9,""Title"":""Man of Steel"",""Studio"":""WB"",""Worldwide"":""668.0"",""Year"":2013},
{""Rank"":10,""Title"":""Thor: The Dark World"",""Studio"":""BV"",""Worldwide"":""644.6"",""Year"":2013},
{""Rank"":1,""Title"":""Marvel's The Avengers"",""Studio"":""BV"",""Worldwide"":""1518.8"",""Year"":2012},
{""Rank"":2,""Title"":""Skyfall"",""Studio"":""Sony"",""Worldwide"":""1108.6"",""Year"":2012},
{""Rank"":3,""Title"":""The Dark Knight Rises"",""Studio"":""WB"",""Worldwide"":""1084.9"",""Year"":2012},
{""Rank"":4,""Title"":""The Hobbit: An Unexpected Journey"",""Studio"":""WB (NL)"",""Worldwide"":""1021.1"",""Year"":2012},
{""Rank"":5,""Title"":""Ice Age: Continental Drift"",""Studio"":""Fox"",""Worldwide"":""877.2"",""Year"":2012},
{""Rank"":6,""Title"":""The Twilight Saga: Breaking Dawn Part 2"",""Studio"":""LG/S"",""Worldwide"":""829.7"",""Year"":2012},
{""Rank"":7,""Title"":""The Amazing Spider-Man"",""Studio"":""Sony"",""Worldwide"":""757.9"",""Year"":2012},
{""Rank"":8,""Title"":""Madagascar 3: Europe's Most Wanted"",""Studio"":""P/DW"",""Worldwide"":""746.9"",""Year"":2012},
{""Rank"":9,""Title"":""The Hunger Games"",""Studio"":""LGF"",""Worldwide"":""694.4"",""Year"":2012},
{""Rank"":10,""Title"":""MIB 3"",""Studio"":""Sony"",""Worldwide"":""624.0"",""Year"":2012},
{""Rank"":1,""Title"":""Harry Potter and the Deathly Hallows Part 2"",""Studio"":""WB"",""Worldwide"":""1341.5"",""Year"":2011},
{""Rank"":2,""Title"":""Transformers: Dark of the Moon"",""Studio"":""P/DW"",""Worldwide"":""1123.8"",""Year"":2011},
{""Rank"":3,""Title"":""Pirates of the Caribbean: On Stranger Tides"",""Studio"":""BV"",""Worldwide"":""1045.7"",""Year"":2011},
{""Rank"":4,""Title"":""The Twilight Saga: Breaking Dawn Part 1"",""Studio"":""Sum."",""Worldwide"":""712.2"",""Year"":2011},
{""Rank"":5,""Title"":""Mission: Impossible - Ghost Protocol"",""Studio"":""Par."",""Worldwide"":""694.7"",""Year"":2011},
{""Rank"":6,""Title"":""Kung Fu Panda 2"",""Studio"":""P/DW"",""Worldwide"":""665.7"",""Year"":2011},
{""Rank"":7,""Title"":""Fast Five"",""Studio"":""Uni."",""Worldwide"":""626.1"",""Year"":2011},
{""Rank"":8,""Title"":""The Hangover Part II"",""Studio"":""WB"",""Worldwide"":""586.8"",""Year"":2011},
{""Rank"":9,""Title"":""The Smurfs"",""Studio"":""Sony"",""Worldwide"":""563.7"",""Year"":2011},
{""Rank"":10,""Title"":""Cars 2"",""Studio"":""BV"",""Worldwide"":""562.1"",""Year"":2011},
{""Rank"":1,""Title"":""Toy Story 3"",""Studio"":""BV"",""Worldwide"":""1067.0"",""Year"":2010},
{""Rank"":2,""Title"":""Alice in Wonderland (2010)"",""Studio"":""BV"",""Worldwide"":""1025.5"",""Year"":2010},
{""Rank"":3,""Title"":""Harry Potter and the Deathly Hallows Part 1"",""Studio"":""WB"",""Worldwide"":""960.3"",""Year"":2010},
{""Rank"":4,""Title"":""Inception"",""Studio"":""WB"",""Worldwide"":""825.5"",""Year"":2010},
{""Rank"":5,""Title"":""Shrek Forever After"",""Studio"":""P/DW"",""Worldwide"":""752.6"",""Year"":2010},
{""Rank"":6,""Title"":""The Twilight Saga: Eclipse"",""Studio"":""Sum."",""Worldwide"":""698.5"",""Year"":2010},
{""Rank"":7,""Title"":""Iron Man 2"",""Studio"":""Par."",""Worldwide"":""623.9"",""Year"":2010},
{""Rank"":8,""Title"":""Tangled"",""Studio"":""BV"",""Worldwide"":""591.8"",""Year"":2010},
{""Rank"":9,""Title"":""Despicable Me"",""Studio"":""Uni."",""Worldwide"":""543.1"",""Year"":2010},
{""Rank"":10,""Title"":""How to Train Your Dragon"",""Studio"":""P/DW"",""Worldwide"":""494.9"",""Year"":2010}]
";

        }        

        private void Window1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.widgetPie.Call("reload", this.comboBox1.Items[this.comboBox1.SelectedIndex]);
        }

        private void widgetDonut_WidgetEvent(object sender, WidgetEventArgs e)
        {
            if (e.Type == "Clicked")
            {
                if (e.Data.category == "Homer")
                    AlertBox.Show("D'oh");
            }
        }
    }
}
