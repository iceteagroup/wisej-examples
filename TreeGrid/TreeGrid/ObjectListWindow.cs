using System;
using TreeGrid.Model;
using Wisej.Web;

namespace TreeGrid
{
    public partial class ObjectListWindow : Form
    {
        public ObjectListWindow()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            var therapyList = TherapyList.Instance();
            var therapistList = TherapistList.Instance();

            foreach (var therapy in therapyList)
            {
                dataGridView.Rows.Add(therapy.TherapyId, therapy.TherapyName, "");

                var currentTherapyRow = dataGridView.Rows[dataGridView.RowCount - 1];
                currentTherapyRow[1].Style.ColSpan = 2;

                foreach (var therapist in therapistList)
                {
                    if (therapist.TherapyId == therapy.TherapyId)
                    {
                        dataGridView.Rows.Add(therapist.TherapyId, "", therapist.TherapistName);
                        dataGridView.Rows[dataGridView.RowCount - 1].ParentRow = currentTherapyRow;
                    }
                }

                currentTherapyRow.Collapse();
            }
        }
    }
}