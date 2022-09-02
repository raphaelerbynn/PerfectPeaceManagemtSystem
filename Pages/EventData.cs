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
    public partial class EventData : Form
    {
        private string query;
        public EventData()
        {
            InitializeComponent();
            eventDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            eventDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            eventDataView.BackgroundColor = Home.foreColor;
            bgPanel.BackColor = Home.foreColor;
            addEventLink.LinkColor = Home.themeColor;
            eventDataView.DataSource = DataFromDb.getAllEventData();

            if(Pages.LoginInput.category.Equals("Accountant") || Pages.LoginInput.category.Equals("Class Teacher"))
            {
                addEventLink.Enabled = false;
                delete.Visible = false;
            }
        }

        private void classDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = eventDataView.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                if (eventDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want this event?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        eventDataView.Rows.RemoveAt(e.RowIndex);
                        query = "DELETE FROM Event WHERE event_id='" + id + "'";
                        DbClient.query_execute(query);
                        MessageBox.Show("Event deleted from system");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void populateEventData()
        {
            query = "SELECT event_id, name, description, FORMAT(date, 'dd-MM-yyyy') AS date, CONVERT(VARCHAR(10), CAST(time AS TIME), 0) AS time FROM Event";
            DbClient.dataGridFill(eventDataView, query);
        }*/

        private void addEventLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            OpenNewPage openNewPage = new OpenNewPage();
            openNewPage.OpenChildForm(new Pages.AddEvent(), bgPanel);
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            DataFromDb.getAllEvent = DbClient.dataSource("SELECT event_id, name, description, FORMAT(date, 'dd-MM-yyyy') AS date, CONVERT(VARCHAR(10), CAST(time AS TIME), 0) AS time FROM Event");
            MessageBox.Show("Event data refreshed");
            eventDataView.DataSource = DataFromDb.getAllEventData();
        }
    }
}
