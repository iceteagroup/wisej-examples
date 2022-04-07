namespace Integration1
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
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package2 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package3 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package4 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package5 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package6 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package7 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package8 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package9 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package10 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package11 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package12 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package13 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package14 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package15 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package16 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package17 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package18 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package19 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package20 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package21 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package22 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package23 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package24 = new Wisej.Web.Widget.Package();
            this.widgetPivotGrid = new Wisej.Web.Widget();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.widgetCircularGage = new Wisej.Web.Widget();
            this.btnHeatUp = new Wisej.Web.Button();
            this.btnCoolDown = new Wisej.Web.Button();
            this.tabPage3 = new Wisej.Web.TabPage();
            this.widgetGallery = new Wisej.Web.Widget();
            this.tabPage4 = new Wisej.Web.TabPage();
            this.tableLayoutPanel2 = new Wisej.Web.TableLayoutPanel();
            this.widgetBarGauge = new Wisej.Web.Widget();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // widgetPivotGrid
            // 
            this.widgetPivotGrid.Dock = Wisej.Web.DockStyle.Fill;
            this.widgetPivotGrid.InitScript = resources.GetString("widgetPivotGrid.InitScript");
            this.widgetPivotGrid.Location = new System.Drawing.Point(0, 0);
            this.widgetPivotGrid.Name = "widgetPivotGrid";
            this.widgetPivotGrid.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "jquery.js";
            package1.Source = "https://code.jquery.com/jquery-3.1.0.min.js";
            package2.Name = "jszip.js";
            package2.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js";
            package3.Name = "dxall.js";
            package3.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js";
            package4.Name = "dxspa.css";
            package4.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css";
            package5.Name = "dxcommon.css";
            package5.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css";
            package6.Name = "dxlight.css";
            package6.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css";
            this.widgetPivotGrid.Packages.Add(package1);
            this.widgetPivotGrid.Packages.Add(package2);
            this.widgetPivotGrid.Packages.Add(package3);
            this.widgetPivotGrid.Packages.Add(package4);
            this.widgetPivotGrid.Packages.Add(package5);
            this.widgetPivotGrid.Packages.Add(package6);
            this.widgetPivotGrid.Size = new System.Drawing.Size(909, 585);
            this.widgetPivotGrid.TabIndex = 0;
            this.widgetPivotGrid.Text = "widget1";
            this.widgetPivotGrid.WebRequest += new Wisej.Web.WebRequestHandler(this.widgetPivotGrid_WebRequest_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(89, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 30, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(911, 616);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.widgetPivotGrid);
            this.tabPage1.Location = new System.Drawing.Point(1, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(909, 585);
            this.tabPage1.Text = "dxPivotGrid";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(1, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(909, 585);
            this.tabPage2.Text = "dxCircularGauge";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.widgetCircularGage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHeatUp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCoolDown, 1, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 585);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // widgetCircularGage
            // 
            this.widgetCircularGage.Dock = Wisej.Web.DockStyle.Fill;
            this.widgetCircularGage.InitScript = resources.GetString("widgetCircularGage.InitScript");
            this.widgetCircularGage.Location = new System.Drawing.Point(3, 3);
            this.widgetCircularGage.Name = "widgetCircularGage";
            this.widgetCircularGage.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package7.Name = "jquery.js";
            package7.Source = "https://code.jquery.com/jquery-3.1.0.min.js";
            package8.Name = "jszip.js";
            package8.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js";
            package9.Name = "dxall.js";
            package9.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js";
            package10.Name = "dxspa.css";
            package10.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css";
            package11.Name = "dxcommon.css";
            package11.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css";
            package12.Name = "dxlight.css";
            package12.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css";
            this.widgetCircularGage.Packages.Add(package7);
            this.widgetCircularGage.Packages.Add(package8);
            this.widgetCircularGage.Packages.Add(package9);
            this.widgetCircularGage.Packages.Add(package10);
            this.widgetCircularGage.Packages.Add(package11);
            this.widgetCircularGage.Packages.Add(package12);
            this.widgetCircularGage.Size = new System.Drawing.Size(721, 579);
            this.widgetCircularGage.TabIndex = 0;
            this.widgetCircularGage.Text = "widget2";
            this.widgetCircularGage.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widgetCircularGage_WidgetEvent);
            // 
            // btnHeatUp
            // 
            this.btnHeatUp.Anchor = Wisej.Web.AnchorStyles.Top;
            this.btnHeatUp.ImageSource = "window-maximize";
            this.btnHeatUp.Location = new System.Drawing.Point(843, 15);
            this.btnHeatUp.Margin = new Wisej.Web.Padding(15);
            this.btnHeatUp.Name = "btnHeatUp";
            this.btnHeatUp.Repeat = true;
            this.btnHeatUp.Size = new System.Drawing.Size(40, 32);
            this.btnHeatUp.TabIndex = 1;
            this.btnHeatUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCoolDown
            // 
            this.btnCoolDown.Anchor = Wisej.Web.AnchorStyles.Top;
            this.btnCoolDown.ImageSource = "window-minimize";
            this.btnCoolDown.Location = new System.Drawing.Point(752, 15);
            this.btnCoolDown.Margin = new Wisej.Web.Padding(15);
            this.btnCoolDown.Name = "btnCoolDown";
            this.btnCoolDown.Repeat = true;
            this.btnCoolDown.Size = new System.Drawing.Size(40, 32);
            this.btnCoolDown.TabIndex = 2;
            this.btnCoolDown.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.widgetGallery);
            this.tabPage3.Location = new System.Drawing.Point(1, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new Wisej.Web.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(909, 585);
            this.tabPage3.Text = "dxGallery";
            // 
            // widgetGallery
            // 
            this.widgetGallery.Dock = Wisej.Web.DockStyle.Fill;
            this.widgetGallery.InitScript = resources.GetString("widgetGallery.InitScript");
            this.widgetGallery.Location = new System.Drawing.Point(3, 3);
            this.widgetGallery.Name = "widgetGallery";
            this.widgetGallery.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package13.Name = "jquery.js";
            package13.Source = "https://code.jquery.com/jquery-3.1.0.min.js";
            package14.Name = "jszip.js";
            package14.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js";
            package15.Name = "dxall.js";
            package15.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js";
            package16.Name = "dxspa.css";
            package16.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css";
            package17.Name = "dxcommon.css";
            package17.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css";
            package18.Name = "dxlight.css";
            package18.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css";
            this.widgetGallery.Packages.Add(package13);
            this.widgetGallery.Packages.Add(package14);
            this.widgetGallery.Packages.Add(package15);
            this.widgetGallery.Packages.Add(package16);
            this.widgetGallery.Packages.Add(package17);
            this.widgetGallery.Packages.Add(package18);
            this.widgetGallery.Size = new System.Drawing.Size(903, 579);
            this.widgetGallery.TabIndex = 0;
            this.widgetGallery.Text = "widget1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel2);
            this.tabPage4.Location = new System.Drawing.Point(1, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new Wisej.Web.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(909, 585);
            this.tabPage4.Text = "dxBarGauge";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.widgetBarGauge, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel2.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 579);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.TabStop = true;
            // 
            // widgetBarGauge
            // 
            this.widgetBarGauge.Dock = Wisej.Web.DockStyle.Fill;
            this.widgetBarGauge.InitScript = resources.GetString("widgetBarGauge.InitScript");
            this.widgetBarGauge.Location = new System.Drawing.Point(3, 3);
            this.widgetBarGauge.Name = "widgetBarGauge";
            this.widgetBarGauge.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package19.Name = "jquery.js";
            package19.Source = "https://code.jquery.com/jquery-3.1.0.min.js";
            package20.Name = "jszip.js";
            package20.Source = "https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js";
            package21.Name = "dxall.js";
            package21.Source = "https://cdn3.devexpress.com/jslib/16.2.6/js/dx.all.js";
            package22.Name = "dxspa.css";
            package22.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.spa.css";
            package23.Name = "dxcommon.css";
            package23.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.common.css";
            package24.Name = "dxlight.css";
            package24.Source = "https://cdn3.devexpress.com/jslib/16.2.6/css/dx.light.css";
            this.widgetBarGauge.Packages.Add(package19);
            this.widgetBarGauge.Packages.Add(package20);
            this.widgetBarGauge.Packages.Add(package21);
            this.widgetBarGauge.Packages.Add(package22);
            this.widgetBarGauge.Packages.Add(package23);
            this.widgetBarGauge.Packages.Add(package24);
            this.widgetBarGauge.Size = new System.Drawing.Size(716, 573);
            this.widgetBarGauge.TabIndex = 0;
            this.widgetBarGauge.Text = "widget1";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Soft Pastel",
            "Harmony Light",
            "Pastel",
            "Bright",
            "Soft",
            "Ocean",
            "Vintage",
            "Violet"});
            this.comboBox1.Location = new System.Drawing.Point(737, 15);
            this.comboBox1.Margin = new Wisej.Web.Padding(15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 34);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1095, 775);
            this.Text = "Page1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Widget widgetPivotGrid;
        private Wisej.Web.TabControl tabControl1;
        private Wisej.Web.TabPage tabPage1;
        private Wisej.Web.TabPage tabPage2;        
        private Wisej.Web.Widget widgetCircularGage;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
        private Wisej.Web.Button btnHeatUp;
        private Wisej.Web.Button btnCoolDown;
        private Wisej.Web.TabPage tabPage3;
        private Wisej.Web.Widget widgetGallery;
        private Wisej.Web.TabPage tabPage4;
        private Wisej.Web.Widget widgetBarGauge;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel2;
        private Wisej.Web.ComboBox comboBox1;
    }
}

