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
            wait.close();
        }


        private void registerParent_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }

            foreach(DataGridViewRow row in reportView.Rows)
            {
                query = "INSERT INTO Teachers_weekly_report (subject, number_exercises, home_assignment, dictation, project_work, reading_assignment, topics_covered, group_work, week, date, class, teacher_id) " +
                    "VALUES('" + row.Cells[subject.Name] + "', '" + row.Cells[number_exercises.Name] + "', '" + row.Cells[home_assignment.Name] + "', '" + row.Cells[diction.Name] + "', '" + row.Cells[project_work.Name] + "', '" + row.Cells[reading_assignment.Name] + "', '" + row.Cells[topics_covered.Name] + "', '" + row.Cells[group_work.Name] + "', '"+weekTb.Text+"', '', '"+DateTime.Now+"', '"+classCb.Text+"', '"+teacher_id+"')";
                DbClient.query_execute(query);
            }
            
            this.Close();
            this.Hide();
        }

        private void clearFeild_Click(object sender, EventArgs e)
        {
            clearFeild();
        }

        private void clearFeild()
        {
            reportView.Rows.Clear();
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
