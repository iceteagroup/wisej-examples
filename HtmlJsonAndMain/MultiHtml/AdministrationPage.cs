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

        private void navigateToDefault_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Default");
        }

        private void navigateToDefaultHtml_Click(object sender, EventArgs e)
        {
            Application.Navigate("/Default.html");
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
