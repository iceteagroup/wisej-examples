namespace ChangedNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.textBox1 = new Wisej.Web.TextBox();
            this.title = new Wisej.Web.Label();
            this.url = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(870, 564);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.title.Location = new System.Drawing.Point(30, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(190, 30);
            this.title.TabIndex = 1;
            this.title.Text = "ChangedNames";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(539, 30);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(361, 16);
            this.url.TabIndex = 2;
            this.url.Text = "url";
            this.url.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.url);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(941, 804);
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Label title;
        private Wisej.Web.Label url;
    }
}

