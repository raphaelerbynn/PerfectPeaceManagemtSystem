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

        private void populateResults()
        {
            query = "SELECT COUNT(*) FROM Student";
            no_subject = int.Parse(DbClient.query_executeScaler(query));
            int length_of_subject = 30 * no_subject;
            resultDataView.Size = new Size(resultDataView.Width, resultDataView.Height + length_of_subject);

            query = "SELECT subject_id, name FROM Subject";
            DbClient.dataGridFill(resultDataView, query);

            remarksPanel.Location = new Point(remarksPanel.Location.X, remarksPanel.Location.Y + length_of_subject);
            printBtn.Location = new Point(printBtn.Location.X, printBtn.Location.Y + length_of_subject);
            //reportCardPanel.Size = new Size(reportCardPanel.Width, reportCardPanel.Height + remarksPanel.Height);
        }

        private void resultDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }

        private void interestLbl_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
