using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public class School_Event
    {
        private string name;
        private string description;
        private DateTime date;
        private DateTime time;

        private string query;

        public School_Event() { }

        public School_Event(string name, string description, DateTime date, DateTime time)
        {
            this.name = name;
            this.description = description;
            this.date = date;
            this.time = time;
        }

        public void insert_event()
        {
            query = "INSERT INTO Event(name, description, date, time, created_at) " +
                "VALUES('" + name + "','" + description + "','" + date + "','" +time+ "','" +DateTime.Today+ "')";
            DbClient.query_execute(query);
        }
        public void show_data(DataGridView dataGrid)
        {
            query = "SELECT name, section, capacity FROM Class";
            DbClient.dataGridFill(dataGrid, query);
        }
    }
}