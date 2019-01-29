using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Responsive.Panels
{
	public partial class OptionsPanel : Wisej.Web.UserControl
	{
		public OptionsPanel()
		{
			InitializeComponent();
		}

		// Fired when one of the option buttons is clicked.
		public event OptionClickedEventHandler OptionClick;

		// Adapts the panel to the device.
		private void OptionsPanel_ResponsiveProfileChanged(object sender, ResponsiveProfileChangedEventArgs e)
		{
			var display = Display.Both;

			if (Application.Browser.Size.Width < 450)
			{
				display = Display.Icon;
				this.label1.Visible = false;
				this.Width = 90;
			}
			else
			{
				this.label1.Visible = true;
				this.Width = 250;
			}

			foreach (Control c in this.Controls)
			{
				var button = c as Button;
				if (button != null)
					button.Display = display;
			}

		}

		// binds the buttons to the corresponding view names.
		private void OptionsPanel_Load(object sender, EventArgs e)
		{
			this.buttonProducts.UserData.ViewName = "ProductsView";
			this.buttonDashboard.UserData.ViewName = "DashboardView";
			this.buttonCustomers.UserData.ViewName = "CustomersView";
		}

		public void UpdateState()
		{
			// update the state of the button to reflect whether
			// the corresponding view is created.
			foreach (Control c in this.Controls)
			{
				var button = c as Button;
				if (button != null)
				{
					string viewName = button.UserData.ViewName;
					Control view = (Control)Application.FindComponent(o => o is Control && ((Control)o).Name == viewName);

					if (view == null || view.IsDisposed || view.Disposing)
						this.styleSheet.SetCssClass(c, null);
					else
						this.styleSheet.SetCssClass(c, "active");
				}
			}
		}

		private void button_Click(object sender, EventArgs e)
		{
			if (this.OptionClick != null)
			{
				OptionClick(this, new OptionClickedEventArgs((Button)sender));
			}
		}

		/// <summary>
		/// Handler for the OptionClicked event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public delegate void OptionClickedEventHandler(object sender, OptionClickedEventArgs e);

		/// <summary>
		/// Data for the OptionClickedEventHandler event handler.
		/// </summary>
		public class OptionClickedEventArgs : EventArgs
		{
			internal OptionClickedEventArgs(Button button)
			{
				this.ViewName = button.UserData.ViewName;
			}

			public string ViewName
			{
				get;
				private set;
			}
		}

	}
}
