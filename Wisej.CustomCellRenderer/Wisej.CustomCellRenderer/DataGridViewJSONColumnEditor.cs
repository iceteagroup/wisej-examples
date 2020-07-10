using System;
using Wisej.Web;

namespace Wisej.CustomCellRenderer
{
	public partial class DataGridViewJSONColumnEditor : Wisej.Web.FlexLayoutPanel
	{
		public DataGridViewJSONColumnEditor()
		{
			InitializeComponent();
		}

		public override string Text
		{
			get
			{
				return new
				{
					Value1 = this.textBox1.Text,
					Value2 = this.textBox2.Text,
					Value3 = this.textBox3.Text
				}.ToJSON(false);
			}
			set 
			{
				var json = JSON.Parse(value);
				this.textBox1.Text = json.Value1;
				this.textBox2.Text = json.Value2;
				this.textBox3.Text = json.Value3;
			}
		}
	}
}
