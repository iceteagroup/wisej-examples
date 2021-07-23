
using System;
using Wisej.Web;

namespace WiseJ.DataGridViewSummaryRows
{
	public partial class frmSummaryAllCallsUserDataDialog : Form
	{
		public frmSummaryAllCallsUserDataDialog()
		{
			InitializeComponent();
		}

		public object[] Values
		{
			get;
			set;
		}

		private void UserDataDialog_Load(object sender, EventArgs e)
		{
			LoadUserData();
		}

		private void LoadUserData()
		{
			this.labelID.Text = this.Values[0].ToString();
			this.textBoxName.Text = this.Values[1].ToString();
			this.textBoxLastName.Text = this.Values[2].ToString();
			this.comboBoxRole.SelectedItem = this.Values[3].ToString();
			this.dateTimePickerActivation.Value = (DateTime)this.Values[4];
			this.dateTimePickerExpiration.Value = (DateTime)this.Values[5];
			this.textBoxTotal.Text = this.Values[6].ToString();
		}

		private void UpdateUserData()
		{
			this.Values[1] = this.textBoxName.Text;
			this.Values[2] = this.textBoxLastName.Text;
			this.Values[3] = this.comboBoxRole.Text;
			this.Values[4] = this.dateTimePickerActivation.Value;
			this.Values[5] = this.dateTimePickerExpiration.Value;
			this.Values[6] = double.Parse(this.textBoxTotal.Text);
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
			// this is the new Invalid property. it works in conjunction with the
			// InvalidMessage property to display the control in an error state (themeable).
			this.dateTimePickerExpiration.Invalid =
				this.dateTimePickerExpiration.Value < this.dateTimePickerActivation.Value;

			e.Cancel = this.dateTimePickerExpiration.Invalid;
		}

	}
}
