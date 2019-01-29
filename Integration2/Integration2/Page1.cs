
using System;
using System.Data;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Wisej.Web;
using System.IO;
using System.Drawing;


namespace Integration2
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitSearchEngines();

            InitializeComponent();
        }

        DataTable dtSearchEngines = new DataTable();
        bool Creating = true;

        /// <summary>
        /// Initialize data
        /// </summary>
        private void InitSearchEngines()
        {
            dtSearchEngines.Columns.Add("text", typeof(string));
            dtSearchEngines.Columns.Add("url", typeof(string));
            dtSearchEngines.Columns.Add("frequency", typeof(int));

            dtSearchEngines.Rows.Add("Yahoo!", "http://search.yahoo.com/", 20);
            dtSearchEngines.Rows.Add("DuckDuckGo", "https://duckduckgo.com/", 5);
            dtSearchEngines.Rows.Add("Bing", "http://www.bing.com/", 23);
            dtSearchEngines.Rows.Add("Blekko", "http://blekko.com/", 4);
            dtSearchEngines.Rows.Add("Alhea", "http://www.alhea.com/", 3);
            dtSearchEngines.Rows.Add("MyWebSearch", "http://home.mywebsearch.com/index.jhtml", 10);
            dtSearchEngines.Rows.Add("Infospace", "http://infospace.com/", 8);
            dtSearchEngines.Rows.Add("Google", "https://www.google.com/", 24);
            dtSearchEngines.Rows.Add("Dogpile", "http://www.dogpile.com/", 4);
            dtSearchEngines.Rows.Add("Wow", "http://www.wow.com/", 14);
            dtSearchEngines.Rows.Add("Info", "http://www.info.com/", 6);
            dtSearchEngines.Rows.Add("WebCrawler", "http://www.webcrawler.com/", 12);
            dtSearchEngines.Rows.Add("Contenko", "http://www.contenko.com/", 3);
            dtSearchEngines.Rows.Add("Aol Search", "http://search.aol.com", 16);
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            // create columns
            this.dataGridViewSearchEngines.Columns[0].DataPropertyName = "text";
            this.dataGridViewSearchEngines.Columns[1].DataPropertyName = "url";
            this.dataGridViewSearchEngines.Columns[2].DataPropertyName = "frequency";
            // bind to data
            this.dataGridViewSearchEngines.DataSource = new BindingSource(dtSearchEngines, null);

            this.dataGridViewSearchEngines.CellClick += DataGridView1_CellClick;

            Creating = false;            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // handle link column
            if (e.ColumnIndex == 1)
            {
                // only if the link is clicked, not somewhere else in the cell
                if (e.Role == "link")
                {
                    if (e.RowIndex >= 0)
                    {
                        // may need to allow popups in chrome etc.
                        Application.Navigate(dtSearchEngines.Rows[e.RowIndex]["url"].ToString(), "_blank");
                    }
                }
            }            
        }

        /// <summary>
        /// Populate TagCloud from DataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void widgetTagCloud_WebRequest(object sender, WebRequestEventArgs e)
        {
            e.Response.ContentType = "application /json";
            e.Response.Write(DataTableToJson (dtSearchEngines));
        }

        /// <summary>
        /// Converts a DataTable to a JSON string
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string DataTableToJson ( DataTable dt)
        {
            var list = new List<Dictionary<string, object>>();

            foreach (DataRow row in dt.Rows)
            {
                var dict = new Dictionary<string, object>();

                foreach (DataColumn col in dt.Columns)
                {
                    dict[col.ColumnName] = row[col];
                }
                list.Add(dict);
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = serializer.Serialize(list);

            return json;
        }

        /// <summary>
        /// When the frequency cell is edited, update slider and TagCloud
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSearchEngines_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && !Creating)
            {
                // empty cell -> 1
                if (dtSearchEngines.Rows[e.RowIndex]["frequency"] == DBNull.Value)
                    dtSearchEngines.Rows[e.RowIndex]["frequency"] = 1;

                int value = Convert.ToInt32(dtSearchEngines.Rows[e.RowIndex]["frequency"]);
                // set to max / min value
                if (value > 25)
                    value = 25;
                else if (value < 1)
                    value = 1;

                RefreshTagCloud();                
                SFSlider sfSlider = this.dataGridViewSearchEngines.Rows[e.RowIndex]["colSlider"].Control as SFSlider;
                sfSlider.Eval("this.setValue(" + value + ")");
                this.dataGridViewSearchEngines.BindingContext[this.dataGridViewSearchEngines.DataSource].EndCurrentEdit();
            }
        }

        /// <summary>
        /// Create the sliders as controls in the 4th column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSearchEngines_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < this.dataGridViewSearchEngines.Rows.Count; i++)
            {
                SFSlider sfSlider = new SFSlider() { Value = Convert.ToInt32(dtSearchEngines.Rows[i]["frequency"]) };
                this.dataGridViewSearchEngines.Rows[i]["colSlider"].Control = sfSlider;
                sfSlider.Dock = DockStyle.Fill;                
                sfSlider.UserData.Row = i;
                sfSlider.WidgetEvent += SfSlider_WidgetEvent;
            }            
        }

        /// <summary>
        /// A sliders value has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfSlider_WidgetEvent(object sender, WidgetEventArgs e)
        {            
            SFSlider sfSlider = sender as SFSlider;
            if (sfSlider != null)
            {
                if (e.Type == "change")
                {
                    int row = sfSlider.UserData.Row;
                    dtSearchEngines.Rows[row]["frequency"] = e.Data;                    
                    RefreshTagCloud();                    
                }
            }
        } 
        /// <summary>
        /// Refresh the TagCloud
        /// </summary>
        private void RefreshTagCloud()
        {
            this.widgetTagCloud.Call("refreshItems");
        }

        /// <summary>
        /// Handles clicks on the TagCloud
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void widgetTagCloud_WidgetEvent(object sender, WidgetEventArgs e)
        {
            AlertBox.Show("clicked on " + e.Data.url + ": " + e.Data.text);            
        }

        private void widgetSignature_WidgetEvent(object sender, WidgetEventArgs e)
        {
            switch (e.Type)
            {
                case "change":
                    OnSignatureChanged(e.Data.lastImage);
                    break;
            }
        }
        private void OnSignatureChanged(string imageData)
        {
            this.pictureBox1.Image = ImageFromBase64(imageData);
        }

        /// <summary>
        /// Returns the Image encoded in a base64 string.
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        private static Image ImageFromBase64(string base64)
        {
            // data:image/gif;base64,R0lGODlhCQAJAIABAAAAAAAAACH5BAEAAAEALAAAAAAJAAkAAAILjI+py+0NojxyhgIAOw==
            try
            {
                if (String.IsNullOrEmpty(base64))
                    return null;

                int pos = base64.IndexOf("base64,");
                if (pos < 0)
                    return null;

                base64 = base64.Substring(pos + 7);
                byte[] buffer = Convert.FromBase64String(base64);

                MemoryStream stream = new MemoryStream(buffer);
                return new Bitmap(stream);
            }
            catch { }

            return null;
        }
    }
}
