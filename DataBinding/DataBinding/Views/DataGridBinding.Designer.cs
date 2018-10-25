namespace DataBinding.Views
{
    partial class DataGridBinding
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
            this.dataGridView = new Wisej.Web.DataGridView();
            this.colVendorid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colFirstname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLastname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colTown = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colState = new Wisej.Web.DataGridViewComboBoxColumn();
            this.colFullname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.vendorListBindingSource = new Wisej.Web.BindingSource(this.components);
            this.statesBindingSource = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colVendorid,
            this.colFirstname,
            this.colLastname,
            this.colTown,
            this.colState,
            this.colFullname});
            this.dataGridView.DataSource = this.vendorListBindingSource;
            this.dataGridView.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidthSizeMode = Wisej.Web.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Resizable = Wisej.Web.DataGridViewTriState.False;
            this.dataGridView.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowColumnVisibilityMenu = false;
            this.dataGridView.Size = new System.Drawing.Size(738, 370);
            this.dataGridView.TabIndex = 1;
            // 
            // colVendorid
            // 
            this.colVendorid.DataPropertyName = "VendorId";
            this.colVendorid.HeaderText = "Id";
            this.colVendorid.Name = "colVendorid";
            this.colVendorid.ReadOnly = true;
            this.colVendorid.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
            this.colVendorid.Width = 50;
            // 
            // colFirstname
            // 
            this.colFirstname.DataPropertyName = "FirstName";
            this.colFirstname.HeaderText = "First Name";
            this.colFirstname.Name = "colFirstname";
            this.colFirstname.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLastname
            // 
            this.colLastname.DataPropertyName = "LastName";
            this.colLastname.HeaderText = "Last Name";
            this.colLastname.Name = "colLastname";
            // 
            // colTown
            // 
            this.colTown.DataPropertyName = "Town";
            this.colTown.HeaderText = "Town";
            this.colTown.Name = "colTown";
            this.colTown.Width = 150;
            // 
            // colState
            // 
            this.colState.DataPropertyName = "State";
            this.colState.HeaderText = "State";
            this.colState.Name = "colState";
            // 
            // colFullname
            // 
            this.colFullname.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullname.DataPropertyName = "FullName";
            this.colFullname.HeaderText = "Full Name";
            this.colFullname.Name = "colFullname";
            this.colFullname.ReadOnly = true;
            // 
            // vendorListBindingSource
            // 
            this.vendorListBindingSource.DataSource = typeof(DataBinding.Model.VendorList);
            this.vendorListBindingSource.RefreshValueOnChange = true;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.AllowNew = false;
            // 
            // DataGridBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 480);
            this.Controls.Add(this.dataGridView);
            this.Name = "DataGridBinding";
            this.Text = "DataGrid Binding";
            this.Load += new System.EventHandler(this.DataGridBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView;
        private Wisej.Web.BindingSource vendorListBindingSource;
        private Wisej.Web.DataGridViewTextBoxColumn colVendorid;
        private Wisej.Web.DataGridViewTextBoxColumn colFirstname;
        private Wisej.Web.DataGridViewTextBoxColumn colLastname;
        private Wisej.Web.DataGridViewTextBoxColumn colTown;
        private Wisej.Web.DataGridViewTextBoxColumn colFullname;
        private Wisej.Web.DataGridViewComboBoxColumn colState;
        private Wisej.Web.BindingSource statesBindingSource;
    }
}