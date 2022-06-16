namespace Wisej.Mobile.Features.Panels
{
	partial class TabBar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabBar));
			this.checkBoxVisible = new Wisej.Web.CheckBox();
			this.selectedColor = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.tabBarButton1 = new Wisej.Mobile.Features.Panels.TabBarButton();
			this.flowLayoutPanelItems = new Wisej.Web.FlowLayoutPanel();
			this.tabBarButton2 = new Wisej.Mobile.Features.Panels.TabBarButton();
			this.tabBarButton3 = new Wisej.Mobile.Features.Panels.TabBarButton();
			this.tabBarButton4 = new Wisej.Mobile.Features.Panels.TabBarButton();
			this.buttonUpdate = new Wisej.Web.Button();
			this.color = new Wisej.Web.TextBox();
			this.backColor = new Wisej.Web.TextBox();
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
			this.checkBoxVisible.TabIndex = 1;
			this.checkBoxVisible.Text = "TabBar Visible";
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// selectedColor
			// 
			this.selectedColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.selectedColor.AutoSize = false;
			this.selectedColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.selectedColor.Location = new System.Drawing.Point(576, 9);
			this.selectedColor.Name = "selectedColor";
			this.selectedColor.Size = new System.Drawing.Size(34, 34);
			this.selectedColor.TabIndex = 3;
			this.selectedColor.TextChanged += new System.EventHandler(this.selectedColor_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Colors";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabBarButton1
			// 
			this.tabBarButton1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.tabBarButton1, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.tabBarButton1, true);
			this.tabBarButton1.Icon = ((System.Drawing.Image)(resources.GetObject("tabBarButton1.Icon")));
			this.tabBarButton1.Label = "Home";
			this.tabBarButton1.Location = new System.Drawing.Point(3, 3);
			this.tabBarButton1.Name = "tabBarButton1";
			this.tabBarButton1.Show = true;
			this.tabBarButton1.Size = new System.Drawing.Size(612, 50);
			this.tabBarButton1.TabIndex = 5;
			// 
			// flowLayoutPanelItems
			// 
			this.flowLayoutPanelItems.Controls.Add(this.tabBarButton1);
			this.flowLayoutPanelItems.Controls.Add(this.tabBarButton2);
			this.flowLayoutPanelItems.Controls.Add(this.tabBarButton3);
			this.flowLayoutPanelItems.Controls.Add(this.tabBarButton4);
			this.flowLayoutPanelItems.Dock = Wisej.Web.DockStyle.Top;
			this.flowLayoutPanelItems.Location = new System.Drawing.Point(16, 220);
			this.flowLayoutPanelItems.Name = "flowLayoutPanelItems";
			this.flowLayoutPanelItems.Size = new System.Drawing.Size(618, 240);
			this.flowLayoutPanelItems.TabIndex = 6;
			this.flowLayoutPanelItems.Text = "Buttons";
			// 
			// tabBarButton2
			// 
			this.tabBarButton2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.tabBarButton2, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.tabBarButton2, true);
			this.tabBarButton2.Icon = ((System.Drawing.Image)(resources.GetObject("tabBarButton2.Icon")));
			this.tabBarButton2.Label = "Options";
			this.tabBarButton2.Location = new System.Drawing.Point(3, 59);
			this.tabBarButton2.Name = "tabBarButton2";
			this.tabBarButton2.Show = true;
			this.tabBarButton2.Size = new System.Drawing.Size(612, 50);
			this.tabBarButton2.TabIndex = 6;
			// 
			// tabBarButton3
			// 
			this.tabBarButton3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.tabBarButton3, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.tabBarButton3, true);
			this.tabBarButton3.Icon = ((System.Drawing.Image)(resources.GetObject("tabBarButton3.Icon")));
			this.tabBarButton3.Label = "Settings";
			this.tabBarButton3.Location = new System.Drawing.Point(3, 115);
			this.tabBarButton3.Name = "tabBarButton3";
			this.tabBarButton3.Show = true;
			this.tabBarButton3.Size = new System.Drawing.Size(612, 50);
			this.tabBarButton3.TabIndex = 7;
			// 
			// tabBarButton4
			// 
			this.tabBarButton4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.tabBarButton4, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.tabBarButton4, true);
			this.tabBarButton4.Icon = ((System.Drawing.Image)(resources.GetObject("tabBarButton4.Icon")));
			this.tabBarButton4.Label = "More";
			this.tabBarButton4.Location = new System.Drawing.Point(3, 171);
			this.tabBarButton4.Name = "tabBarButton4";
			this.tabBarButton4.Show = true;
			this.tabBarButton4.Size = new System.Drawing.Size(612, 50);
			this.tabBarButton4.TabIndex = 8;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Dock = Wisej.Web.DockStyle.Top;
			this.buttonUpdate.Location = new System.Drawing.Point(16, 480);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(618, 40);
			this.buttonUpdate.TabIndex = 7;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// color
			// 
			this.color.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.color.AutoSize = false;
			this.color.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.color.Location = new System.Drawing.Point(536, 9);
			this.color.Name = "color";
			this.color.Size = new System.Drawing.Size(34, 34);
			this.color.TabIndex = 8;
			this.color.TextChanged += new System.EventHandler(this.color_TextChanged);
			// 
			// backColor
			// 
			this.backColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.backColor.AutoSize = false;
			this.backColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.backColor.Location = new System.Drawing.Point(496, 9);
			this.backColor.Name = "backColor";
			this.backColor.Size = new System.Drawing.Size(34, 34);
			this.backColor.TabIndex = 9;
			this.backColor.TextChanged += new System.EventHandler(this.backColor_TextChanged);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 460);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.backColor);
			this.panel1.Controls.Add(this.color);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.selectedColor);
			this.panel1.Dock = Wisej.Web.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(16, 168);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 52);
			this.panel1.TabIndex = 20;
			// 
			// TabBar
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
			this.Name = "TabBar";
			this.Size = new System.Drawing.Size(650, 532);
			this.Load += new System.EventHandler(this.TabBar_Load);
			this.Disposed += new System.EventHandler(this.TabBar_Disposed);
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
		private Web.TextBox selectedColor;
		private Web.Label label1;
		private TabBarButton tabBarButton1;
		private Web.FlowLayoutPanel flowLayoutPanelItems;
		private TabBarButton tabBarButton4;
		private TabBarButton tabBarButton3;
		private TabBarButton tabBarButton2;
		private Web.Button buttonUpdate;
		private Web.TextBox color;
		private Web.TextBox backColor;
		private Web.Spacer spacer1;
		private Web.Panel panel1;
	}
}
