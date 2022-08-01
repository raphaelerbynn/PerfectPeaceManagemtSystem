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
    public partial class CreateAccount : Form
    {
        private string teacher_id;
        private List<string> system_keys = new List<string>()
        {
            "master$$$perfect_Peace@2022!",
            "master$$$Perfect_Peace$System$@2022"
        };
        private string query;

        public CreateAccount()
        {
            InitializeComponent();
            loginAsLbl.Text = LoginCategory.loginAsText;
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
                query = "SELECT [f_name]+' '+[l_name] FROM Teacher";
                DbClient.query_reader(nameCb, query);
                nameCb.DropDownStyle = ComboBoxStyle.DropDownList;
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
                string name, email, username, password, cPassword, system_key, adminPassword;
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
                name = nameCb.Text;
                email = emailTb.Text;
                username = usernameTb.Text;
                password = passwordTb.Text;
                cPassword = cPasswordTb.Text;
                system_key = systemKeyTb.Text;
                adminPassword = adminPasswordTb.Text;

                if (!password.Equals(cPassword))
                {
                    MessageBox.Show("Passwords does not match", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (category.Equals("Administrator"))
                {
                    if (!checkSysKey(system_key))
                    {
                        MessageBox.Show("Wrong System Key", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                }
                else
                {
                    if (!ckeckValidAdminPassword(adminPassword))
                    {
                        MessageBox.Show("Incorrect Administrator Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Confirm to create this account", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (category.Equals("Class Teacher"))
                    {
                        teacher_id = DbClient.query_executeScaler("SELECT teacher_id FROM Teacher WHERE [f_name]+' '+[l_name]='"+ nameCb.SelectedItem.ToString()+"'");
                        query = "INSERT INTO User_account(name, username, email, category, password, teacher_id)" +
                            "VALUES('" + name + "', '" + username + "', '" + email + "', '" + category + "', '" + password + "', '" + teacher_id + "')";
                    }
                    else
                    {
                        query = "INSERT INTO User_account(name, username, email, category, password)" +
                            "VALUES('" + name + "', '" + username + "', '" + email + "', '" + category + "', '" + password + "')";
                    }
                    DbClient.query_execute(query);

                    MessageBox.Show("Account Created Successfully");
                    this.Close();
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Username already exists");
            }
        }

        private bool checkSysKey(string system_key)
        {
            foreach (string key in system_keys)
            {
                if (key.Equals(system_key))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ckeckValidAdminPassword(string password)
        {
            bool value = false;
            query = "SELECT password FROM User_account WHERE category='Administrator'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                if (password.Equals(reader["password"].ToString()))
                {
                    value = true;
                    break;
                }
            }
            reader.Close();
            return value;
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
