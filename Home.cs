﻿using System;
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
    public partial class Home : Form
    {
        OpenNewPage openNewPage = new OpenNewPage();
        private Button currentBtn;
        private int tempIndex;
        private Random random;
        public static Color foreColor;
        public static Color cellColor;
        public static Color themeColor;
        public static Panel displayPanel;
        public static Button _studentBtn, _teachersBtn, _classBtn;
        //public extern bool ReleaseCapture();

        public Home()
        {
            InitializeComponent();

            random = new Random();
            schNameLbl.Text = "Perfect Peace \nInt. School";
            schNameLbl.BackColor = Color.Transparent;
            displayPanel = panelView;
            logo.BackColor = Color.Transparent;
            logoutLink.BackColor = Color.Transparent;
            _studentBtn = studentBtn;
            _teachersBtn = teachersBtn;
            _classBtn = classesBtn;
            ActivateBtn(dashboardBtn);
            openNewPage.OpenChildForm(new Pages.Dashboard(), panelView);
            
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y);
            user_details();

            //user accessibility
            string category = Pages.LoginInput.category;
            if(category.Equals("Class Teacher"))
            {
                addStntBtn.Visible = false;
                teachersBtn.Enabled = false;
                classesBtn.Enabled = false;
                feesBtn.Enabled = false;
                accountBtn.Enabled = false;
                payrollBtn.Enabled = false;
                subjectBtn.Enabled = false;

                teach_pic.Enabled = false;
                class_pic.Enabled = false;
                feees_pic.Enabled = false;
                acc_pic.Enabled = false;
                payroll_pic.Enabled = false;
                subject_pic.Enabled = false;
            }

            if (category.Equals("Accountant"))
            {
                addStntBtn.Visible = false;
                studentBtn.Enabled = false;
                teachersBtn.Enabled = false;
                parentsBtn.Enabled = false;
                classesBtn.Enabled = false;
                subjectBtn.Enabled = false;
                attendanceBtn.Enabled = false;
                reportBtn.Enabled = false; 

                stu_pic.Enabled = false;
                teach_pic.Enabled = false;
                parent_pic.Enabled = false;
                class_pic.Enabled = false;
                subject_pic.Enabled = false;
                att_pic.Enabled = false;
                report_pic.Enabled = false;
            }

        }

        private void DisableBtn()
        {
            themeColor = SelectedThemeColor();
            foreach (Control previousBtn in menuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {

                    previousBtn.BackColor = themeColor;
                    previousBtn.ForeColor = Color.White;
                    //previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                if(previousBtn.GetType() == typeof(PictureBox))
                {
                    previousBtn.BackColor = themeColor;
                }
            }
            
        }

        public void ActivateBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableBtn();
                    
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = foreColor;
                    currentBtn.ForeColor = themeColor;
                    line1.BackColor = themeColor;
                    line2.BackColor = themeColor;
                    line3.BackColor = themeColor;
                    logoPanel.BackColor = Color.FromArgb((int)(themeColor.A * 0.7), themeColor);
                    logoutLink.LinkColor = themeColor;
                    menuPanel.BackColor = themeColor;
                    this.BackColor = foreColor;

                    panelView.BackColor = Color.FromArgb((int)(foreColor.A * 0.8), foreColor);
                    topPanel.BackColor = Color.FromArgb((int)(foreColor.A * 0.8), foreColor);
                    //bgPanel.BackColor = Color.FromArgb((int)(foreColor.A * 0.8), foreColor);
                    //panelLogo.BackColor = Color.FromArgb(color.A, (int)(color.R * 0.8), (int)(color.G * 0.8), (int)(color.B * 0.8));

                    foreach (Control picBox in menuPanel.Controls)
                    {
                        if (picBox.GetType() == typeof(PictureBox))
                        {
                            if (picBox.Tag == currentBtn.Tag)
                            {
                                picBox.BackColor = foreColor;
                            }
                        }
                    }

                }
            }
        }

        private Color SelectedThemeColor()
        {
            int index = random.Next(ThemeColor.darkColors.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.darkColors.Count);
            }
            tempIndex = index;
            string themeColor = ThemeColor.darkColors[index];
            foreColor = ColorTranslator.FromHtml(ThemeColor.lightColors[index]);
            cellColor = ColorTranslator.FromHtml(ThemeColor.cellColors[index]);

            return ColorTranslator.FromHtml(themeColor);
        }




        private void studentBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            openNewPage.OpenChildForm(new Pages.StudentDataDisplay(), panelView);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Student";
            titleLbl.Text = "STUDENTS";
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

            if (addStntBtn.Text == "Pay Fees")
            {
                openNewPage.OpenChildForm(new Pages.FeePaying(), panelView);
                addStntBtn.Text = "Cancel pay fees";
            }
            else if (addStntBtn.Text == "Cancel pay fees")
            {
                new Pages.AddClass().Close();
                openNewPage.OpenChildForm(new Pages.FeesData(), panelView);
                addStntBtn.Text = "Pay Fees";
            }


        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Teacher";
            titleLbl.Text = "TEACHERS";

            openNewPage.OpenChildForm(new Pages.TeacherData(), panelView);
        }

        private void parentsBtn_Click(object sender, EventArgs e)
        {
                
                
                ActivateBtn(sender);
            openNewPage.OpenChildForm(new Pages.ParentsData(), panelView);
            addStntBtn.Visible = true;
            titleLbl.Text = "PARENTS";
            addStntBtn.Text = "Send Message";
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y + 28);
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Class";
            titleLbl.Text = "CLASSROOMS";
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y + 28);
            openNewPage.OpenChildForm(new Pages.ClassData(), panelView);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y);
            titleLbl.Text = "DASHBOARD";
            openNewPage.OpenChildForm(new Pages.Dashboard(), panelView);
        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Event";
            titleLbl.Text = "EVENTS";
            openNewPage.OpenChildForm(new Pages.AddEvent(), panelView);
        }

        private void feesBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Pay Fees";
            titleLbl.Text = "FEES";
            openNewPage.OpenChildForm(new Pages.FeesData(), panelView);
        }
        
        private void accBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            titleLbl.Text = "ACCOUNT";
            openNewPage.OpenChildForm(new Pages.Account(), panelView);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close the application?";
            MessageBoxButtons action = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", action);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            titleLbl.Text = "STUDENT REPORT";
            openNewPage.OpenChildForm(new Pages.StudentReport(), panelView);
        }

        private void subjectBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            titleLbl.Text = "SUBJECT INFORMATION";
            openNewPage.OpenChildForm(new Pages.AddSubject(), panelView);
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            titleLbl.Text = "PAYROLL";
            openNewPage.OpenChildForm(new Pages.Payroll(), panelView);
        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            titleLbl.Text = "STUDENT ATTENDANCE";
            openNewPage.OpenChildForm(new Pages.Attendance(), panelView);
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Do you want to logout?";
            MessageBoxButtons action = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", action);
            if (result == DialogResult.Yes)
            {
                 this.Close();
                Login login = (Login)Application.OpenForms["Login"];
                login.Show();
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void user_details()
        {
            try
            {
                categoryLbl.Text = Pages.LoginInput.category;
                usernameLbl.Text = Pages.LoginInput.username;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
