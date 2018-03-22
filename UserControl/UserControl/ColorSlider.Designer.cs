namespace UserControl
{
	partial class ColorSlider
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
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.trackBarR = new Wisej.Web.TrackBar();
			this.trackBarG = new Wisej.Web.TrackBar();
			this.trackBarB = new Wisej.Web.TrackBar();
			this.trackBarAll = new Wisej.Web.TrackBar();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarAll)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.trackBarAll, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.trackBarB, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.trackBarG, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.trackBarR, 0, 0);
			this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 275);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// trackBarR
			// 
			this.trackBarR.AutoSize = false;
			this.trackBarR.BackColor = System.Drawing.Color.Red;
			this.trackBarR.Dock = Wisej.Web.DockStyle.Fill;
			this.trackBarR.Location = new System.Drawing.Point(3, 3);
			this.trackBarR.Maximum = 255;
			this.trackBarR.Name = "trackBarR";
			this.trackBarR.Orientation = Wisej.Web.Orientation.Vertical;
			this.trackBarR.Size = new System.Drawing.Size(81, 269);
			this.trackBarR.TabIndex = 0;
			this.trackBarR.TickStyle = Wisej.Web.TickStyle.None;
			this.trackBarR.Value = 100;
			this.trackBarR.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
			// 
			// trackBarG
			// 
			this.trackBarG.AutoSize = false;
			this.trackBarG.BackColor = System.Drawing.Color.Green;
			this.trackBarG.Dock = Wisej.Web.DockStyle.Fill;
			this.trackBarG.Location = new System.Drawing.Point(90, 3);
			this.trackBarG.Maximum = 255;
			this.trackBarG.Name = "trackBarG";
			this.trackBarG.Orientation = Wisej.Web.Orientation.Vertical;
			this.trackBarG.Size = new System.Drawing.Size(81, 269);
			this.trackBarG.TabIndex = 2;
			this.trackBarG.TickStyle = Wisej.Web.TickStyle.None;
			this.trackBarG.Value = 100;
			this.trackBarG.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
			// 
			// trackBarB
			// 
			this.trackBarB.AutoSize = false;
			this.trackBarB.BackColor = System.Drawing.Color.Blue;
			this.trackBarB.Dock = Wisej.Web.DockStyle.Fill;
			this.trackBarB.Location = new System.Drawing.Point(177, 3);
			this.trackBarB.Maximum = 255;
			this.trackBarB.Name = "trackBarB";
			this.trackBarB.Orientation = Wisej.Web.Orientation.Vertical;
			this.trackBarB.Size = new System.Drawing.Size(81, 269);
			this.trackBarB.TabIndex = 4;
			this.trackBarB.TickStyle = Wisej.Web.TickStyle.None;
			this.trackBarB.Value = 100;
			this.trackBarB.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
			// 
			// trackBarAll
			// 
			this.trackBarAll.AutoSize = false;
			this.trackBarAll.Dock = Wisej.Web.DockStyle.Fill;
			this.trackBarAll.Location = new System.Drawing.Point(264, 3);
			this.trackBarAll.Maximum = 255;
			this.trackBarAll.Name = "trackBarAll";
			this.trackBarAll.Orientation = Wisej.Web.Orientation.Vertical;
			this.trackBarAll.Size = new System.Drawing.Size(83, 269);
			this.trackBarAll.TabIndex = 6;
			this.trackBarAll.TickStyle = Wisej.Web.TickStyle.None;
			this.trackBarAll.Value = 100;
			this.trackBarAll.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
			// 
			// ColorSlider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ColorSlider";
			this.Size = new System.Drawing.Size(350, 275);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarAll)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TableLayoutPanel tableLayoutPanel1;
		private Wisej.Web.TrackBar trackBarAll;
		private Wisej.Web.TrackBar trackBarB;
		private Wisej.Web.TrackBar trackBarG;
		private Wisej.Web.TrackBar trackBarR;
	}
}
