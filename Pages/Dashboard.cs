using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perfect_Peace_System.Pages
{
    public partial class Dashboard : Form
    {
        private string query;
        OpenNewPage openNewPage;
        

        public Dashboard()
        {
            InitializeComponent();
            openNewPage = new OpenNewPage();
            

            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            Resolution objFormResizer = new Resolution();
            objFormResizer.ResizeForm(this, screenHeight, screenWidth);
            panelBg.BackColor = Home.foreColor;
            feesPanel.BackColor = Home.themeColor;
            eventPanel.BackColor = Home.themeColor;
            feesListView.BackColor = Home.foreColor;
            eventListView.BackColor = Home.foreColor;
            feesLbl.ForeColor = Home.foreColor;
            eventLink.LinkColor = Home.foreColor;
            getTotals();
            populateEvents();
            populateFees();
            loadDataToDounutChat();

            //accessibility
            if(LoginInput.category.Equals("Class Teacher"))
            {
                teacherPanel.Enabled = false;
            }

            if (LoginInput.category.Equals("Accountant"))
            {
                studentPanel.Enabled = false;
                teacherPanel.Enabled = false;
                classPanel.Enabled = false;
            }


            if (Pages.LoginInput.category.Equals("Administrator"))
            {
                termBtn.Visible = true;
                usersBtn.Visible = true;
            }
        }

        private void getTotals()
        {
            try
            {
                /*query = "SELECT COUNT(*) FROM Student";
                string totalStudents = DbClient.query_executeScaler(query);*/
                lblTotalStnt.Text = DataFromDb.totalStudents;

                /*query = "SELECT COUNT(*) FROM Teacher";
                string totalTeachers = DbClient.query_executeScaler(query);*/
                lbltotalTeachers.Text = DataFromDb.totalTeachers;

                /*query = "SELECT COUNT(*) FROM Class";
                string totalRooms = DbClient.query_executeScaler(query);*/
                lblTotoalRooms.Text = DataFromDb.totalRooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populateEvents()
        {
            eventListView.View = View.Details;
            query = "SELECT TOP 5 name, CONVERT(VARCHAR(10), CAST(time AS TIME), 0) AS time, FORMAT(date, 'dd-MM-yyyy') AS date FROM Event ORDER BY event_id DESC";
            SqlDataReader reader = DbClient.query_reader(query);
            //SqlDataReader reader = DataFromDb.eventReader;
            if (reader != null)
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["name"].ToString());
                    item.SubItems.Add(reader["date"].ToString());
                    item.SubItems.Add(reader["time"].ToString());

                    item.SubItems[0].Font = new Font("Calibri", 12, FontStyle.Bold);
                    item.SubItems[1].Font = new Font("Calibri", 12, FontStyle.Bold);
                    item.SubItems[2].Font = new Font("Calibri", 12, FontStyle.Bold);
                    item.UseItemStyleForSubItems = false;
                    eventListView.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void populateFees()
        {
            feesListView.View = View.Details;
            query = "SELECT * FROM Student  WHERE fees_owing>0 ORDER BY fees_owing DESC";
            SqlDataReader reader = DbClient.query_reader(query);
            //SqlDataReader reader = DataFromDb.feesReader;
            if (reader != null)
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["f_name"].ToString() + " " + reader["l_name"].ToString());
                    item.SubItems.Add(reader["class"].ToString());
                    item.SubItems.Add(reader["fees_owing"].ToString());
                    item.SubItems[2].ForeColor = Color.Red;

                    item.SubItems[0].Font = new Font("Calibri", 12, FontStyle.Bold);
                    item.SubItems[1].Font = new Font("Calibri", 12, FontStyle.Bold);
                    item.SubItems[2].Font = new Font("Calibri", 12, FontStyle.Bold);
                    item.UseItemStyleForSubItems = false;
                    feesListView.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void loadDataToDounutChat()
        {
            try
            {
                List<string> classes = new List<string>();
                Dictionary<string, string> classDict = new Dictionary<string, string>();


                //string sub_query = "SELECT COUNT(" + reader["class_id"].ToString() + ") FROM Students";
                //string classTotal = DbClient.query_executeScaler(sub_query);

                query = "SELECT * FROM Class";
                SqlDataReader reader = DbClient.query_reader(query);
                //SqlDataReader reader = DataFromDb.classReader;
                if (reader != null)
                {
                    while (reader.Read())
                    {

                        classes.Add(reader["name"].ToString());
                        classDict.Add(reader["name"].ToString(), reader["class_id"].ToString());
                        //Console.WriteLine(this.classChart.Legends);
                    }
                    reader.Close();
                }

                for (int i = 0; i < classes.Count; i++)
                {
                    string sub_query = "SELECT COUNT(*) FROM Student WHERE class='" + classes[i] + "'";
                    int classTotal = int.Parse(DbClient.query_executeScaler(sub_query));
                    Console.WriteLine(classDict[classes[i]]);

                    if (classTotal > 0)
                    {
                        this.classChart.Series["Class"].Points.AddXY(classes[i], classTotal);
                    }

                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }

            //this.classChart.Series["Class"].Points.AddXY(reader["name"], classTotal);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Test 1");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void panelBg_Click(object sender, EventArgs e)
        {
            this.Close();
            //openNewPage.OpenChildForm(new Pages.StudentDataDisplay(), Form1.displayPanel);
            //form1.studentBtn_Click(sender, e);

        }

        private void studentPanel_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            this.Close();
            openNewPage.OpenChildForm(new Pages.StudentDataDisplay(), Home.displayPanel);
        }
        
        private void teacherPanel_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            this.Close();
            openNewPage.OpenChildForm(new Pages.TeacherData(), Home.displayPanel);
        }
        
        private void classPanel_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            this.Close();
            openNewPage.OpenChildForm(new Pages.ClassData(), Home.displayPanel);
        }

        private void feesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            this.Close();
            openNewPage.OpenChildForm(new Pages.FeesData(), Home.displayPanel);
        }

        private void eventLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            this.Close();
            openNewPage.OpenChildForm(new Pages.EventData(), Home.displayPanel);
        }

        private void termBtn_Click(object sender, EventArgs e)
        {
            Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
            confirmPassword.ShowDialog();
            if (GetData.getConfirmedPassword() == true)
            {
                Home home = (Home)Application.OpenForms["Home"];
                home.Hide();
                Pages.Term term = new Pages.Term();
                term.Show();
                GetData.setConfirmPassword(false);
            }

        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
            confirmPassword.ShowDialog();
            if (GetData.getConfirmedPassword() == true)
            {
                Home home = (Home)Application.OpenForms["Home"];
                home.Hide();
                Pages.UsersDetails users = new Pages.UsersDetails();
                users.Show();

                GetData.setConfirmPassword(false);
            }
        }
    }
}
