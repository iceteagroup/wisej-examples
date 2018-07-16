namespace TreeGrid
{
    partial class ObjectListWindow
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
            this.dataGridView = new Wisej.Web.DataGridView();
            this.colId = new Wisej.Web.DataGridViewColumn();
            this.colName = new Wisej.Web.DataGridViewColumn();
            this.colTherapist = new Wisej.Web.DataGridViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colTherapist});
            this.dataGridView.Location = new System.Drawing.Point(17, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ShowColumnVisibilityMenu = false;
            this.dataGridView.ShowFocusCell = false;
            this.dataGridView.Size = new System.Drawing.Size(500, 475);
            this.dataGridView.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.HeaderText = "Therapy Name";
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colTherapist
            // 
            this.colTherapist.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.colTherapist.HeaderText = "Therapist";
            this.colTherapist.Name = "colTherapist";
            // 
            // ObjectListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 509);
            this.Controls.Add(this.dataGridView);
            this.Name = "ObjectListWindow";
            this.Text = "Object List Example";
            this.Load += new System.EventHandler(this.Page1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView;
        private Wisej.Web.DataGridViewColumn colId;
        private Wisej.Web.DataGridViewColumn colName;
        private Wisej.Web.DataGridViewColumn colTherapist;
    }
}

