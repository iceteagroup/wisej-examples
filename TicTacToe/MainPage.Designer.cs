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
            this.lblTitle = new Wisej.Web.Label();
            this.Field11 = new Wisej.Web.Button();
            this.Field12 = new Wisej.Web.Button();
            this.Field13 = new Wisej.Web.Button();
            this.Field21 = new Wisej.Web.Button();
            this.Field22 = new Wisej.Web.Button();
            this.Field23 = new Wisej.Web.Button();
            this.Field31 = new Wisej.Web.Button();
            this.Field32 = new Wisej.Web.Button();
            this.Field33 = new Wisej.Web.Button();
            this.lblPlayerScore = new Wisej.Web.Label();
            this.lblComputerScore = new Wisej.Web.Label();
            this.Ticker = new Wisej.Web.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(40, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "\"TicTacToe\" - using Wisej.NET by ITG";
            // 
            // Field11
            // 
            this.Field11.BackColor = System.Drawing.Color.AliceBlue;
            this.Field11.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field11.Display = Wisej.Web.Display.Label;
            this.Field11.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field11.Location = new System.Drawing.Point(62, 67);
            this.Field11.Name = "Field11";
            this.Field11.Size = new System.Drawing.Size(64, 64);
            this.Field11.TabIndex = 2;
            this.Field11.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field12
            // 
            this.Field12.BackColor = System.Drawing.Color.AliceBlue;
            this.Field12.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field12.Display = Wisej.Web.Display.Label;
            this.Field12.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field12.Location = new System.Drawing.Point(142, 67);
            this.Field12.Name = "Field12";
            this.Field12.Size = new System.Drawing.Size(64, 64);
            this.Field12.TabIndex = 2;
            this.Field12.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field13
            // 
            this.Field13.BackColor = System.Drawing.Color.AliceBlue;
            this.Field13.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field13.Display = Wisej.Web.Display.Label;
            this.Field13.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field13.Location = new System.Drawing.Point(222, 67);
            this.Field13.Name = "Field13";
            this.Field13.Size = new System.Drawing.Size(64, 64);
            this.Field13.TabIndex = 2;
            this.Field13.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field21
            // 
            this.Field21.BackColor = System.Drawing.Color.AliceBlue;
            this.Field21.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field21.Display = Wisej.Web.Display.Label;
            this.Field21.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field21.Location = new System.Drawing.Point(62, 147);
            this.Field21.Name = "Field21";
            this.Field21.Size = new System.Drawing.Size(64, 64);
            this.Field21.TabIndex = 2;
            this.Field21.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field22
            // 
            this.Field22.BackColor = System.Drawing.Color.AliceBlue;
            this.Field22.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field22.Display = Wisej.Web.Display.Label;
            this.Field22.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field22.Location = new System.Drawing.Point(142, 147);
            this.Field22.Name = "Field22";
            this.Field22.Size = new System.Drawing.Size(64, 64);
            this.Field22.TabIndex = 2;
            this.Field22.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field23
            // 
            this.Field23.BackColor = System.Drawing.Color.AliceBlue;
            this.Field23.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field23.Display = Wisej.Web.Display.Label;
            this.Field23.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field23.Location = new System.Drawing.Point(222, 147);
            this.Field23.Name = "Field23";
            this.Field23.Size = new System.Drawing.Size(64, 64);
            this.Field23.TabIndex = 2;
            this.Field23.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field31
            // 
            this.Field31.BackColor = System.Drawing.Color.AliceBlue;
            this.Field31.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field31.Display = Wisej.Web.Display.Label;
            this.Field31.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field31.Location = new System.Drawing.Point(62, 227);
            this.Field31.Name = "Field31";
            this.Field31.Size = new System.Drawing.Size(64, 64);
            this.Field31.TabIndex = 2;
            this.Field31.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field32
            // 
            this.Field32.BackColor = System.Drawing.Color.AliceBlue;
            this.Field32.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field32.Display = Wisej.Web.Display.Label;
            this.Field32.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field32.Location = new System.Drawing.Point(142, 227);
            this.Field32.Name = "Field32";
            this.Field32.Size = new System.Drawing.Size(64, 64);
            this.Field32.TabIndex = 2;
            this.Field32.Click += new System.EventHandler(this.Field_Click);
            // 
            // Field33
            // 
            this.Field33.BackColor = System.Drawing.Color.AliceBlue;
            this.Field33.BorderStyle = Wisej.Web.BorderStyle.None;
            this.Field33.Display = Wisej.Web.Display.Label;
            this.Field33.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Field33.ForeColor = System.Drawing.Color.DarkBlue;
            this.Field33.Location = new System.Drawing.Point(222, 227);
            this.Field33.Name = "Field33";
            this.Field33.Size = new System.Drawing.Size(64, 64);
            this.Field33.TabIndex = 2;
            this.Field33.Click += new System.EventHandler(this.Field_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AllowHtml = true;
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlayerScore.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblPlayerScore.Location = new System.Drawing.Point(62, 311);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(69, 22);
            this.lblPlayerScore.TabIndex = 3;
            this.lblPlayerScore.Text = "Player: 0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AllowHtml = true;
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblComputerScore.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblComputerScore.Location = new System.Drawing.Point(164, 311);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(98, 22);
            this.lblComputerScore.TabIndex = 3;
            this.lblComputerScore.Text = "Computer: 0";
            // 
            // Ticker
            // 
            this.Ticker.Enabled = true;
            this.Ticker.Interval = 100;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
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
            this.Size = new System.Drawing.Size(1590, 878);
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label lblTitle;
        private Wisej.Web.Button Field11;
        private Wisej.Web.Button Field12;
        private Wisej.Web.Button Field13;
        private Wisej.Web.Button Field21;
        private Wisej.Web.Button Field22;
        private Wisej.Web.Button Field23;
        private Wisej.Web.Button Field31;
        private Wisej.Web.Button Field32;
        private Wisej.Web.Button Field33;
        private Wisej.Web.Label lblPlayerScore;
        private Wisej.Web.Label lblComputerScore;
        private Wisej.Web.Timer Ticker;
    }
}

