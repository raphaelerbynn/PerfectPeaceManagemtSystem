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

        public LoginInput()
        {
            InitializeComponent();
            loginAsLbl.Text = LoginAs.loginAsText;
            bgPanel.BackColor = Login.themeColor;
            bgPanel.ForeColor = Login.foreColor;
            loginBtn.ForeColor = Login.themeColor;
            createAccLink.LinkColor = Login.foreColor;
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            OpenNewPage openNewPage = new OpenNewPage();
            openNewPage.OpenChildForm(new Pages.CreateAccount(), bgPanel);
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTb.Text;
                string password = passwordTb.Text;

                query = "SELECT username, email, password FROM User_account WHERE category='"+loginAsLbl.Text+"'";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    if ((username.Equals(reader["username"].ToString()) && password.Equals(reader["password"].ToString())) ||
                        (username.Equals(reader["email"].ToString()) && password.Equals(reader["password"].ToString())))
                    {
                        Console.WriteLine("User is correct");
                        break;
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            OpenNewPage openNewPage = new OpenNewPage();
            openNewPage.OpenChildForm(new Pages.CreateAccount(), bgPanel);
        }
    }
}
