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
    public partial class Term : Form
    {
        private string query;

        public Term()
        {
            InitializeComponent();
            bgPanel.BackColor = Home.themeColor;
            prevDate();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
        }

        private void saveAttenceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int totalPresent = 0;
                int totalAttendance = 0;
                string student_id;
                
                query = "INSERT INTO Total_Attendance (student_id, present, attendance, term_end_date) " +
                    "SELECT " +
                    "student_id, " +
                    "SUM(CASE WHEN status='Present' THEN 1 ELSE 0 END) AS present, " +
                    "COUNT(status) AS attendance, " +
                    "MAX(date_end) AS term_end_date " +
                    "FROM Attendance " +
                    "GROUP BY student_id";
                //query = "SELECT status INTO Total_attendance FROM Attendance";
                DbClient.query_execute(query);
                /*SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    Console.WriteLine(reader["test"].ToString() + ":" + reader["student_id"].ToString() +":"+ reader["present"].ToString());
                }
                reader.Close();*/

                //query = "SELECT "

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void saveDateBtn_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM Term";
            DbClient.query_execute(query);

            query = "INSERT INTO Term (end_date) VALUES('"+endDatePk.Value+"')";
            DbClient.query_execute(query);
            endDatePk.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            endDatePk.Enabled=true;
        }

        private void prevDate()
        {
            try
            {
                query = "SELECT end_date FROM Term";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    endDatePk.Text = reader["end_date"].ToString();
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
