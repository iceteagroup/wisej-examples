namespace DGVEmbeddedNavigator
{
    partial class EmbeddedBindingNavigator
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
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.bindingNavigator = new Wisej.Web.BindingNavigator(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Controls.Add(this.bindingNavigator);
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowFocusCell = false;
            this.dataGridView1.Size = new System.Drawing.Size(613, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.buttonAddNew;
            this.bindingNavigator.Controls.Add(this.buttonMoveFirst);
            this.bindingNavigator.Controls.Add(this.buttonMovePrevious);
            this.bindingNavigator.Controls.Add(this.separatorLeft);
            this.bindingNavigator.Controls.Add(this.textBoxPosition);
            this.bindingNavigator.Controls.Add(this.labelCount);
            this.bindingNavigator.Controls.Add(this.separatorRight);
            this.bindingNavigator.Controls.Add(this.buttonMoveNext);
            this.bindingNavigator.Controls.Add(this.buttonMoveLast);
            this.bindingNavigator.Controls.Add(this.separatorControl);
            this.bindingNavigator.Controls.Add(this.buttonAddNew);
            this.bindingNavigator.Controls.Add(this.buttonDelete);
            this.bindingNavigator.CountItem = this.labelCount;
            this.bindingNavigator.DeleteItem = this.buttonDelete;
            this.bindingNavigator.Dock = Wisej.Web.DockStyle.Top;
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.buttonMoveFirst;
            this.bindingNavigator.MoveLastItem = this.buttonMoveLast;
            this.bindingNavigator.MoveNextItem = this.buttonMoveNext;
            this.bindingNavigator.MovePreviousItem = this.buttonMovePrevious;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.textBoxPosition;
            this.bindingNavigator.Size = new System.Drawing.Size(611, 34);
            this.bindingNavigator.TabIndex = 0;
            // 
            // buttonMoveFirst
            // 
            this.buttonMoveFirst.ImageSource = "icon-first";
            this.buttonMoveFirst.Location = new System.Drawing.Point(3, 3);
            this.buttonMoveFirst.Name = "buttonMoveFirst";
            this.buttonMoveFirst.Size = new System.Drawing.Size(37, 28);
            this.buttonMoveFirst.TabIndex = 0;
            // 
            // buttonMovePrevious
            // 
            this.buttonMovePrevious.ImageSource = "icon-left";
            this.buttonMovePrevious.Location = new System.Drawing.Point(46, 3);
            this.buttonMovePrevious.Name = "buttonMovePrevious";
            this.buttonMovePrevious.Size = new System.Drawing.Size(37, 28);
            this.buttonMovePrevious.TabIndex = 1;
            // 
            // separatorLeft
            // 
            this.separatorLeft.Location = new System.Drawing.Point(89, 3);
            this.separatorLeft.Name = "separatorLeft";
            this.separatorLeft.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorLeft.Padding = new Wisej.Web.Padding(0, 5, 0, 5);
            this.separatorLeft.Size = new System.Drawing.Size(14, 28);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.AutoSize = false;
            this.textBoxPosition.Location = new System.Drawing.Point(109, 3);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(50, 28);
            this.textBoxPosition.TabIndex = 6;
            this.textBoxPosition.Text = "0";
            // 
            // labelCount
            // 
            this.labelCount.Location = new System.Drawing.Point(165, 3);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 28);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "of {0}";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorRight
            // 
            this.separatorRight.Location = new System.Drawing.Point(210, 3);
            this.separatorRight.Name = "separatorRight";
            this.separatorRight.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorRight.Padding = new Wisej.Web.Padding(0, 5, 0, 5);
            this.separatorRight.Size = new System.Drawing.Size(14, 28);
            // 
            // buttonMoveNext
            // 
            this.buttonMoveNext.ImageSource = "icon-right";
            this.buttonMoveNext.Location = new System.Drawing.Point(230, 3);
            this.buttonMoveNext.Name = "buttonMoveNext";
            this.buttonMoveNext.Size = new System.Drawing.Size(37, 28);
            this.buttonMoveNext.TabIndex = 2;
            // 
            // buttonMoveLast
            // 
            this.buttonMoveLast.ImageSource = "icon-last";
            this.buttonMoveLast.Location = new System.Drawing.Point(273, 3);
            this.buttonMoveLast.Name = "buttonMoveLast";
            this.buttonMoveLast.Size = new System.Drawing.Size(37, 28);
            this.buttonMoveLast.TabIndex = 3;
            // 
            // separatorControl
            // 
            this.separatorControl.Location = new System.Drawing.Point(316, 3);
            this.separatorControl.Name = "separatorControl";
            this.separatorControl.Orientation = Wisej.Web.Orientation.Vertical;
            this.separatorControl.Padding = new Wisej.Web.Padding(0, 5, 0, 5);
            this.separatorControl.Size = new System.Drawing.Size(14, 28);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.ImageSource = "table-row-new";
            this.buttonAddNew.Location = new System.Drawing.Point(336, 3);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(37, 28);
            this.buttonAddNew.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.ImageSource = "icon-close";
            this.buttonDelete.Location = new System.Drawing.Point(379, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(37, 28);
            this.buttonDelete.TabIndex = 5;
            // 
            // EmbeddedBindingNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmbeddedBindingNavigator";
            this.Text = "Embedded BindingNavigator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.BindingNavigator bindingNavigator;
        private Wisej.Web.Button buttonAddNew;
        private Wisej.Web.Button buttonMoveFirst;
        private Wisej.Web.Button buttonMovePrevious;
        private Wisej.Web.Line separatorLeft;
        private Wisej.Web.TextBox textBoxPosition;
        private Wisej.Web.Label labelCount;
        private Wisej.Web.Line separatorRight;
        private Wisej.Web.Button buttonMoveNext;
        private Wisej.Web.Button buttonMoveLast;
        private Wisej.Web.Line separatorControl;
        private Wisej.Web.Button buttonDelete;
    }
}

