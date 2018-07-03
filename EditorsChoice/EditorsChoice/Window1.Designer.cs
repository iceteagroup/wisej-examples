namespace EditorsChoice
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.Ext.CKEditor.ExternalPlugin externalPlugin3 = new Wisej.Web.Ext.CKEditor.ExternalPlugin();
            this.ckEditor1 = new Wisej.Web.Ext.CKEditor.CKEditor();
            this.timer1 = new Wisej.Web.Timer(this.components);
            this.ckEditor2 = new Wisej.Web.Ext.CKEditor.CKEditor();
            this.Tinyeditor1 = new Wisej.Web.Ext.TinyEditor.TinyEditor();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.label4 = new Wisej.Web.Label();
            this.tinyMCE1 = new Wisej.Web.Ext.TinyMCE.TinyMCE();
            this.cbLiveSync = new Wisej.Web.CheckBox();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckEditor1
            // 
            this.ckEditor1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            externalPlugin3.Name = "codesnippet";
            externalPlugin3.Url = "ckeditor/plugins/codesnippet";
            this.ckEditor1.ExternalPlugins = new Wisej.Web.Ext.CKEditor.ExternalPlugin[] {
        externalPlugin3};
            this.ckEditor1.Location = new System.Drawing.Point(16, 40);
            this.ckEditor1.Name = "ckEditor1";
            this.ckEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"codeSnippet_theme\":\"monokai_sublime\",\"extraPlugins\":\"codesnippet\"}")));
            this.ckEditor1.Size = new System.Drawing.Size(967, 372);
            this.ckEditor1.TabIndex = 0;
            this.ckEditor1.Text = "ckEditor1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ckEditor2
            // 
            this.ckEditor2.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.ckEditor2.Location = new System.Drawing.Point(3, 37);
            this.ckEditor2.Name = "ckEditor2";
            this.ckEditor2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"toolbar\":[[\"Bold\",\"Italic\",\"Image\",\"Smiley\",\"Styles\",\"Format\",\"Font\",\"FontSize\"" +
        "]],\"allowedContent\":true}")));
            this.ckEditor2.Size = new System.Drawing.Size(313, 448);
            this.ckEditor2.TabIndex = 3;
            this.ckEditor2.Text = "ckEditor2";
            // 
            // Tinyeditor1
            // 
            this.Tinyeditor1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.Tinyeditor1.FontNames = new string[] {
        "Verdana",
        "Arial",
        "Georgia",
        "Trebuchet MS",
        "Courier New"};
            this.Tinyeditor1.Location = new System.Drawing.Point(322, 37);
            this.Tinyeditor1.Name = "Tinyeditor1";
            this.Tinyeditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.Tinyeditor1.Size = new System.Drawing.Size(322, 448);
            this.Tinyeditor1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default, Helvetica", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "CKEditor 1 (master)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("default, Helvetica", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "CKEditor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("default, Helvetica", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(650, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "TinyEditor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("default, Helvetica", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(322, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "TinyMCE";
            // 
            // tinyMCE1
            // 
            this.tinyMCE1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tinyMCE1.Location = new System.Drawing.Point(650, 37);
            this.tinyMCE1.Name = "tinyMCE1";
            this.tinyMCE1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
            this.tinyMCE1.Size = new System.Drawing.Size(314, 448);
            this.tinyMCE1.TabIndex = 9;
            this.tinyMCE1.Text = "tinyMCE1";
            // 
            // cbLiveSync
            // 
            this.cbLiveSync.Location = new System.Drawing.Point(16, 432);
            this.cbLiveSync.Name = "cbLiveSync";
            this.cbLiveSync.Size = new System.Drawing.Size(77, 23);
            this.cbLiveSync.TabIndex = 10;
            this.cbLiveSync.Text = "live sync";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tinyMCE1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckEditor2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Tinyeditor1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 462);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 7.162534F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 92.83746F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 488);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1029, 966);
            this.ClientSize = new System.Drawing.Size(982, 882);
            this.CloseBox = false;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbLiveSync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckEditor1);
            this.KeepOnScreen = true;
            this.Movable = false;
            this.Name = "Window1";
            this.Text = "Editors choice";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Ext.CKEditor.CKEditor ckEditor1;
        private Wisej.Web.Timer timer1;
        private Wisej.Web.Ext.CKEditor.CKEditor ckEditor2;


        private Wisej.Web.Ext.TinyEditor.TinyEditor Tinyeditor1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label3;
        private Wisej.Web.Label label4;
        private Wisej.Web.Ext.TinyMCE.TinyMCE tinyMCE1;
        private Wisej.Web.CheckBox cbLiveSync;
        private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
    }
}

