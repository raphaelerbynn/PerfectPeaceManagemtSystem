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
    public partial class AddParent : Form
    {
        private string query;
        WaitFunc wait = new WaitFunc();
        string teacher_id = LoginInput.teacher_id;

        public AddParent()
        {
            InitializeComponent();
            bpPanel.BackColor = Home.foreColor;
            loadClassrooms();
        }

        private void loadClassrooms()
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            wait.show();
            classCb.Items.Clear();
            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);

            subject.DataSource = DbClient.dataSource("SELECT name FROM Subject");
            subject.DisplayMember = "name";

            wait.close();
        }


        private void registerParent_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                wait.show();
                foreach (DataGridViewRow row in reportView.Rows)
                {
                    if (row.Cells[subject.Name].Value != null)
                    {
                        int count = int.Parse(DbClient.query_executeScaler("SELECT COUNT(*) FROM Teachers_weekly_report " +
                            "WHERE subject='"+ row.Cells[subject.Name].Value + "' AND " +
                            "week='"+weekTb.Text+"' AND " +
                            "date='"+DateTime.Now+"' AND " +
                            "class='"+classCb.Text+"' AND " +
                            "teacher_id='"+teacher_id+"'"));

                        if (count > 0)
                        {
                            query = "UPDATE Teachers_weekly_report SET " +
                                "subject='" + row.Cells[subject.Name].Value + "', " +
                                "number_exercises='" + row.Cells[number_exercises.Name].Value + "', " +
                                "home_assignment='" + row.Cells[home_assignment.Name].Value + "', " +
                                "dictation='" + row.Cells[diction.Name].Value + "', " +
                                "project_work='" + row.Cells[project_work.Name].Value + "', " +
                                "reading_assignment='" + row.Cells[reading_assignment.Name].Value + "', " +
                                "topics_covered='" + row.Cells[topics_covered.Name].Value + "', " +
                                "group_work='" + row.Cells[group_work.Name].Value + "', " +
                                "week='" + weekTb.Text + "', " +
                                "date='" + DateTime.Now + "', " +
                                "class='" + classCb.Text + "', " +
                                "teacher_id='" + teacher_id + "' " +
                                 "WHERE subject='" + row.Cells[subject.Name].Value + "' AND " +
                            "week='" + weekTb.Text + "' AND " +
                            "date='" + DateTime.Now + "' AND " +
                            "class='" + classCb.Text + "' AND " +
                            "teacher_id='" + teacher_id + "'";
                            DbClient.query_execute(query);
                        }
                        else
                        {
                            query = "INSERT INTO Teachers_weekly_report " +
                                "(subject, " +
                                "number_exercises, " +
                                "home_assignment, " +
                                "dictation, " +
                                "project_work, " +
                                "reading_assignment, " +
                                "topics_covered, " +
                                "group_work, " +
                                "week, " +
                                "date, " +
                                "class, " +
                                "teacher_id) " +
                                "VALUES('" + row.Cells[subject.Name].Value + "', " +
                                "'" + row.Cells[number_exercises.Name].Value + "', " +
                                "'" + row.Cells[home_assignment.Name].Value + "', " +
                                "'" + row.Cells[diction.Name].Value + "', " +
                                "'" + row.Cells[project_work.Name].Value + "', " +
                                "'" + row.Cells[reading_assignment.Name].Value + "', " +
                                "'" + row.Cells[topics_covered.Name].Value + "', " +
                                "'" + row.Cells[group_work.Name].Value + "', " +
                                "'" + weekTb.Text + "', " +
                                "'" + DateTime.Now + "', " +
                                "'" + classCb.Text + "', " +
                                "'" + teacher_id + "')";
                            DbClient.query_execute(query);
                        }
                    }
                    
                }
                MessageBox.Show("Report saved");
                wait.close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFeild_Click(object sender, EventArgs e)
        {
            clearFeild();
        }

        private void clearFeild()
        {
            reportView.Rows.Clear();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
