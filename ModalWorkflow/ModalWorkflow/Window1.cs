
using System;
using Wisej.Web;

namespace ModalWorkflow
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
		}

		private void Window1_Load(object sender, EventArgs e)
		{
			LoadUserData(this.UserData);
		}

		private void LoadUserData(UserData data)
		{
			this.dataGrid.RowCount = 5;
			this.dataGrid[this.columnProperty, 0].Value = "Name";
			this.dataGrid[this.columnProperty, 1].Value = "Last Name";
			this.dataGrid[this.columnProperty, 2].Value = "Role";
			this.dataGrid[this.columnProperty, 3].Value = "Activation Date";
			this.dataGrid[this.columnProperty, 4].Value = "Expiration Date";
			this.dataGrid[this.columnValue, 0].Value = data.Name;
			this.dataGrid[this.columnValue, 1].Value = data.LastName;
			this.dataGrid[this.columnValue, 2].Value = data.Role;
			this.dataGrid[this.columnValue, 3].Value = data.AccountCreation.ToLongDateString();
			this.dataGrid[this.columnValue, 4].Value = data.AccountExpiration.ToLongDateString();
		}


		private UserData UserData = new UserData();


		private void buttonOK_Click(object sender, EventArgs e)
		{
			// create the dialog in a using block to make sure it gets disposed.
			using (var dialog = new UserDataDialog(this.UserData))
			{
				// show the dialog and wait for it to close.
				if (dialog.ShowDialog(this) == Wisej.Web.DialogResult.OK)
				{
					// this code is executed only after the dialog is closed.
					// until then we are suspended...
					this.UserData = dialog.UserData;
					LoadUserData(this.UserData);
				}
			}
		}
	}
}
