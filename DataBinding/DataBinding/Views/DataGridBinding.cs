using Wisej.Web;
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
            // Bind ComboBox list datasources first
            statesBindingSource.EnumToDataSource(typeof(States));
            colState.DataSource = statesBindingSource;
            colState.DisplayMember = "Description";
            colState.ValueMember = "Key";

            vendorListBindingSource.DataSource = VendorList.GetVendorList();
        }
    }
}