using Wisej.Web;

namespace SharedControl
{
	public partial class StatsPanel : UserControl
	{
		private readonly IDataSupplier _supplier;

		public StatsPanel(IDataSupplier supplier)
		{
			InitializeComponent();

			_supplier = supplier;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			_supplier.Fill(this);
		}
	}
}