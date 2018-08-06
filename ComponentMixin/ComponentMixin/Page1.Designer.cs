namespace ComponentMixin
{
    partial class Page1
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
            ComponentMixin.MyTreeNode myTreeNode9 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode myTreeNode10 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode myTreeNode11 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode myTreeNode12 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode myTreeNode13 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode myTreeNode14 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode myTreeNode15 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode myTreeNode16 = new ComponentMixin.MyTreeNode();
            Wisej.Web.TreeNode treeNode9 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode10 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode11 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode12 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode13 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode14 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode15 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode16 = new Wisej.Web.TreeNode();
            this.treeView1 = new Wisej.Web.TreeView();
            this.treeView2 = new Wisej.Web.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 25);
            this.treeView1.Name = "treeView1";
            myTreeNode9.Name = "Node0";
            myTreeNode10.Name = "Node6";
            myTreeNode11.Name = "Node7";
            myTreeNode11.Text = "MyNode7";
            myTreeNode10.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            myTreeNode11});
            myTreeNode10.Text = "MyNode6";
            myTreeNode9.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            myTreeNode10});
            myTreeNode9.Text = "MyNode0";
            myTreeNode12.Name = "Node1";
            myTreeNode12.Text = "MyNode1";
            myTreeNode13.Name = "Node2";
            myTreeNode14.Name = "Node3";
            myTreeNode15.Name = "Node4";
            myTreeNode16.Name = "Node5";
            myTreeNode16.Text = "MyNode5";
            myTreeNode15.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            myTreeNode16});
            myTreeNode15.Text = "MyNode4";
            myTreeNode14.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            myTreeNode15});
            myTreeNode14.Text = "MyNode3";
            myTreeNode13.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            myTreeNode14});
            myTreeNode13.Text = "MyNode2";
            this.treeView1.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            myTreeNode9,
            myTreeNode12,
            myTreeNode13});
            this.treeView1.Size = new System.Drawing.Size(250, 275);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(400, 25);
            this.treeView2.Name = "treeView2";
            treeNode9.Name = "Node0";
            treeNode10.Name = "Node6";
            treeNode11.Name = "Node7";
            treeNode11.Text = "Node7";
            treeNode10.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode11});
            treeNode10.Text = "Node6";
            treeNode9.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode10});
            treeNode9.Text = "Node0";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Node1";
            treeNode13.Name = "Node2";
            treeNode14.Name = "Node3";
            treeNode15.Name = "Node4";
            treeNode16.Name = "Node5";
            treeNode16.Text = "Node5";
            treeNode15.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode16});
            treeNode15.Text = "Node4";
            treeNode14.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode15});
            treeNode14.Text = "Node3";
            treeNode13.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode14});
            treeNode13.Text = "Node2";
            this.treeView2.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode13});
            this.treeView2.Size = new System.Drawing.Size(250, 275);
            this.treeView2.TabIndex = 1;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(917, 779);
            this.Text = "Component Mixin";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TreeView treeView1;
        private Wisej.Web.TreeView treeView2;
    }
}

