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
    public partial class UpdateStudent : Form
    {
        string query;
        private string id = StudentDataDisplay.getIdFromSelectedRow();
        private string parent_id;
        OpenNewPage openNewPage = new OpenNewPage();
        ClassRoom classroom = new ClassRoom();
        WaitFunc wait = new WaitFunc();

        public UpdateStudent()
        {
            InitializeComponent();
            fillFields();
            registerPanel.BackColor = Home.foreColor;
        }

        private void fillFields()
        {
            string _class = "";
            //Console.WriteLine(StudentDataDisplay.getIdFromSelectedRow());

            query = "SELECT * FROM Student WHERE student_id='" + id + "'";
            System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                fnameTb.Text = reader["f_name"].ToString(); 
                mnameTb.Text = reader["m_name"].ToString(); 
                lnameTb.Text = reader["l_name"].ToString(); 
                dobPicker.Text = reader["dob"].ToString();
                addressTb.Text = reader["address"].ToString();
                parent_id = reader["parent_id"].ToString();

                _class = reader["class"].ToString();
                
                
                //Console.WriteLine(index);

                if (reader["gender"].ToString() == "FEMALE")
                {
                    femaleRadio.Checked = true;
                }
                maleRadio.Checked = true;
                
            }
            reader.Close();
            
            query = "SELECT * FROM Parent WHERE parent_id='" + parent_id + "'";
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                fnamePTb.Text = reader["f_name"].ToString(); 
                lnamePTb.Text = reader["l_name"].ToString(); 
                contactTb.Text = reader["contact"].ToString();
                contact1Tb.Text = reader["contact1"].ToString();
                relationshipCB.Text = reader["relationship"].ToString();
                occupationTb.Text = reader["occupation"].ToString();


                if (reader["gender"].ToString() == "FEMALE")
                {
                    femaleRadioBtn.Checked = true;
                }
                maleRadioBtn.Checked = true;
                
            }
            reader.Close();

            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);

            for(int i = 0; i < classCb.Items.Count; i++)
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
                return "FEMALE";
            }
            return "MALE";
        }
        
        private string getRadioBtnValueParent()
        {
            if (femaleRadioBtn.Checked == true)
            {
                return "FEMALE";
            }
            return "MALE";
        }

        private void updateStntBnt_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            wait.show();
            if (classCb.SelectedIndex > -1)
            {
                string class_id = DbClient.query_executeScaler("SELECT class_id FROM Class WHERE name='" + classCb.SelectedItem.ToString() + "'");
                Console.WriteLine("ccccccccccccccllllllllssss:  "+class_id);
                if (classroom.maxCapacity(classCb.Text) > classroom.curCapacity(classCb.Text))
                {
                    Student student = new Student(dobPicker.Value.Date.ToString(), classCb.Text, fnameTb.Text, mnameTb.Text, lnameTb.Text, addressTb.Text, getRadioBtnValue(), DateTime.Today.Date.ToString());
                    student.update(id);

                    query = "UPDATE Student SET class_id='"+class_id+"', class='"+classCb.SelectedItem.ToString()+"' WHERE student_id='"+id+"'";
                    DbClient.query_execute(query);

                    query = "UPDATE Parent SET f_name='" + fnamePTb.Text + "', l_name='" + lnamePTb.Text + "', contact='" + contactTb.Text + "', contact1='" + contact1Tb.Text + "', relationship='" + relationshipCB.Text + "', occupation='" + occupationTb.Text + "', gender='" + getRadioBtnValueParent() + "' WHERE parent_id='" + parent_id + "'";
                    DbClient.query_execute(query);

                    
                    DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                    
                    wait.close();
                    
                    MessageBox.Show("Student updated successfully");
                }
                else
                {
                    
                    wait.close();
                    
                    MessageBox.Show("Class full!!!");
                }
            }
            else
            {
                Student student = new Student(dobPicker.Value.Date.ToString(), classCb.Text, fnameTb.Text, mnameTb.Text, lnameTb.Text, addressTb.Text, getRadioBtnValue(), DateTime.Today.Date.ToString());
                student.update(id);
                query = "UPDATE Student SET class_id=NULL, class=NULL WHERE student_id='"+id+"'";
                DbClient.query_execute(query);
                
                query = "UPDATE Parent SET f_name='"+fnamePTb.Text+"', l_name='"+lnamePTb.Text+"', contact='"+contactTb.Text+"', contact1='"+contact1Tb.Text+"', relationship='"+relationshipCB.Text+"', occupation='"+occupationTb.Text+"', gender='"+getRadioBtnValueParent()+"' WHERE parent_id='"+parent_id+"'";
                DbClient.query_execute(query);

                
                DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                
                wait.close();
                
                MessageBox.Show("Student updated successfully");
            }
        }

        private void assignNoClassLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            classCb.SelectedIndex = -1;
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
