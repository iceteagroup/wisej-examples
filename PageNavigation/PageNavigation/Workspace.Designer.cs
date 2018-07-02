namespace PageNavigation
{
    partial class Workspace
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
            this.label1 = new Wisej.Web.Label();
            this.backButton = new Wisej.Web.Button();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column1 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column2 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column3 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.Column4 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.errorButton = new Wisej.Web.Button();
            this.usernameLabel = new Wisej.Web.Label();
            this.newWorkspace = new Wisej.Web.Button();
            this.workspaceLabel = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.customerName = new Wisej.Web.TextBox();
            this.settingsButton = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // backButton
            // 
            this.backButton.DialogResult = Wisej.Web.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.backButton.Location = new System.Drawing.Point(150, 455);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to Main Page";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;
            this.dataGridView1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(150, 100);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(670, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column0
            // 
            this.Column0.FillWeight = 50F;
            this.Column0.HeaderText = "Nr.";
            this.Column0.Name = "Column0";
            this.Column0.Width = 50;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Address";
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Zip";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Country";
            this.Column4.MinimumWidth = 20;
            this.Column4.Name = "Column4";
            // 
            // errorButton
            // 
            this.errorButton.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.errorButton.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.errorButton.Location = new System.Drawing.Point(620, 534);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(200, 40);
            this.errorButton.TabIndex = 3;
            this.errorButton.Text = "Error";
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.usernameLabel.Location = new System.Drawing.Point(268, 25);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(85, 20);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "username";
            // 
            // newWorkspace
            // 
            this.newWorkspace.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.newWorkspace.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newWorkspace.Location = new System.Drawing.Point(620, 455);
            this.newWorkspace.Name = "newWorkspace";
            this.newWorkspace.Size = new System.Drawing.Size(200, 40);
            this.newWorkspace.TabIndex = 5;
            this.newWorkspace.Text = "New Workspace";
            this.newWorkspace.Click += new System.EventHandler(this.newWorkspace_Click);
            // 
            // workspaceLabel
            // 
            this.workspaceLabel.AutoSize = true;
            this.workspaceLabel.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.workspaceLabel.Location = new System.Drawing.Point(268, 60);
            this.workspaceLabel.Name = "workspaceLabel";
            this.workspaceLabel.Size = new System.Drawing.Size(91, 20);
            this.workspaceLabel.TabIndex = 7;
            this.workspaceLabel.Text = "workspace";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(150, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Workspace:";
            // 
            // label2
            // 
            this.label2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(650, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer";
            // 
            // customerName
            // 
            this.customerName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.customerName.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerName.Location = new System.Drawing.Point(650, 60);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(170, 22);
            this.customerName.TabIndex = 9;
            this.customerName.Text = "Joe Bloggs";
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.settingsButton.Location = new System.Drawing.Point(150, 534);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 40);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.CancelButton = this.backButton;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workspaceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newWorkspace);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.errorButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "Workspace";
            this.Size = new System.Drawing.Size(938, 804);
            this.Text = "Workspace";
            this.Load += new System.EventHandler(this.Workspace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label label1;
        private Wisej.Web.Button backButton;
        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.DataGridViewTextBoxColumn Column0;
        private Wisej.Web.DataGridViewTextBoxColumn Column1;
        private Wisej.Web.DataGridViewTextBoxColumn Column2;
        private Wisej.Web.DataGridViewTextBoxColumn Column3;
        private Wisej.Web.DataGridViewTextBoxColumn Column4;
        private Wisej.Web.Button errorButton;
        private Wisej.Web.Label usernameLabel;
        private Wisej.Web.Button newWorkspace;
        private Wisej.Web.Label workspaceLabel;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label2;
        private Wisej.Web.TextBox customerName;
        private Wisej.Web.Button settingsButton;
    }
}

