
namespace Wisej.TaskBar.Apps.FileExplorerWindow
{
    partial class FolderProperties
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
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.txtbxPath = new Wisej.Web.TextBox();
            this.line1 = new Wisej.Web.Line();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.line2 = new Wisej.Web.Line();
            this.label4 = new Wisej.Web.Label();
            this.btnOK = new Wisej.Web.Button();
            this.lblCreationDate = new Wisej.Web.Label();
            this.lblSize = new Wisej.Web.Label();
            this.lblPath = new Wisej.Web.Label();
            this.label8 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wisej.TaskBar.Properties.Resources.icons8_folder_96px;
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // txtbxPath
            // 
            this.txtbxPath.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxPath.Location = new System.Drawing.Point(104, 39);
            this.txtbxPath.Name = "txtbxPath";
            this.txtbxPath.ReadOnly = true;
            this.txtbxPath.Size = new System.Drawing.Size(269, 22);
            this.txtbxPath.TabIndex = 1;
            // 
            // line1
            // 
            this.line1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(16, 90);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(372, 10);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size:";
            // 
            // line2
            // 
            this.line2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.line2.Location = new System.Drawing.Point(16, 173);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(372, 10);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Creation date:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(288, 250);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 27);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(120, 189);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(8, 15);
            this.lblCreationDate.TabIndex = 10;
            this.lblCreationDate.Text = "-";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(120, 149);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(8, 15);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "-";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(120, 128);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(8, 15);
            this.lblPath.TabIndex = 12;
            this.lblPath.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Folder";
            // 
            // FolderProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 297);
            this.Controls.Add(this.label8);
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
            this.Name = "FolderProperties";
            this.Text = "Properties of:";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.PictureBox pictureBox1;
        private Web.TextBox txtbxPath;
        private Web.Line line1;
        private Web.Label label1;
        private Web.Label label2;
        private Web.Label label3;
        private Web.Line line2;
        private Web.Label label4;
        private Web.Button btnOK;
        private Web.Label lblCreationDate;
        private Web.Label lblSize;
        private Web.Label lblPath;
        private Web.Label label8;
    }
}