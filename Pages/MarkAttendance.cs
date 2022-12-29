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
    public partial class MarkAttendance : Form
    {
        WaitFunc wait = new WaitFunc();
        private string query;
        private DateTime _date = Attendance.getDate();
        public MarkAttendance()
        {
            InitializeComponent();
            populateData();
            //todayDateLbl.Text = "("+DateTime.Now.ToString("ddd, dd MMMM, yyyy")+")";
            todayDateLbl.Text = "("+_date.ToString("ddd, dd MMMM, yyyy")+")";

            attendancePanel.BackColor = Home.foreColor;
            checkAttendanceDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            checkAttendanceDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            checkAttendanceDataView.BackgroundColor = Home.foreColor;

            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                query = "SELECT name FROM Class";
                DbClient.query_reader(classCb, query);
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

        private void populateData()
        {
            query = "SELECT student_id, student_id AS roll_id, [f_name]+' '+[l_name] AS name FROM Student WHERE Class='" + classCb.Text + "'";
            DbClient.dataGridFill(checkAttendanceDataView, query);
            
            int roll = 1;
            foreach (DataGridViewRow item in checkAttendanceDataView.Rows)
            {
                item.Cells["student_roll"].Value = roll;
                roll++;
            }

        }

        private void classCb_TextChanged(object sender, EventArgs e)
        {
            populateData();
        }

        private void checkAttendanceDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = checkAttendanceDataView.Rows[e.RowIndex];
                if (checkAttendanceDataView.Columns[e.ColumnIndex].Name == "present_check" && e.RowIndex >= 0)
                {
                    if(Convert.ToBoolean(row.Cells["absent_check"].Value) == true)
                    {
                        row.Cells["absent_check"].Value = false;
                    }
                }
                
                if (checkAttendanceDataView.Columns[e.ColumnIndex].Name == "absent_check" && e.RowIndex >= 0)
                {
                    if(Convert.ToBoolean(row.Cells["present_check"].Value) == true)
                    {
                        row.Cells["present_check"].Value = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void saveAttendanceBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                wait.show();
                DateTime date_end = DateTime.Today;
                query = "SELECT end_date FROM Term";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    date_end = DateTime.Parse(reader["end_date"].ToString());
                }
                reader.Close();

                query = "DELETE FROM Attendance WHERE class='" + classCb.Text + "' AND date_marked='" + _date + "'";
                DbClient.query_execute(query);

                string message = "Save today's attendance?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in checkAttendanceDataView.Rows)
                    {
                        string id = row.Cells["student_id"].Value.ToString();
                        string status;
                        if (Convert.ToBoolean(row.Cells["present_check"].Value) == true)
                        {
                            status = "Present";
                        }
                        else if(Convert.ToBoolean(row.Cells["absent_check"].Value) == true)
                        {
                            status = "Absent";
                        }
                        else
                        {
                            MessageBox.Show("Please mark all attendance", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        query = "INSERT INTO Attendance(student_id, class, status, date_marked, date_end)" +
                        "VALUES('" + id + "', '" + classCb.Text + "', '" + status + "', '" + _date + "', '" + date_end + "')";
                        DbClient.query_execute(query);
                    }
                    wait.close();
                    this.Close();
                }
            }catch(Exception ex)
            {
                wait.close();
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
