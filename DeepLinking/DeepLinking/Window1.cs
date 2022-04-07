
using System;
using System.Data;
using System.Linq;
using Wisej.Web;

namespace DeepLinking
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
	public partial class Window1 : Form
	{
		private DataTable DataTable;

		public Window1()
		{
			InitializeComponent();
		}

		private void Window1_Load(object sender, EventArgs args)
		{
			LoadUserData();

			// detect changes to the hash in the URL.
			Application.HashChanged += Application_HashChanged;
			
			// detect when the browser's reloads the page (the user hit refresh).
			Application.ApplicationRefresh += Application_ApplicationRefresh;

			// detach all static events when disposed.
			this.Disposed += Window1_Disposed;

			// handle the hash value in the URL when this window
			// is first loaded. the HashChanged event is fired only when
			// the hash changes in the browser.
			EditUser(Application.Hash);
		}

		private void Window1_Disposed(object sender, EventArgs e)
		{
			Application.HashChanged -= Application_HashChanged;
			Application.ApplicationRefresh -= Application_ApplicationRefresh;
		}

		private void Application_ApplicationRefresh(object sender, EventArgs e)
		{
			EditUser(Application.Hash);
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			EditUser(e.Hash);
		}

		private void LoadUserData()
		{
			var table = this.DataTable = new DataTable();
			table.Columns.Add("ID", typeof(int));
			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("Last Name", typeof(string));
			table.Columns.Add("Role", typeof(string));
			table.Columns.Add("Activation Date", typeof(DateTime));
			table.Columns.Add("Expiration Date", typeof(DateTime));

			table.Rows.Add(1, "Abraham", "Baldwin", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5));
			table.Rows.Add(2, "Christopher", "Gadsden", "Administrator", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5));
			table.Rows.Add(3, "Francis", "Dana", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5));
			table.Rows.Add(4, "Hugh", "Williamson", "Supervisor", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5));
			table.Rows.Add(5, "Joseph", "Reed", "User", new DateTime(1785, 4, 5), new DateTime(1885, 4, 5));

			this.dataGrid.DataSource = this.DataTable;

			this.dataGrid.Columns["Activation Date"].DefaultCellStyle.Format = "d";
			this.dataGrid.Columns["Expiration Date"].DefaultCellStyle.Format = "d";
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			EditUser(this.CurrentUserId);
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			var newId = this.dataGrid.Rows.Max(r => (int)r[0].Value) + 1;

			DataTable table = this.DataTable;
			table.Rows.Add(newId, "", "", "User", DateTime.Now, DateTime.Now.AddYears(1));
			EditUser(newId, true);

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
		}

		private void EditUser(int id, bool newRow = false)
		{
			// close the current dialog, if still open.
			if (this.userDialog != null)
			{
				this.userDialog.DialogResult = Wisej.Web.DialogResult.Abort;
				this.userDialog.Close();
			}

			// find the row row edit.
			var row = this.dataGrid.Rows.FirstOrDefault(r => (int)r[0].Value == id);
			if (row == null)
			{
				MessageBox.Show("User not found: ID = " + id);

				// clear the hash to update the current deep linking location.
				Application.Hash = "";

				return;
			}

			if (this.userDialog == null)
				this.userDialog = new UserDataDialog();

			// update the hash to save the current deep linking location.
			Application.Hash = id.ToString();

			// show the dialog and handle the closing event asynchronously (modeless).
			this.userDialog.Values = this.DataTable.Rows[row.Index].ItemArray;
			this.userDialog.ShowDialog(this, (sender, result) =>
			{
				// clear the hash to update the current deep linking location.
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
		private UserDataDialog userDialog;
	}
}
