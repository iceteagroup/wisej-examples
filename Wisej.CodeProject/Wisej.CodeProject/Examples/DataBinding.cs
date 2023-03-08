using System;
using Wisej.Web;
using System.IO;
using System.Drawing;
using System.Configuration;

namespace Wisej.CodeProject.Examples
{
	public partial class DataBinding : Form
	{
		public DataBinding()
		{
			InitializeComponent();
		}

		private string dbFilePath;

		private void DataBinding_Load(object sender, EventArgs e)
		{
			// duplicate the database to isolate it for the session.
			var sourcePath = Application.MapPath("~\\App_Data\\chinook.db");
			var targetPath = Application.MapPath("~\\App_Data\\chinook_" + Application.SessionId + ".db");
			this.dbFilePath = targetPath;
			try
			{
				File.Copy(sourcePath, targetPath);
			}
			catch { }
			Application.ApplicationExit += Application_ApplicationExit;

			this.employeesTableAdapter.Connection = new System.Data.SQLite.SQLiteConnection("data source=" + targetPath + ";Pooling=False");

			LoadData();
		}

		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			// delete the session-cloned db file.
			this.employeesTableAdapter.Connection.Close();
			this.employeesTableAdapter.Connection.Dispose();
			this.employeesTableAdapter.Adapter.Dispose();
			try
			{
				File.Delete(this.dbFilePath);
			}
			catch { }
		}

		private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.dataGridView1.Tools["Save"].Enabled = true;
		}

		private void dataGridView1_ToolClick(object sender, ToolClickEventArgs e)
		{
			switch (e.Tool.Name)
			{
				case "Save":
					SaveData();
					break;

				case "Add":
					AddNewRecord();
					break;

				case "Delete":
					DeleteRecord();
					break;

				case "Reload":
					LoadData();
					break;
			}
		}

		private void DeleteRecord()
		{
			// this method shows server-side modal.

			try
			{
				var row = this.dataGridView1.CurrentRow?.Index ?? -1;
				if (row > -1)
				{
					if (MessageBox.Show(
						"Are you sure you want to delete this record?", 
						icon:MessageBoxIcon.Question, 
						buttons:MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
					{
						this.employeesBindingSource.RemoveCurrent();
						var count = this.employeesTableAdapter.Update(this.chinookDataSet.employees);

						SetStatusText("Deleted 1 record.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void SaveData()
		{
			try
			{
				this.employeesBindingSource.EndEdit();
				var count = this.employeesTableAdapter.Update(this.chinookDataSet.employees);
				this.dataGridView1.Tools["Save"].Enabled = false;

				AlertBox.Show("Saved!");
				SetStatusText("Saved " + count + " records.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void AddNewRecord()
		{
			try
			{
				this.employeesBindingSource.AddNew();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", icon: MessageBoxIcon.Error, modal: false);
			}
		}

		private void SetStatusText(string text)
		{
			this.statusBar1.Text = text;
		}

		private void LoadData()
		{
			this.dataGridView1.CellValueChanged -= new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.employeesTableAdapter.Fill(this.chinookDataSet.employees);
			this.dataGridView1.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);

			SetStatusText("Loaded " + this.employeesBindingSource.Count + " records.");
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			this.dataGridView1.Tools["Delete"].Enabled = this.dataGridView1.CurrentRow != null;
		}

		private void dataGridView1_CellToolClick(object sender, DataGridViewToolClickEventArgs e)
		{
			AlertBox.Show("You clicked the sun tool. Nice work.");
		}

		private void textBox3_ToolClick(object sender, ToolClickEventArgs e)
		{
			if (String.IsNullOrEmpty(this.textBox3.Text))
				AlertBox.Show("Cannot send an email to an empty address! ", icon: MessageBoxIcon.Error);
			else
				AlertBox.Show("I'm sending an email to " + this.textBox3.Text);
		}

		private void textBox2_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("This tool button does't do anything.");
		}

		private void dateTimePicker1_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("You clicked the sun tool. Nice work.");
		}

		private void dataGridView1_Enter(object sender, EventArgs e)
		{
			this.employeesBindingSource.EndEdit();
		}
	}
}
