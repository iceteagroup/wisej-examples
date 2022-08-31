namespace TicTacToe
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
            this.lblComputerScore = new Wisej.Web.Label();
            this.lblPlayerScore = new Wisej.Web.Label();
            this.Field33 = new Wisej.Web.Button();
            this.Field23 = new Wisej.Web.Button();
            this.Field13 = new Wisej.Web.Button();
            this.Field32 = new Wisej.Web.Button();
            this.Field22 = new Wisej.Web.Button();
            this.Field12 = new Wisej.Web.Button();
            this.Field31 = new Wisej.Web.Button();
            this.Field21 = new Wisej.Web.Button();
            this.Field11 = new Wisej.Web.Button();
            this.lblTitle = new Wisej.Web.Label();
            this.Ticker = new Wisej.Web.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AllowHtml = true;
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblComputerScore.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblComputerScore.Location = new System.Drawing.Point(145, 312);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(93, 19);
            this.lblComputerScore.TabIndex = 14;
            this.lblComputerScore.Text = "Computer: 0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AllowHtml = true;
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlayerScore.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblPlayerScore.Location = new System.Drawing.Point(43, 312);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(68, 19);
            this.lblPlayerScore.TabIndex = 15;
            this.lblPlayerScore.Text = "Player: 0";
            // 
            // Field33
            // 
            this.Field33.BackColor = System.Drawing.Color.AliceBlue;
            this.Field33.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field33.Display = Wisej.Web.Display.Label;
            this.Field33.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field33.ForeColor = System.Drawing.Color.DarkBlue;
            this.Field33.Location = new System.Drawing.Point(203, 228);
            this.Field33.Name = "Field33";
            this.Field33.Size = new System.Drawing.Size(64, 64);
            this.Field33.TabIndex = 5;
            this.Field33.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field23
            // 
            this.Field23.BackColor = System.Drawing.Color.AliceBlue;
            this.Field23.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field23.Display = Wisej.Web.Display.Label;
            this.Field23.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field23.Location = new System.Drawing.Point(203, 148);
            this.Field23.Name = "Field23";
            this.Field23.Size = new System.Drawing.Size(64, 64);
            this.Field23.TabIndex = 6;
            this.Field23.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field13
            // 
            this.Field13.BackColor = System.Drawing.Color.AliceBlue;
            this.Field13.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field13.Display = Wisej.Web.Display.Label;
            this.Field13.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field13.Location = new System.Drawing.Point(203, 68);
            this.Field13.Name = "Field13";
            this.Field13.Size = new System.Drawing.Size(64, 64);
            this.Field13.TabIndex = 7;
            this.Field13.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field32
            // 
            this.Field32.BackColor = System.Drawing.Color.AliceBlue;
            this.Field32.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field32.Display = Wisej.Web.Display.Label;
            this.Field32.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field32.Location = new System.Drawing.Point(123, 228);
            this.Field32.Name = "Field32";
            this.Field32.Size = new System.Drawing.Size(64, 64);
            this.Field32.TabIndex = 8;
            this.Field32.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field22
            // 
            this.Field22.BackColor = System.Drawing.Color.AliceBlue;
            this.Field22.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field22.Display = Wisej.Web.Display.Label;
            this.Field22.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field22.Location = new System.Drawing.Point(123, 148);
            this.Field22.Name = "Field22";
            this.Field22.Size = new System.Drawing.Size(64, 64);
            this.Field22.TabIndex = 9;
            this.Field22.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field12
            // 
            this.Field12.BackColor = System.Drawing.Color.AliceBlue;
            this.Field12.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field12.Display = Wisej.Web.Display.Label;
            this.Field12.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field12.Location = new System.Drawing.Point(123, 68);
            this.Field12.Name = "Field12";
            this.Field12.Size = new System.Drawing.Size(64, 64);
            this.Field12.TabIndex = 10;
            this.Field12.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field31
            // 
            this.Field31.BackColor = System.Drawing.Color.AliceBlue;
            this.Field31.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field31.Display = Wisej.Web.Display.Label;
            this.Field31.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field31.Location = new System.Drawing.Point(43, 228);
            this.Field31.Name = "Field31";
            this.Field31.Size = new System.Drawing.Size(64, 64);
            this.Field31.TabIndex = 11;
            this.Field31.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field21
            // 
            this.Field21.BackColor = System.Drawing.Color.AliceBlue;
            this.Field21.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field21.Display = Wisej.Web.Display.Label;
            this.Field21.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field21.Location = new System.Drawing.Point(43, 148);
            this.Field21.Name = "Field21";
            this.Field21.Size = new System.Drawing.Size(64, 64);
            this.Field21.TabIndex = 12;
            this.Field21.Click += new System.EventHandler(this.Button_Click);
            // 
            // Field11
            // 
            this.Field11.BackColor = System.Drawing.Color.AliceBlue;
            this.Field11.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field11.Display = Wisej.Web.Display.Label;
            this.Field11.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field11.Location = new System.Drawing.Point(43, 68);
            this.Field11.Name = "Field11";
            this.Field11.Size = new System.Drawing.Size(64, 64);
            this.Field11.TabIndex = 13;
            this.Field11.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(21, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 19);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "\"TicTacToe\" - using Wisej.NET by ITG";
            // 
            // Ticker
            // 
            this.Ticker.Enabled = true;
            this.Ticker.Interval = 100;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.Field33);
            this.Controls.Add(this.Field23);
            this.Controls.Add(this.Field13);
            this.Controls.Add(this.Field32);
            this.Controls.Add(this.Field22);
            this.Controls.Add(this.Field12);
            this.Controls.Add(this.Field31);
            this.Controls.Add(this.Field21);
            this.Controls.Add(this.Field11);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1590, 933);
            this.Text = "Page1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label lblComputerScore;
		private Wisej.Web.Label lblPlayerScore;
		private Wisej.Web.Button Field33;
		private Wisej.Web.Button Field23;
		private Wisej.Web.Button Field13;
		private Wisej.Web.Button Field32;
		private Wisej.Web.Button Field22;
		private Wisej.Web.Button Field12;
		private Wisej.Web.Button Field31;
		private Wisej.Web.Button Field21;
		private Wisej.Web.Button Field11;
		private Wisej.Web.Label lblTitle;
		private Wisej.Web.Timer Ticker;
	}
}

