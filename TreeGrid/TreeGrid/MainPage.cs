using System;
using Wisej.Web;


namespace TreeGrid
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataTable_Click(object sender, EventArgs e)
        {
            using (var dataTableWindow = new DataTableWindow())
            {
                dataTableWindow.ShowDialog();
            }
        }

        private void objectList_Click(object sender, EventArgs e)
        {
            using (var objectListWindow = new ObjectListWindow())
            {
                objectListWindow.ShowDialog();
            }

        }
    }
}
