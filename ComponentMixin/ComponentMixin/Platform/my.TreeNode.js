
/**
 * my.TreeNode
 */
qx.Class.define("my.TreeNode", {

	extend: wisej.web.TreeNode,

	members: {

		/**
		  * Applies the canExpand property.
		  *
		  * Changes the appearance key of the TreeNode class
		  * to look like a tree-folder or a tree-item.
		  */
		_applyCanExpand: function (value, old) {

			this.base(arguments, value, old);

			this.setAppearance(value ? "mytree-folder" : "mytree-file");
		},
	},

});
