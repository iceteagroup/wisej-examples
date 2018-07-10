
using System;
using Wisej.Web;

namespace ChangedNames
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            url.Text = $"URL {Application.Url}";
        }
    }
}
