
using System;
using System.Drawing;
using System.Globalization;
using Wisej.Web;
using Wisej.Web.Ext.DataGridViewSummaryRow;

namespace WiseJ.DataGridViewSummaryRows
{
	public partial class frmSummaryGroup : Form
	{
		public frmSummaryGroup()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			FillData(1);
			FillData(2);
			FillData(3);
			FillData(4);
			AddAggregations();
		}

		private void FillData(int quarter)
		{
			var grid = this.dataGridView1;

			// add data for quarter/month.
			for (var i = 0; i < Items.Length; i++)
			{
				var index = grid.Rows.Add();
				grid[0, index].Value = $"Quarter {quarter}";
				grid[1, index].Value = Items[i];

				for (int m = 0; m < 12; m++)
				{
					grid[m + 2, index].Value = Values[m][i];
					grid[m + 2, index].Style = AmountStyle;
				}
			}

		}

		private static string[] Items = { "General Supplies", "Printer Ink", "Paper", "Postage" } ;
		private static int[][] Values = { 
			new []{ 17, 20, 43, 42 },
			new[] { 39, 21, 44, 30 },
			new []{ 55, 8, 9, 65 },
			new[] { 79, 43, 14, 20 },
			new []{ 17, 20, 43, 42 },
			new[] { 39, 21, 44, 30 },
			new []{ 55, 8, 9, 65 },
			new[] { 79, 43, 14, 20 },
			new []{ 17, 20, 43, 42 },
			new[] { 39, 21, 44, 30 },
			new []{ 55, 8, 9, 65 },
			new[] { 79, 43, 14, 20 }
		};

		private void AddAggregations()
		{
			// sum all expenses grouped by quarter (column 0)
			DataGridViewRow[] totals = null;
			var grid = this.dataGridView1;
			for (var m = 0; m < 12; m++)
			{
				totals = grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Above, grid.Columns[0], grid.Columns[m + 2], TotalStyle);
			}

            // add total label and group headers
            foreach (var t in totals)
            {
                t[1].Value = "Office Supplies";
                t[1].Style = TotalTitleStyle;

                grid.Rows.Insert(t.Index);
                grid.Rows.Insert(t.Index);

                // quarter label.
                var quarter = grid.Rows[t.Index - 2];
                quarter[2].Value = t[0].Value;
                quarter[2].Style = QuarterStyle;
                t[0].Value = null;

                var months = grid.Rows[t.Index - 1];
                var monthNames = DateTimeFormatInfo.CurrentInfo.AbbreviatedMonthNames;
                for (var m = 0; m < 12; m++)
                {
                    months[m + 2].Value = monthNames[m].ToUpper();
                    months[m + 2].Style = MonthStyle;
                }
            }
        }

		private static DataGridViewCellStyle QuarterStyle = new DataGridViewCellStyle()
		{
			ColSpan = 12,
			BackColor = Color.FromArgb(241, 166, 0),
			ForeColor = Color.White,
			Padding = new Padding(40, 0, 0, 0),
			CssStyle = "border: 1px solid white"
		};

		private static DataGridViewCellStyle AmountStyle = new DataGridViewCellStyle()
		{
			Format = "C0",
			Alignment = DataGridViewContentAlignment.MiddleRight
		};

		private static DataGridViewCellStyle TotalStyle = new DataGridViewCellStyle()
		{
			Format = "C0",
			Font = new Font("Helvetica", 12, FontStyle.Bold, GraphicsUnit.Point),
			Alignment = DataGridViewContentAlignment.MiddleRight
		};

		private static DataGridViewCellStyle TotalTitleStyle = new DataGridViewCellStyle()
		{
			Font = new Font("Helvetica", 12, FontStyle.Bold, GraphicsUnit.Point),
			Alignment = DataGridViewContentAlignment.MiddleLeft
		};

		private static DataGridViewCellStyle MonthStyle = new DataGridViewCellStyle()
		{
			BackColor = Color.FromArgb(250, 203, 89),
			ForeColor = Color.White,
			Alignment = DataGridViewContentAlignment.MiddleCenter,
			CssStyle = "border: 1px solid white"
		};
	}
}
