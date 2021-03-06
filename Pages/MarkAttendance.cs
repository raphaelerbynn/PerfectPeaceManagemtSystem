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
        private string query;
        public MarkAttendance()
        {
            InitializeComponent();
            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);
            populateData();
            todayDateLbl.Text = "("+DateTime.Now.ToString("ddd, dd MMMM, yyyy")+")";
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
            try
            {
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
                        else
                        {
                            status = "Absent";
                        }

                        query = "INSERT INTO Attendance(student_id, class, status, date_marked)" +
                        "VALUES('" + id + "', '" + classCb.Text + "', '" + status + "', '" + DateTime.Today + "')";
                        DbClient.query_execute(query);
                    }
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
