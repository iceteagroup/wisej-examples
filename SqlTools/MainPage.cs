
using SqlTools.Classes;
using System;
using System.Linq;
using Wisej.Web;
using Dapper;
using System.Collections.Generic;

namespace SqlTools
{
	public partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();

			// hooking up the event handlers here instead of assigning individual
			// event handlers to each control saves a lot of lines of code
			TabPages.SelectedIndexChanged += SharedChangedHandler;
			lvColumns.SelectedIndexChanged += SharedChangedHandler;
			cbFieldAlias.CheckedChanged += SharedChangedHandler;
			cbQualifiedNames.CheckedChanged += SharedChangedHandler;
			cbBrackets.CheckedChanged += SharedChangedHandler;
			dfNamespace.TextChanged += SharedChangedHandler;
			dfTableAlias.TextChanged += SharedChangedHandler;
		}

		private void LoadDatabases()
		{
			lvColumns.Items.Clear();
			lbTableNames.DataSource = null;
			cmbDatabaseNames.DataSource = null;
			dfSqlStatement.Clear();
			dfModelCode.Clear();

			cmbDatabaseNames.DataSource = Database.LoadDatabaseNames();
			if (cmbDatabaseNames.Items.Count > 0)
				cmbDatabaseNames.SelectedIndex = 0;
		}

		private void LoadTables()
		{
			lvColumns.Items.Clear();
			lbTableNames.DataSource = null;
			dfSqlStatement.Clear();
			dfModelCode.Clear();

			if (string.IsNullOrEmpty(cmbDatabaseNames.Text))
				return;
			lbTableNames.DataSource = Database.LoadTableNames(dfServerName.Text, cmbDatabaseNames.Text);
			if (lbTableNames.Items.Count > 0)
				lbTableNames.SelectedIndex = 0;
		}

		private void LoadColumns()
		{
			lvColumns.Items.Clear();

			if (lbTableNames.SelectedIndex < 0)
				return;

			var columns = Database.LoadColumns(dfServerName.Text, cmbDatabaseNames.Text, lbTableNames.Text);
			if (columns.Count == 0)
				return;

			foreach (var column in columns)
			{
				ListViewItem item = new ListViewItem(column.Name);
				item.SubItems.Add(column.SqlType);
				item.SubItems.Add(column.Length.ToString());
				item.SubItems.Add(column.IsPrimaryKey ? "PK" : "");
				item.SubItems.Add(column.CSharpType);
				item.ImageKey = column.Required ? "Required" : "Empty";
				dynamic x = item.UserData;
				x.Column = column;
				lvColumns.Items.Add(item);
				item.Selected = true;
			}
		}

		private List<DBColumn> CollectSelectedColumns()
		{
			List<DBColumn> list = new List<DBColumn>();
			foreach (var column in lvColumns.SelectedItems)
			{
				// UserData holds a reference to associated DBColumn so that
				// we can pass selected columns to the SqlGenerator class
				var x = column.UserData.Column;
				list.Add(x);
			}
			return list;
		}

		private List<DBColumn> CollectColumns()
		{
			List<DBColumn> list = new List<DBColumn>();
			foreach (var column in lvColumns.Items)
			{
				var x = column.UserData.Column;
				list.Add(x);
			}
			return list;
		}

		private void Generate()
		{
			switch (TabPages.SelectedIndex)
			{
				case 0:
					GenerateSqlStatements();
					break;
				case 1:
					GenerateModelCode();
					dfAttributesCode.Text = ModelGenerator.GenerateAttributes(dfNamespace.Text);
					dfBaseModelCode.Text = ModelGenerator.GenerateBaseModel(dfNamespace.Text);
					break;
			}
		}

		private void GenerateSqlStatements()
		{
            List<DBColumn> columnList = CollectSelectedColumns();
			string sqlSelect = SqlGenerator.GenerateSelect(columnList, (int)dfFieldsPerLine.Value, lbTableNames.Text, dfTableAlias.Text, cbQualifiedNames.Checked, cbFieldAlias.Checked, cbBrackets.Checked);
			string sqlUpdate = SqlGenerator.GenerateUpdate(columnList, (int)dfFieldsPerLine.Value, lbTableNames.Text, cbBrackets.Checked);
			string sqlInsert = SqlGenerator.GenerateInsert(columnList, (int)dfFieldsPerLine.Value, lbTableNames.Text, cbBrackets.Checked);

			string gap = "\r\n\r\n\r\n";
			dfSqlStatement.Text = $"{sqlSelect}{gap}{sqlUpdate}{gap}{sqlInsert}{gap}{gap}{ConvertSqlToCode(sqlSelect)}{gap}{ConvertSqlToCode(sqlUpdate)}{gap}{ConvertSqlToCode(sqlInsert)}";

		}

		private void GenerateModelCode()
		{
			dfModelCode.Text = ModelGenerator.GenerateCode(CollectColumns(), lbTableNames.Text, dfNamespace.Text, cbPropertyChanged.Checked, cbAttributes.Checked);
		}

		private static string ConvertSqlToCode(string sql)
        {
			sql = sql.Replace("\r\n", "\\r\\n\" + \r\n\"");
			sql = sql.Replace("\t", "  ");
			return $"\"{sql}\"";
        }

		private void SharedChangedHandler(object sender, EventArgs e)
		{
			Generate();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			LoadDatabases();
		}

		private void dfServerName_TextChanged(object sender, EventArgs e)
		{
			LoadDatabases();
		}

		private void cmbDatabaseNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadTables();
		}

		private void lbTableNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadColumns();
			Generate();
		}

        private void cbPropertyChanged_CheckedChanged(object sender, EventArgs e)
        {
			tabCodeBaseModel.Hidden = !cbPropertyChanged.Checked;
			Generate();
		}

        private void dfFieldsPerLine_ValueChanged(object sender, EventArgs e)
        {
			Generate();
		}

        private void cbAttributes_CheckedChanged(object sender, EventArgs e)
        {
			tabCodeAttributes.Hidden = !cbAttributes.Checked;
			Generate();
		}
	}
}
