namespace Integration3
{
    partial class Window1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window1));
            Wisej.Web.Widget.Package package1 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package2 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package3 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package4 = new Wisej.Web.Widget.Package();
            Wisej.Web.Widget.Package package5 = new Wisej.Web.Widget.Package();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.widgetDonut = new Wisej.Web.Widget();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.tableLayoutPanel2 = new Wisej.Web.TableLayoutPanel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.label1 = new Wisej.Web.Label();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.widgetPie = new Wisej.Web.Widget();
            this.tabPage3 = new Wisej.Web.TabPage();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.panel4 = new Wisej.Web.Panel();
            this.tableLayoutPanel3 = new Wisej.Web.TableLayoutPanel();
            this.button1 = new Wisej.Web.Button();
            this.textBoxQRfreeText = new Wisej.Web.TextBox();
            this.widgetQRfreeText = new Wisej.Web.Widget();
            this.panel3 = new Wisej.Web.Panel();
            this.widgetQRurl = new Wisej.Web.Widget();
            this.panel2 = new Wisej.Web.Panel();
            this.widgetQRgeo = new Wisej.Web.Widget();
            this.panel1 = new Wisej.Web.Panel();
            this.widgetQRemail = new Wisej.Web.Widget();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = Wisej.Web.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(986, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.widgetDonut);
            this.tabPage2.Location = new System.Drawing.Point(1, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Text = "Donut";
            // 
            // widgetDonut
            // 
            this.widgetDonut.Dock = Wisej.Web.DockStyle.Fill;
            this.widgetDonut.InitScript = resources.GetString("widgetDonut.InitScript");
            this.widgetDonut.Location = new System.Drawing.Point(0, 0);
            this.widgetDonut.Name = "widgetDonut";
            this.widgetDonut.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "jquery-1.12.3.min.js";
            package1.Source = "https://code.jquery.com/jquery-1.12.3.min.js";
            package2.Name = "kendo.all.min.js";
            package2.Source = "https://kendo.cdn.telerik.com/2017.2.621/js/kendo.all.min.js";
            package3.Name = "kendo.common.min.css";
            package3.Source = "https://kendo.cdn.telerik.com/2017.2.621/styles/kendo.common.min.css";
            package4.Name = "kendo.default.min.css";
            package4.Source = "https://kendo.cdn.telerik.com/2017.2.621/styles/kendo.default.min.css";
            package5.Name = "kendo.default.mobile.min.css";
            package5.Source = "https://kendo.cdn.telerik.com/2017.2.621/styles/kendo.default.mobile.min.css";
            this.widgetDonut.Packages.Add(package1);
            this.widgetDonut.Packages.Add(package2);
            this.widgetDonut.Packages.Add(package3);
            this.widgetDonut.Packages.Add(package4);
            this.widgetDonut.Packages.Add(package5);
            this.widgetDonut.Size = new System.Drawing.Size(984, 625);
            this.widgetDonut.TabIndex = 0;
            this.widgetDonut.Text = "widget1";
            this.widgetDonut.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widgetDonut_WidgetEvent);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(1, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Text = "Pie";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.widgetPie, 1, 0);
            this.tableLayoutPanel2.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(984, 625);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(190, 619);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select year";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.comboBox1.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.comboBox1.Location = new System.Drawing.Point(23, 46);
            this.comboBox1.MinimumSize = new System.Drawing.Size(80, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 22);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // widgetPie
            // 
            this.widgetPie.Dock = Wisej.Web.DockStyle.Fill;
            this.widgetPie.InitScript = resources.GetString("widgetPie.InitScript");
            this.widgetPie.Location = new System.Drawing.Point(199, 3);
            this.widgetPie.Name = "widgetPie";
            this.widgetPie.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetPie.Size = new System.Drawing.Size(782, 619);
            this.widgetPie.TabIndex = 0;
            this.widgetPie.Text = "widget1";
            this.widgetPie.WebRequest += new Wisej.Web.WebRequestHandler(this.widgetPie_WebRequest);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(1, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Text = "QRCodes";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.widgetQRfreeText);
            this.panel4.Dock = Wisej.Web.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(495, 315);
            this.panel4.Name = "panel4";
            this.panel4.ShowHeader = true;
            this.panel4.Size = new System.Drawing.Size(486, 307);
            this.panel4.TabIndex = 3;
            this.panel4.Text = "free text";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxQRfreeText, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(467, 37);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(294, 3);
            this.button1.MinimumSize = new System.Drawing.Size(80, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "create QR";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxQRfreeText
            // 
            this.textBoxQRfreeText.Dock = Wisej.Web.DockStyle.Fill;
            this.textBoxQRfreeText.Location = new System.Drawing.Point(3, 3);
            this.textBoxQRfreeText.Multiline = true;
            this.textBoxQRfreeText.Name = "textBoxQRfreeText";
            this.textBoxQRfreeText.Size = new System.Drawing.Size(274, 31);
            this.textBoxQRfreeText.TabIndex = 1;
            // 
            // widgetQRfreeText
            // 
            this.widgetQRfreeText.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.widgetQRfreeText.InitScript = resources.GetString("widgetQRfreeText.InitScript");
            this.widgetQRfreeText.Location = new System.Drawing.Point(122, 45);
            this.widgetQRfreeText.Name = "widgetQRfreeText";
            this.widgetQRfreeText.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetQRfreeText.Size = new System.Drawing.Size(262, 191);
            this.widgetQRfreeText.TabIndex = 0;
            this.widgetQRfreeText.Text = "widget1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.widgetQRurl);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 315);
            this.panel3.Name = "panel3";
            this.panel3.ShowHeader = true;
            this.panel3.Size = new System.Drawing.Size(486, 307);
            this.panel3.TabIndex = 2;
            this.panel3.Text = "url";
            // 
            // widgetQRurl
            // 
            this.widgetQRurl.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.widgetQRurl.InitScript = resources.GetString("widgetQRurl.InitScript");
            this.widgetQRurl.Location = new System.Drawing.Point(99, 45);
            this.widgetQRurl.Name = "widgetQRurl";
            this.widgetQRurl.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetQRurl.Size = new System.Drawing.Size(263, 191);
            this.widgetQRurl.TabIndex = 0;
            this.widgetQRurl.Text = "widget1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.widgetQRgeo);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(495, 3);
            this.panel2.Name = "panel2";
            this.panel2.ShowHeader = true;
            this.panel2.Size = new System.Drawing.Size(486, 306);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "geo";
            // 
            // widgetQRgeo
            // 
            this.widgetQRgeo.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.widgetQRgeo.InitScript = resources.GetString("widgetQRgeo.InitScript");
            this.widgetQRgeo.Location = new System.Drawing.Point(122, 42);
            this.widgetQRgeo.Name = "widgetQRgeo";
            this.widgetQRgeo.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetQRgeo.Size = new System.Drawing.Size(262, 191);
            this.widgetQRgeo.TabIndex = 0;
            this.widgetQRgeo.Text = "widget1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.widgetQRemail);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(486, 306);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "email";
            // 
            // widgetQRemail
            // 
            this.widgetQRemail.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.widgetQRemail.InitScript = resources.GetString("widgetQRemail.InitScript");
            this.widgetQRemail.Location = new System.Drawing.Point(99, 42);
            this.widgetQRemail.Name = "widgetQRemail";
            this.widgetQRemail.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.widgetQRemail.Size = new System.Drawing.Size(263, 191);
            this.widgetQRemail.TabIndex = 0;
            this.widgetQRemail.Text = "widget1";
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 661);
            this.CloseBox = false;
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "Window1";
            this.Text = "Integration 3 - Telerik Kendo UI";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TabControl tabControl1;
        private Wisej.Web.TabPage tabPage1;
        private Wisej.Web.Widget widgetPie;
        private Wisej.Web.TabPage tabPage2;
        private Wisej.Web.Widget widgetDonut;
        private Wisej.Web.TabPage tabPage3;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
        private Wisej.Web.Panel panel4;
        private Wisej.Web.Panel panel3;
        private Wisej.Web.Panel panel2;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.TextBox textBoxQRfreeText;
        private Wisej.Web.Widget widgetQRfreeText;
        private Wisej.Web.Widget widgetQRurl;
        private Wisej.Web.Widget widgetQRgeo;
        private Wisej.Web.Widget widgetQRemail;
        private Wisej.Web.Button button1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel2;
        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Label label1;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel3;
    }
}

