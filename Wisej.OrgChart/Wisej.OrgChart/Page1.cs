
using System;
using Wisej.Web;
using Wisej.Core;

namespace Wisej.OrgChart
{
	public partial class Page1 : Page
	{
		private object data;

		public Page1()
		{
			InitializeComponent();

			data = new
			{
				name = "Silver Surfer",
				title = "Department Manager",
				children = new[] {
					new {
						name = "Spiderman",
						title = "Senior Engineer"
					},
					new {
						name = "Daredevil",
						title = "Junion Associate"
					}
				}
			};
		}

		[WebMethod]
		public object GetOrgChartData()
		{
			return this.data;
		}

		private void widget1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch	(e.Type)
			{
				case "nodeClick":
					AlertBox.Show("You clicked: " + e.Data);
					break;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			data = new
			{
				name = "Superman",
				title = "Department Manager",
				children = new[] {
					new {
						name = "Batman",
						title = "Senior Engineer"
					}
				}
			};

			this.widget1.Call("reload");
		}
	}
}
