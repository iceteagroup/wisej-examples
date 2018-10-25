namespace DataBinding.Views
{
    partial class TextBoxBinding
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
            this.idLabel = new Wisej.Web.Label();
            this.idTextBox = new Wisej.Web.Label();
            this.vendorBindingSource = new Wisej.Web.BindingSource(this.components);
            this.firstNameLabel = new Wisej.Web.Label();
            this.firstNameTextBox = new Wisej.Web.TextBox();
            this.lastNameLabel = new Wisej.Web.Label();
            this.lastNameTextBox = new Wisej.Web.TextBox();
            this.townLabel = new Wisej.Web.Label();
            this.townTextBox = new Wisej.Web.TextBox();
            this.stateLabel = new Wisej.Web.Label();
            this.stateComboBox = new Wisej.Web.ComboBox();
            this.fullNameLabel = new Wisej.Web.Label();
            this.fullNameTextBox = new Wisej.Web.Label();
            this.saveButton = new Wisej.Web.Button();
            this.newButton = new Wisej.Web.Button();
            this.removeButton = new Wisej.Web.Button();
            this.closeButton = new Wisej.Web.Button();
            this.statesBindingSource = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(40, 45);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(69, 16);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.vendorBindingSource, "VendorId", true));
            this.idTextBox.Location = new System.Drawing.Point(140, 43);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(0, 18);
            this.idTextBox.TabIndex = 1;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(DataBinding.Model.Vendor);
            this.vendorBindingSource.RefreshValueOnChange = true;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(40, 100);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(69, 16);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.vendorBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(140, 98);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(40, 155);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(69, 16);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.vendorBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(140, 153);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // townLabel
            // 
            this.townLabel.Location = new System.Drawing.Point(40, 210);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(69, 16);
            this.townLabel.TabIndex = 6;
            this.townLabel.Text = "Town";
            // 
            // townTextBox
            // 
            this.townTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.vendorBindingSource, "Town", true));
            this.townTextBox.Location = new System.Drawing.Point(140, 208);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(207, 22);
            this.townTextBox.TabIndex = 7;
            // 
            // stateLabel
            // 
            this.stateLabel.Location = new System.Drawing.Point(40, 265);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(69, 16);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.vendorBindingSource, "State", true));
            this.stateComboBox.Location = new System.Drawing.Point(140, 263);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(207, 22);
            this.stateComboBox.TabIndex = 9;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Location = new System.Drawing.Point(40, 320);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(69, 16);
            this.fullNameLabel.TabIndex = 10;
            this.fullNameLabel.Text = "Full Name";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.AutoSize = true;
            this.fullNameTextBox.DataBindings.Add(new Wisej.Web.Binding("Text", this.vendorBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(140, 265);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(4, 16);
            this.fullNameTextBox.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(40, 414);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 26);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(140, 414);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(80, 26);
            this.newButton.TabIndex = 12;
            this.newButton.Text = "New";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(240, 414);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(80, 26);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "Remove";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(360, 414);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 26);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.AllowNew = false;
            // 
            // TextBoxBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 511);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(this.townLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "TextBoxBinding";
            this.Text = "TextBox Binding";
            this.Load += new System.EventHandler(this.TextBoxBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label idLabel;
        private Wisej.Web.Label idTextBox;
        private Wisej.Web.Label firstNameLabel;
        private Wisej.Web.TextBox firstNameTextBox;
        private Wisej.Web.Label lastNameLabel;
        private Wisej.Web.TextBox lastNameTextBox;
        private Wisej.Web.Label townLabel;
        private Wisej.Web.TextBox townTextBox;
        private Wisej.Web.Label stateLabel;
        private Wisej.Web.ComboBox stateComboBox;
        private Wisej.Web.Label fullNameLabel;
        private Wisej.Web.Label fullNameTextBox;
        private Wisej.Web.Button saveButton;
        private Wisej.Web.Button newButton;
        private Wisej.Web.Button removeButton;
        private Wisej.Web.Button closeButton;
        private Wisej.Web.BindingSource vendorBindingSource;
        private Wisej.Web.BindingSource statesBindingSource;
    }
}