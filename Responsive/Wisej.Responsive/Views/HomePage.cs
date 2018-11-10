using System;
using Wisej.Web;


namespace Wisej.Responsive.Views
{
	public partial class HomePage : Page
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private void optionsPanel1_OptionClick(object sender, Panels.OptionsPanel.OptionClickedEventArgs args)
		{
			// create or activate the view that corresponds to the clicked option button.
			string viewName = args.ViewName;
			Control view = (Control)Application.FindComponent(o => o is Control && ((Control)o).Name == viewName);
			if (view == null)
			{
				Type type = Type.GetType("Wisej.Responsive.Views." + viewName, true);
				view = (Control)Activator.CreateInstance(type);
				view.Parent = this.workspacePanel;
				view.Dock = DockStyle.Fill;
				view.Disposed += (s, e) => { this.optionsPanel1.UpdateState(); };
				this.optionsPanel1.UpdateState();
			}
			view.BringToFront();
		}
	}
}
