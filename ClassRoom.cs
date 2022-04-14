using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public class ClassRoom
    {
        private string name;
        private int capacity;
        private string section;

        public ClassRoom() { }

        public ClassRoom(string name, int capacity, string section)
        {
            this.name = name;
            this.capacity = capacity;
            this.section = section;
        }

        public void insert_class()
        {
            string query = "INSERT INTO Class(name, section, capacity) VALUES('"+name+"','"+section+"','"+capacity+"')";
            DbClient.query_execute(query);
        }

        public void show_data(DataGridView dataGridView)
        {
            string query = "SELECT class_id, name, section, capacity, teacher_id, CAST(teacher_id AS VARCHAR(50)) AS teacher FROM Class";
            DbClient.dataGridFill(dataGridView, query);
        }
    }
}
