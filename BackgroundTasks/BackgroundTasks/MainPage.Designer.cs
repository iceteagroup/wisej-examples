namespace BackgroundTasks
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flowLayoutPanel = new Wisej.Web.FlowLayoutPanel();
			this.label1 = new Wisej.Web.Label();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.label3 = new Wisej.Web.Label();
			this.panel1 = new Wisej.Web.Panel();
			this.notification = new Wisej.Web.Ext.Notification.Notification(this.components);
			this.sortBox1 = new BackgroundTasks.SortBox();
			this.sortBox3 = new BackgroundTasks.SortBox();
			this.sortBox2 = new BackgroundTasks.SortBox();
			this.flowLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoSize = true;
			this.flowLayoutPanel.Controls.Add(this.sortBox1);
			this.flowLayoutPanel.Controls.Add(this.sortBox3);
			this.flowLayoutPanel.Controls.Add(this.sortBox2);
			this.flowLayoutPanel.Dock = Wisej.Web.DockStyle.Top;
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 177);
			this.flowLayoutPanel.Margin = new Wisej.Web.Padding(7, 0, 7, 0);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(923, 744);
			this.flowLayoutPanel.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = false;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("default", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label1.Image = global::BackgroundTasks.Properties.Resources._64x64;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new Wisej.Web.Padding(7, 0, 7, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new Wisej.Web.Padding(20);
			this.label1.Size = new System.Drawing.Size(923, 88);
			this.label1.TabIndex = 8;
			this.label1.Text = "Parallel Sorting";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(266, 29);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(7, 0, 7, 0);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(119, 28);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label3.Location = new System.Drawing.Point(14, 12);
			this.label3.Margin = new Wisej.Web.Padding(7, 0, 7, 0);
			this.label3.Name = "label3";
			this.label3.Padding = new Wisej.Web.Padding(20);
			this.label3.Size = new System.Drawing.Size(238, 64);
			this.label3.TabIndex = 11;
			this.label3.Text = "Delay between swaps (ms)";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Dock = Wisej.Web.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 88);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(923, 89);
			this.panel1.TabIndex = 12;
			// 
			// sortBox1
			// 
			this.sortBox1.BackColor = System.Drawing.Color.FromName("@window");
			this.sortBox1.Delay = 10;
			this.sortBox1.ForeColor = System.Drawing.Color.Crimson;
			this.sortBox1.Location = new System.Drawing.Point(14, 11);
			this.sortBox1.Margin = new Wisej.Web.Padding(14, 11, 14, 11);
			this.sortBox1.Name = "sortBox1";
			this.sortBox1.Padding = new Wisej.Web.Padding(14, 11, 14, 11);
			this.sortBox1.Size = new System.Drawing.Size(413, 351);
			this.sortBox1.SortMode = BackgroundTasks.SortMode.BubbleSort;
			this.sortBox1.TabIndex = 5;
			this.sortBox1.Title = "Bubble Sort";
			this.sortBox1.SortCompleted += new System.EventHandler(this.sortBox_SortCompleted);
			// 
			// sortBox3
			// 
			this.sortBox3.BackColor = System.Drawing.Color.FromName("@window");
			this.sortBox3.Delay = 10;
			this.sortBox3.ForeColor = System.Drawing.Color.DarkSeaGreen;
			this.sortBox3.Location = new System.Drawing.Point(455, 11);
			this.sortBox3.Margin = new Wisej.Web.Padding(14, 11, 14, 11);
			this.sortBox3.Name = "sortBox3";
			this.sortBox3.Padding = new Wisej.Web.Padding(14, 11, 14, 11);
			this.sortBox3.Size = new System.Drawing.Size(413, 351);
			this.sortBox3.SortMode = BackgroundTasks.SortMode.SelectionSort;
			this.sortBox3.TabIndex = 5;
			this.sortBox3.Title = "Selection Sort";
			this.sortBox3.SortCompleted += new System.EventHandler(this.sortBox_SortCompleted);
			// 
			// sortBox2
			// 
			this.sortBox2.BackColor = System.Drawing.Color.FromName("@window");
			this.sortBox2.Delay = 10;
			this.sortBox2.ForeColor = System.Drawing.Color.SteelBlue;
			this.sortBox2.Location = new System.Drawing.Point(14, 384);
			this.sortBox2.Margin = new Wisej.Web.Padding(14, 11, 14, 11);
			this.sortBox2.Name = "sortBox2";
			this.sortBox2.Padding = new Wisej.Web.Padding(14, 11, 14, 11);
			this.sortBox2.Size = new System.Drawing.Size(413, 351);
			this.sortBox2.SortMode = BackgroundTasks.SortMode.QuickSort;
			this.sortBox2.TabIndex = 4;
			this.sortBox2.Title = "Quick Sort";
			this.sortBox2.SortCompleted += new System.EventHandler(this.sortBox_SortCompleted);
			// 
			// MainPage
			// 
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.None;
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.Margin = new Wisej.Web.Padding(7, 0, 7, 0);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(923, 578);
			this.flowLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SortBox sortBox1;
		private SortBox sortBox2;
		private SortBox sortBox3;
		private Wisej.Web.FlowLayoutPanel flowLayoutPanel;
		private Wisej.Web.Label label1;
		private Wisej.Web.NumericUpDown numericUpDown1;
		private Wisej.Web.Label label3;
		private Wisej.Web.Panel panel1;
		private Wisej.Web.Ext.Notification.Notification notification;

	}
}