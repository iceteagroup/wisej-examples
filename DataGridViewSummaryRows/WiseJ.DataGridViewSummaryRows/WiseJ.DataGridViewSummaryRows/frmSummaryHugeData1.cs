
using System;
using System.Data;
using System.Drawing;
using System.IO;
using Wisej.Web;
using WiseJ.DataGridViewSummaryRows.data;

namespace WiseJ.DataGridViewSummaryRows
{
    public partial class frmSummaryHugeData1 : Form
    {
        DataSet _dsData;
        private BindingSource masterBindingSource = new BindingSource();

        public frmSummaryHugeData1()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();

            LoadGrid();

        }

        private void btnAddSummaryRow_Click(object sender, EventArgs e)
        {
            //AppDomainSetup summary rows allways after fill the datagrid
            AddSummaryTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCount();
        }

        private void LoadData()
        {
            bool result = false;

            dataPurchaseDataSet oData = new dataPurchaseDataSet();

            result = oData.LoadData(Path.Combine(Application.StartupPath, "data"),
                                    "dataPurchaseHeader.xml",
                                    "header");

            _dsData = new DataSet();
            _dsData = oData.DsData;

            masterBindingSource.DataSource = _dsData;
            masterBindingSource.DataMember = "header";

        }

        private void LoadGrid()
        {
            var i = 0;
            string sValue = "";
            double dSubTotal = 0;
            double dTaxAmount = 0;
            double dFreight = 0;
            double dTotalDue = 0;

            // Fill datagrid with data 
            // and calculate totals in columns for compare with
            // SummaryRow

            dgvMaster.Rows.Clear();
            dgvMaster.RowCount = masterBindingSource.Count;

            //this is an awful manner for load data.
            //Is only for ejemplify
            foreach (DataRow dataRow in _dsData.Tables[0].Rows)
            {

                dgvMaster[0, i].Value = dataRow["VendorID"];

                dgvMaster[1, i].Value = dataRow["SubTotal"];
                sValue = dataRow["SubTotal"].ToString();
                dSubTotal += double.Parse(sValue);

                dgvMaster[2, i].Value = dataRow["TaxAmt"];
                sValue = dataRow["TaxAmt"].ToString();
                dTaxAmount += double.Parse(sValue);

                dgvMaster[3, i].Value = dataRow["Freight"];
                sValue = dataRow["Freight"].ToString();
                dFreight += double.Parse(sValue);

                dgvMaster[4, i].Value = dataRow["TotalDue"];
                sValue = dataRow["TotalDue"].ToString();
                dTotalDue += double.Parse(sValue);

                i++;
            }

            this.lblHeaderCount.Text = masterBindingSource.Count.ToString();

            this.lblSubTotal.Text = dSubTotal.ToString("C0");
            this.lblTaxAmnt.Text = dTaxAmount.ToString("C0");
            this.lblFreight.Text = dFreight.ToString("C0");
            this.lblTotalDue.Text = dTotalDue.ToString("C0");
        }

        private void AddSummaryTotal()
        {
            var grid = this.dgvMaster;
            DataGridViewRow[] GridTotals = null;

            for (var i = 1; i < grid.ColumnCount; i++)
            {
                GridTotals = grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Above, null, null, grid.Columns[i], TotalStyle);
            }

        }


        private void AddCount()
        {
            var grid = this.dgvMaster;
         
            for (var i = 1; i < grid.ColumnCount; i++)
            {
                grid.AddSummaryRows(SummaryType.Sum, colVendorID, grid.Columns[i], TotalRowStyle);
            }

        }

        private static DataGridViewCellStyle TotalStyle = new DataGridViewCellStyle()
        {

            BackColor = Color.YellowGreen,
            Format = "C0",
            Font = new Font("Helvetica", 10, FontStyle.Bold, GraphicsUnit.Point),
            Alignment = DataGridViewContentAlignment.MiddleRight
        };


        private static DataGridViewCellStyle TotalRowStyle = new DataGridViewCellStyle()
        {
            BackColor = Color.Aqua,
            Format = "C0",
            Font = new Font("Helvetica", 10, FontStyle.Bold, GraphicsUnit.Point),
            Alignment = DataGridViewContentAlignment.MiddleRight
        };



    }
}
