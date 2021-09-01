
namespace Wisej.TaskBar.Apps.FileExplorerWindow
{
    partial class FileProperties
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
            this.lblType = new Wisej.Web.Label();
            this.lblPath = new Wisej.Web.Label();
            this.lblSize = new Wisej.Web.Label();
            this.lblCreationDate = new Wisej.Web.Label();
            this.btnOK = new Wisej.Web.Button();
            this.label4 = new Wisej.Web.Label();
            this.line2 = new Wisej.Web.Line();
            this.label3 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.line1 = new Wisej.Web.Line();
            this.txtbxPath = new Wisej.Web.TextBox();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.lblType2 = new Wisej.Web.Label();
            this.panel1 = new Wisej.Web.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(136, 117);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(8, 15);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "-";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(136, 142);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(8, 15);
            this.lblPath.TabIndex = 25;
            this.lblPath.Text = "-";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(136, 166);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(8, 15);
            this.lblSize.TabIndex = 24;
            this.lblSize.Text = "-";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(136, 240);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(8, 15);
            this.lblCreationDate.TabIndex = 23;
            this.lblCreationDate.Text = "-";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(304, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 27);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Creation date:";
            // 
            // line2
            // 
            this.line2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.line2.Location = new System.Drawing.Point(32, 224);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(372, 10);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type:";
            // 
            // line1
            // 
            this.line1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(32, 100);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(372, 10);
            // 
            // txtbxPath
            // 
            this.txtbxPath.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxPath.Location = new System.Drawing.Point(120, 49);
            this.txtbxPath.Name = "txtbxPath";
            this.txtbxPath.ReadOnly = true;
            this.txtbxPath.Size = new System.Drawing.Size(269, 22);
            this.txtbxPath.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wisej.TaskBar.Properties.Resources.icons8_file_96px;
            this.pictureBox1.Location = new System.Drawing.Point(29, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // lblType2
            // 
            this.lblType2.AutoSize = true;
            this.lblType2.Dock = Wisej.Web.DockStyle.Bottom;
            this.lblType2.Font = new System.Drawing.Font("default", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblType2.Location = new System.Drawing.Point(0, 6);
            this.lblType2.Name = "lblType2";
            this.lblType2.Size = new System.Drawing.Size(114, 20);
            this.lblType2.TabIndex = 35;
            this.lblType2.Text = "-";
            this.lblType2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblType2.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(2, 255, 255, 255);
            this.panel1.Controls.Add(this.lblType2);
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 26);
            this.panel1.TabIndex = 36;
            this.panel1.TabStop = true;
            // 
            // FileProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.txtbxPath);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FileProperties";
            this.Text = "File Properties";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Label lblType;
        private Web.Label lblPath;
        private Web.Label lblSize;
        private Web.Label lblCreationDate;
        private Web.Button btnOK;
        private Web.Label label4;
        private Web.Line line2;
        private Web.Label label3;
        private Web.Label label2;
        private Web.Label label1;
        private Web.Line line1;
        private Web.TextBox txtbxPath;
        private Web.PictureBox pictureBox1;
        private Web.Label lblType2;
        private Web.Panel panel1;
    }
}