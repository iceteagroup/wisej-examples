using System.Drawing;
using Wisej.Web;

namespace Wisej.CustomCellRenderer
{
    public class DataGridViewJSONColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewJSONColumn()
        {
            this.Editor = new DataGridViewJSONColumnEditor();
        }

        public override string CellRenderer
        {
            get { return "my.JSONCellRenderer"; }
            set { }
        }
    }     
}