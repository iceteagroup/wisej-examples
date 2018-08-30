namespace SmoothieChartSample
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
            this.smoothieChart1 = new Wisej.Web.Ext.SmoothieChart.SmoothieChart();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.smoothieChart3 = new Wisej.Web.Ext.SmoothieChart.SmoothieChart();
            this.smoothieChart2 = new Wisej.Web.Ext.SmoothieChart.SmoothieChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smoothieChart1
            // 
            this.smoothieChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.smoothieChart1.Location = new System.Drawing.Point(3, 3);
            this.smoothieChart1.MaxValue = 100;
            this.smoothieChart1.MinValue = 0;
            this.smoothieChart1.Name = "smoothieChart1";
            this.smoothieChart1.Size = new System.Drawing.Size(911, 188);
            this.smoothieChart1.DataNeeded += new Wisej.Web.Ext.SmoothieChart.DataNeededEventHandler(this.smoothieChart1_DataNeeded);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.smoothieChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.smoothieChart3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.smoothieChart2, 0, 2);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 779);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // smoothieChart3
            // 
            this.smoothieChart3.DataFrequency = 2000;
            this.smoothieChart3.Dock = Wisej.Web.DockStyle.Fill;
            this.smoothieChart3.FontSize = 20;
            this.smoothieChart3.Interpolation = Wisej.Web.Ext.SmoothieChart.InterpolationType.Linear;
            this.smoothieChart3.Location = new System.Drawing.Point(3, 197);
            this.smoothieChart3.MaxValue = 100;
            this.smoothieChart3.MinValue = 0;
            this.smoothieChart3.Name = "smoothieChart3";
            this.smoothieChart3.ShowTimeStamps = false;
            this.smoothieChart3.Size = new System.Drawing.Size(911, 188);
            this.smoothieChart3.VerticalSections = 1;
            this.smoothieChart3.DataNeeded += new Wisej.Web.Ext.SmoothieChart.DataNeededEventHandler(this.smoothieChart3_DataNeeded);
            // 
            // smoothieChart2
            // 
            this.smoothieChart2.Dock = Wisej.Web.DockStyle.Fill;
            this.smoothieChart2.FontSize = 13;
            this.smoothieChart2.Interpolation = Wisej.Web.Ext.SmoothieChart.InterpolationType.Linear;
            this.smoothieChart2.Location = new System.Drawing.Point(3, 391);
            this.smoothieChart2.MaxValue = 1000;
            this.smoothieChart2.MinValue = 0;
            this.smoothieChart2.Name = "smoothieChart2";
            this.smoothieChart2.Size = new System.Drawing.Size(911, 385);
            this.smoothieChart2.VerticalSections = 10;
            this.smoothieChart2.DataNeeded += new Wisej.Web.Ext.SmoothieChart.DataNeededEventHandler(this.smoothieChart2_DataNeeded);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(917, 779);
            this.Text = "SmoothieChart Sample";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Ext.SmoothieChart.SmoothieChart smoothieChart1;
		private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
		private Wisej.Web.Ext.SmoothieChart.SmoothieChart smoothieChart2;
		private Wisej.Web.Ext.SmoothieChart.SmoothieChart smoothieChart3;
	}
}

