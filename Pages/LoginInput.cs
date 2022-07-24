﻿using System;
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
    public partial class LoginInput : Form
    {
        public LoginInput()
        {
            InitializeComponent();
            loginAsLbl.Text = LoginAs.loginAsText;
            bgPanel.BackColor = Login.themeColor;
            bgPanel.ForeColor = Login.foreColor;
            loginBtn.ForeColor = Login.themeColor;
            createAccBtn.ForeColor = Login.themeColor;
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
    }
}