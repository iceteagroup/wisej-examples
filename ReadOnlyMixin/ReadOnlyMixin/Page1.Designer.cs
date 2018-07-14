namespace ReadOnlyMixin
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
            this.controlStateLabel = new Wisej.Web.Label();
            this.controlState = new Wisej.Web.ComboBox();
            this.statePanel = new Wisej.Web.Panel();
            this.domainUpDown = new Wisej.Web.DomainUpDown();
            this.numericUpDown = new Wisej.Web.NumericUpDown();
            this.listBox = new Wisej.Web.ListBox();
            this.dateTimePicker = new Wisej.Web.DateTimePicker();
            this.comboBox = new Wisej.Web.ComboBox();
            this.textBox = new Wisej.Web.TextBox();
            this.statePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // controlStateLabel
            // 
            this.controlStateLabel.AutoSize = true;
            this.controlStateLabel.Location = new System.Drawing.Point(36, 41);
            this.controlStateLabel.Name = "controlStateLabel";
            this.controlStateLabel.Size = new System.Drawing.Size(127, 16);
            this.controlStateLabel.TabIndex = 0;
            this.controlStateLabel.Text = "Select Control State";
            // 
            // controlState
            // 
            this.controlState.Items.AddRange(new object[] {
            "Enabled",
            "Disabled",
            "ReadOnly"});
            this.controlState.Location = new System.Drawing.Point(189, 38);
            this.controlState.Name = "controlState";
            this.controlState.Size = new System.Drawing.Size(120, 22);
            this.controlState.TabIndex = 1;
            this.controlState.Text = "ReadOnly";
            this.controlState.SelectedItemChanged += new System.EventHandler(this.comboBox1_SelectedItemChanged);
            // 
            // statePanel
            // 
            this.statePanel.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.statePanel.Controls.Add(this.domainUpDown);
            this.statePanel.Controls.Add(this.numericUpDown);
            this.statePanel.Controls.Add(this.listBox);
            this.statePanel.Controls.Add(this.dateTimePicker);
            this.statePanel.Controls.Add(this.comboBox);
            this.statePanel.Controls.Add(this.textBox);
            this.statePanel.Location = new System.Drawing.Point(36, 104);
            this.statePanel.Name = "statePanel";
            this.statePanel.ShowCloseButton = false;
            this.statePanel.ShowHeader = true;
            this.statePanel.Size = new System.Drawing.Size(576, 450);
            this.statePanel.TabIndex = 2;
            this.statePanel.Text = "Enable";
            // 
            // domainUpDown
            // 
            this.domainUpDown.AutoSize = false;
            this.domainUpDown.Items.Add("George Washington (1789-1797)");
            this.domainUpDown.Items.Add("John Adams (1797-1801)");
            this.domainUpDown.Items.Add("Thomas Jefferson (1801-1809)");
            this.domainUpDown.Items.Add("James Madison (1809-1817)");
            this.domainUpDown.Items.Add("James Monroe (1817-1825)");
            this.domainUpDown.Items.Add("John Quincy Adams (1825-1829*)");
            this.domainUpDown.Items.Add("Andrew Jackson (1829-1837)");
            this.domainUpDown.Items.Add("");
            this.domainUpDown.Location = new System.Drawing.Point(18, 201);
            this.domainUpDown.Name = "domainUpDown";
            this.domainUpDown.SelectedIndex = 0;
            this.domainUpDown.Size = new System.Drawing.Size(304, 22);
            this.domainUpDown.TabIndex = 7;
            this.domainUpDown.Text = "George Washington (1789-1797)";
            // 
            // numericUpDown
            // 
            this.numericUpDown.AutoSize = false;
            this.numericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown.Location = new System.Drawing.Point(352, 201);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1829,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1789,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown.TabIndex = 6;
            this.numericUpDown.Value = new decimal(new int[] {
            1789,
            0,
            0,
            0});
            // 
            // listBox
            // 
            this.listBox.Items.AddRange(new object[] {
            "George Washington (1789-1797)",
            "John Adams (1797-1801)",
            "Thomas Jefferson (1801-1809)",
            "James Madison (1809-1817)",
            "James Monroe (1817-1825)",
            "John Quincy Adams (1825-1829*)",
            "Andrew Jackson (1829-1837)"});
            this.listBox.Location = new System.Drawing.Point(18, 244);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(534, 156);
            this.listBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(352, 159);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2018, 7, 14, 12, 18, 5, 367);
            // 
            // comboBox
            // 
            this.comboBox.AutoSize = false;
            this.comboBox.Items.AddRange(new object[] {
            "George Washington (1789-1797)",
            "John Adams (1797-1801)",
            "Thomas Jefferson (1801-1809)",
            "James Madison (1809-1817)",
            "James Monroe (1817-1825)",
            "John Quincy Adams (1825-1829*)",
            "Andrew Jackson (1829-1837)"});
            this.comboBox.Location = new System.Drawing.Point(18, 159);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(304, 22);
            this.comboBox.TabIndex = 3;
            this.comboBox.Text = "George Washington (1789-1797)";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(18, 23);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(534, 118);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "George Washington (1789-1797)\r\nJohn Adams (1797-1801)\r\nThomas Jefferson (1801-180" +
    "9)\r\nJames Madison (1809-1817)\r\nJames Monroe (1817-1825)\r\nJohn Quincy Adams (1825" +
    "-1829*)\r\nAndrew Jackson (1829-1837)";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.statePanel);
            this.Controls.Add(this.controlState);
            this.Controls.Add(this.controlStateLabel);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(941, 804);
            this.Text = "Page1";
            this.Appear += new System.EventHandler(this.Page1_Appear);
            this.statePanel.ResumeLayout(false);
            this.statePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label controlStateLabel;
        private Wisej.Web.ComboBox controlState;
        private Wisej.Web.Panel statePanel;
        private Wisej.Web.DomainUpDown domainUpDown;
        private Wisej.Web.NumericUpDown numericUpDown;
        private Wisej.Web.ListBox listBox;
        private Wisej.Web.DateTimePicker dateTimePicker;
        private Wisej.Web.ComboBox comboBox;
        private Wisej.Web.TextBox textBox;
    }
}

