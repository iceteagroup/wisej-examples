using Wisej.Web;
using DataBinding.Model;

namespace DataBinding.Views
{
    public partial class AllBindings : Form
    {
        private Vendor _vendor;

        public AllBindings()
        {
            InitializeComponent();
        }

        private void DataGridBinding_Load(object sender, System.EventArgs e)
        {
            vendorListBindingSource.DataSource = VendorList.GetVendorList();

            // Bind ComboBox list datasources first
            statesBindingSource.EnumToDataSource(typeof(States));
            colState.DataSource = statesBindingSource;
            colState.DisplayMember = "Description";
            colState.ValueMember = "Key";

            dataGridView.Rows[0].Selected = true;
        }

        private void newButton_Click(object sender, System.EventArgs e)
        {
            ClearSelectedRows();
            GetNewVendor();
        }

        private void ClearSelectedRows()
        {
            for (var index = 0; index < dataGridView.RowCount; index++)
            {
                dataGridView.Rows[index].Selected = false;
            }
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            bool isNew = _vendor.IsNew;
            _vendor.Save();

            if (isNew)
                dataGridView.Rows[dataGridView.Rows.Count - 1].Selected = true;
        }

        private void removeButton_Click(object sender, System.EventArgs e)
        {
            var deletedRowIndex = dataGridView.CurrentRow.ClientIndex;
            _vendor.Delete();

            if (dataGridView.RowCount > deletedRowIndex)
            {
                dataGridView.Rows[deletedRowIndex].Selected = true;
            }
        }

        private void GetNewVendor()
        {
            _vendor = new Vendor();
            vendorBindingSource.DataSource = _vendor;
        }

        private void dataGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            BindLine();
        }

        private void BindLine()
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var id = (int) dataGridView.SelectedRows[0].Cells[0].Value;
                _vendor = VendorList.GetVendor(id);
                vendorBindingSource.DataSource = _vendor;
            }
        }
    }
}