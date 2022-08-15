using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class LoginInput : Form
    {
        private string query;
        public static string username;
        public static string category;
        public static string teacher_id;
        public static bool logged_in = false;

        public LoginInput()
        {
            InitializeComponent();
            loginAsLbl.Text = LoginCategory.loginAsText;
            bgPanel.BackColor = Login.themeColor;
            bgPanel.ForeColor = Login.foreColor;
            loginBtn.ForeColor = Login.themeColor;
            createAccLink.LinkColor = Login.foreColor;
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            OpenNewPage openNewPage = new OpenNewPage();
            openNewPage.OpenChildForm(new Pages.CreateAccount(), bgPanel);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (InternetConnectivity.checkConnectivity())
            {

                try
                {
                    category = loginAsLbl.Text;
                    username = usernameTb.Text;
                    string password = passwordTb.Text;

                    if (String.IsNullOrEmpty(usernameTb.Text))
                    {
                        usernameTb.BackColor = Color.LightCoral;
                        MessageBox.Show("Username missing", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        usernameTb.BackColor = DefaultBackColor;
                    }

                    if (String.IsNullOrEmpty(passwordTb.Text))
                    {
                        usernameTb.BackColor = Color.LightCoral;
                        MessageBox.Show("Password missing", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        passwordTb.BackColor = DefaultBackColor;
                    }


                    if (checkUserDetails(username, password) == true)
                    {
                        if (category.Equals("Administrator"))
                        {
                            DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                            DataFromDb.getAllTeacher = DbClient.dataSource("SELECT teacher_id,phone,email, (SELECT name FROM Class WHERE Class.class_id=Teacher.class_id) AS class, [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Teaching'");
                            DataFromDb.getAllNonTeacher = DbClient.dataSource("SELECT teacher_id,phone,email, staff_position, [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Non-Teaching'");
                            DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                            DataFromDb.getAllClass = DbClient.dataSource("SELECT class_id, name, section, capacity, fees, teacher_id, (SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE Teacher.teacher_id=Class.teacher_id) AS teacher FROM Class");
                            DataFromDb.getExpenses = DbClient.dataSource("");
                        }
                        else if (category.Equals("Class Teacher"))
                        {
                            DataFromDb.getAllStudentForTeacher = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student WHERE class_id='" + DataFromDb.class_id_teacher() + "'");
                        }
                        else
                        {
                            
                        }
                        DataFromDb.getAllEvent = DbClient.dataSource("SELECT event_id, name, description, FORMAT(date, 'dd-MM-yyyy') AS date, CONVERT(VARCHAR(10), CAST(time AS TIME), 0) AS time FROM Event");

                        wrongMeesageLbl.Visible = false;
                        Login login = (Login)Application.OpenForms["Login"];
                        login.Hide();

                        Home home = new Home();
                        home.Show();

                        usernameTb.Text = null;
                        passwordTb.Text = null;
                    }
                    else
                    {
                        wrongMeesageLbl.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
            
        }

        private void viewPassword_Click(object sender, EventArgs e)
        {
            if(passwordTb.PasswordChar == '\0')
            {
                passwordTb.PasswordChar = '*';
            }
            else
            {
                passwordTb.PasswordChar = '\0';
            }
        }

        private void createAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            OpenNewPage openNewPage = new OpenNewPage();
            openNewPage.OpenChildForm(new Pages.CreateAccount(), bgPanel);
        }

        private bool checkUserDetails(string usrname, string password)
        {

            try
            {
                bool value = false;
                query = "SELECT username, email, password, teacher_id FROM User_account WHERE category='" + loginAsLbl.Text + "'";
                SqlDataReader reader = DbClient.query_reader(query);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        if ((usrname.Equals(reader["username"].ToString()) && password.Equals(reader["password"].ToString())) ||
                            (usrname.Equals(reader["email"].ToString()) && password.Equals(reader["password"].ToString())))
                        {
                            value = true;
                            teacher_idLbl.Text = reader["teacher_id"].ToString();
                            teacher_id = reader["teacher_id"].ToString();
                            break;
                        }
                    }
                    reader.Close();
                }
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return false;
            }
            
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
