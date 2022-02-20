namespace Wisej.Mobile.Features.Panels
{
	partial class Toolbar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolbar));
			this.checkBoxVisible = new Wisej.Web.CheckBox();
			this.backColor = new Wisej.Web.TextBox();
			this.color = new Wisej.Web.TextBox();
			this.buttonUpdate = new Wisej.Web.Button();
			this.flowLayoutPanelItems = new Wisej.Web.FlowLayoutPanel();
			this.toolbarButton4 = new Wisej.Mobile.Features.Panels.ToolbarButton();
			this.toolbarButton1 = new Wisej.Mobile.Features.Panels.ToolbarButton();
			this.toolbarButton2 = new Wisej.Mobile.Features.Panels.ToolbarButton();
			this.toolbarButton3 = new Wisej.Mobile.Features.Panels.ToolbarButton();
			this.toolbarButton5 = new Wisej.Mobile.Features.Panels.ToolbarButton();
			this.toolbarButton6 = new Wisej.Mobile.Features.Panels.ToolbarButton();
			this.label1 = new Wisej.Web.Label();
			this.spacer1 = new Wisej.Web.Spacer();
			this.panel1 = new Wisej.Web.Panel();
			this.flowLayoutPanelItems.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxVisible
			// 
			this.checkBoxVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVisible.AutoSize = false;
			this.checkBoxVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxVisible.Dock = Wisej.Web.DockStyle.Top;
			this.checkBoxVisible.Location = new System.Drawing.Point(16, 128);
			this.checkBoxVisible.MinimumSize = new System.Drawing.Size(180, 0);
			this.checkBoxVisible.Name = "checkBoxVisible";
			this.checkBoxVisible.Size = new System.Drawing.Size(618, 40);
			this.checkBoxVisible.TabIndex = 2;
			this.checkBoxVisible.Text = "Toolbar Visible";
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// backColor
			// 
			this.backColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.backColor.AutoSize = false;
			this.backColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.backColor.Location = new System.Drawing.Point(536, 11);
			this.backColor.Name = "backColor";
			this.backColor.Size = new System.Drawing.Size(34, 34);
			this.backColor.TabIndex = 15;
			this.backColor.TextChanged += new System.EventHandler(this.backColor_TextChanged);
			// 
			// color
			// 
			this.color.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.color.AutoSize = false;
			this.color.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.color.Location = new System.Drawing.Point(576, 11);
			this.color.Name = "color";
			this.color.Size = new System.Drawing.Size(34, 34);
			this.color.TabIndex = 14;
			this.color.TextChanged += new System.EventHandler(this.color_TextChanged);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Dock = Wisej.Web.DockStyle.Top;
			this.buttonUpdate.Location = new System.Drawing.Point(16, 582);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(618, 40);
			this.buttonUpdate.TabIndex = 13;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// flowLayoutPanelItems
			// 
			this.flowLayoutPanelItems.Controls.Add(this.toolbarButton4);
			this.flowLayoutPanelItems.Controls.Add(this.toolbarButton1);
			this.flowLayoutPanelItems.Controls.Add(this.toolbarButton2);
			this.flowLayoutPanelItems.Controls.Add(this.toolbarButton3);
			this.flowLayoutPanelItems.Controls.Add(this.toolbarButton5);
			this.flowLayoutPanelItems.Controls.Add(this.toolbarButton6);
			this.flowLayoutPanelItems.Dock = Wisej.Web.DockStyle.Top;
			this.flowLayoutPanelItems.Location = new System.Drawing.Point(16, 224);
			this.flowLayoutPanelItems.Name = "flowLayoutPanelItems";
			this.flowLayoutPanelItems.Size = new System.Drawing.Size(618, 338);
			this.flowLayoutPanelItems.TabIndex = 12;
			this.flowLayoutPanelItems.Text = "Buttons";
			// 
			// toolbarButton4
			// 
			this.toolbarButton4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.toolbarButton4, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.toolbarButton4, true);
			this.toolbarButton4.Icon = ((System.Drawing.Image)(resources.GetObject("toolbarButton4.Icon")));
			this.toolbarButton4.Location = new System.Drawing.Point(3, 3);
			this.toolbarButton4.Name = "toolbarButton4";
			this.toolbarButton4.Show = true;
			this.toolbarButton4.Size = new System.Drawing.Size(612, 50);
			this.toolbarButton4.TabIndex = 8;
			// 
			// toolbarButton1
			// 
			this.toolbarButton1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.toolbarButton1, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.toolbarButton1, true);
			this.toolbarButton1.Icon = ((System.Drawing.Image)(resources.GetObject("toolbarButton1.Icon")));
			this.toolbarButton1.Location = new System.Drawing.Point(3, 59);
			this.toolbarButton1.Name = "toolbarButton1";
			this.toolbarButton1.Show = true;
			this.toolbarButton1.Size = new System.Drawing.Size(612, 50);
			this.toolbarButton1.TabIndex = 5;
			// 
			// toolbarButton2
			// 
			this.toolbarButton2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.toolbarButton2, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.toolbarButton2, true);
			this.toolbarButton2.Icon = ((System.Drawing.Image)(resources.GetObject("toolbarButton2.Icon")));
			this.toolbarButton2.Location = new System.Drawing.Point(3, 115);
			this.toolbarButton2.Name = "toolbarButton2";
			this.toolbarButton2.Show = true;
			this.toolbarButton2.Size = new System.Drawing.Size(612, 50);
			this.toolbarButton2.TabIndex = 6;
			// 
			// toolbarButton3
			// 
			this.toolbarButton3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.toolbarButton3, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.toolbarButton3, true);
			this.toolbarButton3.Location = new System.Drawing.Point(3, 171);
			this.toolbarButton3.Name = "toolbarButton3";
			this.toolbarButton3.Show = true;
			this.toolbarButton3.Size = new System.Drawing.Size(612, 50);
			this.toolbarButton3.TabIndex = 7;
			this.toolbarButton3.Type = Wisej.Web.Ext.MobileIntegration.DeviceToolbar.ButtonType.Search;
			// 
			// toolbarButton5
			// 
			this.toolbarButton5.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.toolbarButton5, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.toolbarButton5, true);
			this.toolbarButton5.Location = new System.Drawing.Point(3, 227);
			this.toolbarButton5.Name = "toolbarButton5";
			this.toolbarButton5.Show = true;
			this.toolbarButton5.Size = new System.Drawing.Size(612, 50);
			this.toolbarButton5.TabIndex = 9;
			this.toolbarButton5.Type = Wisej.Web.Ext.MobileIntegration.DeviceToolbar.ButtonType.FlexibleSpace;
			// 
			// toolbarButton6
			// 
			this.toolbarButton6.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.toolbarButton6, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.toolbarButton6, true);
			this.toolbarButton6.Location = new System.Drawing.Point(3, 283);
			this.toolbarButton6.Name = "toolbarButton6";
			this.toolbarButton6.Show = true;
			this.toolbarButton6.Size = new System.Drawing.Size(612, 50);
			this.toolbarButton6.TabIndex = 10;
			this.toolbarButton6.Type = Wisej.Web.Ext.MobileIntegration.DeviceToolbar.ButtonType.Save;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 33);
			this.label1.TabIndex = 11;
			this.label1.Text = "Colors";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 562);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.backColor);
			this.panel1.Controls.Add(this.color);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = Wisej.Web.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(16, 168);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 56);
			this.panel1.TabIndex = 20;
			// 
			// Toolbar
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.flowLayoutPanelItems);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.checkBoxVisible);
			this.Name = "Toolbar";
			this.Size = new System.Drawing.Size(650, 644);
			this.Load += new System.EventHandler(this.Toolbar_Load);
			this.Disposed += new System.EventHandler(this.Toolbar_Disposed);
			this.Controls.SetChildIndex(this.checkBoxVisible, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.flowLayoutPanelItems, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.flowLayoutPanelItems.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.CheckBox checkBoxVisible;
		private Web.TextBox backColor;
		private Web.TextBox color;
		private Web.Button buttonUpdate;
		private Web.FlowLayoutPanel flowLayoutPanelItems;
		private ToolbarButton toolbarButton1;
		private ToolbarButton toolbarButton2;
		private ToolbarButton toolbarButton3;
		private ToolbarButton toolbarButton4;
		private Web.Label label1;
		private ToolbarButton toolbarButton6;
		private ToolbarButton toolbarButton5;
		private Web.Spacer spacer1;
		private Web.Panel panel1;
	}
}
