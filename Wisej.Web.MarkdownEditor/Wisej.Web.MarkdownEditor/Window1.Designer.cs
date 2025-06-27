namespace Wisej.Web.MarkdownEditor
{
    partial class Window1
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

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			aceEditor1 = new Wisej.Web.Ext.AceEditor.AceEditor();
			htmlPanel1 = new HtmlPanel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Cursor = null;
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new System.Drawing.Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(aceEditor1);
			splitContainer1.Panel1.Cursor = null;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(htmlPanel1);
			splitContainer1.Panel2.Cursor = null;
			splitContainer1.Size = new System.Drawing.Size(1306, 694);
			splitContainer1.SplitterDistance = 417;
			splitContainer1.TabIndex = 0;
			// 
			// aceEditor1
			// 
			aceEditor1.Dock = DockStyle.Fill;
			aceEditor1.Size = new System.Drawing.Size(415, 692);
			aceEditor1.TabIndex = 0;
			aceEditor1.TextChanged += aceEditor1_TextChanged;
			// 
			// htmlPanel1
			// 
			htmlPanel1.Cursor = null;
			htmlPanel1.Dock = DockStyle.Fill;
			htmlPanel1.Focusable = false;
			htmlPanel1.Location = new System.Drawing.Point(0, 0);
			htmlPanel1.Name = "htmlPanel1";
			htmlPanel1.Size = new System.Drawing.Size(878, 692);
			htmlPanel1.TabIndex = 0;
			htmlPanel1.TabStop = false;
			// 
			// Window1
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1306, 694);
			Controls.Add(splitContainer1);
			Name = "Window1";
			Text = "Markdown Editor";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);

		}

		#endregion

		private SplitContainer splitContainer1;
		private Ext.AceEditor.AceEditor aceEditor1;
		private HtmlPanel htmlPanel1;
	}

}
