using Wisej.Web.Ext.RibbonBar;

namespace Wisej.RibbonBar
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
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			this.ribbonBar = new Wisej.Web.Ext.RibbonBar.RibbonBar();
			this.ribbonBarPage1 = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
			this.ribbonBarGroup1 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
			this.ribbonBarItemButton1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton2 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton3 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemSeparator1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemSeparator();
			this.ribbonBarItemButton4 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton5 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton6 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.menuItem1 = new Wisej.Web.MenuItem();
			this.menuItem2 = new Wisej.Web.MenuItem();
			this.ribbonBarGroup2 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
			this.ribbonBarItemSplitButton1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemSplitButton();
			this.menuItem3 = new Wisej.Web.MenuItem();
			this.menuItem4 = new Wisej.Web.MenuItem();
			this.ribbonBarItemButton7 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemCheckBox1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemCheckBox();
			this.ribbonBarItemCheckBox2 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemCheckBox();
			this.ribbonBarPage2 = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
			this.ribbonBarGroup3 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
			this.ribbonBarItemTextBox1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemTextBox();
			this.ribbonBarItemTextBox2 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemTextBox();
			this.ribbonBarItemComboBox1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemComboBox();
			this.ribbonBarGroup4 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
			this.ribbonBarItemControl1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemControl();
			this.themePicker1 = new Wisej.RibbonBar.ThemePicker();
			this.ribbonBarPage3 = new Wisej.Web.Ext.RibbonBar.RibbonBarPage();
			this.ribbonBarGroup5 = new Wisej.Web.Ext.RibbonBar.RibbonBarGroup();
			this.ribbonBarItemButtonGroup1 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButtonGroup();
			this.ribbonBarItemButton12 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton13 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton14 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton15 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton16 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButtonGroup2 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButtonGroup();
			this.ribbonBarItemButton17 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton18 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton19 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton20 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.ribbonBarItemButton21 = new Wisej.Web.Ext.RibbonBar.RibbonBarItemButton();
			this.SuspendLayout();
			// 
			// ribbonBar
			// 
			// 
			// 
			// 
			this.ribbonBar.AppButton.ImageSource = "icon-preview?color=#3FBEBF";
			this.ribbonBar.AppButton.Text = "FIle";
			this.ribbonBar.AppButton.Visible = true;
			this.ribbonBar.Dock = Wisej.Web.DockStyle.Top;
			this.ribbonBar.Location = new System.Drawing.Point(0, 0);
			this.ribbonBar.Name = "ribbonBar";
			this.ribbonBar.Pages.Add(this.ribbonBarPage1);
			this.ribbonBar.Pages.Add(this.ribbonBarPage2);
			this.ribbonBar.Pages.Add(this.ribbonBarPage3);
			this.ribbonBar.Size = new System.Drawing.Size(896, 145);
			componentTool1.ImageSource = "messagebox-question?color=#3600FF";
			componentTool1.Name = "Help";
			componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool2.ImageSource = "icon-settings?color=#FF1700";
			componentTool2.Name = "Settings";
			this.ribbonBar.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2});
			this.ribbonBar.AppButtonClick += new System.EventHandler(this.ribbonBar_AppButtonClick);
			this.ribbonBar.ItemClick += new Wisej.Web.Ext.RibbonBar.RibbonBarItemEventHandler(this.ribbonBar_ItemClick);
			this.ribbonBar.GroupClick += new Wisej.Web.Ext.RibbonBar.RibbonBarGroupEventHandler(this.ribbonBar_GroupClick);
			this.ribbonBar.ToolClick += new Wisej.Web.ToolClickEventHandler(this.ribbonBar_ToolClick);
			// 
			// ribbonBarPage1
			// 
			this.ribbonBarPage1.Groups.Add(this.ribbonBarGroup1);
			this.ribbonBarPage1.Groups.Add(this.ribbonBarGroup2);
			this.ribbonBarPage1.Text = "Home";
			// 
			// ribbonBarGroup1
			// 
			this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton1);
			this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton2);
			this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton3);
			this.ribbonBarGroup1.Items.Add(this.ribbonBarItemSeparator1);
			this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton4);
			this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton5);
			this.ribbonBarGroup1.Items.Add(this.ribbonBarItemButton6);
			this.ribbonBarGroup1.Text = "Clipboard";
			// 
			// ribbonBarItemButton1
			// 
			this.ribbonBarItemButton1.ColumnBreak = true;
			this.ribbonBarItemButton1.ImageSource = "ribbon-pin";
			this.ribbonBarItemButton1.Text = "Pin to quick panel";
			this.ribbonBarItemButton1.ToolTipText = "Adds the item to the quick access panel.";
			// 
			// ribbonBarItemButton2
			// 
			this.ribbonBarItemButton2.ColumnBreak = true;
			this.ribbonBarItemButton2.ImageSource = "ribbon-copy";
			this.ribbonBarItemButton2.Text = "Copy";
			// 
			// ribbonBarItemButton3
			// 
			this.ribbonBarItemButton3.ColumnBreak = true;
			this.ribbonBarItemButton3.ImageSource = "ribbon-paste";
			this.ribbonBarItemButton3.Text = "Paste";
			// 
			// ribbonBarItemButton4
			// 
			this.ribbonBarItemButton4.ImageSource = "ribbon-cut";
			this.ribbonBarItemButton4.Orientation = Wisej.Web.Orientation.Horizontal;
			this.ribbonBarItemButton4.Text = "Cut";
			// 
			// ribbonBarItemButton5
			// 
			this.ribbonBarItemButton5.ImageSource = "ribbon-copy";
			this.ribbonBarItemButton5.Orientation = Wisej.Web.Orientation.Horizontal;
			this.ribbonBarItemButton5.Text = "Copy special...";
			// 
			// ribbonBarItemButton6
			// 
			this.ribbonBarItemButton6.ImageSource = "ribbon-paste";
			this.ribbonBarItemButton6.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
			this.ribbonBarItemButton6.Orientation = Wisej.Web.Orientation.Horizontal;
			this.ribbonBarItemButton6.Text = "Paste special";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Name = "menuItem1";
			this.menuItem1.Text = "Only text";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Name = "menuItem2";
			this.menuItem2.Text = "Preserve formatting";
			// 
			// ribbonBarGroup2
			// 
			this.ribbonBarGroup2.Items.Add(this.ribbonBarItemSplitButton1);
			this.ribbonBarGroup2.Items.Add(this.ribbonBarItemButton7);
			this.ribbonBarGroup2.Items.Add(this.ribbonBarItemCheckBox1);
			this.ribbonBarGroup2.Items.Add(this.ribbonBarItemCheckBox2);
			this.ribbonBarGroup2.ShowButton = true;
			this.ribbonBarGroup2.Text = "New";
			// 
			// ribbonBarItemSplitButton1
			// 
			this.ribbonBarItemSplitButton1.ColumnBreak = true;
			this.ribbonBarItemSplitButton1.ImageSource = "ribbon-add-file";
			this.ribbonBarItemSplitButton1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem3,
            this.menuItem4});
			this.ribbonBarItemSplitButton1.Text = "File";
			// 
			// menuItem3
			// 
			this.menuItem3.IconSource = "resource.wx/Wisej.Ext.FontAwesome/archive.svg?color=#FF8F00";
			this.menuItem3.Index = 0;
			this.menuItem3.Name = "menuItem3";
			this.menuItem3.Text = "Archive";
			// 
			// menuItem4
			// 
			this.menuItem4.IconSource = "resource.wx/Wisej.Ext.FontAwesome/bar-chart.svg?color=#00FF00";
			this.menuItem4.Index = 1;
			this.menuItem4.Name = "menuItem4";
			this.menuItem4.Text = "Chart";
			// 
			// ribbonBarItemButton7
			// 
			this.ribbonBarItemButton7.ColumnBreak = true;
			this.ribbonBarItemButton7.ImageSource = "ribbon-add-folder";
			this.ribbonBarItemButton7.Text = "Folder";
			// 
			// ribbonBarItemCheckBox1
			// 
			this.ribbonBarItemCheckBox1.Text = "Overwrite";
			// 
			// ribbonBarItemCheckBox2
			// 
			this.ribbonBarItemCheckBox2.Text = "Save to cloud";
			// 
			// ribbonBarPage2
			// 
			this.ribbonBarPage2.Groups.Add(this.ribbonBarGroup3);
			this.ribbonBarPage2.Groups.Add(this.ribbonBarGroup4);
			this.ribbonBarPage2.Text = "&Options";
			// 
			// ribbonBarGroup3
			// 
			this.ribbonBarGroup3.Items.Add(this.ribbonBarItemTextBox1);
			this.ribbonBarGroup3.Items.Add(this.ribbonBarItemTextBox2);
			this.ribbonBarGroup3.Items.Add(this.ribbonBarItemComboBox1);
			this.ribbonBarGroup3.Text = "Settings";
			// 
			// ribbonBarItemTextBox1
			// 
			this.ribbonBarItemTextBox1.ImageSource = "icon-settings?color=#3FBF47";
			this.ribbonBarItemTextBox1.Text = "Profile Name";
			// 
			// ribbonBarItemTextBox2
			// 
			this.ribbonBarItemTextBox2.ImageSource = "icon-settings?color=#3FBF47";
			this.ribbonBarItemTextBox2.Text = "Unique ID";
			// 
			// ribbonBarItemComboBox1
			// 
			this.ribbonBarItemComboBox1.ImageSource = "menu-overflow?color=#DF00FF";
			this.ribbonBarItemComboBox1.Text = "User Level";
			// 
			// ribbonBarGroup4
			// 
			this.ribbonBarGroup4.Items.Add(this.ribbonBarItemControl1);
			this.ribbonBarGroup4.Text = "Themes";
			// 
			// ribbonBarItemControl1
			// 
			this.ribbonBarItemControl1.ColumnBreak = true;
			this.ribbonBarItemControl1.Control = this.themePicker1;
			this.ribbonBarItemControl1.Text = "ribbonBarItemControl1";
			// 
			// themePicker1
			// 
			this.themePicker1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.themePicker1.Location = new System.Drawing.Point(14, 163);
			this.themePicker1.Name = "themePicker1";
			this.themePicker1.Size = new System.Drawing.Size(340, 70);
			this.themePicker1.TabIndex = 1;
			this.themePicker1.ThemeClicked += new System.EventHandler(this.themePicker1_ThemeClicked);
			// 
			// ribbonBarPage3
			// 
			this.ribbonBarPage3.Groups.Add(this.ribbonBarGroup5);
			this.ribbonBarPage3.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(191)))), ((int)(((byte)(63)))));
			this.ribbonBarPage3.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
			this.ribbonBarPage3.Text = "Edit";
			// 
			// ribbonBarGroup5
			// 
			this.ribbonBarGroup5.Items.Add(this.ribbonBarItemButtonGroup1);
			this.ribbonBarGroup5.Items.Add(this.ribbonBarItemButtonGroup2);
			this.ribbonBarGroup5.Text = "Formatting";
			// 
			// ribbonBarItemButtonGroup1
			// 
			this.ribbonBarItemButtonGroup1.Buttons.Add(this.ribbonBarItemButton12);
			this.ribbonBarItemButtonGroup1.Buttons.Add(this.ribbonBarItemButton13);
			this.ribbonBarItemButtonGroup1.Buttons.Add(this.ribbonBarItemButton14);
			this.ribbonBarItemButtonGroup1.Buttons.Add(this.ribbonBarItemButton15);
			this.ribbonBarItemButtonGroup1.Buttons.Add(this.ribbonBarItemButton16);
			// 
			// ribbonBarItemButton12
			// 
			this.ribbonBarItemButton12.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/align-center.svg";
			this.ribbonBarItemButton12.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton13
			// 
			this.ribbonBarItemButton13.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/align-justify.svg";
			this.ribbonBarItemButton13.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton14
			// 
			this.ribbonBarItemButton14.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/anchor.svg";
			this.ribbonBarItemButton14.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton15
			// 
			this.ribbonBarItemButton15.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrows-alt.svg";
			this.ribbonBarItemButton15.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton16
			// 
			this.ribbonBarItemButton16.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/code.svg";
			this.ribbonBarItemButton16.Orientation = Wisej.Web.Orientation.Horizontal;
			this.ribbonBarItemButton16.Text = "Source";
			// 
			// ribbonBarItemButtonGroup2
			// 
			this.ribbonBarItemButtonGroup2.Buttons.Add(this.ribbonBarItemButton17);
			this.ribbonBarItemButtonGroup2.Buttons.Add(this.ribbonBarItemButton18);
			this.ribbonBarItemButtonGroup2.Buttons.Add(this.ribbonBarItemButton19);
			this.ribbonBarItemButtonGroup2.Buttons.Add(this.ribbonBarItemButton20);
			this.ribbonBarItemButtonGroup2.Buttons.Add(this.ribbonBarItemButton21);
			// 
			// ribbonBarItemButton17
			// 
			this.ribbonBarItemButton17.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-down.svg";
			this.ribbonBarItemButton17.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton18
			// 
			this.ribbonBarItemButton18.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-left.svg";
			this.ribbonBarItemButton18.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton19
			// 
			this.ribbonBarItemButton19.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-right.svg";
			this.ribbonBarItemButton19.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton20
			// 
			this.ribbonBarItemButton20.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-o-up.svg";
			this.ribbonBarItemButton20.Orientation = Wisej.Web.Orientation.Horizontal;
			// 
			// ribbonBarItemButton21
			// 
			this.ribbonBarItemButton21.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/android.svg?color=#FF7700";
			this.ribbonBarItemButton21.Orientation = Wisej.Web.Orientation.Horizontal;
			this.ribbonBarItemButton21.Text = "Wizard";
			// 
			// Window1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 467);
			this.Controls.Add(this.ribbonBar);
			this.Name = "Window1";
			this.Text = "Window1";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.RibbonBar.RibbonBar ribbonBar;
		private RibbonBarPage ribbonBarPage1;
		private RibbonBarPage ribbonBarPage2;
		private RibbonBarGroup ribbonBarGroup1;
		private RibbonBarGroup ribbonBarGroup2;
		private RibbonBarGroup ribbonBarGroup3;
		private RibbonBarGroup ribbonBarGroup4;
		private RibbonBarItemButton ribbonBarItemButton1;
		private RibbonBarItemButton ribbonBarItemButton2;
		private RibbonBarItemButton ribbonBarItemButton3;
		private RibbonBarItemSeparator ribbonBarItemSeparator1;
		private RibbonBarItemButton ribbonBarItemButton4;
		private RibbonBarItemButton ribbonBarItemButton5;
		private RibbonBarItemButton ribbonBarItemButton6;
		private Web.MenuItem menuItem1;
		private Web.MenuItem menuItem2;
		private RibbonBarItemSplitButton ribbonBarItemSplitButton1;
		private Web.MenuItem menuItem3;
		private Web.MenuItem menuItem4;
		private RibbonBarItemButton ribbonBarItemButton7;
		private RibbonBarItemCheckBox ribbonBarItemCheckBox1;
		private RibbonBarItemCheckBox ribbonBarItemCheckBox2;
		private RibbonBarItemTextBox ribbonBarItemTextBox1;
		private RibbonBarItemTextBox ribbonBarItemTextBox2;
		private RibbonBarItemComboBox ribbonBarItemComboBox1;
		private RibbonBarItemControl ribbonBarItemControl1;
		private ThemePicker themePicker1;
		private RibbonBarPage ribbonBarPage3;
		private RibbonBarGroup ribbonBarGroup5;
		private RibbonBarItemButtonGroup ribbonBarItemButtonGroup1;
		private RibbonBarItemButton ribbonBarItemButton12;
		private RibbonBarItemButton ribbonBarItemButton13;
		private RibbonBarItemButton ribbonBarItemButton14;
		private RibbonBarItemButton ribbonBarItemButton15;
		private RibbonBarItemButton ribbonBarItemButton16;
		private RibbonBarItemButtonGroup ribbonBarItemButtonGroup2;
		private RibbonBarItemButton ribbonBarItemButton17;
		private RibbonBarItemButton ribbonBarItemButton18;
		private RibbonBarItemButton ribbonBarItemButton19;
		private RibbonBarItemButton ribbonBarItemButton20;
		private RibbonBarItemButton ribbonBarItemButton21;
	}
}

