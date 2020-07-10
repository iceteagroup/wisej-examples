namespace Wisej.CustomCellRenderer
{
    partial class DataGridViewJSONColumnEditor
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
            this.textBox2 = new Wisej.Web.TextBox();
            this.textBox3 = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(322, 22);
            this.textBox3.TabIndex = 2;
            // 
            // DataGridViewJSONColumnEditor
            // 
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.Name = "DataGridViewJSONColumnEditor";
            this.Size = new System.Drawing.Size(328, 221);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TextBox textBox1;
        private Web.TextBox textBox3;
        private Web.TextBox textBox2;
    }
}
