using System;
using Wisej.Web;
using System.Data;

namespace TreeGrid
{
    public partial class DataTableWindow : Form
    {
        public DataTableWindow()
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
        private void SetParents()
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
                    row[1].Style.ColSpan = 2;
                    dataGridView1.Rows[ParentRow].Collapse();
                    ParentRow = row.Index;
                }

                prevType = row.Cells["colType"].Value.ToString();
            }

            dataGridView1.Rows[ParentRow].Collapse();
        }

        private DataTable DefineData()
        {
            DataTable dt = new DataTable();
            dt.TableName = "Therapy";

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("TYPE", typeof(string));
            dt.Columns.Add("THERAPIST", typeof(string));

            // preordered
            dt.Rows.Add(1, "Acupuncture", "Type 1", "");
            dt.Rows.Add(1, "", "Type 1", "Dr. Lucius Livius Andronicus");
            dt.Rows.Add(2, "", "Type 1", "Dr. Gnaeus Naevius");
            dt.Rows.Add(3, "", "Type 1", "Dr. Quintus Ennius");
            dt.Rows.Add(4, "Osmotherapy", "Type 2", "");
            dt.Rows.Add(4, "", "Type 2", "Dr. Marcus Pacuvius");
            dt.Rows.Add(5, "Prolotherapy", "Type 3", "");
            dt.Rows.Add(5, "", "Type 3", "Dr. Lucius Accius");
            dt.Rows.Add(6, "", "Type 3", "Dr. Titus Maccius Plautus");
            dt.Rows.Add(7, "Helminthic Therapy", "Type 4", "");
            dt.Rows.Add(7, "", "Type 4", "Dr. Publius Terentius Afer (Dr. Terence)");
            dt.Rows.Add(8, "Physiotherapy", "Type 5", "");
            dt.Rows.Add(8, "", "Type 5", "Dr. Marcus Porcius Cato (Dr. Cato the Elder)");
            dt.Rows.Add(9, "", "Type 5", "Dr. Gaius Lucilius");
            dt.Rows.Add(10, "", "Type 5", "Dr. Marcus Tullius Cicero");
            dt.Rows.Add(11, "", "Type 5", "Dr. Publius Ovidius Naso (Dr. Ovid)");
            dt.Rows.Add(11, "", "Type 5", "Dr. Gaius Valerius Catullus");

            return dt;
        }
    }
}