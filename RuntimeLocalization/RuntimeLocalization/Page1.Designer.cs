namespace RuntimeLocalization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.dateTimePicker = new Wisej.Web.DateTimePicker();
            this.label1 = new Wisej.Web.Label();
            this.statusBar = new Wisej.Web.StatusBar();
            this.statusBarPanel1 = new Wisej.Web.StatusBarPanel();
            this.menuBar = new Wisej.Web.MenuBar();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.menuItem3 = new Wisej.Web.MenuItem();
            this.menuItem4 = new Wisej.Web.MenuItem();
            this.menuItem5 = new Wisej.Web.MenuItem();
            this.menuItem8 = new Wisej.Web.MenuItem();
            this.selectEnglish = new Wisej.Web.MenuItem();
            this.selectFrench = new Wisej.Web.MenuItem();
            this.button1 = new Wisej.Web.Button();
            this.toolBar1 = new Wisej.Web.ToolBar();
            this.toolBarButton1 = new Wisej.Web.ToolBarButton();
            this.contextMenu = new Wisej.Web.ContextMenu();
            this.menuItem6 = new Wisej.Web.MenuItem();
            this.menuItem7 = new Wisej.Web.MenuItem();
            this.toolBarButton4 = new Wisej.Web.ToolBarButton();
            this.toolBarButton2 = new Wisej.Web.ToolBarButton();
            this.toolBarButton3 = new Wisej.Web.ToolBarButton();
            this.textBox1 = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.button2 = new Wisej.Web.Button();
            this.groupBox = new Wisej.Web.GroupBox();
            this.label4 = new Wisej.Web.Label();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.hourUpDown = new Wisej.Web.NumericUpDown();
            this.label3 = new Wisej.Web.Label();
            this.textBox2 = new Wisej.Web.TextBox();
            this.dataGridView = new Wisej.Web.DataGridView();
            this.Column1 = new Wisej.Web.DataGridViewColumn();
            this.Column3 = new Wisej.Web.DataGridViewColumn();
            this.showOnWindow = new Wisej.Web.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Value = new System.DateTime(((long)(0)));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new Wisej.Web.StatusBarPanel[] {
            this.statusBarPanel1});
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            resources.ApplyResources(this.statusBarPanel1, "statusBarPanel1");
            // 
            // menuBar
            // 
            resources.ApplyResources(this.menuBar, "menuBar");
            this.menuBar.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem8});
            this.menuBar.Name = "menuBar";
            this.menuBar.TabStop = false;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            this.menuItem1.Name = "menuItem1";
            resources.ApplyResources(this.menuItem1, "menuItem1");
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Name = "menuItem2";
            resources.ApplyResources(this.menuItem2, "menuItem2");
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Name = "menuItem3";
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Name = "menuItem4";
            resources.ApplyResources(this.menuItem4, "menuItem4");
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Name = "menuItem5";
            resources.ApplyResources(this.menuItem5, "menuItem5");
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.selectEnglish,
            this.selectFrench});
            this.menuItem8.Name = "menuItem8";
            resources.ApplyResources(this.menuItem8, "menuItem8");
            // 
            // selectEnglish
            // 
            this.selectEnglish.Checked = true;
            this.selectEnglish.Index = 0;
            this.selectEnglish.Name = "selectEnglish";
            this.selectEnglish.RadioCheck = true;
            resources.ApplyResources(this.selectEnglish, "selectEnglish");
            this.selectEnglish.Click += new System.EventHandler(this.selectlanguage_Click);
            // 
            // selectFrench
            // 
            this.selectFrench.Index = 1;
            this.selectFrench.Name = "selectFrench";
            this.selectFrench.RadioCheck = true;
            resources.ApplyResources(this.selectFrench, "selectFrench");
            this.selectFrench.Click += new System.EventHandler(this.selectlanguage_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton4,
            this.toolBarButton2,
            this.toolBarButton3});
            resources.ApplyResources(this.toolBar1, "toolBar1");
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.TabStop = false;
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.DropDownMenu = this.contextMenu;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
            resources.ApplyResources(this.toolBarButton1, "toolBarButton1");
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem6,
            this.menuItem7});
            this.contextMenu.Name = "contextMenu";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Name = "menuItem6";
            resources.ApplyResources(this.menuItem6, "menuItem6");
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Name = "menuItem7";
            resources.ApplyResources(this.menuItem7, "menuItem7");
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            resources.ApplyResources(this.toolBarButton4, "toolBarButton4");
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            resources.ApplyResources(this.toolBarButton2, "toolBarButton2");
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            resources.ApplyResources(this.toolBarButton3, "toolBarButton3");
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.numericUpDown1);
            this.groupBox.Controls.Add(this.hourUpDown);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.textBox2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.button2);
            this.groupBox.Controls.Add(this.dateTimePicker);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.textBox1);
            resources.ApplyResources(this.groupBox, "groupBox");
            this.groupBox.Name = "groupBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // hourUpDown
            // 
            resources.ApplyResources(this.hourUpDown, "hourUpDown");
            this.hourUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.hourUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column1,
            this.Column3});
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ShowFocusCell = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FillWeight = 110F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // showOnWindow
            // 
            this.showOnWindow.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            resources.ApplyResources(this.showOnWindow, "showOnWindow");
            this.showOnWindow.Name = "showOnWindow";
            this.showOnWindow.Click += new System.EventHandler(this.showOnWindow_Click);
            // 
            // Page1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.showOnWindow);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.statusBar);
            this.Name = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.DateTimePicker dateTimePicker;
        private Wisej.Web.Label label1;
        private Wisej.Web.StatusBar statusBar;
        private Wisej.Web.StatusBarPanel statusBarPanel1;
        private Wisej.Web.MenuBar menuBar;
        private Wisej.Web.MenuItem menuItem1;
        private Wisej.Web.MenuItem menuItem2;
        private Wisej.Web.MenuItem menuItem3;
        private Wisej.Web.MenuItem menuItem4;
        private Wisej.Web.MenuItem menuItem5;
        private Wisej.Web.Button button1;
        private Wisej.Web.ToolBar toolBar1;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Button button2;
        private Wisej.Web.GroupBox groupBox;
        private Wisej.Web.ToolBarButton toolBarButton1;
        private Wisej.Web.ToolBarButton toolBarButton4;
        private Wisej.Web.ToolBarButton toolBarButton2;
        private Wisej.Web.ToolBarButton toolBarButton3;
        private Wisej.Web.DataGridView dataGridView;
        private Wisej.Web.MenuItem menuItem8;
        private Wisej.Web.MenuItem selectEnglish;
        private Wisej.Web.MenuItem selectFrench;
        private Wisej.Web.ContextMenu contextMenu;
        private Wisej.Web.MenuItem menuItem6;
        private Wisej.Web.MenuItem menuItem7;
        private Wisej.Web.DataGridViewColumn Column1;
        private Wisej.Web.DataGridViewColumn Column3;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox textBox2;
        private Wisej.Web.NumericUpDown hourUpDown;
        private Wisej.Web.Label label4;
        private Wisej.Web.NumericUpDown numericUpDown1;
        private Wisej.Web.Button showOnWindow;
    }
}

