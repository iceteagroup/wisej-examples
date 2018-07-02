using System;
using System.Windows.Forms;
using DataBinding.Model;
using DataBinding.Views;

namespace DataBinding
{
    public partial class MainForm : Form
    {
        public MainForm()
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