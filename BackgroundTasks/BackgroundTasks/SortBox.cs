using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using Wisej.Web;

namespace BackgroundTasks
{
	public partial class SortBox : UserControl
	{
		// gap between lines.
		private int gap = 2;

		// line width;
		private int lineWidth = 2;

		// values to sort.
		private int[] values = new int[0];

		// sorted flag.
		private bool sorted = false;

		public SortBox()
		{
			InitializeComponent();

			this.Delay = 10;
		}

		public event EventHandler SortCompleted;

		private void buttonSort_Click(object sender, EventArgs e)
		{
			// reshuffle.
			if (this.sorted)
			{
				this.sorted = false;
				GenerateLines();
				DrawLines();
			}

			switch (this.SortMode)
			{
				case BackgroundTasks.SortMode.BubbleSort:
					Application.StartTask(() => { RunBubbleSort(); });
					break;

				case BackgroundTasks.SortMode.QuickSort:
					Application.StartTask(() => { RunQuickSort(); });
					break;

				case BackgroundTasks.SortMode.SelectionSort:
					Application.StartTask(() => { RunSelectionSort(); });
					break;
			}
		}


		private void RunSelectionSort()
		{
			Stopwatch stopwatch = new Stopwatch();
			this.buttonSort.Enabled = false;
			this.buttonSort.Text = "Sorting...";

			var i = 0;
			var max = values.Length - 1;
			stopwatch.Start();
			while (i <= max - 1)
			{
				var k = max;
				while (k >= i + 1)
				{
					if (values[i] > values[k])
					{
						SwapValue(i, k);
					}
					k = k - 1;
				}
				i = i + 1;
			}
			stopwatch.Stop();

			if (this.SortCompleted != null)
				SortCompleted(this, EventArgs.Empty);

			AlertBox.Show("SelectionSort completed in " + stopwatch.ElapsedMilliseconds + " milliseconds.");

			this.sorted = true;
			this.buttonSort.Enabled = true;
			this.buttonSort.Text = "SORT";
			Application.Update(this);
		}

		private void RunQuickSort()
		{
			Stopwatch stopwatch = new Stopwatch();
			this.buttonSort.Enabled = false;
			this.buttonSort.Text = "Sorting...";

			stopwatch.Start();
			DoQuickSort(0, values.Length - 1);
			stopwatch.Stop();

			if (this.SortCompleted != null)
				SortCompleted(this, EventArgs.Empty);

			AlertBox.Show("QuickSort completed in " + stopwatch.ElapsedMilliseconds + " milliseconds.");

			this.sorted = true;
			this.buttonSort.Enabled = true;
			this.buttonSort.Text = "SORT";
			Application.Update(this);
		}

		private void DoQuickSort(int low, int high)
		{
			var lo = low;
			var hi = high;
			var mid = values[(lo + hi) / 2];
			while (true)
			{
				while (values[lo] < mid)
				{
					lo = lo + 1;
				}
				while (values[hi] > mid)
				{
					hi = hi - 1;
				}
				if (lo <= hi)
				{
					SwapValue(lo, hi);
					lo = lo + 1;
					hi = hi - 1;
				}
				if (lo > hi)
				{
					break;
				}
			}
			if (hi > low)
			{
				DoQuickSort(low, hi);
			}
			if (lo < high)
			{
				DoQuickSort(lo, high);
			}
		}

		private void RunBubbleSort()
		{
			Stopwatch stopwatch = new Stopwatch();
			this.buttonSort.Enabled = false;
			this.buttonSort.Text = "Sorting...";

			var i = 0;
			var max = values.Length - 1;
			stopwatch.Start();
			while (i <= max)
			{
				var k = 0;
				while (k <= max - 1)
				{
					if (values[k] > values[k + 1])
					{
						SwapValue(k, k + 1);
					}
					k = k + 1;
				}
				i = i + 1;
			}
			stopwatch.Stop();

			if (this.SortCompleted != null)
				SortCompleted(this, EventArgs.Empty);

			AlertBox.Show("BubbleSort completed in " + stopwatch.ElapsedMilliseconds + " milliseconds.");

			this.sorted = true;
			this.buttonSort.Enabled = true;
			this.buttonSort.Text = "SORT";
			Application.Update(this);
		}

		private void SwapValue(int a, int b)
		{
			var t = values[a];
			values[a] = values[b];
			values[b] = t;

			var canvas = this.canvas;
			var rect = this.DisplayRectangle;
			canvas.LiveUpdate = true;
			try
			{
				// clear the previous lines
				canvas.BeginPath();
				canvas.StrokeStyle = this.BackColor;
				canvas.LineWidth = this.lineWidth;
				var y = a * (this.lineWidth + this.gap) + 1;
				canvas.MoveTo(0, y);
				canvas.LineTo(rect.Width, y);
				y = b * (this.lineWidth + this.gap) + 1;
				canvas.MoveTo(0, y);
				canvas.LineTo(rect.Width, y);
				canvas.Stroke();

				// draw the swapped lines.
				canvas.BeginPath();
				canvas.StrokeStyle = this.ForeColor;
				y = a * (this.lineWidth + this.gap) + 1;
				canvas.MoveTo(0, y);
				canvas.LineTo(values[a], y);
				y = b * (this.lineWidth + this.gap) + 1;
				canvas.MoveTo(0, y);
				canvas.LineTo(values[b], y);
				canvas.Stroke();
			}
			finally
			{
				canvas.LiveUpdate = false;
			}

			Application.Update(this);
			Thread.Sleep(this.Delay);
		}

		public string Title
		{
			get { return this.title.Text; }
			set { this.title.Text = value; }
		}

		public SortMode SortMode
		{
			get;
			set;
		}

		public int Delay
		{
			get;
			set;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			GenerateLines();
		}

		private void GenerateLines()
		{
			Random rand = new Random();

			this.values = new int[this.canvas.Height / (this.lineWidth + this.gap)];
			for (int i = 0, length = values.Length; i < length; i++)
			{
				values[i] = rand.Next(this.Width);
			}
		}

		private void DrawLines()
		{
			var canvas = this.canvas;
			var rect = this.DisplayRectangle;

			// clear the canvas.
			canvas.BeginPath();
			canvas.ClearRect(rect);

			// set the line color.
			canvas.StrokeStyle = this.ForeColor;

			// calculate the size if the line of the line.
			canvas.LineWidth = this.lineWidth;

			Point pos = pos = new Point(0, 1);
			for (int i = 0, length = values.Length; i < length; i++)
			{
				canvas.MoveTo(pos);
				canvas.LineTo(values[i], pos.Y);
				pos.Y += canvas.LineWidth + gap;
			}

			canvas.Stroke();
		}

		private void canvas_Redraw(object sender, EventArgs e)
		{
			DrawLines();
		}

	}

	public enum SortMode
	{
		BubbleSort,
		SelectionSort,
		QuickSort
	}


}
