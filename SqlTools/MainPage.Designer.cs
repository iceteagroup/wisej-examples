namespace SqlTools
{
	partial class MainPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tabCode = new Wisej.Web.TabPage();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.TabCodeModel = new Wisej.Web.TabPage();
            this.dfModelCode = new Wisej.Web.TextBox();
            this.tabCodeAttributes = new Wisej.Web.TabPage();
            this.dfAttributesCode = new Wisej.Web.TextBox();
            this.tabCodeBaseModel = new Wisej.Web.TabPage();
            this.dfBaseModelCode = new Wisej.Web.TextBox();
            this.panel4 = new Wisej.Web.Panel();
            this.cbAttributes = new Wisej.Web.CheckBox();
            this.cbPropertyChanged = new Wisej.Web.CheckBox();
            this.dfNamespace = new Wisej.Web.TextBox();
            this.columnHeaderPK = new Wisej.Web.ColumnHeader();
            this.columnHeaderLen = new Wisej.Web.ColumnHeader();
            this.columnHeaderType = new Wisej.Web.ColumnHeader();
            this.columnHeaderColumn = new Wisej.Web.ColumnHeader();
            this.panel3 = new Wisej.Web.Panel();
            this.lvColumns = new Wisej.Web.ListView();
            this.columnHeaderCSharp = new Wisej.Web.ColumnHeader();
            this.cbBrackets = new Wisej.Web.CheckBox();
            this.cbFieldAlias = new Wisej.Web.CheckBox();
            this.cbQualifiedNames = new Wisej.Web.CheckBox();
            this.label3 = new Wisej.Web.Label();
            this.dfTableAlias = new Wisej.Web.TextBox();
            this.dfSqlStatement = new Wisej.Web.TextBox();
            this.panelSqlStatements = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.dfFieldsPerLine = new Wisej.Web.NumericUpDown();
            this.tabSqlStatements = new Wisej.Web.TabPage();
            this.panel1 = new Wisej.Web.Panel();
            this.TabPages = new Wisej.Web.TabControl();
            this.label1 = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.panel2 = new Wisej.Web.Panel();
            this.lbTableNames = new Wisej.Web.ListBox();
            this.lblTables = new Wisej.Web.Label();
            this.cmbDatabaseNames = new Wisej.Web.ComboBox();
            this.lblDatabase = new Wisej.Web.Label();
            this.dfServerName = new Wisej.Web.TextBox();
            this.lblServer = new Wisej.Web.Label();
            this.LeftPanel = new Wisej.Web.Panel();
            this.tabCode.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabCodeModel.SuspendLayout();
            this.tabCodeAttributes.SuspendLayout();
            this.tabCodeBaseModel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSqlStatements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dfFieldsPerLine)).BeginInit();
            this.tabSqlStatements.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCode
            // 
            this.tabCode.Controls.Add(this.tabControl1);
            this.tabCode.Controls.Add(this.panel4);
            this.tabCode.ImageSource = "Images\\CSharp.svg";
            this.tabCode.Location = new System.Drawing.Point(0, 41);
            this.tabCode.Name = "tabCode";
            this.tabCode.Size = new System.Drawing.Size(1660, 906);
            this.tabCode.Text = "Code Generator";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = Wisej.Web.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.TabCodeModel);
            this.tabControl1.Controls.Add(this.tabCodeAttributes);
            this.tabControl1.Controls.Add(this.tabCodeBaseModel);
            this.tabControl1.Dock = Wisej.Web.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Orientation = Wisej.Web.Orientation.Horizontal;
            this.tabControl1.PageInsets = new Wisej.Web.Padding(124, 0, 2, 2);
            this.tabControl1.Size = new System.Drawing.Size(1660, 858);
            this.tabControl1.TabIndex = 4;
            // 
            // TabCodeModel
            // 
            this.TabCodeModel.Controls.Add(this.dfModelCode);
            this.TabCodeModel.Location = new System.Drawing.Point(124, 0);
            this.TabCodeModel.Name = "TabCodeModel";
            this.TabCodeModel.Size = new System.Drawing.Size(1534, 856);
            this.TabCodeModel.Text = "Model class";
            // 
            // dfModelCode
            // 
            this.dfModelCode.Dock = Wisej.Web.DockStyle.Fill;
            this.dfModelCode.Font = new System.Drawing.Font("Courier New, default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dfModelCode.Location = new System.Drawing.Point(0, 0);
            this.dfModelCode.Multiline = true;
            this.dfModelCode.Name = "dfModelCode";
            this.dfModelCode.ReadOnly = true;
            this.dfModelCode.Size = new System.Drawing.Size(1534, 856);
            this.dfModelCode.TabIndex = 3;
            // 
            // tabCodeAttributes
            // 
            this.tabCodeAttributes.Controls.Add(this.dfAttributesCode);
            this.tabCodeAttributes.Location = new System.Drawing.Point(124, 0);
            this.tabCodeAttributes.Name = "tabCodeAttributes";
            this.tabCodeAttributes.Size = new System.Drawing.Size(1534, 856);
            this.tabCodeAttributes.Text = "Attributes class";
            // 
            // dfAttributesCode
            // 
            this.dfAttributesCode.Dock = Wisej.Web.DockStyle.Fill;
            this.dfAttributesCode.Font = new System.Drawing.Font("Courier New, default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dfAttributesCode.Location = new System.Drawing.Point(0, 0);
            this.dfAttributesCode.Multiline = true;
            this.dfAttributesCode.Name = "dfAttributesCode";
            this.dfAttributesCode.ReadOnly = true;
            this.dfAttributesCode.Size = new System.Drawing.Size(1534, 856);
            this.dfAttributesCode.TabIndex = 4;
            // 
            // tabCodeBaseModel
            // 
            this.tabCodeBaseModel.Controls.Add(this.dfBaseModelCode);
            this.tabCodeBaseModel.Location = new System.Drawing.Point(124, 0);
            this.tabCodeBaseModel.Name = "tabCodeBaseModel";
            this.tabCodeBaseModel.Padding = new Wisej.Web.Padding(3);
            this.tabCodeBaseModel.Size = new System.Drawing.Size(1534, 856);
            this.tabCodeBaseModel.Text = "BaseModel class";
            // 
            // dfBaseModelCode
            // 
            this.dfBaseModelCode.Dock = Wisej.Web.DockStyle.Fill;
            this.dfBaseModelCode.Font = new System.Drawing.Font("Courier New, default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dfBaseModelCode.Location = new System.Drawing.Point(3, 3);
            this.dfBaseModelCode.Multiline = true;
            this.dfBaseModelCode.Name = "dfBaseModelCode";
            this.dfBaseModelCode.ReadOnly = true;
            this.dfBaseModelCode.Size = new System.Drawing.Size(1528, 850);
            this.dfBaseModelCode.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbAttributes);
            this.panel4.Controls.Add(this.cbPropertyChanged);
            this.panel4.Controls.Add(this.dfNamespace);
            this.panel4.Dock = Wisej.Web.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1660, 48);
            this.panel4.TabIndex = 0;
            this.panel4.TabStop = true;
            // 
            // cbAttributes
            // 
            this.cbAttributes.Checked = true;
            this.cbAttributes.CheckState = Wisej.Web.CheckState.Checked;
            this.cbAttributes.Location = new System.Drawing.Point(621, 12);
            this.cbAttributes.Name = "cbAttributes";
            this.cbAttributes.Size = new System.Drawing.Size(114, 22);
            this.cbAttributes.TabIndex = 2;
            this.cbAttributes.Text = "Use Attributes";
            this.cbAttributes.CheckedChanged += new System.EventHandler(this.cbAttributes_CheckedChanged);
            // 
            // cbPropertyChanged
            // 
            this.cbPropertyChanged.Checked = true;
            this.cbPropertyChanged.CheckState = Wisej.Web.CheckState.Checked;
            this.cbPropertyChanged.Location = new System.Drawing.Point(342, 12);
            this.cbPropertyChanged.Name = "cbPropertyChanged";
            this.cbPropertyChanged.Size = new System.Drawing.Size(236, 22);
            this.cbPropertyChanged.TabIndex = 1;
            this.cbPropertyChanged.Text = "Implement INotifyPropertyChanged";
            this.cbPropertyChanged.CheckedChanged += new System.EventHandler(this.cbPropertyChanged_CheckedChanged);
            // 
            // dfNamespace
            // 
            this.dfNamespace.Label.Position = Wisej.Web.LabelPosition.Left;
            this.dfNamespace.LabelText = "Namespace";
            this.dfNamespace.Location = new System.Drawing.Point(39, 12);
            this.dfNamespace.Name = "dfNamespace";
            this.dfNamespace.Size = new System.Drawing.Size(260, 22);
            this.dfNamespace.TabIndex = 0;
            this.dfNamespace.Text = "Noname";
            // 
            // columnHeaderPK
            // 
            this.columnHeaderPK.Name = "columnHeaderPK";
            this.columnHeaderPK.Text = "PK";
            this.columnHeaderPK.TextAlign = Wisej.Web.HorizontalAlignment.Center;
            // 
            // columnHeaderLen
            // 
            this.columnHeaderLen.Name = "columnHeaderLen";
            this.columnHeaderLen.Text = "Len";
            this.columnHeaderLen.TextAlign = Wisej.Web.HorizontalAlignment.Right;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Name = "columnHeaderType";
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 80;
            // 
            // columnHeaderColumn
            // 
            this.columnHeaderColumn.Name = "columnHeaderColumn";
            this.columnHeaderColumn.Text = "Column";
            this.columnHeaderColumn.Width = 180;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvColumns);
            this.panel3.Dock = Wisej.Web.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(6);
            this.panel3.ResizableEdges = Wisej.Web.AnchorStyles.Right;
            this.panel3.Size = new System.Drawing.Size(528, 906);
            this.panel3.TabIndex = 3;
            this.panel3.TabStop = true;
            // 
            // lvColumns
            // 
            this.lvColumns.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeaderColumn,
            this.columnHeaderType,
            this.columnHeaderLen,
            this.columnHeaderPK,
            this.columnHeaderCSharp});
            this.lvColumns.Dock = Wisej.Web.DockStyle.Fill;
            this.lvColumns.Location = new System.Drawing.Point(6, 6);
            this.lvColumns.MultiSelect = true;
            this.lvColumns.Name = "lvColumns";
            this.lvColumns.SelectionMode = Wisej.Web.SelectionMode.MultiExtended;
            this.lvColumns.Size = new System.Drawing.Size(516, 894);
            this.lvColumns.TabIndex = 1;
            this.lvColumns.View = Wisej.Web.View.Details;
            // 
            // columnHeaderCSharp
            // 
            this.columnHeaderCSharp.Name = "columnHeaderCSharp";
            this.columnHeaderCSharp.Text = "C#";
            this.columnHeaderCSharp.Width = 80;
            // 
            // cbBrackets
            // 
            this.cbBrackets.Location = new System.Drawing.Point(294, 37);
            this.cbBrackets.Name = "cbBrackets";
            this.cbBrackets.Size = new System.Drawing.Size(129, 22);
            this.cbBrackets.TabIndex = 8;
            this.cbBrackets.Text = "Square Brackets";
            // 
            // cbFieldAlias
            // 
            this.cbFieldAlias.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbFieldAlias.Location = new System.Drawing.Point(294, 12);
            this.cbFieldAlias.Name = "cbFieldAlias";
            this.cbFieldAlias.Size = new System.Drawing.Size(106, 22);
            this.cbFieldAlias.TabIndex = 6;
            this.cbFieldAlias.Text = "Field Aliases";
            // 
            // cbQualifiedNames
            // 
            this.cbQualifiedNames.Location = new System.Drawing.Point(434, 12);
            this.cbQualifiedNames.Name = "cbQualifiedNames";
            this.cbQualifiedNames.Size = new System.Drawing.Size(129, 22);
            this.cbQualifiedNames.TabIndex = 7;
            this.cbQualifiedNames.Text = "Qualified Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Table Alias";
            // 
            // dfTableAlias
            // 
            this.dfTableAlias.Location = new System.Drawing.Point(124, 9);
            this.dfTableAlias.Name = "dfTableAlias";
            this.dfTableAlias.Size = new System.Drawing.Size(120, 22);
            this.dfTableAlias.TabIndex = 4;
            // 
            // dfSqlStatement
            // 
            this.dfSqlStatement.Dock = Wisej.Web.DockStyle.Fill;
            this.dfSqlStatement.Font = new System.Drawing.Font("Courier New, default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dfSqlStatement.Location = new System.Drawing.Point(6, 78);
            this.dfSqlStatement.Multiline = true;
            this.dfSqlStatement.Name = "dfSqlStatement";
            this.dfSqlStatement.ReadOnly = true;
            this.dfSqlStatement.Size = new System.Drawing.Size(1120, 822);
            this.dfSqlStatement.TabIndex = 2;
            // 
            // panelSqlStatements
            // 
            this.panelSqlStatements.Controls.Add(this.label2);
            this.panelSqlStatements.Controls.Add(this.dfFieldsPerLine);
            this.panelSqlStatements.Controls.Add(this.cbBrackets);
            this.panelSqlStatements.Controls.Add(this.cbFieldAlias);
            this.panelSqlStatements.Controls.Add(this.cbQualifiedNames);
            this.panelSqlStatements.Controls.Add(this.label3);
            this.panelSqlStatements.Controls.Add(this.dfTableAlias);
            this.panelSqlStatements.Dock = Wisej.Web.DockStyle.Top;
            this.panelSqlStatements.Location = new System.Drawing.Point(6, 6);
            this.panelSqlStatements.Name = "panelSqlStatements";
            this.panelSqlStatements.Size = new System.Drawing.Size(1120, 72);
            this.panelSqlStatements.TabIndex = 1;
            this.panelSqlStatements.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fields per line";
            // 
            // dfFieldsPerLine
            // 
            this.dfFieldsPerLine.Location = new System.Drawing.Point(124, 37);
            this.dfFieldsPerLine.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.dfFieldsPerLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dfFieldsPerLine.Name = "dfFieldsPerLine";
            this.dfFieldsPerLine.Size = new System.Drawing.Size(95, 22);
            this.dfFieldsPerLine.TabIndex = 9;
            this.dfFieldsPerLine.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dfFieldsPerLine.ValueChanged += new System.EventHandler(this.dfFieldsPerLine_ValueChanged);
            // 
            // tabSqlStatements
            // 
            this.tabSqlStatements.Controls.Add(this.panel1);
            this.tabSqlStatements.Controls.Add(this.panel3);
            this.tabSqlStatements.ForeColor = System.Drawing.Color.FromName("@controlText");
            this.tabSqlStatements.ImageSource = "Images\\Sql.svg";
            this.tabSqlStatements.Location = new System.Drawing.Point(0, 41);
            this.tabSqlStatements.Name = "tabSqlStatements";
            this.tabSqlStatements.Size = new System.Drawing.Size(1660, 906);
            this.tabSqlStatements.Text = "SQL Statements";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dfSqlStatement);
            this.panel1.Controls.Add(this.panelSqlStatements);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(528, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(6);
            this.panel1.Size = new System.Drawing.Size(1132, 906);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // TabPages
            // 
            this.TabPages.Controls.Add(this.tabSqlStatements);
            this.TabPages.Controls.Add(this.tabCode);
            this.TabPages.Dock = Wisej.Web.DockStyle.Fill;
            this.TabPages.Location = new System.Drawing.Point(257, 36);
            this.TabPages.Name = "TabPages";
            this.TabPages.PageInsets = new Wisej.Web.Padding(0, 41, 2, 2);
            this.TabPages.Size = new System.Drawing.Size(1662, 949);
            this.TabPages.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI, default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Tools";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBox1.ForeColor = System.Drawing.Color.White;
            this.pictureBox1.ImageSource = "Images\\SqlApp.svg";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new Wisej.Web.Padding(6);
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1919, 36);
            this.panel2.TabIndex = 4;
            this.panel2.TabStop = true;
            // 
            // lbTableNames
            // 
            this.lbTableNames.Dock = Wisej.Web.DockStyle.Fill;
            this.lbTableNames.Location = new System.Drawing.Point(6, 119);
            this.lbTableNames.Name = "lbTableNames";
            this.lbTableNames.Size = new System.Drawing.Size(245, 824);
            this.lbTableNames.TabIndex = 11;
            this.lbTableNames.SelectedIndexChanged += new System.EventHandler(this.lbTableNames_SelectedIndexChanged);
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Dock = Wisej.Web.DockStyle.Top;
            this.lblTables.Location = new System.Drawing.Point(6, 94);
            this.lblTables.Name = "lblTables";
            this.lblTables.Padding = new Wisej.Web.Padding(0, 6, 0, 4);
            this.lblTables.Size = new System.Drawing.Size(245, 25);
            this.lblTables.TabIndex = 10;
            this.lblTables.Text = "Tables:";
            // 
            // cmbDatabaseNames
            // 
            this.cmbDatabaseNames.Dock = Wisej.Web.DockStyle.Top;
            this.cmbDatabaseNames.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbDatabaseNames.Location = new System.Drawing.Point(6, 72);
            this.cmbDatabaseNames.Name = "cmbDatabaseNames";
            this.cmbDatabaseNames.Size = new System.Drawing.Size(245, 22);
            this.cmbDatabaseNames.TabIndex = 9;
            this.cmbDatabaseNames.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseNames_SelectedIndexChanged);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Dock = Wisej.Web.DockStyle.Top;
            this.lblDatabase.Location = new System.Drawing.Point(6, 47);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Padding = new Wisej.Web.Padding(0, 6, 0, 4);
            this.lblDatabase.Size = new System.Drawing.Size(245, 25);
            this.lblDatabase.TabIndex = 8;
            this.lblDatabase.Text = "Database:";
            // 
            // dfServerName
            // 
            this.dfServerName.Dock = Wisej.Web.DockStyle.Top;
            this.dfServerName.Location = new System.Drawing.Point(6, 25);
            this.dfServerName.Name = "dfServerName";
            this.dfServerName.Size = new System.Drawing.Size(245, 22);
            this.dfServerName.TabIndex = 7;
            this.dfServerName.Text = "(localdb)\\MSSQLLocalDB";
            this.dfServerName.TextChanged += new System.EventHandler(this.dfServerName_TextChanged);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Dock = Wisej.Web.DockStyle.Top;
            this.lblServer.Location = new System.Drawing.Point(6, 6);
            this.lblServer.Name = "lblServer";
            this.lblServer.Padding = new Wisej.Web.Padding(0, 0, 0, 4);
            this.lblServer.Size = new System.Drawing.Size(245, 19);
            this.lblServer.TabIndex = 6;
            this.lblServer.Text = "Server:";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromName("@window");
            this.LeftPanel.Controls.Add(this.lbTableNames);
            this.LeftPanel.Controls.Add(this.lblTables);
            this.LeftPanel.Controls.Add(this.cmbDatabaseNames);
            this.LeftPanel.Controls.Add(this.lblDatabase);
            this.LeftPanel.Controls.Add(this.dfServerName);
            this.LeftPanel.Controls.Add(this.lblServer);
            this.LeftPanel.Dock = Wisej.Web.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 36);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new Wisej.Web.Padding(6);
            this.LeftPanel.ResizableEdges = Wisej.Web.AnchorStyles.Right;
            this.LeftPanel.Size = new System.Drawing.Size(257, 949);
            this.LeftPanel.TabIndex = 3;
            this.LeftPanel.TabStop = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.TabPages);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panel2);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1919, 985);
            this.Text = "Sql Tools";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabCode.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabCodeModel.ResumeLayout(false);
            this.TabCodeModel.PerformLayout();
            this.tabCodeAttributes.ResumeLayout(false);
            this.tabCodeAttributes.PerformLayout();
            this.tabCodeBaseModel.ResumeLayout(false);
            this.tabCodeBaseModel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelSqlStatements.ResumeLayout(false);
            this.panelSqlStatements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dfFieldsPerLine)).EndInit();
            this.tabSqlStatements.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.TabPage tabCode;
        private Wisej.Web.ColumnHeader columnHeaderPK;
        private Wisej.Web.ColumnHeader columnHeaderLen;
        private Wisej.Web.ColumnHeader columnHeaderType;
        private Wisej.Web.ColumnHeader columnHeaderColumn;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.ListView lvColumns;
        private Wisej.Web.ColumnHeader columnHeaderCSharp;
        private Wisej.Web.CheckBox cbBrackets;
        private Wisej.Web.CheckBox cbFieldAlias;
        private Wisej.Web.CheckBox cbQualifiedNames;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox dfTableAlias;
        private Wisej.Web.TextBox dfSqlStatement;
        private Wisej.Web.Panel panelSqlStatements;
        private Wisej.Web.TabPage tabSqlStatements;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.TabControl TabPages;
        private Wisej.Web.Label label1;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.ListBox lbTableNames;
        private Wisej.Web.Label lblTables;
        private Wisej.Web.ComboBox cmbDatabaseNames;
        private Wisej.Web.Label lblDatabase;
        private Wisej.Web.TextBox dfServerName;
        private Wisej.Web.Label lblServer;
        private Wisej.Web.Panel LeftPanel;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.CheckBox cbPropertyChanged;
        private Wisej.Web.TextBox dfNamespace;
        private Wisej.Web.TextBox dfModelCode;
        private Wisej.Web.TabControl tabControl1;
        private Wisej.Web.TabPage TabCodeModel;
        private Wisej.Web.TabPage tabCodeAttributes;
        private Wisej.Web.TextBox dfAttributesCode;
        private Wisej.Web.TabPage tabCodeBaseModel;
        private Wisej.Web.TextBox dfBaseModelCode;
        private Wisej.Web.Label label2;
        private Wisej.Web.NumericUpDown dfFieldsPerLine;
        private Wisej.Web.CheckBox cbAttributes;
    }
}

