﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public partial class Home : Form
    {
        WaitFunc wait = new WaitFunc();
        OpenNewPage openNewPage = new OpenNewPage();
        private Button currentBtn;
        private int tempIndex;
        private Random random;
        public static Color foreColor;
        public static Color cellColor;
        public static Color searchBgColor;
        public static Color themeColor;
        public static Panel displayPanel;
        public static Button _studentBtn, _teachersBtn, _classBtn;
        string category = Pages.LoginInput.category;
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

            if (category.Equals("Class Teacher"))
            {
                addStntBtn.Visible = false;
                teachersBtn.Enabled = false;
                classesBtn.Enabled = false;
                feesBtn.Enabled = false;
                accountBtn.Enabled = false;
                payrollBtn.Enabled = false;
                subjectBtn.Enabled = false;
                addStntBtn.Enabled = false;
                //parentsBtn.Enabled = false;

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
                if (previousBtn.GetType() == typeof(PictureBox))
                {
                    previousBtn.BackColor = themeColor;
                }
            }

        }

        public void ActivateBtn(object btnSender)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            wait.show(this);
            ActivateBtn(sender);
            openNewPage.OpenChildForm(new Pages.StudentDataDisplay(), panelView);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Student";
            titleLbl.Text = "STUDENTS";
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y + 28);

            if (category.Equals("Class Teacher"))
            {
                addStntBtn.Enabled = false;
            }
                wait.close();
        }

        private void addStntBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {

                if (addStntBtn.Text == "Cancel add student")
                {
                    wait.show(this);
                    new Pages.AddStudent().Close();
                    openNewPage.OpenChildForm(new Pages.StudentDataDisplay(), panelView);
                    addStntBtn.Text = "Add Student";
                    wait.close();
                }
                else if (addStntBtn.Text == "Add Student")
                {
                    wait.show(this);
                    openNewPage.OpenChildForm(new Pages.AddStudent(), panelView);
                    addStntBtn.Text = "Cancel add student";
                    wait.close();
                }

                if (addStntBtn.Text == "Add To Staff")
                {
                    wait.show(this);
                    openNewPage.OpenChildForm(new Pages.AddTeacher(), panelView);
                    addStntBtn.Text = "Cancel add to staff";
                    wait.close();
                }
                else if (addStntBtn.Text == "Cancel add to staff")
                {
                    wait.show(this);
                    new Pages.AddTeacher().Close();
                    openNewPage.OpenChildForm(new Pages.TeacherData(), panelView);
                    addStntBtn.Text = "Add To Staff";
                    wait.close();
                }

                if (addStntBtn.Text == "Add Class")
                {
                    wait.show(this);
                    openNewPage.OpenChildForm(new Pages.AddClass(), panelView);
                    addStntBtn.Text = "Cancel add class";
                    wait.close();
                }
                else if (addStntBtn.Text == "Cancel add class")
                {
                    wait.show(this);
                    new Pages.AddClass().Close();
                    openNewPage.OpenChildForm(new Pages.ClassData(), panelView);
                    addStntBtn.Text = "Add Class";
                    wait.close();
                }

                if (addStntBtn.Text == "Pay Fees")
                {
                    wait.show(this);
                    openNewPage.OpenChildForm(new Pages.FeePaying(), panelView);
                    addStntBtn.Text = "Cancel pay fees";
                    wait.close();
                }
                else if (addStntBtn.Text == "Cancel pay fees")
                {
                    wait.show(this);
                    new Pages.FeePaying().Close();
                    openNewPage.OpenChildForm(new Pages.FeesData(), panelView);
                    addStntBtn.Text = "Pay Fees";
                    wait.close();
                }
                if (addStntBtn.Text == "Add Weekly Report")
                {
                    wait.show(this);
                    openNewPage.OpenChildForm(new Pages.AddParent(), panelView);
                    addStntBtn.Text = "Cancel Add Weekly Report";
                    wait.close();
                }
                else if (addStntBtn.Text == "Cancel Add Weekly Report")
                {
                    wait.show(this);
                    new Pages.AddParent().Close();
                    openNewPage.OpenChildForm(new Pages.ParentsData(), panelView);
                    addStntBtn.Text = "Add Weekly Report";
                    wait.close();
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }

        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {
            wait.show(this);
            ActivateBtn(sender);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add To Staff";
            titleLbl.Text = "STAFF";
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y + 28);
            openNewPage.OpenChildForm(new Pages.TeacherData(), panelView);
            wait.close();
        }

        private void parentsBtn_Click(object sender, EventArgs e)
        {
            wait.show(this);
            ActivateBtn(sender);
            openNewPage.OpenChildForm(new Pages.ParentsData(), panelView);
            addStntBtn.Visible = true;
            titleLbl.Text = "WEEKLY REPORT";
            addStntBtn.Text = "Add Weekly Report";

            if (category.Equals("Class Teacher"))
            {
            
                addStntBtn.Enabled = true;
            }

            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y + 28);
            wait.close();

        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            wait.show(this);
            ActivateBtn(sender);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Add Class";
            titleLbl.Text = "CLASSROOMS";
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y + 28);
            openNewPage.OpenChildForm(new Pages.ClassData(), panelView);
            wait.close();

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                wait.show(this);
                ActivateBtn(sender);
                addStntBtn.Visible = false;
                panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y);
                titleLbl.Text = "DASHBOARD";
                openNewPage.OpenChildForm(new Pages.Dashboard(), panelView);
                wait.close();
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
        }

        private void feesBtn_Click(object sender, EventArgs e)
        {
            wait.show(this);
            ActivateBtn(sender);
            addStntBtn.Visible = true;
            addStntBtn.Text = "Pay Fees";
            titleLbl.Text = "FEES";
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y + 28);
            openNewPage.OpenChildForm(new Pages.FeesData(), panelView);
            wait.close();
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            wait.show(this);
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            titleLbl.Text = "ACCOUNT";
            openNewPage.OpenChildForm(new Pages.Account(), panelView);
            wait.close();
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

            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                wait.show(this);
                ActivateBtn(sender);
                addStntBtn.Visible = false;
                titleLbl.Text = "STUDENT REPORT";
                panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y);
                openNewPage.OpenChildForm(new Pages.StudentReport(), panelView);
                wait.close();
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }

        }

        private void subjectBtn_Click(object sender, EventArgs e)
        {
            wait.show(this);
            ActivateBtn(sender);
            addStntBtn.Visible = false;
            titleLbl.Text = "SUBJECT INFORMATION";
            panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y);
            openNewPage.OpenChildForm(new Pages.AddSubject(), panelView);
            wait.close();
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                wait.show(this);
                ActivateBtn(sender);
                addStntBtn.Visible = false;
                titleLbl.Text = "PAYROLL";
                panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y);
                openNewPage.OpenChildForm(new Pages.Payroll(), panelView);
                wait.close();
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }

        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                wait.show(this);
                ActivateBtn(sender);
                addStntBtn.Visible = false;
                titleLbl.Text = "STUDENT ATTENDANCE";
                panelView.Location = new Point(panelView.Location.X, addStntBtn.Location.Y);
                openNewPage.OpenChildForm(new Pages.Attendance(), panelView);
                wait.close();
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }

        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
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

        private void Home_Load(object sender, EventArgs e)
        {

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
