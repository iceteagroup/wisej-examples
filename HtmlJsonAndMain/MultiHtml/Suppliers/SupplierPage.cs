using System;
using Wisej.Web;

namespace MultiHtml.Suppliers
{
    public partial class SupplierPage : Page
    {
        public SupplierPage()
        {
            InitializeComponent();
        }

        private void SupplierPage_Load(object sender, EventArgs e)
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

        private void navigateToCustomers_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Customers");
        }

        private void navigateToCustomersHtml_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Customers/Default.html");
        }
    }
}