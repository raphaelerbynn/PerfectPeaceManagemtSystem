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
        private static string termVal = "";
        private static string date = "";
        private static string result_id = "";
        private static string class_position = "";
        private static string section;
        private static string className;
        OpenNewPage openNewpage;
        WaitFunc wait = new WaitFunc();

        public StudentReport()
        {
            InitializeComponent();
            openNewpage = new OpenNewPage();

            resultsDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            resultsDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            resultsDataView.BackgroundColor = Home.foreColor;

            studentDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            studentDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            studentDataView.BackgroundColor = Home.foreColor;

            kgDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            kgDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            kgDataView.BackgroundColor = Home.foreColor;

            topPanel.BackColor = Home.themeColor;
            middlePanel.BackColor = Home.foreColor;
            bgPanel.BackColor = Home.foreColor;

            foreach (Control c in topPanel.Controls)
            {
                if (c.Tag?.ToString() == "top" && c.Tag.ToString() != null)
                {
                    c.ForeColor = Home.foreColor;
                }
            }

            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                query = "SELECT name FROM Class";
                DbClient.query_reader(classCb, query);
                if (classCb.Items.Count > 0)
                {
                    classCb.SelectedIndex = 0;
                }
            }

            if (Pages.LoginInput.category.Equals("Class Teacher"))
            {
                query = "SELECT name FROM Class WHERE teacher_id='" + Pages.LoginInput.teacher_id + "' AND teacher_id IS NOT NULL";
                DbClient.query_reader(classCb, query);

                if (classCb.Items.Count > 0)
                {
                    classCb.SelectedIndex = 0;
                }
                classCb.Enabled = false;
            }
        }

        private void loadListBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            wait.show();
            titleLbl.Visible = true;
            titleLbl.Text = "CLASS LIST";
            explainTb.Visible = false;
            resultsDataView.Visible = false;
            kgDataView.Visible = false;
            studentDataView.Visible = true;

            query = "SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student WHERE class='"+classCb.Text+"'";
            DbClient.dataGridFill(studentDataView, query);
            studentDataView.Visible = true;
            searchBtn.Enabled = true;
            adjustColumnOrder();
            wait.close();
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
                    else if(resultsDataView.Visible == true)
                    {
                        (resultsDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchTextBox.Text); ;
                    }
                    else
                    {
                        (kgDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchTextBox.Text); ;
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
                else if(resultsDataView.Visible == true)
                {
                    (resultsDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    (kgDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                }
            }
        }

        private string getClassSection()
        {
            try
            {
                query = "SELECT section FROM Class WHERE name='" + classCb.SelectedItem.ToString() + "'";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    section = reader["section"].ToString();
                }
                reader.Close();

                return section;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void studentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = studentDataView.Rows[e.RowIndex];
                id = row.Cells["student_Id"].Value.ToString();

                if (studentDataView.Columns[e.ColumnIndex].Name == "input_results" && e.RowIndex >= 0)
                {
                    if (getClassSection().Equals("Crech") || 
                        getClassSection().Equals("Nursury") ||
                        getClassSection().Equals("KG"))
                    {
                        wait.show();
                        openNewpage.OpenChildForm(new Pages.ReportForKG(), bgPanel);
                        wait.close();
                    }
                    else
                    {
                        wait.show();
                        openNewpage.OpenChildForm(new Pages.AddResult(), bgPanel);
                        wait.close();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void viewResultBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            wait.show();
            titleLbl.Visible = true;
            titleLbl.Text = "RESULTS";
            explainTb.Visible = true;
            date = datePicker.Text;
            if(resultsDataView.Visible == true)
            searchBtn.Enabled = true;
            studentDataView.Visible = false;

            if (getClassSection().Equals("Crech") ||
                        getClassSection().Equals("Nursury") ||
                        getClassSection().Equals("KG"))
            {
                resultsDataView.Visible = false;
                kgDataView.Visible = true;
                query = "SELECT student_id, CAST(student_id AS VARCHAR(100)) AS name, class, term, date FROM KG_assessment WHERE class='" + classCb.Text + "' AND date LIKE '%" + datePicker.Text + "%' AND term='" + getSelectedTerm() + "' GROUP BY student_id, term, date, class";
                DbClient.dataGridFill(kgDataView, query);
                getStudentNameKg();
            }
            else
            {
                kgDataView.Visible=false;
                resultsDataView.Visible = true;
                {
                    adjustColumnOrder();
                }
                query = "SELECT student_result_id, student_id, raw_score, pass_raw_score, total_raw_score, result_status, class, term, date, RANK() OVER(ORDER BY raw_score DESC) AS position FROM Student_result WHERE class='" + classCb.Text + "' AND date LIKE '%" + datePicker.Text + "%' AND term='" + getSelectedTerm() + "'";
                DbClient.dataGridFill(resultsDataView, query);
                getStudentName();
            }
            wait.close();
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
        
        private void getStudentNameKg()
        {
            try
            {
                foreach (DataGridViewRow item in kgDataView.Rows)
                {
                    string id = item.Cells["student_id_kg"].Value.ToString();
                    query = "SELECT [f_name]+' '+[l_name] AS name FROM Student WHERE student_id='" + id + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    kgDataView.ReadOnly = false;
                    while (reader.Read())
                    {
                        item.Cells["student_name_kg"].Value = reader["name"].ToString();
                    }
                    reader.Close();
                    kgDataView.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void resultsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = resultsDataView.Rows[e.RowIndex];
                id = row.Cells["student_idR"].Value.ToString();
                result_id = row.Cells["student_result_idR"].Value.ToString();
                termVal = row.Cells["term"].Value.ToString();
                class_position = row.Cells["position"].Value.ToString();

                if (resultsDataView.Columns[e.ColumnIndex].Name == "show_result" && e.RowIndex >= 0)
                {
                    wait.show();
                    openNewpage.OpenChildForm(new Pages.ReportCard(), bgPanel);
                    wait.close();
                }
                if (kgDataView.Columns[e.ColumnIndex].Name == "delete_kg" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete result?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        wait.show();
                        query = "DELETE FROM Student_result WHERE student_id='" + id + "' AND term='" + termVal + "' AND class='" + className + "' AND date LIKE '%" + date + "%'";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Student_marks WHERE student_id='" + id + "' AND term='" + termVal + "' AND class='" + className + "' AND date LIKE '%" + date + "%'";
                        DbClient.query_execute(query);
                        wait.close();
                        MessageBox.Show("Result deleted");
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        public static string getClassCategory()
        {
            return section;
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
        
        public static string getClassName()
        {
            return className;
        }

        public static string getClassPosition()
        {
            if (class_position.EndsWith("11") || class_position.EndsWith("12") || class_position.EndsWith("13"))
            {
                return class_position + " TH";
            }
            else if (class_position.EndsWith("1"))
            {
                return class_position + " ST";
            }else if (class_position.EndsWith("2"))
            {
                return class_position + " ND";
            }else if (class_position.EndsWith("3"))
            {
                return class_position + " RD";
            }
            return class_position + " TH";
        }

        private string getSelectedTerm()
        {
            if (term1Radio.Checked == true)
            {
                return "1";
            }
            if(term2Radio.Checked == true)
            {
                return "2";
            }
            return "3";
        }

        private void kgDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = kgDataView.Rows[e.RowIndex];
                id = row.Cells["student_id_kg"].Value.ToString();
                termVal = row.Cells["term_kg"].Value.ToString();
                className = row.Cells["student_class_kg"].Value.ToString();

                if (kgDataView.Columns[e.ColumnIndex].Name == "show_result_kg" && e.RowIndex >= 0)
                {
                    wait.show();
                    openNewpage.OpenChildForm(new Pages.ReportCard(), bgPanel);
                    wait.close();
                }
                if (kgDataView.Columns[e.ColumnIndex].Name == "delete_kg" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete result?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        wait.show();
                        query = "DELETE FROM KG_assessment WHERE student_id='" + id + "' AND term='" + termVal + "' AND class='" + className + "' AND date LIKE '%" + date + "%'";
                        DbClient.query_execute(query);
                        
                        
                        wait.close();
                        MessageBox.Show("Result deleted");
                    }
                }
            }
            catch (Exception ex)
            {
                wait.close();
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}
