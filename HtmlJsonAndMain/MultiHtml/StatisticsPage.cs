using System;
using Wisej.Web;

namespace MultiHtml
{
    public partial class StatisticsPage : Page
    {
        public StatisticsPage()
        {
            InitializeComponent();
        }

        private void StatisticsPage_Load(object sender, EventArgs e)
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
