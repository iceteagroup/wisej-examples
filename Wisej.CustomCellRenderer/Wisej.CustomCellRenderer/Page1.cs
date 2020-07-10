
using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.CustomCellRenderer
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var grid = this.dataGridView1;

            grid.RowCount = 10;
            for (var i = 0; i < this.dataGridView1.RowCount; i++)
            {
                // set json string.
                grid[this.Column2, i].Value = new
                {

                    Value1 = $"Row {i}",
                    Value2 = $"Col {this.Column2.Name}",
                    Value3 = $"{i * 30}"

                }.ToJSON(false);


                var panel = new Panel() { Dock = DockStyle.Fill };
                panel.Controls.Add(new Button() { Dock = DockStyle.Fill, Text = $"{i}" });
                grid[this.Column0, i].Control = panel;
            }
        }
    }
}
