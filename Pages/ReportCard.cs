using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class ReportCard : Form
    {
        private string query;
        private string subject_idR;
        private int no_subject;

        public ReportCard()
        {
            InitializeComponent();
            populateResults();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populateResults()
        {
            query = "SELECT COUNT(*) FROM Student";
            no_subject = int.Parse(DbClient.query_executeScaler(query)) - 1;
            resultDataView.Size = new Size(resultDataView.Width, resultDataView.Height + (30*no_subject));

            query = "SELECT subject_id, name FROM Subject";
            DbClient.dataGridFill(resultDataView, query);
        }
    }
}
