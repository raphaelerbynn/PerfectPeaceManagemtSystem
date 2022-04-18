using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public class Teacher : Person
    {
        private string phone;
        private string email;

        private string query;

        public Teacher() { }

        public Teacher(string phone, string email)
        {
            this.phone = phone;
            this.email = email;
        }

        public Teacher(string phone, string email, string f_name, string l_name, string address, string gender, DateTime _date_registered):
            base(f_name, l_name, address, gender, _date_registered)
        {
            this.phone = phone;
            this.email = email;
        }

        public override void delete(string id)
        {
            query = "DELETE FROM Teacher WHERE teacher_id='" + id + "'";
            DbClient.query_execute(query);
        }

        public override void save()
        {
            query = "INSERT INTO Teacher (f_name, l_name, gender, phone, address, email, date_registered)" +
                "VALUES('" + f_name + "','" + l_name + "','" + gender + "','" + phone + "','" + address + "','" + email + "','" + _date_registered + "')";
            DbClient.query_execute(query);
        }

        public override void show_data(DataGridView dataGrid)
        {
            query = "SELECT teacher_id,phone,email,gender,class, [f_name]+' '+[l_name] AS name FROM Teacher";
            DbClient.dataGridFill(dataGrid, query);
        }

        public override void update(string id)
        {
            query = "UPDATE Teacher SET f_name='" + f_name + "', l_name='" + l_name + "', gender='" + gender + "', phone='" + phone + "', address='" + address + "', email='" + email + "', date_updated='" + DateTime.Now + "' WHERE teacher_id='" + id + "'";
            DbClient.query_execute(query);
        }
    }
}
