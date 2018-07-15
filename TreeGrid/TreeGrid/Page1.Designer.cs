namespace TreeGrid
{
    partial class Page1
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
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.colId = new Wisej.Web.DataGridViewColumn();
            this.colName = new Wisej.Web.DataGridViewColumn();
            this.colType = new Wisej.Web.DataGridViewColumn();
            this.colTherapist = new Wisej.Web.DataGridViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colType,
            this.colTherapist});
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowFocusCell = false;
            this.dataGridView1.Size = new System.Drawing.Size(483, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            // 
            // colTherapist
            // 
            this.colTherapist.HeaderText = "Therapist";
            this.colTherapist.Name = "colTherapist";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(941, 804);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewColumn colId;
        private Wisej.Web.DataGridViewColumn colName;
        private Wisej.Web.DataGridViewColumn colType;
        private Wisej.Web.DataGridViewColumn colTherapist;
    }
}

