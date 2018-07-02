
using System;
using Wisej.Web;

namespace TourPanelSample
{
	public partial class Window3 : Form
	{
		public Window3()
		{
			InitializeComponent();
		}	

		private void comboBox1_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("Not implemented in this sample.");
		}

		private void Window3_Load(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Add(1, "Joe", "Smith", false, "IT");
			this.dataGridView1.Rows.Add(2, "Jack", "Jones", true, "Finance");
			this.dataGridView1.Rows.Add(3, "Paul", "Meyer", true, "Finance");
			this.dataGridView1.Rows.Add(4, "Susan", "Miller", false, "Administration");
			this.dataGridView1.Rows.Add(5, "Peter", "McDonald", true, "IT");
			this.dataGridView1.Rows.Add(6, "Monica", "Di Marco", true, "Finance");
			this.dataGridView1.Rows.Add(7, "Oliver", "Stone", true, "Administration");
			this.dataGridView1.Rows.Add(8, "Jill", "Jackson", false, "Administration");
		}

		public void SortDGVByName ()
		{
			this.dataGridView1.Sort(this.dataGridView1.Columns["colNAME"], System.ComponentModel.ListSortDirection.Ascending);
		}

		private void dataGridView1_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show("Not implemented in this demo.");
		}
	}
}
