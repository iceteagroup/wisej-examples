
using System;
using Wisej.Web;

namespace Wisej.ColumnFilterSample
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			var table = this.dataGridView1;
			for (int i = 0; i < 100; i++)
			{
				table.Rows.Add("Name " + i, "Last Name " + i, DateTime.Now.AddYears(-30 + i).AddDays(i), i, i % 2 == 1);
			}
		}
	}
}
