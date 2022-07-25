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

            populateEventData();
        }

        private void classDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populateEventData()
        {
            query = "SELECT event_id, name, description, FORMAT(date, 'dd-MM-yyyy') AS date, CONVERT(VARCHAR(10), CAST(time AS TIME), 0) AS time FROM Event";
            DbClient.dataGridFill(eventDataView, query);
        }
    }
}
