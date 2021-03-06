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
    public partial class TeacherData : Form
    {
        private static string id;
        private Teacher teacher;

        OpenNewPage openNewPage = new OpenNewPage();

        public TeacherData()
        {
            teacher = new Teacher();
            InitializeComponent();
            topPanel.BackColor = Home.foreColor;
            teacherDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            teacherDataGridView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            teacherDataGridView.BackgroundColor = Home.foreColor;

            adjustColumnOrder();
            teacher.show_data(teacherDataGridView);
            getClassName();
        }

        private void adjustColumnOrder()
        {
            teacherDataGridView.AutoGenerateColumns = false;

            teacherDataGridView.Columns["teacher_id"].DisplayIndex = 0;
            teacherDataGridView.Columns["name"].DisplayIndex = 1;
            teacherDataGridView.Columns["phone"].DisplayIndex = 2;
            teacherDataGridView.Columns["email"].DisplayIndex = 3;
            teacherDataGridView.Columns["_class"].DisplayIndex = 4;
            teacherDataGridView.Columns["view"].DisplayIndex = 5;
            teacherDataGridView.Columns["edit"].DisplayIndex = 6;
            teacherDataGridView.Columns["delete"].DisplayIndex = 7;

            searchCb.SelectedIndex = 0;
        }

        private void teacherDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = teacherDataGridView.Rows[e.RowIndex];
                id = row.Cells["teacher_id"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();


                if (teacherDataGridView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete " + name + "?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        teacherDataGridView.Rows.RemoveAt(e.RowIndex);
                        teacher.delete(id);

                        MessageBox.Show(name + " deleted from system");
                    }
                }

                if (teacherDataGridView.Columns[e.ColumnIndex].Name == "view" && e.RowIndex >= 0)
                {
                    TeacherDetails details = new TeacherDetails();
                    details.Show();
                    Home home = (Home)Application.OpenForms["Home"];
                    home.Hide();
                }

                if (teacherDataGridView.Columns[e.ColumnIndex].Name == "edit" && e.RowIndex >= 0)
                {
                    //update data
                    teacherDataGridView.Visible = false;
                    openNewPage.OpenChildForm(new Pages.UpdateTeacher(), showDataPanel);
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

        private void TeacherData_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {
                    (teacherDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchCb.Text + " LIKE '%{0}%'", searchTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                (teacherDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void getClassName()
        {
            foreach(DataGridViewRow row in teacherDataGridView.Rows)
            {
                string query = "SELECT name FROM Class WHERE class_id='" + row.Cells["_class"].Value.ToString() + "'";
                System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    row.Cells["_class"].Value = reader["name"].ToString();
                }
                reader.Close();
            }
        }
    }
}
