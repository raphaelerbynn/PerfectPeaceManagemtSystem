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
        private string staffCategory = "";

        public UpdateTeacher()
        {
            InitializeComponent();
            fillFields();
            bgPanel.BackColor = Home.foreColor;

            if (!staffCategory.Equals("Teaching"))
            {
                cLbl.Visible = false;
                asLbl.Visible = false;
                removeClassLink.Visible = false;
                classCb.Visible = false;
            }
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

                bankTb.Text = reader["bank"].ToString();
                accountNumTb.Text = reader["account_number"].ToString();
                ssnitTb.Text = reader["ssnit_number"].ToString();
                tinTb.Text = reader["tin_number"].ToString();

                _class = reader["class_id"].ToString();
                
                if (reader["gender"].ToString() == "Female")
                {
                    femaleRadio.Checked = true;
                }
                maleRadio.Checked = true;

                staffCategory = reader["category"].ToString();
            }
            reader.Close();

            if (staffCategory.Equals("Teaching"))
            {
                query = "SELECT name FROM Class WHERE class_id='" + _class + "'";
                reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    _class = reader["name"].ToString();
                }
                reader.Close();

                query = "SELECT name FROM Class EXCEPT SELECT name FROM Class WHERE teacher_id IS NOT NULL AND teacher_id != '" + id + "'";
                DbClient.query_reader(classCb, query);
                for (int i = 0; i < classCb.Items.Count; i++)
                {
                    if (_class.Equals(classCb.Items[i].ToString()))
                    {
                        classCb.SelectedIndex = i;
                        break;
                    }
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

        private void updateTeacherBnt_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                if (staffCategory.Equals("Teaching"))
                {
                    if (classCb.SelectedIndex != -1)
                    {

                        query = "SELECT class_id FROM Class WHERE name='" + classCb.SelectedItem.ToString() + "'";
                        string class_id = DbClient.query_executeScaler(query).ToString();

                        Teacher teacher = new Teacher(bankTb.Text, accountNumTb.Text, ssnitTb.Text, tinTb.Text, class_id, phoneTB.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, addressTb.Text, getRadioBtnValue(), DateTime.Now);
                        teacher.update(id);

                        query = "UPDATE Class SET teacher_id=NULL WHERE teacher_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "UPDATE Class SET teacher_id='" + id + "' WHERE class_id='" + class_id + "'";
                        DbClient.query_execute(query);


                        MessageBox.Show("Staff Info Updated");
                    }

                    else
                    {
                        //Teacher teacher = new Teacher(bankTb.Text, accountNumTb.Text, ssnitTb.Text, tinTb.Text, null, phoneTB.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, addressTb.Text, getRadioBtnValue(), DateTime.Now);
                        //teacher.update(id);
                        query = "UPDATE Teacher SET class_id=NULL, f_name='" + fnameTb.Text + "', l_name='" + lnameTb.Text + "', gender='" + getRadioBtnValue() + "', phone='" + phoneTB.Text + "', address='" + addressTb.Text + "', email='" + emailTb.Text + "', bank='" + bankTb.Text + "', account_number='" + accountNumTb.Text + "', ssnit_number='" + ssnitTb.Text + "', tin_number='" + tinTb.Text + "', date_updated='" + DateTime.Now + "' WHERE teacher_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "UPDATE Class SET teacher_id=NULL WHERE teacher_id='" + id + "'";
                        DbClient.query_execute(query);

                        MessageBox.Show("Staff Info Updated");
                    }
                }
                else
                {
                    query = "UPDATE Teacher SET class_id=NULL, f_name='" + fnameTb.Text + "', l_name='" + lnameTb.Text + "', gender='" + getRadioBtnValue() + "', phone='" + phoneTB.Text + "', address='" + addressTb.Text + "', email='" + emailTb.Text + "', bank='" + bankTb.Text + "', account_number='" + accountNumTb.Text + "', ssnit_number='" + ssnitTb.Text + "', tin_number='" + tinTb.Text + "', date_updated='" + DateTime.Now + "' WHERE teacher_id='" + id + "'";
                    DbClient.query_execute(query);

                    MessageBox.Show("Staff Info Updated");
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeClassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            classCb.SelectedIndex = -1;
        }
    }
}
