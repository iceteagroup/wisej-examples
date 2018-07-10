using System;
using Wisej.Web;

namespace MultiHtml
{
    public partial class DefaultPage : Page
    {
        public DefaultPage()
        {
            InitializeComponent();
        }

        private void DefaultPage_Load(object sender, EventArgs e)
        {
            url.Text = $"Application URL {Application.Url}";
        }

        private void administration_Click(object sender, EventArgs e)
        {
            Application.Navigate("Administration");
        }

        private void administrationHtml_Click(object sender, EventArgs e)
        {
            Application.Navigate("Administration.html");
        }
    }
}