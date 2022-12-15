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

        public AddParent()
        {
            InitializeComponent();
            //get_child_name();
            classDetailsOnStudent();
            bpPanel.BackColor = Home.foreColor;
        }

        

        private void classDetailsOnStudent()
        {
            string class_id = "", fees_owned="";

            query = "SELECT * FROM Class WHERE name='"+AddStudent.class_name+"'";
            System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                class_id = reader["class_id"].ToString();
                fees_owned = reader["fees"].ToString();
            }
            reader.Close();

            Console.WriteLine();
            query = "UPDATE Student SET fees_owing='"+fees_owned+"', class_id='"+class_id+"' WHERE class='"+AddStudent.class_name+"' AND class != ''";
            DbClient.query_execute(query);
        }


        private void registerParent_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            //Person parent = new Parent(contactTb.Text, contact1Tb.Text, relationshipCB.Text, occupationTb.Text, fnameTb.Text, lnameTb.Text, getRadioBtnValue(), DateTime.Today.Date.ToString());
            //parent.save();

            query = "UPDATE Student SET parent_id=" + DbClient.GetLastId("Parent") + " WHERE student_id=" + DbClient.GetLastId("Student");
            DbClient.query_execute(query);
            MessageBox.Show("Parent Registered");
            //DataFromDb.getAllParent = DbClient.dataSource("SELECT parent_id,contact,gender,relationship, [f_name]+' '+[l_name] AS name FROM Parent");
            this.Close();
            this.Hide();
        }

        private void clearFeild_Click(object sender, EventArgs e)
        {
            clearFeild();
        }

        private void clearFeild()
        {
            /*fnameTb.Text = null;
            lnameTb.Text = null;
            maleRadioBtn.Checked = true;
            contactTb.Text = null;
            contact1Tb.Text = null;
            relationshipCB.SelectedIndex = -1;*/

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
