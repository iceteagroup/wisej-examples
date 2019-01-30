
using System;
using Wisej.Web;

namespace Wisej.LazyLoadingPanel
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void containerPanel1_LoadPanels(object sender, EventArgs e)
		{
			var container = (ContainerPanel)sender;
			var count = container.Controls.Count;
			if (count < 1000)
			{
				// load 50 at a time.
				for (int i = 0; i < 50; i++)
				{
					var newItem = new ItemPanel()
					{
						ImageSource = "https://placeimg.com/64/64/animals?v="+i,
						Dock = DockStyle.Top,
						Title = "Item #" + (i + count),
						Text = " This is item number " + (i + count)

					};
					newItem.ActionClick += this.itemPanel_Click;

					container.Controls.Add(newItem);

					// docking top is reversed to follow winforms standard behavior.
					container.Controls.SetChildIndex(newItem, 1);

					// uncomment for live loading
					// Application.Update(this);
				}
			}
		}

		private void itemPanel_Click(object sender, EventArgs e)
		{
			var panel = (ItemPanel)sender;
			AlertBox.Show($"Action click on {panel.Title}");
		}
	}
}
