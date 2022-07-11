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
    public partial class StudentReport : Form
    {
        private string query;
        private static string id;
        private static string termVal;
        private static string date;
        private static string result_id;
        OpenNewPage openNewpage;

        public StudentReport()
        {
            InitializeComponent();
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
            
            resultsDataView.Columns["student_result_idR"].DisplayIndex = 0;
            resultsDataView.Columns["student_nameR"].DisplayIndex = 1;
            resultsDataView.Columns["student_classR"].DisplayIndex = 2;
            resultsDataView.Columns["total_raw_score"].DisplayIndex = 3;
            resultsDataView.Columns["pass_score"].DisplayIndex = 4;
            resultsDataView.Columns["raw_score"].DisplayIndex = 5;
            resultsDataView.Columns["position"].DisplayIndex = 6;
            resultsDataView.Columns["status"].DisplayIndex = 7;
            resultsDataView.Columns["term"].DisplayIndex = 8;
            resultsDataView.Columns["show_result"].DisplayIndex = 9;

            resultsDataView.AutoGenerateColumns = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {
                    if (studentDataView.Visible == true)
                    {
                        (studentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchTextBox.Text);
                    }
                    else
                    {
                        (resultsDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchTextBox.Text); ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                if (studentDataView.Visible == true)
                {
                    (studentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (resultsDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
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

        private void viewResultBtn_Click(object sender, EventArgs e)
        {
            date = datePicker.Text;
            searchBtn.Enabled = true;
            studentDataView.Visible = false;
            resultsDataView.Visible = true;
            if(resultsDataView.Visible == true)
            {
                adjustColumnOrder();
            }
            query = "SELECT student_result_id, student_id, raw_score, pass_raw_score, total_raw_score, class, term, date FROM Student_result WHERE class='"+classCb.Text+ "' AND date LIKE '%"+datePicker.Text+"%'";
            DbClient.dataGridFill(resultsDataView, query);
            getStudentName();
        }

        private void getStudentName()
        {
            try
            {
                foreach (DataGridViewRow item in resultsDataView.Rows)
                {
                    string id = item.Cells["student_idR"].Value.ToString();
                    query = "SELECT [f_name]+' '+[l_name] AS name FROM Student WHERE student_id='" + id + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    resultsDataView.ReadOnly = false;
                    while (reader.Read())
                    {
                        item.Cells["student_nameR"].Value = reader["name"].ToString();
                    }
                    reader.Close();
                    resultsDataView.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void resultsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = resultsDataView.Rows[e.RowIndex];
                id = row.Cells["student_idR"].Value.ToString();
                result_id = row.Cells["student_result_idR"].Value.ToString();
                termVal = row.Cells["term"].Value.ToString();

                if (resultsDataView.Columns[e.ColumnIndex].Name == "show_result" && e.RowIndex >= 0)
                {
                    openNewpage.OpenChildForm(new Pages.ReportCard(), bgPanel);
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

        public static string getTermFromSelectedRow()
        {
            return termVal;
        }

        public static string getDate()
        {
            return date;
        }

        public static string getResultId()
        {
            return result_id;
        }
    }
}
