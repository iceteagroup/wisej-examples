namespace Wisej.Mobile.Features
{
    partial class DeepLink
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
            this.textBox1 = new Wisej.Web.TextBox();
            this.button1 = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.textBox1.AutoSize = false;
            this.textBox1.Label.Size = 30;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Absolute;
            this.textBox1.LabelText = "Message";
            this.textBox1.Location = new System.Drawing.Point(76, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1336, 122);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new Wisej.Web.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(76, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1336, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Navigate Back to Wisej Mobile";
            this.button1.Click += new System.EventHandler(this.buttonNavigate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(76, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1336, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "wisej://";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeepLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "DeepLink";
            this.Size = new System.Drawing.Size(1488, 824);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.TextBox textBox1;
        private Web.Button button1;
        private Web.Label label1;
    }
}
