namespace BackgroundTasks
{
	partial class SortBox
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.canvas = new Wisej.Web.Canvas();
			this.title = new Wisej.Web.Label();
			this.buttonSort = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// canvas
			// 
			this.canvas.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.canvas.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.canvas.Location = new System.Drawing.Point(10, 53);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(475, 300);
			this.canvas.TabIndex = 0;
			this.canvas.Redraw += new System.EventHandler(this.canvas_Redraw);
			// 
			// title
			// 
			this.title.AutoSize = false;
			this.title.Dock = Wisej.Web.DockStyle.Top;
			this.title.ForeColor = System.Drawing.Color.FromName("@windowText");
			this.title.Location = new System.Drawing.Point(10, 10);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(475, 37);
			this.title.TabIndex = 1;
			this.title.Text = "Title";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSort
			// 
			this.buttonSort.Dock = Wisej.Web.DockStyle.Bottom;
			this.buttonSort.Location = new System.Drawing.Point(10, 364);
			this.buttonSort.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(475, 46);
			this.buttonSort.TabIndex = 2;
			this.buttonSort.Text = "SORT";
			this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
			// 
			// SortBox
			// 
			this.Controls.Add(this.canvas);
			this.Controls.Add(this.buttonSort);
			this.Controls.Add(this.title);
			this.Name = "SortBox";
			this.Padding = new Wisej.Web.Padding(10);
			this.Size = new System.Drawing.Size(495, 420);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Canvas canvas;
		private Wisej.Web.Label title;
		private Wisej.Web.Button buttonSort;
	}
}
