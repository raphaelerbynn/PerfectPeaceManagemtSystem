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
                string message = "Are you sure you want to save all attendance for the term?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {
                    Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
                    confirmPassword.ShowDialog();
                    if (GetData.getConfirmedPassword() == true)
                    {
                        query = "INSERT INTO Total_Attendance (student_id, present, attendance, term_end_date) " +
                        "SELECT " +
                        "student_id, " +
                        "SUM(CASE WHEN status='Present' THEN 1 ELSE 0 END) AS present, " +
                        "COUNT(status) AS attendance, " +
                        "MAX(date_end) AS term_end_date " +
                        "FROM Attendance " +
                        "GROUP BY student_id";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Attendance";
                        DbClient.query_execute(query);
                        /*SqlDataReader reader = DbClient.query_reader(query);
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["test"].ToString() + ":" + reader["student_id"].ToString() +":"+ reader["present"].ToString());
                        }
                        reader.Close();*/

                        //query = "SELECT "

                        MessageBox.Show("Total Attendance saved... can print report with total attendance now");
                        GetData.setConfirmPassword(false);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void saveDateBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to set next term end date?";
            MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", deleteAction);
            if (result == DialogResult.Yes)
            {
                Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
                confirmPassword.ShowDialog();
                if (GetData.getConfirmedPassword() == true)
                {

                    query = "DELETE FROM Term";
                    DbClient.query_execute(query);

                    query = "INSERT INTO Term (end_date) VALUES('" + endDatePk.Value + "')";
                    DbClient.query_execute(query);
                    endDatePk.Enabled = false;

                    MessageBox.Show("Term end date resetted...");
                    
                }
            }
            
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

        private void feesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure you want to reset student fees for next term?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {
                    Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
                    confirmPassword.ShowDialog();
                    if (GetData.getConfirmedPassword() == true)
                    {
                        query = "UPDATE Student SET fees_owing=fees_owing+(SELECT fees FROM Class WHERE Class.class_id=Student.class_id) WHERE class_id IS NOT NULL";
                        DbClient.query_execute(query);

                        MessageBox.Show("Fees resetted...");
                        GetData.setConfirmPassword(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Are you sure you want to end this term?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {
                    Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
                    confirmPassword.ShowDialog();
                    if (GetData.getConfirmedPassword() == true)
                    {
                        query = "DELETE FROM EVENT";
                        DbClient.query_execute(query);

                        MessageBox.Show("Term Ended... Set end of next term date");
                        GetData.setConfirmPassword(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}
