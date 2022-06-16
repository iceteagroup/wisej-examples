namespace Wisej.Mobile.Features
{
	partial class MainView
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
			this.imageList1 = new Wisej.Web.ImageList(this.components);
			this.animation1 = new Wisej.Web.Animation(this.components);
			this.animation2 = new Wisej.Web.Animation(this.components);
			this.panelContainer = new Wisej.Web.Panel();
			this.panel5 = new Wisej.Web.Panel();
			this.buttonBack = new Wisej.Web.Button();
			this.buttonPortal = new Wisej.Web.Button();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
			// 
			// panelContainer
			// 
			this.panelContainer.CssStyle = "transition: left 150ms, width 150ms";
			this.panelContainer.Dock = Wisej.Web.DockStyle.Fill;
			this.panelContainer.Location = new System.Drawing.Point(0, 30);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new System.Drawing.Size(1603, 745);
			this.panelContainer.TabIndex = 4;
			this.panelContainer.TabStop = true;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.buttonBack);
			this.panel5.Controls.Add(this.buttonPortal);
			this.panel5.Dock = Wisej.Web.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1603, 30);
			this.panel5.TabIndex = 0;
			this.panel5.TabStop = true;
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.Transparent;
			this.buttonBack.BorderStyle = Wisej.Web.BorderStyle.None;
			this.buttonBack.Dock = Wisej.Web.DockStyle.Left;
			this.buttonBack.Focusable = false;
			this.buttonBack.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/go-back-left-arrow.svg";
			this.buttonBack.Location = new System.Drawing.Point(151, 0);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(151, 30);
			this.buttonBack.TabIndex = 6;
			this.buttonBack.Text = "Return to Apps";
			this.buttonBack.Visible = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonPortal
			// 
			this.buttonPortal.BackColor = System.Drawing.Color.Transparent;
			this.buttonPortal.BorderStyle = Wisej.Web.BorderStyle.None;
			this.buttonPortal.Dock = Wisej.Web.DockStyle.Left;
			this.buttonPortal.Focusable = false;
			this.buttonPortal.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/go-back-left-arrow.svg";
			this.buttonPortal.Location = new System.Drawing.Point(0, 0);
			this.buttonPortal.Name = "buttonPortal";
			this.buttonPortal.Size = new System.Drawing.Size(151, 30);
			this.buttonPortal.TabIndex = 5;
			this.buttonPortal.Text = "Return to Portal";
			this.buttonPortal.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panelContainer);
			this.Controls.Add(this.panel5);
			this.Name = "MainView";
			this.Size = new System.Drawing.Size(1603, 775);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.Animation animation1;
		private Web.Animation animation2;
		private Web.Panel panelContainer;
		private Web.ImageList imageList1;
		private Web.Panel panel5;
		private Web.Button buttonPortal;
		private Web.Button buttonBack;
	}
}

