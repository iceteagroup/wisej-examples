using System;
using System.Data;
using System.Drawing;
using System.IO;
using Wisej.Web;
using Wisej.Web.Ext.DataGridViewSummaryRow;
using WiseJ.DataGridViewSummaryRows.data;

namespace WiseJ.DataGridViewSummaryRows
{
    public partial class frmSummaryHugeData2 : Form
    {
        DataGridViewColumn colPurchaseOrderID;
        DataGridViewColumn colOrderQty;
        DataGridViewColumn colName;
        DataGridViewColumn colUnitPrice;
        DataGridViewColumn colStockedQty;
        DataGridViewColumn colModifiedDate;
        DataSet _dsData;
        
        private BindingSource detailBindingSource = new BindingSource();

        bool bFullCols = false;

        public frmSummaryHugeData2()
        {
            InitializeComponent();
        }

        private void frmSumaryGroup_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (this.dgvMaster.Columns.Count > 0)
            {
                dgvMaster.Columns.Clear();

                dgvMaster.AutoGenerateColumns = false;
            }

            DataGridCreateColumns();

            LoadData();

            bFullCols = false;

            LoadGrid();
        }

        private void btnLoadDataFullCols_Click(object sender, EventArgs e)
        {
            if (this.dgvMaster.Columns.Count > 0)
            {
                dgvMaster.Columns.Clear();

                dgvMaster.AutoGenerateColumns = true;
            }

            LoadData();

            bFullCols = true;

            LoadGrid2();
        }


        private void btnAddSummaryRow_Click(object sender, EventArgs e)
        {
            AddSummary1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSummary2();
        }

        private void btnSummary3_Click(object sender, EventArgs e)
        {
            AddSummary3();
        }

        private void btnRemoveSummary_Click(object sender, EventArgs e)
        {
            RemoveSummaryGroup();
        }

        private void AddSummary1()
        {
            var grid = this.dgvMaster;
            bool bDataGridHasRows = (this.dgvMaster.Rows.Count > 0);

            if (bDataGridHasRows)
            {
                if (bFullCols == false)
                {
                    for (var i = 3; i < 5; i++)
                    {
                        grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, null, null, grid.Columns[i], TotalStyle);
                    }
                }
                else
                {
                    for (var i = 6; i <= 10; i++)
                    {
                        grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, null, null, grid.Columns[i], TotalStyle);
                    }
                }
            }

            //position in the last row
            if (bDataGridHasRows)
            {
                int nRowIndex = dgvMaster.Rows.Count - 1;
                int nColumnIndex = 0;

                dgvMaster.ClearSelection();
                dgvMaster.CurrentCell = dgvMaster[nColumnIndex, nRowIndex];
            }

        }

        private void AddSummary2()
        {
            var grid = this.dgvMaster;

            if (this.dgvMaster.Rows.Count > 0)
            {
                if (bFullCols == false)
                {
                    for (var i = 3; i < 5; i++)
                    {
                        grid.AddSummaryRows(SummaryType.Sum, colPurchaseOrderID, colUnitPrice, TotalRowStyle);
                    }
                }
                else
                {
                    for (var i = 6; i <= 10; i++)
                    {
                        // grid.Columns[0] is group column for  colPurchaseOrderID
                        grid.AddSummaryRows(SummaryType.Sum, grid.Columns[0], grid.Columns[i], TotalRowStyle);
                    }
                }
            }

        }

        private void RemoveSummaryGroup()
        {
            bool bDataGridHasRows = (this.dgvMaster.Rows.Count > 0);

            if (bDataGridHasRows)
            {
                dgvMaster.RemoveSummaryRows();

                //position in the first row
                int nRowIndex = 0;
                int nColumnIndex = 0;

                dgvMaster.ClearSelection();
                dgvMaster.CurrentCell = dgvMaster[nColumnIndex, nRowIndex];
            }
        }

        private void AddSummary3()
        {
            var grid = this.dgvMaster;

           
            if (this.dgvMaster.Rows.Count > 0)
            {
                if (bFullCols == false)
                {
                    for (var i = 3; i < 5; i++)
                    {
                        grid.AddSummaryRows(SummaryType.Sum, "colPurchaseOrderID", "colUnitPrice", TotalRowStyle);
                    }
                }
                else
                {
                    for (var i = 6; i <= 10; i++)
                    {
                        // names in dataPurchaseDetail.xml for fields
                        grid.AddSummaryRows(SummaryType.Sum, "PurchaseOrderID", "UnitPrice", TotalRowStyle);
                    }
                }
            }


        }

        private void DataGridCreateColumns()
        {
            colPurchaseOrderID = new DataGridViewColumn();
            colOrderQty = new DataGridViewColumn();
            colName = new DataGridViewColumn();
            colUnitPrice = new DataGridViewColumn();
            colStockedQty = new DataGridViewColumn();
            colModifiedDate = new DataGridViewColumn();
            
            colPurchaseOrderID.HeaderText = "Order ID";
            colPurchaseOrderID.Name = "colPurchaseOrderID";

            colOrderQty.HeaderText = "Order Qty";
            colOrderQty.Name = "colOrderQty";

            colName.HeaderText = "Product";
            colName.Name = "colName";

            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.Name = "colUnitPrice";

            colStockedQty.HeaderText = "Stocket Qty";
            colStockedQty.Name = "colStockedQty";

            colModifiedDate.HeaderText = "Date";
            colModifiedDate.Name = "colModifiedDate";


            this.dgvMaster.Columns.Add(colPurchaseOrderID);
            this.dgvMaster.Columns.Add(colOrderQty);
            this.dgvMaster.Columns.Add(colName);
            this.dgvMaster.Columns.Add(colUnitPrice);
            this.dgvMaster.Columns.Add(colStockedQty);
            this.dgvMaster.Columns.Add(colModifiedDate);
        }

        private void LoadData()
        {
            bool result = false;

            dataPurchaseDataSet oData = new dataPurchaseDataSet();

            result = oData.LoadData(Path.Combine(Application.StartupPath, "data"),
                                    "dataPurchaseDetail.xml",
                                    "detail");

            _dsData = new DataSet();
            _dsData = oData.DsData;

            detailBindingSource.DataSource = _dsData;
            detailBindingSource.DataMember = "detail";
        
        }


        private void LoadGrid()
        {
            var i = 0;
            string sValue = "";
            double dUnitPrice = 0;
            double dStockedQty = 0;

            int rowsLoaded = _dsData.Tables[0].Rows.Count;

            // This is the recommended way to load datagridview when will be use with SummaryRows
            var oTable = _dsData.Tables[0];

            dgvMaster.RowCount = rowsLoaded;

            foreach (DataRow dataRow in _dsData.Tables[0].Rows)
            {

               dgvMaster[0, i].Value = dataRow["PurchaseOrderID"];

               dgvMaster[1, i].Value = dataRow["OrderQty"];
                sValue = dataRow["OrderQty"].ToString();

               dgvMaster[2, i].Value = dataRow["Name"];
                sValue = dataRow["Name"].ToString();

               dgvMaster[3, i].Value = dataRow["UnitPrice"];
                sValue = dataRow["UnitPrice"].ToString();
                dUnitPrice += double.Parse(sValue);

               dgvMaster[4, i].Value = dataRow["StockedQty"];
                sValue = dataRow["StockedQty"].ToString();
                dStockedQty += double.Parse(sValue);

               dgvMaster[5, i].Value = dataRow["ModifiedDate"];
                sValue = dataRow["ModifiedDate"].ToString();

                i++;
            }

            this.lblHeaderCount.Text = detailBindingSource.Count.ToString();

            this.lblUnitPrice.Text = dUnitPrice.ToString("C0");
            this.lblStockedQty.Text = dStockedQty.ToString("C0");
        }


        private void LoadGrid2()
        {
            var i = 0;
            string sValue = "";
            double dUnitPrice = 0;
            double dStockedQty = 0;
            int rowsLoaded = 0;

            // This is the recommended way to load datagridview when will be use with SummaryRows
            var oTable = _dsData.Tables[0];
            if (oTable != null)
            {
                rowsLoaded = dgvMaster.Fill(oTable);
            }

            foreach (DataRow dataRow in _dsData.Tables[0].Rows)
            {

                sValue = dataRow["OrderQty"].ToString();

                sValue = dataRow["Name"].ToString();

                sValue = dataRow["UnitPrice"].ToString();
                dUnitPrice += double.Parse(sValue);

                sValue = dataRow["StockedQty"].ToString();
                dStockedQty += double.Parse(sValue);

                sValue = dataRow["ModifiedDate"].ToString();

                i++;
            }

            this.lblHeaderCount.Text = detailBindingSource.Count.ToString();

            this.lblUnitPrice.Text = dUnitPrice.ToString("C0");
            this.lblStockedQty.Text = dStockedQty.ToString("C0");
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
