using System.Windows.Forms;
using DataBinding.Model;

namespace DataBinding.Views
{
    public partial class DataGridBinding : Form
    {
        public DataGridBinding()
        {
            InitializeComponent();
        }

        private void DataGridBinding_Load(object sender, System.EventArgs e)
        {
            vendorListBindingSource.DataSource = VendorList.GetVendorList();
        }
    }
}