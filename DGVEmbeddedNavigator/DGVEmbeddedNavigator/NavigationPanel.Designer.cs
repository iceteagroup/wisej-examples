namespace DGVEmbeddedNavigator
{
    partial class NavigationPanel
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
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.panel = new Wisej.Web.FlowLayoutPanel();
            this.buttonMoveFirst = new Wisej.Web.Button();
            this.buttonMovePrevious = new Wisej.Web.Button();
            this.separatorLeft = new Wisej.Web.Line();
            this.textBoxPosition = new Wisej.Web.TextBox();
            this.labelCount = new Wisej.Web.Label();
            this.separatorRight = new Wisej.Web.Line();
            this.buttonMoveNext = new Wisej.Web.Button();
            this.buttonMoveLast = new Wisej.Web.Button();
            this.separatorControl = new Wisej.Web.Line();
            this.buttonAddNew = new Wisej.Web.Button();
            this.buttonDelete = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridView1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Controls.Add(this.panel);
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowFocusCell = false;
            this.dataGridView1.Size = new System.Drawing.Size(612, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonMoveFirst);
            this.panel.Controls.Add(this.buttonMovePrevious);
            this.panel.Controls.Add(this.separatorLeft);
            this.panel.Controls.Add(this.textBoxPosition);
            this.panel.Controls.Add(this.labelCount);
            this.panel.Controls.Add(this.separatorRight);
            this.panel.Controls.Add(this.buttonMoveNext);
            this.panel.Controls.Add(this.buttonMoveLast);
            this.panel.Controls.Add(this.separatorControl);
            this.panel.Controls.Add(this.buttonAddNew);
            this.panel.Controls.Add(this.buttonDelete);
            this.panel.Dock = Wisej.Web.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ScrollBars = Wisej.Web.ScrollBars.None;
            this.panel.Size = new System.Drawing.Size(610, 30);
            this.panel.TabIndex = 0;
            // 
            // buttonMoveFirst
            // 
            this.buttonMoveFirst.BackgroundImageSource = "icon-first?color=#FFFFFF";
            this.buttonMoveFirst.Display = Wisej.Web.Display.Icon;
            this.buttonMoveFirst.Location = new System.Drawing.Point(4, 4);
            this.buttonMoveFirst.Margin = new Wisej.Web.Padding(4);
            this.buttonMoveFirst.Name = "buttonMoveFirst";
            this.buttonMoveFirst.Size = new System.Drawing.Size(24, 22);
            this.buttonMoveFirst.TabIndex = 0;
            // 
            // buttonMovePrevious
            // 
            this.buttonMovePrevious.BackgroundImageSource = "icon-left?color=#FFFFFF";
            this.buttonMovePrevious.Display = Wisej.Web.Display.Icon;
            this.buttonMovePrevious.Location = new System.Drawing.Point(36, 4);
            this.buttonMovePrevious.Margin = new Wisej.Web.Padding(4);
            this.buttonMovePrevious.Name = "buttonMovePrevious";
            this.buttonMovePrevious.Size = new System.Drawing.Size(24, 22);
            this.buttonMovePrevious.TabIndex = 1;
            // 
            // separatorLeft
            // 
            this.separatorLeft.Location = new System.Drawing.Point(68, 4);
            this.separatorLeft.Margin = new Wisej.Web.Padding(4);
            this.separatorLeft.Name = "separatorLeft";
            this.separatorLeft.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorLeft.Size = new System.Drawing.Size(6, 22);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(82, 4);
            this.textBoxPosition.Margin = new Wisej.Web.Padding(4);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 22);
            this.textBoxPosition.TabIndex = 2;
            this.textBoxPosition.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelCount.Location = new System.Drawing.Point(190, 6);
            this.labelCount.Margin = new Wisej.Web.Padding(4, 6, 4, 4);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 16);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "of {0}";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // separatorRight
            // 
            this.separatorRight.Location = new System.Drawing.Point(237, 4);
            this.separatorRight.Margin = new Wisej.Web.Padding(4);
            this.separatorRight.Name = "separatorRight";
            this.separatorRight.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorRight.Size = new System.Drawing.Size(6, 22);
            // 
            // buttonMoveNext
            // 
            this.buttonMoveNext.BackgroundImageSource = "icon-right?color=#FFFFFF";
            this.buttonMoveNext.Display = Wisej.Web.Display.Icon;
            this.buttonMoveNext.Location = new System.Drawing.Point(251, 4);
            this.buttonMoveNext.Margin = new Wisej.Web.Padding(4);
            this.buttonMoveNext.Name = "buttonMoveNext";
            this.buttonMoveNext.Size = new System.Drawing.Size(24, 22);
            this.buttonMoveNext.TabIndex = 4;
            // 
            // buttonMoveLast
            // 
            this.buttonMoveLast.BackgroundImageSource = "icon-last?color=#FFFFFF";
            this.buttonMoveLast.Display = Wisej.Web.Display.Icon;
            this.buttonMoveLast.Location = new System.Drawing.Point(283, 4);
            this.buttonMoveLast.Margin = new Wisej.Web.Padding(4);
            this.buttonMoveLast.Name = "buttonMoveLast";
            this.buttonMoveLast.Size = new System.Drawing.Size(24, 22);
            this.buttonMoveLast.TabIndex = 5;
            // 
            // separatorControl
            // 
            this.separatorControl.Location = new System.Drawing.Point(315, 4);
            this.separatorControl.Margin = new Wisej.Web.Padding(4);
            this.separatorControl.Name = "separatorControl";
            this.separatorControl.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorControl.Size = new System.Drawing.Size(6, 22);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackgroundImageSource = "table-row-new?color=#FFFFFF";
            this.buttonAddNew.Display = Wisej.Web.Display.Icon;
            this.buttonAddNew.Location = new System.Drawing.Point(329, 4);
            this.buttonAddNew.Margin = new Wisej.Web.Padding(4);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(30, 22);
            this.buttonAddNew.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImageSource = "icon-close?color=#FFFFFF";
            this.buttonDelete.Display = Wisej.Web.Display.Icon;
            this.buttonDelete.Location = new System.Drawing.Point(367, 4);
            this.buttonDelete.Margin = new Wisej.Web.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(30, 22);
            this.buttonDelete.TabIndex = 7;
            // 
            // NavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 480);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NavigationPanel";
            this.Text = "Navigation Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.FlowLayoutPanel panel;
        private Wisej.Web.Button buttonMoveFirst;
        private Wisej.Web.Button buttonMovePrevious;
        private Wisej.Web.Line separatorLeft;
        private Wisej.Web.Label labelCount;
        private Wisej.Web.TextBox textBoxPosition;
        private Wisej.Web.Line separatorRight;
        private Wisej.Web.Button buttonMoveNext;
        private Wisej.Web.Button buttonMoveLast;
        private Wisej.Web.Line separatorControl;
        private Wisej.Web.Button buttonAddNew;
        private Wisej.Web.Button buttonDelete;
    }
}