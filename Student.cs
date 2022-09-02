using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public class Student : Person
    {
        private string dob;
        private string _class;
        private float fees_owed;
        private float fees_paid;

        private string query;

        public Student() { }

        public Student(string dob, string _class, float fees_owed, float fees_paid)
        {

            this.dob = dob;
            this._class = _class;
            this.fees_paid = fees_paid;
        }

        public Student(string dob, string _class, float fees_paid, string f_name, string m_name, string l_name, string address, string gender, string _date_registerd) :
                            base(f_name, m_name, l_name, address, gender, _date_registerd)
        {
            this.dob = dob;
            this._class = _class;
            this.fees_paid = fees_paid;
        }

        public Student(string dob, string _class, string f_name, string m_name, string l_name, string address, string gender, string _date_registerd) :
                            base(f_name, m_name, l_name, address, gender, _date_registerd)
        {
            this.dob = dob;
            this._class = _class;
        }
        
        





        public string class_id
        {
            get
            {
                return _class;
            }
        }

        public override void save()
        {

            query = "INSERT INTO Student (f_name, m_name, l_name, dob, gender, class, address, fees_paid, date_registered)" +
                " VALUES('" + f_name + "','" + m_name + "','" + l_name + "','" + dob + "','" + gender + "','" + _class + "','" + address + "','" + fees_paid + "','" + _date_registered + "')";
            DbClient.query_execute(query);
        }

        public override void update(string id)
        {
            query = "UPDATE Student SET f_name='" + f_name + "', m_name='" + m_name + "', l_name='" + l_name + "', dob='" + dob + "', gender='" + gender + "', class='" + _class + "', address='" + address + "', date_updated='" + DateTime.Now + "' WHERE student_id='" +id+"'";
            DbClient.query_execute(query);
        }

        public override void show_data(DataGridView dataGrid)
        {
            query = "SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student";
            DbClient.dataGridFill(dataGrid, query);
        }

        public override void delete(string id)
        {
            query = "DELETE FROM Student WHERE student_id='" + id + "'";
            DbClient.query_execute(query);
        }


    }
}
