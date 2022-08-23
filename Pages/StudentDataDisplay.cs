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
    public partial class StudentDataDisplay : Form
    {
        Student student;
        Parent parent;
        private string query;
        private static string id;

        OpenNewPage openNewPage = new OpenNewPage();

        public StudentDataDisplay()
        {
            student = new Student();
            parent = new Parent();
            InitializeComponent();
            adjustColumnOrder();
            studentDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            studentDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            studentDataView.BackgroundColor = Home.foreColor;
            topPanel.BackColor = Home.foreColor;
            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                studentDataView.DataSource = DataFromDb.getAllStudentData();
            }
            
            if(Pages.LoginInput.category.Equals("Class Teacher"))
            {
                studentDataView.DataSource = DataFromDb.getAllStudentDataForTeacher();
                searchCb.Items.RemoveAt(2);

                delete.Visible = false;
            }
        }

        

        private void adjustColumnOrder()
        {
            studentDataView.Columns["student_Id"].DisplayIndex = 0;
            studentDataView.Columns["full_name"].DisplayIndex = 1;
            studentDataView.Columns["age"].DisplayIndex = 3;
            studentDataView.Columns["_class"].DisplayIndex = 3;
            studentDataView.Columns["fees_details"].DisplayIndex = 6;
            studentDataView.Columns["gender"].DisplayIndex = 2;
            studentDataView.Columns["view"].DisplayIndex = 6;
            studentDataView.Columns["edit"].DisplayIndex = 7;
            studentDataView.Columns["delete"].DisplayIndex = 8;

            studentDataView.AutoGenerateColumns = false;
            searchCb.SelectedIndex = 0;
        }

        private void reloadDataBtn_Click(object sender, EventArgs e)
        {
            student.show_data(studentDataView);
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
                string parent_id = getParentIdFromSelectedRow();
                string name = row.Cells["full_name"].Value.ToString();


                if (studentDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete " + name + "?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {

                        query = "DELETE FROM Fee WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Student_marks WHERE student_id='" + id + "'";
                        DbClient.query_execute(query); 
                        
                        query = "DELETE FROM Student_result WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Attendance WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM Total_attendance WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM KG_assessment WHERE student_id='" + id + "'";
                        DbClient.query_execute(query);

                        studentDataView.Rows.RemoveAt(e.RowIndex);
                        student.delete(id);
                        parent.delete(parent_id);
                   
                        MessageBox.Show(name + " deleted from system");
                        
                    }

                }

                if (studentDataView.Columns[e.ColumnIndex].Name == "view" && e.RowIndex >= 0)
                {
                    StudentDetail studentDetail = new StudentDetail();
                    studentDetail.Show();
                    Home home = (Home)Application.OpenForms["Home"];
                    home.Hide();
                }

                if (studentDataView.Columns[e.ColumnIndex].Name == "edit")
                {
                    //update data
                    openNewPage.OpenChildForm(new Pages.UpdateStudent(), showDataPanel);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        public static string getIdFromSelectedRow()
        {
            return id;
        }

        public string getParentIdFromSelectedRow()
        {
            try
            {
                query = "SELECT parent_id FROM Student WHERE student_id='" + id + "' AND parent_id IS NOT NULL";
                string parent_id = "";
                System.Data.SqlClient.SqlDataReader reader0 = DbClient.query_reader(query);
                while (reader0.Read())
                {
                    parent_id = reader0["parent_id"].ToString();
                }
                reader0.Close();

                return parent_id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {
                    (studentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchCb.Text + " LIKE '%{0}%'", searchTextBox.Text);
                }catch(Exception ex)
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

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                MessageBox.Show("Student data refreshed");
                studentDataView.DataSource = DataFromDb.getAllStudentData();

            }

            if (Pages.LoginInput.category.Equals("Class Teacher"))
            {
                DataFromDb.getAllStudentForTeacher = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student WHERE class_id='" + DataFromDb.class_id_teacher() + "'");
                MessageBox.Show("Student data refreshed");
                studentDataView.DataSource = DataFromDb.getAllStudentDataForTeacher();
            }
        }
    }

}
