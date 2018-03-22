
using System;
using Wisej.Web;

namespace ModalWorkflow
{
	public partial class UserDataDialog : Form
	{
		public UserDataDialog()
		{
			InitializeComponent();
		}

		public UserDataDialog(UserData userData) :this()
		{
			this.UserData = (UserData)userData.Clone();
		}

		public UserData UserData { get; set; }

		private void UserDataDialog_Load(object sender, EventArgs e)
		{
			LoadRoles();
			LoadUserData();
		}

		private void LoadRoles()
		{
			this.comboBoxRole.Items.Add(UserRole.User);
			this.comboBoxRole.Items.Add(UserRole.Editor);
			this.comboBoxRole.Items.Add(UserRole.Contributor);
			this.comboBoxRole.Items.Add(UserRole.Administrator);
		}

		private void LoadUserData()
		{
			this.textBoxName.Text = this.UserData.Name;
			this.textBoxLastName.Text = this.UserData.LastName;
			this.comboBoxRole.SelectedItem = this.UserData.Role;
			this.dateTimePickerActivation.Value = this.UserData.AccountCreation;
			this.dateTimePickerExpiration.Value = this.UserData.AccountExpiration;
		}

		private void UpdateUserData()
		{
			this.UserData.Name = this.textBoxName.Text;
			this.UserData.LastName = this.textBoxLastName.Text;
			this.UserData.Role = (UserRole)this.comboBoxRole.SelectedItem;
			this.UserData.AccountCreation = this.dateTimePickerActivation.Value;
			this.UserData.AccountExpiration = this.dateTimePickerExpiration.Value;
		}

		private void UserDataDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			// when the user tries to close the dialog on the client, the server
			// we receive the FormClosing event and confirm or cancel.
			if (MessageBox.Show(
					"Are you sure you want to close this dialog?",
					buttons: MessageBoxButtons.YesNoCancel) != Wisej.Web.DialogResult.Yes)
			{
				// this line i reached only after the message box has been closed.
				e.Cancel = true;
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			UpdateUserData();

			Close();
		}

		private void dateTimePickerExpiration_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// this is the new Invalid pproperty. it works in conjuction with the
			// InvalidMessage property to display the control in an error state (themeable).
			this.dateTimePickerExpiration.Invalid = 
				this.dateTimePickerExpiration.Value < this.dateTimePickerActivation.Value;

			e.Cancel = this.dateTimePickerExpiration.Invalid;
		}

	}
}
