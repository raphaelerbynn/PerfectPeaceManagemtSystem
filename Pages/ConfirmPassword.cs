﻿using System;
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
    public partial class ConfirmPassword : Form
    {
        static string username = Pages.LoginInput.username;
        private string query;
        private string password;
        WaitFunc wait = new WaitFunc();
        public ConfirmPassword()
        {
            InitializeComponent();
        }

        public bool passwordConfirmed()
        {
            wait.show();
            bool val = false;
            password = passwordTb.Text;
            query = "SELECT username, email, password FROM User_account WHERE username='"+username+"'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                Console.WriteLine(username);
                Console.WriteLine(password);
                Console.WriteLine(reader["username"].ToString());
                if ((username.Equals(reader["username"].ToString()) && password.Equals(reader["password"].ToString())) ||
                    (username.Equals(reader["email"].ToString()) && password.Equals(reader["password"].ToString())))
                {
                    val = true;
                    break;
                }
            }
            reader.Close();
            wait.close();
            return val;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (passwordConfirmed() == true)
            {
                GetData.setConfirmPassword(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Password Incorrect");
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
