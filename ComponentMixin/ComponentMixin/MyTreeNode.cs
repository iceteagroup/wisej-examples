using Wisej.Web;

namespace ComponentMixin
{
	public class MyTreeNode : TreeNode
	{
		protected override void OnWebRender(dynamic config)
		{
			base.OnWebRender((object)config);

			config.className = "my.TreeNode";
		}
	}
}