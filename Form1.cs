using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public partial class Form1 : Form
    {
        OpenNewPage openNewPage = new OpenNewPage();

        public Form1()
        {
            InitializeComponent();
            openNewPage.OpenChildForm(new Pages.Dashboard(), panelView);
        }

        

        private void studentBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new Pages.StudentDataDisplay(), panelView);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Student";
        }

        private void addStntBtn_Click(object sender, EventArgs e)
        {
            if (addStntBtn.Text == "Cancel add student")
            {
                new Pages.AddStudent().Close();
                openNewPage.OpenChildForm(new Pages.StudentDataDisplay(), panelView);
                addStntBtn.Text = "Add Student";
            }
            else if(addStntBtn.Text == "Add Student")
            {
                openNewPage.OpenChildForm(new Pages.AddStudent(), panelView);
                addStntBtn.Text = "Cancel add student";
            }

            if(addStntBtn.Text == "Add Teacher")
            {
                openNewPage.OpenChildForm(new Pages.AddTeacher(), panelView);
                addStntBtn.Text = "Cancel add teacher";
            }
            else if (addStntBtn.Text == "Cancel add teacher")
            {
                new Pages.AddTeacher().Close();
                openNewPage.OpenChildForm(new Pages.TeacherData(), panelView);
                addStntBtn.Text = "Add Teacher";
            }

            if (addStntBtn.Text == "Send Message")
            {
               
            }

            if (addStntBtn.Text == "Add Class")
            {
                openNewPage.OpenChildForm(new Pages.AddClass(), panelView);
                addStntBtn.Text = "Cancel add class";
            }
            else if (addStntBtn.Text == "Cancel add class")
            {
                new Pages.AddClass().Close();
                openNewPage.OpenChildForm(new Pages.ClassData(), panelView);
                addStntBtn.Text = "Add Class";
            }


        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Teacher";
            openNewPage.OpenChildForm(new Pages.TeacherData(), panelView);
        }

        private void parentsBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new Pages.ParentsData(), panelView);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Send Message";
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Class";
            openNewPage.OpenChildForm(new Pages.ClassData(), panelView);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new Pages.Dashboard(), panelView);
        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Event";
            openNewPage.OpenChildForm(new Pages.AddEvent(), panelView);
        }

        private void feesBtn_Click(object sender, EventArgs e)
        {
            addStntBtn.Visible = false;
            addStntBtn.Text = "Pay Fee";
            openNewPage.OpenChildForm(new Pages.FeePaying(), panelView);
        }
    }
}
