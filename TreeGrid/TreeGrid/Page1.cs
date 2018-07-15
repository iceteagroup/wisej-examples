
using System;
using Wisej.Web;
using System.Data;

namespace TreeGrid
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns[0].DataPropertyName = "ID";
            this.dataGridView1.Columns[1].DataPropertyName = "NAME";
            this.dataGridView1.Columns[2].DataPropertyName = "TYPE";
            this.dataGridView1.Columns[3].DataPropertyName = "THERAPIST";           

            this.dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;

            this.dataGridView1.DataSource = new BindingSource(DefineData(), null);
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetParents();
        }

        /// <summary>
        /// Set Parent Rows
        /// </summary>
        private void SetParents ()
        {
            string prevType = "";
            int ParentRow = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                if (row.Cells["colType"].Value.ToString() == prevType)
                {
                    row.ParentRow = dataGridView1.Rows[ParentRow];
                }
                else
                {
                    ParentRow = row.Index;
                }
                prevType = row.Cells["colType"].Value.ToString();
            }
        }

        private DataTable DefineData ()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Therapy";

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("TYPE", typeof(string));
            dt.Columns.Add("THERAPIST", typeof(string));

            // preordered
            dt.Rows.Add(1, "Therapy 1", "Type 1", "Dr. A");
            dt.Rows.Add(2, "Therapy 1", "Type 1", "Dr. B");
            dt.Rows.Add(3, "Therapy 1", "Type 1", "Dr. C");
            dt.Rows.Add(4, "Therapy 2", "Type 2", "Dr. D");
            dt.Rows.Add(5, "Therapy 3", "Type 3", "Dr. E");
            dt.Rows.Add(6, "Therapy 3", "Type 3", "Dr. F");
            dt.Rows.Add(7, "Therapy 4", "Type 4", "Dr. G");
            dt.Rows.Add(8, "Therapy 5", "Type 5", "Dr. A");
            dt.Rows.Add(9, "Therapy 5", "Type 5", "Dr. B");
            dt.Rows.Add(10, "Therapy 5", "Type 5", "Dr. C");
            dt.Rows.Add(11, "Therapy 5", "Type 5", "Dr. D");
            dt.Rows.Add(11, "Therapy 5", "Type 5", "Dr. E");

            return dt;
        }

    }
}
