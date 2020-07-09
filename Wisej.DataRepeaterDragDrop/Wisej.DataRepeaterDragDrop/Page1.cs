
using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace Wisej.DataRepeaterDragDrop
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void dataRepeater1_ItemSelected(object sender, DataRepeaterItemEventArgs e)
		{
			this.button1.Enabled = e.DataRepeaterItem.ItemIndex > 0;
			this.button2.Enabled = e.DataRepeaterItem.ItemIndex < this.dataRepeater1.ItemCount - 1;
		}

		private void dataRepeater1_DragStart(object sender, EventArgs e)
		{
			var item = this.dataRepeater1.CurrentItem;
			var data = (BindingList<Model>)this.dataRepeater1.DataSource;
			this.dataRepeater1.DoDragDrop(data[item.ItemIndex], DragDropEffects.Move);
		}

		private void dataRepeater1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Model)))
			{
				e.Effect = DragDropEffects.Move;
				e.ImageSource = "data-item.png";
				e.ImageSize = new Size(32, 32);
			}
		}

		private void dataRepeater1_DragDrop(object sender, DragEventArgs e)
		{
			var data = (BindingList<Model>)this.dataRepeater1.DataSource;
			var item = (Model)e.Data.GetData(typeof(Model));
			var target = e.DropTarget as DataRepeaterItem;
			if (target != null)
				MoveDataItem(data.IndexOf(item), target.ItemIndex);
			else
				MoveDataItem(data.IndexOf(item), data.Count - 1);
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			var data = new BindingList<Model>();
			for (var i = 0; i < 100; i++)
			{
				data.Add(new Model() { 
					ID = i,
					Name = $"Item #{i}"
				});
			}
			this.dataRepeater1.DataSource = data;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var index = this.dataRepeater1.CurrentItemIndex;
			MoveDataItem(index, index - 1);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var index = this.dataRepeater1.CurrentItemIndex;
			MoveDataItem( index, index + 1);
		}

		private void MoveDataItem(int index, int destination)
		{
			if (index < 0 || index == destination)
				return;

			var data = (BindingList<Model>)this.dataRepeater1.DataSource;
			var item = data[index];
			data.RemoveAt(index);
			data.Insert(destination, item);
			this.dataRepeater1.CurrentItemIndex = destination;
		}
	}
}
