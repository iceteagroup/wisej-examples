using System;
using DataBinding.Model;
using DataBinding.Views;
using Wisej.Web;

namespace DataBinding
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            VendorList.GetVendorList();
        }

        private void textBoxBindingButton_Click(object sender, EventArgs e)
        {
            using (var textBoxBinding = new TextBoxBinding())
            {
                var result = textBoxBinding.ShowDialog();
            }
        }

        private void dataGridBindingButton_Click(object sender, EventArgs e)
        {
            using (var dataGridBinding = new DataGridBinding())
            {
                var result = dataGridBinding.ShowDialog();
            }
        }

        private void allBindingsButton_Click(object sender, EventArgs e)
        {
            using (var allBindings = new AllBindings())
            {
                var result = allBindings.ShowDialog();
            }
        }
    }
}