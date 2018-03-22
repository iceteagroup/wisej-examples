namespace Wisej.CodeProject.Examples
{
	partial class BackgroundTasks
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
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.progressBar1 = new Wisej.Web.ProgressBar();
			this.progressCircle1 = new Wisej.Web.Ext.ProgressCircle.ProgressCircle();
			this.label1 = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg";
			this.button1.Location = new System.Drawing.Point(25, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(164, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/stop-button.svg";
			this.button2.Location = new System.Drawing.Point(25, 96);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(164, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "Stop";
			this.button2.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(0)))));
			this.progressBar1.Location = new System.Drawing.Point(234, 30);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(349, 49);
			this.progressBar1.TabIndex = 2;
			this.progressBar1.Text = "0%";
			// 
			// progressCircle1
			// 
			this.progressCircle1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.progressCircle1.Font = new System.Drawing.Font("default", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.progressCircle1.ForeColor = System.Drawing.Color.Coral;
			this.progressCircle1.LineWidth = 20;
			this.progressCircle1.Location = new System.Drawing.Point(234, 241);
			this.progressCircle1.Name = "progressCircle1";
			this.progressCircle1.Size = new System.Drawing.Size(349, 233);
			this.progressCircle1.TabIndex = 3;
			this.progressCircle1.Value = 20;
			// 
			// label1
			// 
			this.label1.AllowHtml = true;
			this.label1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.label1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.label1.Location = new System.Drawing.Point(234, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 123);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// BackgroundTasks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 502);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressCircle1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/settings-cogwheel-button.svg?color=#FFD700";
			this.Name = "BackgroundTasks";
			this.Text = "Background Tasks Example";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button button1;
		private Web.Button button2;
		private Web.ProgressBar progressBar1;
		private Web.Ext.ProgressCircle.ProgressCircle progressCircle1;
		private Web.Label label1;
	}
}