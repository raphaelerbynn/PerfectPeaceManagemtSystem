using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perfect_Peace_System.Pages
{
    public partial class Attendance : Form
    {
        private string query;
        private static DateTime _date;

        public Attendance()
        {
            InitializeComponent();
            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                query = "SELECT name FROM Class";
                DbClient.query_reader(classCb, query);
            }
            attendanceDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            attendanceDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            attendanceDataView.BackgroundColor = Home.foreColor;

            attendancePanel.BackColor = Home.foreColor;

            if(Pages.LoginInput.category.Equals("Class Teacher"))
            {
                query = "SELECT name FROM Class WHERE teacher_id='"+Pages.LoginInput.teacher_id+"' AND teacher_id IS NOT NULL";
                DbClient.query_reader(classCb, query);

                if(classCb.Items.Count > 0) 
                {
                    classCb.SelectedIndex = 0;
                }
               
                classCb.Enabled = false;
            }
        }

        public static DateTime getDate()
        {
            return _date;
        }

        private void loadAttendanceBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                if (classCb.SelectedIndex != -1)
                {
                    query = "SELECT student_id, CAST(student_id AS VARCHAR(60)) AS name, status FROM Attendance WHERE class='"+classCb.Text+"' AND date_marked='"+attendanceDatePk.Text+"'";
                    DbClient.dataGridFill(attendanceDataView, query);

                    int totalPresent = 0;
                    int totalAbsent = 0;
                    int roll = 1;
                    foreach (DataGridViewRow row in attendanceDataView.Rows)
                    {
                        string student_id = row.Cells["student_name"].Value.ToString();
                        string statusValue = row.Cells["status"].Value.ToString();
                        Console.WriteLine(statusValue);
                        if (statusValue.Contains("Present"))
                        {
                            totalPresent++;
                            row.Cells["status"].Style.ForeColor = Color.Green;
                        }
                        if (statusValue.Contains("Absent"))
                        {
                            totalAbsent++;
                            row.Cells["status"].Style.ForeColor = Color.Red;
                        }
                        query = "SELECT [f_name]+' '+[m_name]+' '+[l_name] AS name FROM Student WHERE student_id='"+student_id+"'";
                        SqlDataReader reader = DbClient.query_reader(query);
                        while (reader.Read())
                        {
                            row.Cells["student_name"].Value = reader["name"].ToString();
                            row.Cells["student_roll"].Value = roll;
                        }
                        reader.Close();
                        roll++;
                    }

                    totalPresentLbl.Text = totalPresent.ToString();
                    totalAbsentLbl.Text = totalAbsent.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void attendanceDataView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void checkAttendanceBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            _date = attendanceDatePk.Value;
            OpenNewPage openNewPage = new OpenNewPage();
            openNewPage.OpenChildForm(new Pages.MarkAttendance(), attendancePanel);
        }
    }
}
