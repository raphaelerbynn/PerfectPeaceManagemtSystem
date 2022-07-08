using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class StudentReport : Form
    {
        private string query;
        private static string id;
        Student student;
        OpenNewPage openNewpage;

        public StudentReport()
        {
            InitializeComponent();
            student = new Student();
            openNewpage = new OpenNewPage();

            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);
            classCb.SelectedIndex = 0;
            
        }

        private void loadListBtn_Click(object sender, EventArgs e)
        {
            resultsDataView.Visible = false;
            studentDataView.Visible = true;

            query = "SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student WHERE class='"+classCb.Text+"'";
            DbClient.dataGridFill(studentDataView, query);
            studentDataView.Visible = true;
            searchBtn.Enabled = true;
            adjustColumnOrder();
        }

        private void adjustColumnOrder()
        {
            studentDataView.Columns["student_Id"].DisplayIndex = 0;
            studentDataView.Columns["full_name"].DisplayIndex = 1;
            studentDataView.Columns["age"].DisplayIndex = 2;
            studentDataView.Columns["_class"].DisplayIndex = 4;
            studentDataView.Columns["fees_details"].DisplayIndex = 5;
            studentDataView.Columns["gender"].DisplayIndex = 3;
            studentDataView.Columns["input_results"].DisplayIndex = 6;

            studentDataView.AutoGenerateColumns = false;


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {
                    (studentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                (studentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void studentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = studentDataView.Rows[e.RowIndex];
                id = row.Cells["student_Id"].Value.ToString();


                if (studentDataView.Columns[e.ColumnIndex].Name == "input_results" && e.RowIndex >= 0)
                {
                    openNewpage.OpenChildForm(new Pages.AddResult(), bgPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string getIdFromSelectedRow()
        {
            return id;
        }

        private void viewResultBtn_Click(object sender, EventArgs e)
        {
            studentDataView.Visible = false;
            resultsDataView.Visible = true;
        }
    }
}
