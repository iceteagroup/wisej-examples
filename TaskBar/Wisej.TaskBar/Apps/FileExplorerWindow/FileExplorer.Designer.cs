
namespace Wisej.TaskBar.Apps.FileExplorerWindow
{
    partial class FileExplorer
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
            this.txtbxCurrentPath = new Wisej.Web.TextBox();
            this.btnGo = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.btnParentFolder = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.list = new Wisej.Web.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxCurrentPath
            // 
            this.txtbxCurrentPath.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.txtbxCurrentPath.Location = new System.Drawing.Point(15, 14);
            this.txtbxCurrentPath.Name = "txtbxCurrentPath";
            this.txtbxCurrentPath.Size = new System.Drawing.Size(1076, 22);
            this.txtbxCurrentPath.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.btnGo.ImageSource = "icon-search";
            this.btnGo.Location = new System.Drawing.Point(992, 53);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 27);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnParentFolder);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.txtbxCurrentPath);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 100);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Each item has a MenuContext";
            // 
            // btnParentFolder
            // 
            this.btnParentFolder.ImageSource = "icon-sorted-ascending";
            this.btnParentFolder.Location = new System.Drawing.Point(15, 52);
            this.btnParentFolder.Name = "btnParentFolder";
            this.btnParentFolder.Size = new System.Drawing.Size(124, 27);
            this.btnParentFolder.TabIndex = 2;
            this.btnParentFolder.Text = "Parent folder";
            this.btnParentFolder.Click += new System.EventHandler(this.btnParentFolder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.list);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Image = global::Wisej.TaskBar.Properties.Resources.icons8_folder_96px;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 489);
            this.panel2.TabIndex = 3;
            this.panel2.TabStop = true;
            // 
            // list
            // 
            this.list.AllowColumnSorting = true;
            this.list.Dock = Wisej.Web.DockStyle.Fill;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1109, 489);
            this.list.TabIndex = 0;
            this.list.View = Wisej.Web.View.Tile;
            this.list.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.list_ItemDoubleClick);
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FileExplorer";
            this.Text = "File Explorer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.TextBox txtbxCurrentPath;
        private Web.Button btnGo;
        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.ListView list;
        private Web.Button btnParentFolder;
        private Web.Label label2;
    }
}