﻿namespace DeepLinking
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			this.label1 = new Wisej.Web.Label();
			this.dataGrid = new Wisej.Web.DataGridView();
			this.buttonEdit = new Wisej.Web.Button();
			this.buttonAdd = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 35);
			this.label1.Margin = new Wisej.Web.Padding(9, 0, 9, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "User Data:";
			// 
			// dataGrid
			// 
			this.dataGrid.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			this.dataGrid.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGrid.LiveResize = true;
			this.dataGrid.Location = new System.Drawing.Point(27, 95);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ReadOnly = true;
			this.dataGrid.RowHeadersVisible = false;
			this.dataGrid.ShowColumnVisibilityMenu = false;
			this.dataGrid.Size = new System.Drawing.Size(613, 378);
			this.dataGrid.TabIndex = 1;
			this.dataGrid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonEdit.AppearanceKey = "button-ok";
			this.buttonEdit.Location = new System.Drawing.Point(487, 35);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(153, 40);
			this.buttonEdit.TabIndex = 2;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonAdd.AppearanceKey = "button";
			this.buttonAdd.Location = new System.Drawing.Point(316, 35);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(153, 40);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Add New";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 508);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.label1);
			this.CloseBox = false;
			this.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new Wisej.Web.Padding(9, 0, 9, 0);
			this.MinimizeBox = false;
			this.Name = "Window1";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Window1";
			this.Load += new System.EventHandler(this.Window1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label label1;
		private Wisej.Web.DataGridView dataGrid;
		private Wisej.Web.Button buttonEdit;
		private Wisej.Web.Button buttonAdd;
	}
}

