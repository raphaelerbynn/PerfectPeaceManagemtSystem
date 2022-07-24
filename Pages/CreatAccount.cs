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
    public partial class CreateAccount : Form
    {
        private List<string> system_keys = new List<string>()
        {
            "master$$$perfect_Peace@2022!",
            "master$$$Perfect_Peace$System$@2022"
        };
        private string query;

        public CreateAccount()
        {
            InitializeComponent();
            loginAsLbl.Text = LoginAs.loginAsText;
            bgPanel.BackColor = Login.themeColor;
            bgPanel.ForeColor = Login.foreColor;
            createAccBtn.ForeColor = Login.themeColor;

            if (loginAsLbl.Text.Equals("Administrator")){
                adminPasswordLbl.Visible = false;
                adminPasswordTb.Visible = false;
                viewAdminPassword.Visible = false;
            }
            else
            {
                systemKeyTb.Text = "Not needed";
                systemKeyTb.PasswordChar = '\0';
                systemKeyTb.Enabled = false;
            }
        }

        private void backLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string category = loginAsLbl.Text;
                string name, email, username, password, cPassword, system_key;
                foreach(Control c in bgPanel.Controls)
                {
                    if(c is TextBox && c.Visible == true)
                    {
                        if (String.IsNullOrEmpty(((TextBox)c).Text))
                        {
                            c.BackColor = Color.LightCoral;
                            MessageBox.Show("This feild must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            c.BackColor = DefaultBackColor;
                        }
                        
                    }
                }
                name = nameTb.Text;
                email = emailTb.Text;
                username = usernameTb.Text;
                password = passwordTb.Text;
                cPassword = cPasswordTb.Text;
                system_key = systemKeyTb.Text;

                if (!password.Equals(cPassword))
                {
                    MessageBox.Show("Passwords does not match", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                query = "INSERT INTO User_account(name, username, email, category, password)" +
                    "VALUES('', '', '', '', '')";
                
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

        private void viewConfirmPassword_Click(object sender, EventArgs e)
        {
            if (cPasswordTb.PasswordChar == '\0')
            {
                cPasswordTb.PasswordChar = '*';
            }
            else
            {
                cPasswordTb.PasswordChar = '\0';
            }
        }

        private void viewSysKey_Click(object sender, EventArgs e)
        {
            if(systemKeyTb.Enabled == true)
            {
                if (systemKeyTb.PasswordChar == '\0')
                {
                    systemKeyTb.PasswordChar = '*';
                }
                else
                {
                    systemKeyTb.PasswordChar = '\0';
                }
            }
        }

        private void viewAdminPassword_Click(object sender, EventArgs e)
        {
            if (adminPasswordTb.PasswordChar == '\0')
            {
                adminPasswordTb.PasswordChar = '*';
            }
            else
            {
                adminPasswordTb.PasswordChar = '\0';
            }
        }
    }
}
