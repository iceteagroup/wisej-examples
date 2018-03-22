namespace Wisej.FullCalendar
{
    partial class MainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			this.splitContainer1 = new Wisej.Web.SplitContainer();
			this.monthCalendar1 = new Wisej.Web.MonthCalendar();
			this.fullCalendar1 = new Wisej.Web.Ext.FullCalendar.FullCalendar();
			this.toolBar1 = new Wisej.Web.ToolBar();
			this.tbNew = new Wisej.Web.ToolBarButton();
			this.tbBasicSep = new Wisej.Web.ToolBarButton();
			this.tbBasicTitle = new Wisej.Web.ToolBarButton();
			this.tbBasicDay = new Wisej.Web.ToolBarButton();
			this.tbBasicWeek = new Wisej.Web.ToolBarButton();
			this.tbBasicMonth = new Wisej.Web.ToolBarButton();
			this.tbAgendaSep = new Wisej.Web.ToolBarButton();
			this.tbAgendaTitle = new Wisej.Web.ToolBarButton();
			this.tbAgendaDay = new Wisej.Web.ToolBarButton();
			this.tbAgendaWeek = new Wisej.Web.ToolBarButton();
			this.tbListSep = new Wisej.Web.ToolBarButton();
			this.tbListTitle = new Wisej.Web.ToolBarButton();
			this.tbListDay = new Wisej.Web.ToolBarButton();
			this.tbListWeek = new Wisej.Web.ToolBarButton();
			this.tbListMonth = new Wisej.Web.ToolBarButton();
			this.tbListYear = new Wisej.Web.ToolBarButton();
			this.imageList1 = new Wisej.Web.ImageList(this.components);
			this.styleSheet1 = new Wisej.Web.StyleSheet(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = Wisej.Web.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 79);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.fullCalendar1);
			this.splitContainer1.Panel2.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
			this.splitContainer1.Panel2.ShowCloseButton = false;
			this.splitContainer1.Panel2.ShowHeader = true;
			this.splitContainer1.Panel2.Text = "Scheduler";
			this.splitContainer1.Size = new System.Drawing.Size(1294, 698);
			this.splitContainer1.SplitterDistance = 326;
			this.splitContainer1.TabIndex = 3;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
			this.monthCalendar1.Dock = Wisej.Web.DockStyle.Fill;
			this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
			this.monthCalendar1.MaxSelectionCount = 1;
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.Size = new System.Drawing.Size(324, 696);
			this.monthCalendar1.TabIndex = 1;
			this.monthCalendar1.DateSelected += new Wisej.Web.DateRangeEventHandler(this.monthCalendar1_DateSelected);
			// 
			// fullCalendar1
			// 
			this.fullCalendar1.Dock = Wisej.Web.DockStyle.Fill;
			this.fullCalendar1.Location = new System.Drawing.Point(0, 0);
			this.fullCalendar1.Name = "fullCalendar1";
			this.fullCalendar1.Size = new System.Drawing.Size(960, 668);
			this.fullCalendar1.SlotLabelInterval = System.TimeSpan.Parse("01:00:00");
			this.fullCalendar1.TabIndex = 0;
			this.fullCalendar1.Text = "fullCalendar1";
			this.fullCalendar1.View = Wisej.Web.Ext.FullCalendar.ViewType.AgendaWeek;
			this.fullCalendar1.EventDoubleClick += new Wisej.Web.Ext.FullCalendar.EventClickEventHandler(this.fullCalendar1_EventDoubleClick);
			// 
			// toolBar1
			// 
			this.toolBar1.BackColor = System.Drawing.Color.White;
			this.toolBar1.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
			this.toolBar1.BackgroundImageSource = "Images/toolbar-background.jpg";
			this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.tbNew,
            this.tbBasicSep,
            this.tbBasicTitle,
            this.tbBasicDay,
            this.tbBasicWeek,
            this.tbBasicMonth,
            this.tbAgendaSep,
            this.tbAgendaTitle,
            this.tbAgendaDay,
            this.tbAgendaWeek,
            this.tbListSep,
            this.tbListTitle,
            this.tbListDay,
            this.tbListWeek,
            this.tbListMonth,
            this.tbListYear});
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(1294, 79);
			this.toolBar1.TabIndex = 2;
			this.toolBar1.TabStop = false;
			this.toolBar1.ButtonClick += new Wisej.Web.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tbNew
			// 
			this.tbNew.ImageSource = "resource.wx/Wisej.Ext.ModernUI/plus.svg";
			this.tbNew.Name = "tbNew";
			this.tbNew.Text = "New";
			// 
			// tbBasicSep
			// 
			this.tbBasicSep.Name = "tbBasicSep";
			this.tbBasicSep.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			this.tbBasicSep.Text = "toolBarButton1";
			// 
			// tbBasicTitle
			// 
			this.tbBasicTitle.AllowHtml = true;
			this.tbBasicTitle.Enabled = false;
			this.tbBasicTitle.Name = "tbBasicTitle";
			this.tbBasicTitle.Text = "Basic<br/>View";
			// 
			// tbBasicDay
			// 
			this.tbBasicDay.ImageSource = "resource.wx/Wisej.Ext.ModernUI/day.svg";
			this.tbBasicDay.Name = "tbBasicDay";
			this.tbBasicDay.Tag = "2";
			this.tbBasicDay.Text = "Day";
			// 
			// tbBasicWeek
			// 
			this.tbBasicWeek.ImageSource = "resource.wx/Wisej.Ext.ModernUI/week.svg";
			this.tbBasicWeek.Name = "tbBasicWeek";
			this.tbBasicWeek.Tag = "1";
			this.tbBasicWeek.Text = "Week";
			// 
			// tbBasicMonth
			// 
			this.tbBasicMonth.ImageSource = "resource.wx/Wisej.Ext.ModernUI/month.svg";
			this.tbBasicMonth.Name = "tbBasicMonth";
			this.tbBasicMonth.Tag = "0";
			this.tbBasicMonth.Text = "Month";
			// 
			// tbAgendaSep
			// 
			this.tbAgendaSep.Name = "tbAgendaSep";
			this.tbAgendaSep.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			this.tbAgendaSep.Text = "toolBarButton1";
			// 
			// tbAgendaTitle
			// 
			this.tbAgendaTitle.AllowHtml = true;
			this.tbAgendaTitle.Enabled = false;
			this.tbAgendaTitle.Name = "tbAgendaTitle";
			this.tbAgendaTitle.Text = "Agenda<br/>View";
			// 
			// tbAgendaDay
			// 
			this.tbAgendaDay.ImageSource = "resource.wx/Wisej.Ext.ModernUI/day.svg";
			this.tbAgendaDay.Name = "tbAgendaDay";
			this.tbAgendaDay.Tag = "4";
			this.tbAgendaDay.Text = "Day";
			// 
			// tbAgendaWeek
			// 
			this.tbAgendaWeek.ImageSource = "resource.wx/Wisej.Ext.ModernUI/week.svg";
			this.tbAgendaWeek.Name = "tbAgendaWeek";
			this.tbAgendaWeek.Pushed = true;
			this.tbAgendaWeek.Tag = "3";
			this.tbAgendaWeek.Text = "Week";
			// 
			// tbListSep
			// 
			this.tbListSep.Name = "tbListSep";
			this.tbListSep.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			this.tbListSep.Text = "toolBarButton4";
			// 
			// tbListTitle
			// 
			this.tbListTitle.AllowHtml = true;
			this.tbListTitle.Enabled = false;
			this.tbListTitle.Name = "tbListTitle";
			this.tbListTitle.Text = "List<br/>View";
			this.tbListTitle.Visible = false;
			// 
			// tbListDay
			// 
			this.tbListDay.ImageSource = "resource.wx/Wisej.Ext.ModernUI/day.svg";
			this.tbListDay.Name = "tbListDay";
			this.tbListDay.Tag = "8";
			this.tbListDay.Text = "Day";
			this.tbListDay.Visible = false;
			// 
			// tbListWeek
			// 
			this.tbListWeek.ImageSource = "resource.wx/Wisej.Ext.ModernUI/week.svg";
			this.tbListWeek.Name = "tbListWeek";
			this.tbListWeek.Tag = "7";
			this.tbListWeek.Text = "Week";
			this.tbListWeek.Visible = false;
			// 
			// tbListMonth
			// 
			this.tbListMonth.ImageSource = "resource.wx/Wisej.Ext.ModernUI/month.svg";
			this.tbListMonth.Name = "tbListMonth";
			this.tbListMonth.Tag = "6";
			this.tbListMonth.Text = "Month";
			this.tbListMonth.Visible = false;
			// 
			// tbListYear
			// 
			this.tbListYear.ImageSource = "resource.wx/Wisej.Ext.ModernUI/year.svg";
			this.tbListYear.Name = "tbListYear";
			this.tbListYear.Tag = "5";
			this.tbListYear.Text = "Year";
			this.tbListYear.Visible = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
			// 
			// styleSheet1
			// 
			this.styleSheet1.Styles = resources.GetString("styleSheet1.Styles");
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolBar1);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(1294, 777);
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.Ext.FullCalendar.FullCalendar fullCalendar1;
        private Web.MonthCalendar monthCalendar1;
        private Web.ToolBar toolBar1;
        private Web.ToolBarButton tbNew;
        private Web.ToolBarButton tbBasicDay;
        private Web.ToolBarButton tbBasicWeek;
        private Web.ImageList imageList1;
        private Web.ToolBarButton tbBasicMonth;
        private Web.ToolBarButton tbBasicSep;
        private Web.ToolBarButton tbAgendaSep;
        private Web.SplitContainer splitContainer1;
        private Web.ToolBarButton tbBasicTitle;
        private Web.ToolBarButton tbAgendaTitle;
        private Web.ToolBarButton tbAgendaDay;
        private Web.ToolBarButton tbAgendaWeek;
        private Web.ToolBarButton tbListSep;
        private Web.ToolBarButton tbListTitle;
        private Web.ToolBarButton tbListDay;
        private Web.ToolBarButton tbListWeek;
        private Web.ToolBarButton tbListMonth;
        private Web.ToolBarButton tbListYear;
		private Web.StyleSheet styleSheet1;
	}
}
