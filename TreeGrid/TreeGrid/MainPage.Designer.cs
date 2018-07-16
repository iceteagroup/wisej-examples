namespace TreeGrid
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
            this.dataTable = new Wisej.Web.Button();
            this.objectList = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataTable.Location = new System.Drawing.Point(100, 100);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(300, 40);
            this.dataTable.TabIndex = 0;
            this.dataTable.Text = "DataTable example";
            this.dataTable.Click += new System.EventHandler(this.dataTable_Click);
            // 
            // objectList
            // 
            this.objectList.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.objectList.Location = new System.Drawing.Point(100, 250);
            this.objectList.Name = "objectList";
            this.objectList.Size = new System.Drawing.Size(300, 40);
            this.objectList.TabIndex = 1;
            this.objectList.Text = "Object List example";
            this.objectList.Click += new System.EventHandler(this.objectList_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.objectList);
            this.Controls.Add(this.dataTable);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(941, 804);
            this.Text = "TreeGrid Example";
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button dataTable;
        private Wisej.Web.Button objectList;
    }
}
