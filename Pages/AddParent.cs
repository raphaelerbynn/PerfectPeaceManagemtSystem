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
        public AddParent()
        {
            InitializeComponent();

            get_child_name();

            
        }

        private void get_child_name()
        {
            string query = "SELECT [f_name]+' '+[l_name] FROM Student WHERE student_id=" + DbClient.GetLastId("Student");
            DbClient.query_reader(childCB, query);
            childCB.SelectedIndex = 0;
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

            string query = "UPDATE Student SET parent_id=" + DbClient.GetLastId("Parent") + " WHERE student_id=" + DbClient.GetLastId("Student");
            DbClient.query_execute(query);
            MessageBox.Show("Parent Registered");

            this.Close();
            this.Hide();
        }
    }
}
