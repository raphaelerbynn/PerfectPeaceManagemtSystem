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
        OpenNewPage openNewPage = new OpenNewPage();
        //Form1 form1 = new Form1();

        public Dashboard()
        {
            InitializeComponent();
            
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            Resolution objFormResizer = new Resolution();
            objFormResizer.ResizeForm(this, screenHeight, screenWidth);
            panelBg.BackColor = Form1.themeColor;
            getTotals();
            populateEvents();
            loadDataToDounutChat();
        }

        private void getTotals()
        {
            try
            {
                query = "SELECT COUNT(*) FROM Student";
                string totalStudents = DbClient.query_executeScaler(query);
                lblTotalStnt.Text = totalStudents;

                query = "SELECT COUNT(*) FROM Teacher";
                string totalTeachers = DbClient.query_executeScaler(query);
                lbltotalTeachers.Text = totalTeachers;

                query = "SELECT COUNT(*) FROM Class";
                string totalRooms = DbClient.query_executeScaler(query);
                lblTotoalRooms.Text = totalRooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populateEvents()
        {
            eventListView.Columns.Clear();
            eventListView.Items.Clear();
            eventListView.View = View.Details;

            eventListView.Columns.Add("Name");
            eventListView.Columns.Add("Description");
            eventListView.Columns.Add("Time");
            eventListView.Columns.Add("Date");

            query = "SELECT TOP 5 * FROM Event ORDER BY event_id DESC";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[3].ToString());
                eventListView.Items.Add(item);
            }
            reader.Close();

        }

        private void loadDataToDounutChat()
        {
            List<string> classes = new List<string>();
            Dictionary<string, string> classDict = new Dictionary<string, string>();
            

            //string sub_query = "SELECT COUNT(" + reader["class_id"].ToString() + ") FROM Students";
            //string classTotal = DbClient.query_executeScaler(sub_query);

            query = "SELECT * FROM Class";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {

                classes.Add(reader["name"].ToString());
                classDict.Add(reader["name"].ToString(),  reader["class_id"].ToString());
                //Console.WriteLine(this.classChart.Legends);
            }
            reader.Close();
            
            for(int i = 0; i < classes.Count; i++)
            {
                string sub_query = "SELECT COUNT(*) FROM Student WHERE class='" + classes[i]+"'";
                int classTotal = int.Parse(DbClient.query_executeScaler(sub_query));
                Console.WriteLine(classDict[classes[i]]);

                if (classTotal  > 0)
                {
                    this.classChart.Series["Class"].Points.AddXY(classes[i], classTotal);
                }

            }

            //this.classChart.Series["Class"].Points.AddXY(reader["name"], classTotal);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Test 1");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
