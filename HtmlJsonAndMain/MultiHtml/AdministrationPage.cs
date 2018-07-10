using System;
using Wisej.Web;


namespace MultiHtml
{
    public partial class AdministrationPage : Page
    {
        public AdministrationPage()
        {
            InitializeComponent();
        }

        private void AdministrationPage_Load(object sender, EventArgs e)
        {
            url.Text = $"Application URL {Application.Url}";
        }

        private void defaultApplication_Click(object sender, EventArgs e)
        {
            Application.Navigate("Default");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Navigate("Default.html");
        }
    }
}
