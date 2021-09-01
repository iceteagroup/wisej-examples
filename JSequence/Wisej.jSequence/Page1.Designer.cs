
namespace Wisej.Sequence
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
            this.txtSequence = new Wisej.Web.TextBox();
            this.btnTransform = new Wisej.Web.Button();
            this.cmbBorderStyle = new Wisej.Web.ComboBox();
            this.cmbTheme = new Wisej.Web.ComboBox();
            this.btnDownload = new Wisej.Web.Button();
            this.sequence = new Wisej.Web.Ext.jSequence.Sequence();
            this.btnPreview = new Wisej.Web.Button();
            this.lblWisejExtLink = new Wisej.Web.Label();
            this.lbljSequenceLink = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // txtSequence
            // 
            this.txtSequence.AcceptsReturn = true;
            this.txtSequence.LabelText = "Sequence text";
            this.txtSequence.Location = new System.Drawing.Point(33, 15);
            this.txtSequence.Multiline = true;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(470, 404);
            this.txtSequence.TabIndex = 1;
            this.txtSequence.Text = "Andrew->China: Says Hello \r\nNote right of China: China thinks\\nabout it\r\nChina-->" +
    "Andrew: How are you?\r\nAndrew->>China: I am good thanks!";
            this.txtSequence.Watermark = "Write something here";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(33, 425);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(187, 82);
            this.btnTransform.TabIndex = 2;
            this.btnTransform.Text = "Transform";
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.Items.AddRange(new object[] {
            "None",
            "Solid",
            "Dotted",
            "Dashed",
            "Double"});
            this.cmbBorderStyle.LabelText = "Border Style";
            this.cmbBorderStyle.Location = new System.Drawing.Point(852, 43);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(198, 42);
            this.cmbBorderStyle.TabIndex = 3;
            this.cmbBorderStyle.Watermark = "Select border style";
            this.cmbBorderStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBorderStyle_SelectedIndexChanged);
            // 
            // cmbTheme
            // 
            this.cmbTheme.Items.AddRange(new object[] {
            "Simple",
            "Hand"});
            this.cmbTheme.LabelText = "Theme";
            this.cmbTheme.Location = new System.Drawing.Point(616, 43);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(198, 42);
            this.cmbTheme.TabIndex = 4;
            this.cmbTheme.Watermark = "Select theme";
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(253, 425);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(250, 82);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // sequence
            // 
            this.sequence.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.sequence.Location = new System.Drawing.Point(616, 90);
            this.sequence.Name = "sequence";
            this.sequence.Size = new System.Drawing.Size(1168, 590);
            this.sequence.TabIndex = 0;
            this.sequence.Text = "sequence1";
            this.sequence.UML = "Andrew->China: Says Hello \r\nNote right of China: China thinks\\nabout it\r\nChina-->" +
    "Andrew: How are you?\r\nAndrew->>China: I am good thanks!";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(33, 526);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(470, 71);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview in Picture Box";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblWisejExtLink
            // 
            this.lblWisejExtLink.AllowHtml = true;
            this.lblWisejExtLink.AutoSize = true;
            this.lblWisejExtLink.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWisejExtLink.Location = new System.Drawing.Point(31, 692);
            this.lblWisejExtLink.Name = "lblWisejExtLink";
            this.lblWisejExtLink.Size = new System.Drawing.Size(1003, 19);
            this.lblWisejExtLink.TabIndex = 8;
            this.lblWisejExtLink.Text = "<a href=\"https://github.com/iceteagroup/wisej-extensions/tree/2.2/Wisej.Web.Ext.j" +
    "Sequence\" target=\"_blank\">Wisej jSequence Extention</a>";
            // 
            // lbljSequenceLink
            // 
            this.lbljSequenceLink.AllowHtml = true;
            this.lbljSequenceLink.AutoSize = true;
            this.lbljSequenceLink.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbljSequenceLink.Location = new System.Drawing.Point(33, 737);
            this.lbljSequenceLink.Name = "lbljSequenceLink";
            this.lbljSequenceLink.Size = new System.Drawing.Size(1028, 19);
            this.lbljSequenceLink.TabIndex = 8;
            this.lbljSequenceLink.Text = "<a href=\" https://bramp.github.io/js-sequence-diagrams/\" target=\"_blank\">For more" +
    " help, visit  https://bramp.github.io/js-sequence-diagrams/</a>";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.lbljSequenceLink);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.cmbBorderStyle);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.sequence);
            this.Controls.Add(this.lblWisejExtLink);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1814, 793);
            this.Text = "Wisej JSequence Sample";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Ext.jSequence.Sequence sequence;
        private Web.TextBox txtSequence;
        private Web.Button btnTransform;
        private Web.ComboBox cmbBorderStyle;
        private Web.ComboBox cmbTheme;
        private Web.Button btnDownload;
        private Web.Button btnPreview;
        private Web.Label lblWisejExtLink;
        private Web.Label lbljSequenceLink;
    }
}

