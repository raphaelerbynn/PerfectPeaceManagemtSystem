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

        public Dashboard()
        {
            InitializeComponent();
            getTotals();
            populateEvents();
        }

        private void getTotals()
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

    }
}
