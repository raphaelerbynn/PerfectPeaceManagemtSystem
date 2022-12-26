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
    public partial class AddStudent : Form
    {
        WaitFunc wait = new WaitFunc();
        OpenNewPage openNewPage = new OpenNewPage();
        ClassRoom classroom = new ClassRoom();
        public static string class_name = "";

        string query;

        public AddStudent()
        {
            InitializeComponent();
            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);
            registerPanel.BackColor = Home.foreColor;

            maleRadio.Checked = true;
            maleRadioBtn.Checked = true;
        } 

        private string getRadioBtnValueS()
        {
            if (femaleRadio.Checked == true)
            {
                return "FEMALE";
            }
            return "MALE";
        }

        private string getRadioBtnValueP()
        {
            if (femaleRadioBtn.Checked == true)
            {
                return "FEMALE";
            }
            return "MALE";
        }

        public void clearFeilds()
        {
            fnameTb.Text = null;
            mnameTb.Text = null;
            lnameTb.Text = null;
            dobPicker.Text = null;
            addressTb.Text = null;
            femaleRadio.Checked = false;
            classCb.SelectedIndex = -1;

            fnameTb.Text = null;
            lnameTb.Text = null;
            maleRadioBtn.Checked = true;
            contactTb.Text = null;
            contact1Tb.Text = null;
            relationshipCB.SelectedIndex = -1;
        }

        private void registerStntBnt_Click(object sender, EventArgs e)
        {
            
        }










        private void classCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dobPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mnameTb_TextChanged(object sender, EventArgs e)
        {
            childCB.Items.Clear();
            childCB.Items.Add(fnameTb.Text + " " + mnameTb.Text + " " + lnameTb.Text);
            childCB.SelectedIndex = 0;
        }

        private void lnameTb_TextChanged(object sender, EventArgs e)
        {
            childCB.Items.Clear();
            childCB.Items.Add(fnameTb.Text + " " + mnameTb.Text + " " + lnameTb.Text);
            childCB.SelectedIndex = 0;
        }

        private void addressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearFeildBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void fnameTb_TextChanged(object sender, EventArgs e)
        {
            childCB.Items.Clear();
            childCB.Items.Add(fnameTb.Text + " " + mnameTb.Text + " " +lnameTb.Text);
            childCB.SelectedIndex = 0;
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
                wait.show(this);
                string class_id = "", fees_owned = "";

                query = "SELECT * FROM Class WHERE name='" + classCb.Text + "'";
                System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    class_id = reader["class_id"].ToString();
                    fees_owned = reader["fees"].ToString();
                }
                reader.Close();
                Student student;
                if (classCb.SelectedIndex > -1)
                {
                    student = new Student(
                        dobPicker.Value.Date.ToString(), classCb.Text, 0.00f, float.Parse(fees_owned), class_id,
                        fnameTb.Text, mnameTb.Text, lnameTb.Text, addressTb.Text,
                        getRadioBtnValueS(), DateTime.Today.Date.ToString()
                        );
                }
                else
                {
                    student = new Student(
                        dobPicker.Value.Date.ToString(), classCb.Text,
                        fnameTb.Text, mnameTb.Text, lnameTb.Text, addressTb.Text,
                        getRadioBtnValueS(), DateTime.Today.Date.ToString()
                        );
                }
                //


                if (String.IsNullOrWhiteSpace(fnameTb.Text) ||
                    String.IsNullOrWhiteSpace(lnameTb.Text) ||
                    String.IsNullOrWhiteSpace(dobPicker.Text) ||
                    String.IsNullOrWhiteSpace(addressTb.Text) ||
                    //parent fields
                    String.IsNullOrWhiteSpace(fnamePTb.Text) ||
                    String.IsNullOrWhiteSpace(lnamePTb.Text) ||
                    String.IsNullOrWhiteSpace(contactTb.Text) ||
                    String.IsNullOrWhiteSpace(relationshipCB.Text))
                {
                    wait.close();
                    MessageBox.Show("Fields with * must be filled!");
                    
                }
                else
                {
                    //wait.show(this);
                    if (classCb.SelectedIndex > -1 || !String.IsNullOrEmpty(classCb.Text))
                    {
                        if (classroom.maxCapacity(classCb.Text) > classroom.curCapacity(classCb.Text))
                        {

                            student.save();
                            /*MessageBox.Show("Student Saved");
                            clearFeilds();
                            openNewPage.OpenChildForm(new Pages.AddParent(), registerPanel);*/
                        }
                        else
                        {
                            MessageBox.Show("Class full!!!");
                        }
                    }
                    else
                    {
                        student.saveWithoutClass();
                        //MessageBox.Show("Student Saved");
                        //clearFeilds();
                        //openNewPage.OpenChildForm(new Pages.AddParent(), registerPanel);
                    }

                    Person parent = new Parent(contactTb.Text, contact1Tb.Text, relationshipCB.Text, occupationTb.Text, fnamePTb.Text, lnamePTb.Text, getRadioBtnValueP(), DateTime.Today.Date.ToString());
                    parent.save();

                    query = "UPDATE Student SET parent_id=" + DbClient.GetLastId("Parent") + " WHERE student_id=" + DbClient.GetLastId("Student");
                    DbClient.query_execute(query);
                    clearFeilds();
                    //DataFromDb.getAllParent = DbClient.dataSource("SELECT parent_id,contact,gender,relationship, [f_name]+' '+[l_name] AS name FROM Parent");

                    DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                    DataFromDb.totalStudents = DbClient.query_executeScaler("SELECT COUNT(*) FROM Student");
                    wait.close();
                    MessageBox.Show("Student Registered");
                }
                //wait.close();
            }
            catch (Exception ex)
            {
                wait.close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
