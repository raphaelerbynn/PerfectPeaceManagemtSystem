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
            get_child_name();
            classDetailsOnStudent();
        }

        private void get_child_name()
        {
            query = "SELECT [f_name]+' '+[l_name] FROM Student WHERE student_id=" + DbClient.GetLastId("Student");
            DbClient.query_reader(childCB, query);
            childCB.SelectedIndex = 0;

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
            query = "UPDATE Student SET fees_owing='"+fees_owned+"', class_id='"+class_id+"' WHERE class='"+AddStudent.class_name+"'";
            DbClient.query_execute(query);
        }

        private string getRadioBtnValue()
        {
            if (femaleRadioBtn.Checked == true)
            {
                return "female";
            }
            return "male";
        }

        private void registerParent_Click(object sender, EventArgs e)
        {
            Person parent = new Parent(contactTb.Text, contact1Tb.Text, relationshipCB.Text, fnameTb.Text, lnameTb.Text, getRadioBtnValue(), DateTime.Now);
            parent.save();

            query = "UPDATE Student SET parent_id=" + DbClient.GetLastId("Parent") + " WHERE student_id=" + DbClient.GetLastId("Student");
            DbClient.query_execute(query);
            MessageBox.Show("Parent Registered");

            this.Close();
            this.Hide();
        }
    }
}
