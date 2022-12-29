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
    public partial class EditUserDetails : Form
    {
        WaitFunc wait = new WaitFunc();
        public EditUserDetails()
        {
            InitializeComponent();
            this.BackColor = Home.foreColor;
            fillData();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            UsersDetails details = (UsersDetails)Application.OpenForms["UsersDetails"];
            details.Show();
        }

        private void fillData()
        {
            try
            {

                string query = "SELECT * FROM User_account WHERE username='" + UsersDetails.user + "'";
                System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    usernameTb.Text = reader["username"].ToString();
                    emailTb.Text = reader["email"].ToString();
                    passwordTb.Text = reader["password"].ToString();
                    nameCb.Text = reader["name"].ToString();
                }
                reader.Close();
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                string message = "Are you sure you want to change user details?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {
                    Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
                    confirmPassword.ShowDialog();
                    if (GetData.getConfirmedPassword() == true)
                    {
                        wait.show();
                        string query = "UPDATE User_account SET name='" + nameCb.Text + "', email='" + emailTb.Text + "', password='" + passwordTb.Text + "' WHERE username='" + UsersDetails.user + "'";
                        DbClient.query_execute(query);

                        
                        this.Close();
                        UsersDetails details = (UsersDetails)Application.OpenForms["UsersDetails"];
                        details.Show();

                        GetData.setConfirmPassword(false);
                        wait.close();
                        MessageBox.Show("Account Updated");
                    }
                }
            }catch(Exception ex)
            {
                wait.close();
                MessageBox.Show("Check details, maybe it may exist already");
                Console.WriteLine(ex);
            }
        }
    }
}
