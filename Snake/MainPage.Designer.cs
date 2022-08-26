namespace Snake
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
            this.GameCanvas = new Wisej.Web.PictureBox();
            this.btnReset = new Wisej.Web.Button();
            this.Ticker = new Wisej.Web.Timer(this.components);
            this.lblScore = new Wisej.Web.Label();
            this.Progress = new Wisej.Web.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "\"Snake\" - using Wisej.NET by ITG";
            // 
            // GameCanvas
            // 
            this.GameCanvas.BackColor = System.Drawing.Color.AliceBlue;
            this.GameCanvas.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.GameCanvas.Location = new System.Drawing.Point(16, 67);
            this.GameCanvas.Name = "GameCanvas";
            this.GameCanvas.Size = new System.Drawing.Size(600, 400);
            this.GameCanvas.Paint += new Wisej.Web.PaintEventHandler(this.DrawGame);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReset.Location = new System.Drawing.Point(516, 483);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 32);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.KeyDown += new Wisej.Web.KeyEventHandler(this.btnReset_KeyDown);
            // 
            // Ticker
            // 
            this.Ticker.Interval = 500;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblScore.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblScore.Location = new System.Drawing.Point(490, 16);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(123, 22);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.Color.FromName("@window");
            this.Progress.BarColor = System.Drawing.Color.DeepPink;
            this.Progress.Location = new System.Drawing.Point(16, 51);
            this.Progress.MaximumSize = new System.Drawing.Size(0, 5);
            this.Progress.MinimumSize = new System.Drawing.Size(0, 5);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(600, 5);
            this.Progress.Step = 1;
            this.Progress.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.GameCanvas);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1590, 878);
            this.Text = "Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.GameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Wisej.Web.Label lblTitle;
        private Wisej.Web.PictureBox GameCanvas;
        private Wisej.Web.Button btnReset;
        private Wisej.Web.Timer Ticker;
        private Wisej.Web.Label lblScore;
        private Wisej.Web.ProgressBar Progress;
    }
}

