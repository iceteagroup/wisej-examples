namespace Wisej.CustomCellRenderer
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
            this.Column0 = new Wisej.Web.DataGridViewColumn();
            this.Column1 = new Wisej.Web.DataGridViewColumn();
            this.Column2 = new Wisej.CustomCellRenderer.DataGridViewJSONColumn();
            this.button1 = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(72, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Column0";
            this.Column0.Name = "Column0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Populate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1169, 862);
            this.Text = "Page1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.DataGridViewColumn Column0;
        private Web.DataGridViewColumn Column1;
        private DataGridViewJSONColumn Column2;
        private Web.Button button1;
    }
}

