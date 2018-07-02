namespace Wisej.CodeProject.Examples
{
	partial class DataBinding
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
			this.components = new System.ComponentModel.Container();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool4 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool5 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool6 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool7 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool8 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool9 = new Wisej.Web.ComponentTool();
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.colEmployeeid = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colFirstname = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colLastname = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTitle = new Wisej.Web.DataGridViewComboBoxColumn();
			this.colBirthdate = new Wisej.Web.DataGridViewDateTimePickerColumn();
			this.colPhone = new Wisej.Web.DataGridViewMaskedTextBoxColumn();
			this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.statusBar1 = new Wisej.Web.StatusBar();
			this.employeesBindingSource = new Wisej.Web.BindingSource(this.components);
			this.chinookDataSet = new Wisej.CodeProject.chinookDataSet();
			this.textBox1 = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.textBox2 = new Wisej.Web.TextBox();
			this.label3 = new Wisej.Web.Label();
			this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
			this.label4 = new Wisej.Web.Label();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.label5 = new Wisej.Web.Label();
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.textBox3 = new Wisej.Web.TextBox();
			this.maskedTextBox1 = new Wisej.Web.MaskedTextBox();
			this.label6 = new Wisej.Web.Label();
			this.employeesTableAdapter = new Wisej.CodeProject.chinookDataSetTableAdapters.employeesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.dataGridView1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chinookDataSet)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colEmployeeid,
            this.colFirstname,
            this.colLastname,
            this.colTitle,
            this.colBirthdate,
            this.colPhone,
            this.colEmail});
			this.dataGridView1.Controls.Add(this.statusBar1);
			this.dataGridView1.DataSource = this.employeesBindingSource;
			this.dataGridView1.EditMode = Wisej.Web.DataGridViewEditMode.EditOnEnter;
			this.dataGridView1.Location = new System.Drawing.Point(37, 264);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(839, 311);
			this.dataGridView1.TabIndex = 1;
			componentTool2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/square-add-button.svg?color=#3F76BF";
			componentTool2.Name = "Add";
			componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool3.Enabled = false;
			componentTool3.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/save-button.svg?color=#3FBF47";
			componentTool3.Name = "Save";
			componentTool3.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool4.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/refresh-button.svg?color=#003EFF";
			componentTool4.Name = "Reload";
			componentTool4.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool5.Enabled = false;
			componentTool5.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rubbish-bin-delete-button.svg?color=#7A7A7A";
			componentTool5.Name = "Delete";
			this.dataGridView1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2,
            componentTool3,
            componentTool4,
            componentTool5});
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			this.dataGridView1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dataGridView1_ToolClick);
			this.dataGridView1.CellToolClick += new Wisej.Web.DataGridViewToolClickEventHandler(this.dataGridView1_CellToolClick);
			this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
			// 
			// colEmployeeid
			// 
			this.colEmployeeid.DataPropertyName = "EmployeeId";
			this.colEmployeeid.HeaderText = "ID";
			this.colEmployeeid.Name = "colEmployeeid";
			this.colEmployeeid.ReadOnly = true;
			this.colEmployeeid.Width = 50;
			// 
			// colFirstname
			// 
			this.colFirstname.DataPropertyName = "FirstName";
			this.colFirstname.HeaderText = "Name";
			this.colFirstname.Name = "colFirstname";
			this.colFirstname.Width = 150;
			// 
			// colLastname
			// 
			this.colLastname.DataPropertyName = "LastName";
			this.colLastname.HeaderText = "Last Name";
			this.colLastname.Name = "colLastname";
			this.colLastname.Width = 150;
			// 
			// colTitle
			// 
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.colTitle.HeaderText = "Title";
			this.colTitle.Items.AddRange(new object[] {
            "General Manager",
            "Sales Manager",
            "Sales Support Agent",
            "IT Manager",
            "IT Staff"});
			this.colTitle.Name = "colTitle";
			// 
			// colBirthdate
			// 
			this.colBirthdate.DataPropertyName = "BirthDate";
			this.colBirthdate.Format = Wisej.Web.DateTimePickerFormat.Long;
			this.colBirthdate.HeaderText = "Birth Date";
			this.colBirthdate.Name = "colBirthdate";
			componentTool1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FEC14C";
			this.colBirthdate.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
			this.colBirthdate.Width = 150;
			// 
			// colPhone
			// 
			this.colPhone.DataPropertyName = "Phone";
			this.colPhone.HeaderText = "Phone";
			this.colPhone.Mask = "(999) 000-0000";
			this.colPhone.Name = "colPhone";
			// 
			// colEmail
			// 
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Width = 150;
			// 
			// statusBar1
			// 
			this.statusBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
			this.statusBar1.Location = new System.Drawing.Point(0, 287);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.ShowPanels = false;
			this.statusBar1.Size = new System.Drawing.Size(837, 22);
			this.statusBar1.SizingGrip = false;
			this.statusBar1.TabIndex = 0;
			this.statusBar1.Text = "statusBar1";
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "employees";
			this.employeesBindingSource.DataSource = this.chinookDataSet;
			// 
			// chinookDataSet
			// 
			this.chinookDataSet.DataSetName = "chinookDataSet";
			this.chinookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.employeesBindingSource, "FirstName", true));
			this.textBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(8, 58);
			this.textBox1.Margin = new Wisej.Web.Padding(8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(204, 34);
			this.textBox1.TabIndex = 1;
			this.textBox1.Watermark = "Enter a name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Margin = new Wisej.Web.Padding(8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = Wisej.Web.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(228, 8);
			this.label2.Margin = new Wisej.Web.Padding(8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(204, 34);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Last Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox2
			// 
			this.textBox2.AutoSize = false;
			this.textBox2.DataBindings.Add(new Wisej.Web.Binding("Text", this.employeesBindingSource, "LastName", true));
			this.textBox2.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(228, 58);
			this.textBox2.Margin = new Wisej.Web.Padding(8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(204, 34);
			this.textBox2.TabIndex = 3;
			componentTool6.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/birthday-cake.svg";
			componentTool7.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/underline-text-button.svg";
			this.textBox2.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool6,
            componentTool7});
			this.textBox2.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBox2_ToolClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = Wisej.Web.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(624, 8);
			this.label3.Margin = new Wisej.Web.Padding(8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 34);
			this.label3.TabIndex = 6;
			this.label3.Text = "&Date of Birth";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.AutoSize = false;
			this.dateTimePicker1.DataBindings.Add(new Wisej.Web.Binding("Value", this.employeesBindingSource, "BirthDate", true));
			this.dateTimePicker1.Dock = Wisej.Web.DockStyle.Fill;
			this.dateTimePicker1.Location = new System.Drawing.Point(624, 58);
			this.dateTimePicker1.Margin = new Wisej.Web.Padding(8);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(207, 34);
			this.dateTimePicker1.TabIndex = 7;
			componentTool8.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/shining-sun.svg?color=#FFA700";
			this.dateTimePicker1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool8});
			this.dateTimePicker1.Value = new System.DateTime(2017, 8, 25, 17, 55, 6, 102);
			this.dateTimePicker1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dateTimePicker1_ToolClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = Wisej.Web.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(448, 8);
			this.label4.Margin = new Wisej.Web.Padding(8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 34);
			this.label4.TabIndex = 4;
			this.label4.Text = "&Title";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.employeesBindingSource, "Title", true));
			this.comboBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "General Manager",
            "Sales Manager",
            "Sales Support Agent",
            "IT Manager",
            "IT Staff"});
			this.comboBox1.Location = new System.Drawing.Point(448, 58);
			this.comboBox1.Margin = new Wisej.Web.Padding(8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 34);
			this.comboBox1.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
			this.label5.Dock = Wisej.Web.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(228, 108);
			this.label5.Margin = new Wisej.Web.Padding(8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(380, 34);
			this.label5.TabIndex = 10;
			this.label5.Text = "E&Mail";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 30);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 203);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// textBox3
			// 
			this.textBox3.AutoSize = false;
			this.tableLayoutPanel1.SetColumnSpan(this.textBox3, 2);
			this.textBox3.DataBindings.Add(new Wisej.Web.Binding("Text", this.employeesBindingSource, "Email", true));
			this.textBox3.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox3.Location = new System.Drawing.Point(223, 153);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(390, 47);
			this.textBox3.TabIndex = 11;
			componentTool9.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/write-email-envelope-button.svg";
			componentTool9.Name = "Send Email";
			this.textBox3.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool9});
			this.textBox3.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBox3_ToolClick);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.AutoSize = false;
			this.maskedTextBox1.DataBindings.Add(new Wisej.Web.Binding("Text", this.employeesBindingSource, "Phone", true));
			this.maskedTextBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.maskedTextBox1.Location = new System.Drawing.Point(3, 153);
			this.maskedTextBox1.Mask = "(999) 000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(214, 47);
			this.maskedTextBox1.TabIndex = 9;
			this.maskedTextBox1.Text = "(   )    -";
			// 
			// label6
			// 
			this.label6.Dock = Wisej.Web.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(8, 108);
			this.label6.Margin = new Wisej.Web.Padding(8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(204, 34);
			this.label6.TabIndex = 8;
			this.label6.Text = "&Phone";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
			// 
			// DataBinding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(913, 610);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.dataGridView1);
			this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/server-rack-with-three-levels.svg?color=#BF3" +
    "F3F";
			this.Name = "DataBinding";
			this.Text = "DataBinding Example";
			this.Load += new System.EventHandler(this.DataBinding_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.dataGridView1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chinookDataSet)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.DataGridView dataGridView1;
		private Web.TextBox textBox1;
		private Web.Label label1;
		private Web.Label label2;
		private Web.TextBox textBox2;
		private Web.Label label3;
		private Web.DateTimePicker dateTimePicker1;
		private Web.Label label4;
		private Web.ComboBox comboBox1;
		private Web.TableLayoutPanel tableLayoutPanel1;
		private Web.Label label5;
		private Web.StatusBar statusBar1;
		private Web.DataGridViewTextBoxColumn colEmployeeid;
		private Web.DataGridViewTextBoxColumn colLastname;
		private Web.DataGridViewTextBoxColumn colFirstname;
		private Web.DataGridViewDateTimePickerColumn colBirthdate;
		private Web.DataGridViewTextBoxColumn colEmail;
		private Web.BindingSource employeesBindingSource;
		private chinookDataSet chinookDataSet;
		private chinookDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
		private Web.DataGridViewComboBoxColumn colTitle;
		private Web.DataGridViewMaskedTextBoxColumn colPhone;
		private Web.TextBox textBox3;
		private Web.MaskedTextBox maskedTextBox1;
		private Web.Label label6;
	}
}