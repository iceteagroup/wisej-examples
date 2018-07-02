namespace Wisej.CodeProject.Examples
{
	partial class HtmlEditorExample
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
			this.ckEditor1 = new Wisej.Web.Ext.CKEditor.CKEditor();
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// ckEditor1
			// 
			this.ckEditor1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.ckEditor1.Location = new System.Drawing.Point(26, 37);
			this.ckEditor1.Name = "ckEditor1";
			this.ckEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{}")));
			this.ckEditor1.Size = new System.Drawing.Size(988, 567);
			this.ckEditor1.TabIndex = 0;
			this.ckEditor1.Text = "ckEditor1";
			// 
			// button1
			// 
			this.button1.Anchor = Wisej.Web.AnchorStyles.Bottom;
			this.button1.Location = new System.Drawing.Point(449, 631);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 58);
			this.button1.TabIndex = 1;
			this.button1.Text = "Close";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HtmlEditorExample
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1052, 714);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ckEditor1);
			this.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/android-logo-1.svg?color=#BF3FB5";
			this.Name = "HtmlEditorExample";
			this.Text = "HTML Editor (CKEditor)";
			this.Load += new System.EventHandler(this.HtmlEditorExample_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.CKEditor.CKEditor ckEditor1;
		private Web.Button button1;
	}
}