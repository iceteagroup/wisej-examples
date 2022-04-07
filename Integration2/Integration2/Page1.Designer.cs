namespace Integration2
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
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.dataGridViewSearchEngines = new Wisej.Web.DataGridView();
            this.colText = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colURL = new Wisej.Web.DataGridViewLinkColumn();
            this.colFrequency = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSlider = new Wisej.Web.DataGridViewColumn();
            this.widgetTagCloud = new Wisej.Web.Widget();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.widgetSignature = new Wisej.Web.Widget();
            this.label1 = new Wisej.Web.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEngines)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(1024, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSearchEngines);
            this.tabPage1.Controls.Add(this.widgetTagCloud);
            this.tabPage1.Location = new System.Drawing.Point(1, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1022, 489);
            this.tabPage1.Text = "TagCloud and Slider";
            // 
            // dataGridViewSearchEngines
            // 
            this.dataGridViewSearchEngines.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colText,
            this.colURL,
            this.colFrequency,
            this.colSlider});
            this.dataGridViewSearchEngines.Location = new System.Drawing.Point(8, 11);
            this.dataGridViewSearchEngines.Name = "dataGridViewSearchEngines";
            this.dataGridViewSearchEngines.Size = new System.Drawing.Size(658, 443);
            this.dataGridViewSearchEngines.TabIndex = 1;
            this.dataGridViewSearchEngines.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridViewSearchEngines_CellValueChanged);
            this.dataGridViewSearchEngines.RowsAdded += new Wisej.Web.DataGridViewRowsAddedEventHandler(this.dataGridViewSearchEngines_RowsAdded);
            // 
            // colText
            // 
            this.colText.HeaderText = "SearchEngine";
            this.colText.Name = "colText";
            this.colText.ReadOnly = true;
            // 
            // colURL
            // 
            this.colURL.HeaderText = "URL";
            this.colURL.Name = "colURL";
            this.colURL.Text = "";
            this.colURL.Width = 200;
            // 
            // colFrequency
            // 
            this.colFrequency.HeaderText = "Frequency";
            this.colFrequency.Name = "colFrequency";
            // 
            // colSlider
            // 
            this.colSlider.HeaderText = "Slider";
            this.colSlider.Name = "colSlider";
            this.colSlider.Width = 200;
            // 
            // widgetTagCloud
            // 
            this.widgetTagCloud.BackColor = System.Drawing.Color.Silver;
            this.widgetTagCloud.InitScript = resources.GetString("widgetTagCloud.InitScript");
            this.widgetTagCloud.Location = new System.Drawing.Point(684, 11);
            this.widgetTagCloud.Name = "widgetTagCloud";
            this.widgetTagCloud.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package1.Name = "ej.web.all.min.css";
            package1.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/flat-azure/ej.web.all.min.css";
            package2.Name = "jquery-1.10.2.min.js";
            package2.Source = "http://cdn.syncfusion.com/js/assets/external/jquery-1.10.2.min.js";
            package3.Name = "jquery.easing.1.3.min.js";
            package3.Source = "http://cdn.syncfusion.com/js/assets/external/jquery.easing.1.3.min.js";
            package4.Name = "ej.web.all.min.js";
            package4.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/ej.web.all.min.js";
            this.widgetTagCloud.Packages.Add(package1);
            this.widgetTagCloud.Packages.Add(package2);
            this.widgetTagCloud.Packages.Add(package3);
            this.widgetTagCloud.Packages.Add(package4);
            this.widgetTagCloud.Size = new System.Drawing.Size(322, 314);
            this.widgetTagCloud.TabIndex = 0;
            this.widgetTagCloud.Text = "widgetTagCloud";
            this.widgetTagCloud.WebRequest += new Wisej.Web.WebRequestHandler(this.widgetTagCloud_WebRequest);
            this.widgetTagCloud.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widgetTagCloud_WidgetEvent);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.widgetSignature);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(1, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1022, 489);
            this.tabPage2.Text = "Signature";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pictureBox1.Location = new System.Drawing.Point(692, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 157);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // widgetSignature
            // 
            this.widgetSignature.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.widgetSignature.InitScript = resources.GetString("widgetSignature.InitScript");
            this.widgetSignature.Location = new System.Drawing.Point(15, 37);
            this.widgetSignature.Name = "widgetSignature";
            this.widgetSignature.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            package5.Name = "ej.web.all.min.css";
            package5.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/flat-azure/ej.web.all.min.css";
            package6.Name = "jquery-1.10.2.min.js";
            package6.Source = "http://cdn.syncfusion.com/js/assets/external/jquery-1.10.2.min.js";
            package7.Name = "jquery.easing.1.3.min.js";
            package7.Source = "http://cdn.syncfusion.com/js/assets/external/jquery.easing.1.3.min.js";
            package8.Name = "ej.web.all.min.js";
            package8.Source = "http://cdn.syncfusion.com/15.1.0.41/js/web/ej.web.all.min.js";
            this.widgetSignature.Packages.Add(package5);
            this.widgetSignature.Packages.Add(package6);
            this.widgetSignature.Packages.Add(package7);
            this.widgetSignature.Packages.Add(package8);
            this.widgetSignature.Size = new System.Drawing.Size(671, 429);
            this.widgetSignature.TabIndex = 3;
            this.widgetSignature.Text = "widgetSignature";
            this.widgetSignature.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.widgetSignature_WidgetEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign Here:";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1814, 759);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchEngines)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TabControl tabControl1;
        private Wisej.Web.TabPage tabPage1;
        private Wisej.Web.DataGridView dataGridViewSearchEngines;
        private Wisej.Web.Widget widgetTagCloud;
        private Wisej.Web.TabPage tabPage2;
        private Wisej.Web.DataGridViewTextBoxColumn colText;
        private Wisej.Web.DataGridViewLinkColumn colURL;
        private Wisej.Web.DataGridViewTextBoxColumn colFrequency;
        private Wisej.Web.DataGridViewColumn colSlider;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.Widget widgetSignature;
        private Wisej.Web.Label label1;
    }
}

