
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using Wisej.Web;

namespace WiseJ.DataGridViewSummaryRows
{
	/// <summary>
	/// 
	/// This is an awful example of data binding and handling!
	/// 
	/// The goal of this simple app is to show deep linking, not data management.
	/// 
	/// This window handles the Application.HashChanged and Application.ApplicationRefresh events
	/// to read the hash from the URL and open the dialog used to edit the user id specified in the URL.
	/// 
	/// When the user edit dialog is opened, it saves the user id being edited
	/// in the URL hash, when the dialog is closed, it removes the user id from the URL hash.
	/// 
	/// Navigating using the browser's back/forward arrows performs the deep linking functionality.
	/// 
	/// </summary>
	public partial class frmSummaryAllCalls : Form
	{
		private DataTable DataTable;

		public frmSummaryAllCalls()
		{
			InitializeComponent();
		}

		private void Window1_Load(object sender, EventArgs args)
		{
			// detect changes to the hash in the URL.
			Application.HashChanged += Application_HashChanged;

			// handle the first hash value, if any.
			EditUser(Application.Hash);
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			EditUser(e.Hash);
		}

		
		private void btnLoadFromDataSource_Click(object sender, EventArgs e)
		{
			this.dataGrid.Rows.Clear();
			this.dataGrid.Columns.Clear();
			this.LoadFromDataSource();
		}

		private void btnLoadData_Click(object sender, EventArgs e)
		{

			this.dataGrid.Rows.Clear();
			this.dataGrid.Columns.Clear();
			this.LoadData();
		}

		private void btnSummary1_Click(object sender, EventArgs e)
		{
			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.YellowGreen,
				Font = new Font(grid.Font, FontStyle.Bold)
			};

            if (this.dataGrid.Rows.Count >0)
            {
				this.dataGrid.AddSummaryRows(SummaryType.Sum, null, this.dataGrid.Columns[6], style);
            }

		}

		private void btnSummary2_Click(object sender, EventArgs e)
		{

			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.BurlyWood,
				Font = new Font(grid.Font, FontStyle.Bold)
			};


			if (this.dataGrid.Rows.Count > 0)
			{
				grid.AddSummaryRows(SummaryType.Sum, null, "Total", style);
			}
		}

		private void btnSummary3_Click(object sender, EventArgs e)
		{
			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.Aquamarine,
				Font = new Font(grid.Font, FontStyle.Bold)
			};

			if (this.dataGrid.Rows.Count > 0)
			{

				DataGridViewColumn oColumn = this.dataGrid.Columns[6];

				grid.AddSummaryRows(SummaryType.Sum, null, null, oColumn, style);
			}
		}

		private void btnSummary4_Click(object sender, EventArgs e)
		{
			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.Beige,
				Font = new Font(grid.Font, FontStyle.Bold)
			};

			if (this.dataGrid.Rows.Count > 0)
			{

				grid.AddSummaryRows(SummaryType.Sum, "", "", "Total", style);
			}
		}

		private void btnSummary5_Click(object sender, EventArgs e)
		{
			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.Coral,
				Font = new Font(grid.Font, FontStyle.Bold)
			};

			if (this.dataGrid.Rows.Count > 0)
			{

				DataGridViewColumn oColumn = this.dataGrid.Columns[6];
				grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, null, oColumn, style);
			}
		}

		private void btnSummary6_Click(object sender, EventArgs e)
		{
			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.Gold,
				Font = new Font(grid.Font, FontStyle.Bold)
			};

			if (this.dataGrid.Rows.Count > 0)
			{

				DataGridViewColumn oColumn = this.dataGrid.Columns[6];
				grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, "", "Total", style);
			}
		}


		private void btnSummary7_Click(object sender, EventArgs e)
		{
			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.Bisque,
				Font = new Font(grid.Font, FontStyle.Bold)
			};

			if (this.dataGrid.Rows.Count > 0)
			{
				grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, null, null, grid.Columns[6], style);
			}
		}

		private void btnSummary8_Click(object sender, EventArgs e)
		{
			var grid = this.dataGrid;
			var style = new DataGridViewCellStyle()
			{
				BackColor = Color.CornflowerBlue,
				Font = new Font(grid.Font, FontStyle.Bold)
			};


			if (this.dataGrid.Rows.Count > 0)
			{
				grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Below, "", "", "Total", style);
			}
		}

		private void btnRemoveSumary_Click(object sender, EventArgs e)
		{
			bool bDataGridHasRows = (this.dataGrid.Rows.Count > 0);

			if (bDataGridHasRows)
			{
				dataGrid.RemoveSummaryRows();

				//position in the first row
				int nRowIndex = 0;
				int nColumnIndex = 0;

				dataGrid.ClearSelection();
				dataGrid.CurrentCell = dataGrid[nColumnIndex, nRowIndex];
			}
		}

		private void LoadFromDataSource()
		{
			var table = this.DataTable = new DataTable();
			table.Columns.Add("ID", typeof(int));
			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("Last Name", typeof(string));
			table.Columns.Add("Role", typeof(string));
			table.Columns.Add("Activation Date", typeof(DateTime));
			table.Columns.Add("Expiration Date", typeof(DateTime));
			table.Columns.Add("Total", typeof(double));

			table.Rows.Add(1, "Abraham", "Baldwin", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 100);
			table.Rows.Add(2, "Christopher", "Gadsden", "Administrator", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 200);
			table.Rows.Add(3, "Francis", "Dana", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 5);
			table.Rows.Add(4, "Hugh", "Williamson", "Supervisor", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 1300);
			table.Rows.Add(5, "Joseph", "Reed", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 1100);

			//this.dataGrid.DataSource = this.DataTable;
			this.dataGrid.Fill(this.DataTable);

			this.dataGrid.Columns["Activation Date"].DefaultCellStyle.Format = "d";
			this.dataGrid.Columns["Expiration Date"].DefaultCellStyle.Format = "d";


		}

		private void LoadData()
		{
			var table = this.DataTable = new DataTable();
			table.Columns.Add("ID", typeof(int));
			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("Last Name", typeof(string));
			table.Columns.Add("Role", typeof(string));
			table.Columns.Add("Activation Date", typeof(DateTime));
			table.Columns.Add("Expiration Date", typeof(DateTime));
			table.Columns.Add("Total", typeof(double));

			table.Rows.Add(1, "Abraham", "Baldwin", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 100);
			table.Rows.Add(2, "Christopher", "Gadsden", "Administrator", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 200);
			table.Rows.Add(3, "Francis", "Dana", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 5);
			table.Rows.Add(4, "Hugh", "Williamson", "Supervisor", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 1300);
			table.Rows.Add(5, "Joseph", "Reed", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5), 1100);

			for (int i = 0; i <= this.DataTable.Columns.Count; i++)
			{
				DataGridViewTextBoxColumn oColumn = new DataGridViewTextBoxColumn();

				if (i == 0)
				{
					oColumn.Name = "ID";
				}

				if (i==6) {
					oColumn.Name = "Total";
                }

				this.dataGrid.Columns.Add(oColumn);
			}


			this.dataGrid.Rows.Add(DataTable.Rows.Count);

			int row = 0;
			foreach (DataRow dr in DataTable.Rows)
			{
				for (int i = 0; i < 7; i++)
					this.dataGrid[i, row].Value = dr[i];

				++row;
			}

		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{

            if (this.dataGrid.Rows.Count >0)
            {
				EditUser(this.CurrentUserId);
            }
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (this.dataGrid.Rows.Count > 0)
			{

				var newId = this.dataGrid.Rows.Max(r => (int)r[0].Value) + 1;

				DataTable table = this.DataTable;
				table.Rows.Add(newId, "", "", "User", DateTime.Now, DateTime.Now.AddYears(1));
				EditUser(newId, true);
			}

		}

		private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			EditUser(this.CurrentUserId);
		}

		private int CurrentUserId
		{
			get
			{
				var row = this.dataGrid.CurrentRow;
				return row != null
					? (int)row[0].Value
					: -1;
			}
		}

		private void EditUser(string hash)
		{
			var userId = -1;
			if (int.TryParse(hash, out userId))
				EditUser(userId);
			else
				EditUser(-1);
		}

		private void EditUser(int id, bool newRow=false)
		{
			// close the current dialog, if still open.
			if (this.userDialog != null)
			{
				this.userDialog.DialogResult = Wisej.Web.DialogResult.Abort;
				this.userDialog.Close();
			}

			if (id < 0)
				return;

			// find the row row edit.
			var row = this.dataGrid.Rows.FirstOrDefault(r => (int)r[0].Value == id);
			if (row == null)
			{
				MessageBox.Show("User not found: ID = " + id, modal: false);
				return;
			}

			if (this.userDialog == null)
				this.userDialog = new frmSummaryAllCallsUserDataDialog();

			// update the hash to save the current deep linking location.
			Application.Hash = id.ToString();

			// show the dialog and handle the closing event asynchronously (modeless).
			this.userDialog.Values = this.DataTable.Rows[row.Index].ItemArray;
			this.userDialog.ShowDialog(this, (sender, result) =>
			{
				// clear the hash to update the current deep linking location.
				if (result != Wisej.Web.DialogResult.Abort)
					Application.Hash = "";

				if (result == DialogResult.OK)
				{
					// this code is executed only after the dialog is closed.
					row.SetValues(this.userDialog.Values);
				}
                else if (result == DialogResult.Cancel && newRow)
                {
                    // delete new row if cancel was pressed.
                    dataGrid.Rows.Remove(row);
                }
            });
		}

		// reference to the current user dialog.
		private frmSummaryAllCallsUserDataDialog userDialog;

 
    }
}
