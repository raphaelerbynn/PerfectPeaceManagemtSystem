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
    public partial class LoginCategory : Form
    {
        OpenNewPage openNewPage;
        public static string loginAsText;
        public LoginCategory()
        {
            InitializeComponent();
            loginAsPanel.BackColor = Login.themeColor;
            adminLink.LinkColor = Login.foreColor;
            classTeacherLink.LinkColor = Login.foreColor;
            accountantLink.LinkColor = Login.foreColor;
        }

        private void adminLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openNewPage = new OpenNewPage();
            Control control = sender as Control;
            if(control.Name == "adminLink")
            {
                loginAsText = control.Text;
            }
            else if(control.Name == "classTeacherLink")
            {
                loginAsText = control.Text;
            }
            else
            {
                loginAsText = control.Text;
            }
            openNewPage.OpenChildForm(new Pages.LoginInput(), loginAsPanel);
        }
    }
}
