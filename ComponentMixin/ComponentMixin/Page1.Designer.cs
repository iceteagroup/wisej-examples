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
            ComponentMixin.MyTreeNode treeNode17 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode treeNode18 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode treeNode19 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode treeNode20 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode treeNode21 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode treeNode22 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode treeNode23 = new ComponentMixin.MyTreeNode();
            ComponentMixin.MyTreeNode treeNode24 = new ComponentMixin.MyTreeNode();
            Wisej.Web.TreeNode treeNode25 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode26 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode27 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode28 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode29 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode30 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode31 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode32 = new Wisej.Web.TreeNode();
            this.treeView1 = new Wisej.Web.TreeView();
            this.treeView2 = new Wisej.Web.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 18);
            this.treeView1.Name = "treeView1";
            treeNode17.Name = "Node0";
            treeNode18.Name = "Node6";
            treeNode19.Name = "Node7";
            treeNode19.Text = "MyNode7";
            treeNode18.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode19});
            treeNode18.Text = "MyNode6";
            treeNode17.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode18});
            treeNode17.Text = "MyNode0";
            treeNode20.Name = "Node1";
            treeNode20.Text = "MyNode1";
            treeNode21.Name = "Node2";
            treeNode22.Name = "Node3";
            treeNode23.Name = "Node4";
            treeNode24.Name = "Node5";
            treeNode24.Text = "MyNode5";
            treeNode23.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode24});
            treeNode23.Text = "MyNode4";
            treeNode22.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode23});
            treeNode22.Text = "MyNode3";
            treeNode21.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode22});
            treeNode21.Text = "MyNode2";
            this.treeView1.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode17,
            treeNode20,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(264, 321);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(348, 18);
            this.treeView2.Name = "treeView2";
            treeNode25.Name = "Node0";
            treeNode26.Name = "Node6";
            treeNode27.Name = "Node7";
            treeNode27.Text = "Node7";
            treeNode26.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode27});
            treeNode26.Text = "Node6";
            treeNode25.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode26});
            treeNode25.Text = "Node0";
            treeNode28.Name = "Node1";
            treeNode28.Text = "Node1";
            treeNode29.Name = "Node2";
            treeNode30.Name = "Node3";
            treeNode31.Name = "Node4";
            treeNode32.Name = "Node5";
            treeNode32.Text = "Node5";
            treeNode31.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode32});
            treeNode31.Text = "Node4";
            treeNode30.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode31});
            treeNode30.Text = "Node3";
            treeNode29.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode30});
            treeNode29.Text = "Node2";
            this.treeView2.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode25,
            treeNode28,
            treeNode29});
            this.treeView2.Size = new System.Drawing.Size(264, 321);
            this.treeView2.TabIndex = 1;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(858, 408);
            this.Text = "Component Mixin";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TreeView treeView1;
        private Wisej.Web.TreeView treeView2;
    }
}

