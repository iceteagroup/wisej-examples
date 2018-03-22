namespace Wisej.Responsive.Views
{
	partial class DashboardView
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
			Wisej.Web.Ext.ChartJS.LineOptions lineOptions1 = new Wisej.Web.Ext.ChartJS.LineOptions();
			this.flowLayoutPanel = new Wisej.Web.FlowLayoutPanel();
			this.salesTargetGage = new Wisej.Web.Ext.JustGage.JustGage();
			this.returnsGage = new Wisej.Web.Ext.JustGage.JustGage();
			this.salesChart = new Wisej.Web.Ext.ChartJS.ChartJS();
			this.flowLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.Controls.Add(this.salesTargetGage);
			this.flowLayoutPanel.Controls.Add(this.returnsGage);
			this.flowLayoutPanel.Controls.Add(this.salesChart);
			this.flowLayoutPanel.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 33);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(740, 609);
			this.flowLayoutPanel.TabIndex = 2;
			// 
			// salesTargetGage
			// 
			this.flowLayoutPanel.SetFillWeight(this.salesTargetGage, 100);
			this.salesTargetGage.ForeColor = System.Drawing.Color.Green;
			this.salesTargetGage.Location = new System.Drawing.Point(30, 30);
			this.salesTargetGage.Margin = new Wisej.Web.Padding(30);
			this.salesTargetGage.MinimumSize = new System.Drawing.Size(200, 190);
			this.salesTargetGage.Name = "salesTargetGage";
			this.salesTargetGage.Size = new System.Drawing.Size(310, 196);
			this.salesTargetGage.Symbol = "%";
			this.salesTargetGage.TabIndex = 1;
			this.salesTargetGage.Text = "Sales Target";
			this.salesTargetGage.Value = 0F;
			// 
			// returnsGage
			// 
			this.flowLayoutPanel.SetFillWeight(this.returnsGage, 100);
			this.flowLayoutPanel.SetFlowBreak(this.returnsGage, true);
			this.returnsGage.ForeColor = System.Drawing.Color.DarkRed;
			this.returnsGage.Location = new System.Drawing.Point(400, 30);
			this.returnsGage.Margin = new Wisej.Web.Padding(30);
			this.returnsGage.MinimumSize = new System.Drawing.Size(200, 190);
			this.returnsGage.Name = "returnsGage";
			this.returnsGage.Size = new System.Drawing.Size(310, 196);
			this.returnsGage.Symbol = "%";
			this.returnsGage.TabIndex = 2;
			this.returnsGage.Text = "Returns";
			this.returnsGage.Value = 0F;
			// 
			// salesChart
			// 
			this.flowLayoutPanel.SetFillWeight(this.salesChart, 100);
			this.salesChart.Location = new System.Drawing.Point(30, 286);
			this.salesChart.Margin = new Wisej.Web.Padding(30);
			this.salesChart.Name = "salesChart";
			this.salesChart.Options = lineOptions1;
			this.salesChart.Size = new System.Drawing.Size(680, 329);
			this.salesChart.TabIndex = 0;
			this.salesChart.Text = "Sales";
			// 
			// DashboardView
			// 
			this.Controls.Add(this.flowLayoutPanel);
			this.Name = "DashboardView";
			this.Title = "Dashboard";
			this.Controls.SetChildIndex(this.flowLayoutPanel, 0);
			this.flowLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.FlowLayoutPanel flowLayoutPanel;
		private Web.Ext.ChartJS.ChartJS salesChart;
		private Web.Ext.JustGage.JustGage salesTargetGage;
		private Web.Ext.JustGage.JustGage returnsGage;
	}
}
