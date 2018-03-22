using System;
using Wisej.Web;


namespace Wisej.PolymerExample
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.paperSlider1.Value++;
			this.paperSlider1.Update();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.paperSlider1.Value--;
			this.paperSlider1.Update();
		}

		private void paperCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.label4.Text = this.paperCheckBox1.Checked.ToString();
		}

		private void paperSlider1_ValueChanged(object sender, EventArgs e)
		{
			this.label3.Text = this.paperSlider1.Value.ToString();
			this.paperProgress1.Value = this.paperSlider1.Value;
		}

		private void paperButton1_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Thank you!", alignment: System.Drawing.ContentAlignment.MiddleCenter);
		}

		private void paperRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.paperRadioButton2.Checked = !this.paperRadioButton1.Checked;
		}

		private void paperRadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			this.paperRadioButton1.Checked = !this.paperRadioButton2.Checked;
		}

		private void paperRadioGroup1_SelectedChanged(object sender, EventArgs e)
		{
			AlertBox.Show(this.paperRadioGroup1.Selected, alignment: System.Drawing.ContentAlignment.MiddleCenter, icon:MessageBoxIcon.Information);
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			this.googleChart1.Type = "treemap";
			this.googleChart1.Options.showScale = true;
			this.googleChart1.Options.maxPostDepth = 2;

			this.googleChart1.Data = new object[] {
				new object[]{ "Location", "Parent", "Value" },
				new object[]{ "Global", null, 0 },
				new object[]{ "America", "Global", 0 },
				new object[]{ "Europe", "Global", 0 },
				new object[]{ "Asia", "Global", 0 },
				new object[]{ "Australia", "Global", 0 },
				new object[]{ "Africa", "Global", 0},
				new object[]{ "Brazil", "America", 11 },
				new object[]{ "USA", "America", 52 },
				new object[]{ "Mexico", "America", 24 },
				new object[]{ "Canada", "America", 16 },
				new object[]{ "France", "Europe", 42 },
				new object[]{ "Germany", "Europe", 31 },
				new object[]{ "Sweden", "Europe", 22 },
				new object[]{ "Italy", "Europe", 17 },
				new object[]{ "UK", "Europe", 21 },
				new object[]{ "China", "Asia", 36 },
				new object[]{ "Japan", "Asia", 20 },
				new object[]{ "India", "Asia", 40 },
				new object[]{ "Laos", "Asia", 4 },
				new object[]{ "Mongolia", "Asia", 1 },
				new object[]{ "Israel", "Asia", 12 },
				new object[]{ "Iran", "Asia", 18 },
				new object[]{ "Pakistan", "Asia", 11 },
				new object[]{ "Egypt", "Africa", 2 },
				new object[]{ "S. Africa", "Africa", 30 },
				new object[]{ "Sudan", "Africa", 12 },
				new object[]{ "Congo", "Africa", 10 },
				new object[]{ "Zaire", "Africa", 8 } };
		}

		private void googleChart1_SelectionChanged(object sender, EventArgs e)
		{
			var selection = this.googleChart1.Selection;
			if (selection != null && selection.Length > 0)
				AlertBox.Show(this.googleChart1.Data[selection[0].row + 1][0], alignment: System.Drawing.ContentAlignment.TopCenter);
		}
	}
}
