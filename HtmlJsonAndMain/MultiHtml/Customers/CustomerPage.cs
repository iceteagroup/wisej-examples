using System;
using Wisej.Web;

namespace MultiHtml.Customers
{
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            url.Text = $"Application URL {Application.Url}";
        }

        private void navigateToDefault_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Default");
        }

        private void navigateToDefaultHtml_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Default.html");
        }

        private void navigateToAdministration_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Administration");
        }

        private void navigateToAdministrationHtml_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Administration.html");
        }

        private void navigateToStatistics_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Statistics");
        }

        private void navigateToStatisticsHtml_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Statistics.html");
        }

        private void navigateToSuppliers_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Suppliers");
        }

        private void navigateToSuppliersHtml_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Suppliers/Default.html");
        }
    }
}