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
    public partial class UpdateTeacher : Form
    {
        string query;
        private string id = TeacherData.getIdFromSelectedRow();

        public UpdateTeacher()
        {
            InitializeComponent();
            fillFields();
        }

        private void fillFields()
        {
            query = "SELECT * FROM Teacher WHERE teacher_id ='" + id + "'";
            System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                fnameTb.Text = reader["f_name"].ToString();
                lnameTb.Text = reader["l_name"].ToString();
                phoneTB.Text = reader["phone"].ToString();
                emailTb.Text = reader["email"].ToString();
                addressTb.Text = reader["address"].ToString();
                
                if (reader["gender"].ToString() == "Female")
                {
                    femaleRadio.Checked = true;
                }
                maleRadio.Checked = true;
            }
            reader.Close();

        }

        private void clearFeildBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateTeacherBnt_Click(object sender, EventArgs e)
        {

        }

        
    }
}
