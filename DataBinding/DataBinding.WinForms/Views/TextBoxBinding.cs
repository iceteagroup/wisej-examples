using DataBinding.Model;
using System.Windows.Forms;

namespace DataBinding.Views
{
    public partial class TextBoxBinding : Form
    {
        private Vendor _vendor;

        public TextBoxBinding()
        {
            InitializeComponent();
        }

        private void TextBoxBinding_Load(object sender, System.EventArgs e)
        {
            GetNewVendor();
        }

        private void newButton_Click(object sender, System.EventArgs e)
        {
            GetNewVendor();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            _vendor.Save();
        }

        private void removeButton_Click(object sender, System.EventArgs e)
        {
            _vendor.Delete();
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void GetNewVendor()
        {
            _vendor = new Vendor();
            vendorBindingSource.DataSource = _vendor;
        }
    }
}