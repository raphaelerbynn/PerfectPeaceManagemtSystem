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
            string _class = "";
            query = "SELECT * FROM Teacher WHERE teacher_id ='" + id + "'";
            System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                fnameTb.Text = reader["f_name"].ToString();
                lnameTb.Text = reader["l_name"].ToString();
                phoneTB.Text = reader["phone"].ToString();
                emailTb.Text = reader["email"].ToString();
                addressTb.Text = reader["address"].ToString();

                _class = reader["class"].ToString();
                
                if (reader["gender"].ToString() == "Female")
                {
                    femaleRadio.Checked = true;
                }
                maleRadio.Checked = true;
            }
            reader.Close();

            query = "SELECT name FROM Class EXCEPT SELECT name FROM Class WHERE teacher_id IS NOT NULL";
            DbClient.query_reader(classCb, query);
            for (int i = 0; i < classCb.Items.Count; i++)
            {
                if (_class == classCb.Items[i].ToString())
                {
                    classCb.SelectedIndex = i;
                    Console.WriteLine(i);
                    break;
                }
            }

        }

        private string getRadioBtnValue()
        {
            if (femaleRadio.Checked == true)
            {
                return "Female";
            }
            return "Male";
        }

        private void clearFeildBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateTeacherBnt_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher(classCb.Text, phoneTB.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, addressTb.Text, getRadioBtnValue(), DateTime.Now);
                teacher.update(id);

                MessageBox.Show("Teacher Info Updated");
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
