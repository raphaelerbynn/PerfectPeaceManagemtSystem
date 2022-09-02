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
        private string _class;
        private string bank;
        private string account_number;
        private string ssnit_number;
        private string tin_number;
        private string category;
        private string staff_position;

        private string query;

        public Teacher() { }

        public Teacher(string phone, string email)
        {
            this.phone = phone;
            this.email = email;
        }

        public Teacher(string category, string staff_position, string bank, string account_number, string ssnit_number, string tin_number, string phone, string email, string f_name, string l_name, string address, string gender, string _date_registered):
            base(f_name, l_name, address, gender, _date_registered)
        {
            this.category = category;
            this.staff_position = staff_position;
            this.phone = phone;
            this.email = email;
            this.bank = bank;
            this.account_number = account_number;  
            this.ssnit_number = ssnit_number;
            this.tin_number = tin_number;
        }

        public Teacher(string bank, string account_number, string ssnit_number, string tin_number, string _class, string phone, string email, string f_name, string l_name, string address, string gender, string _date_registered):
            base(f_name, l_name, address, gender, _date_registered)
        {
            this.phone = phone;
            this.email = email;
            this._class = _class;
            this.bank = bank;
            this.account_number = account_number;
            this.ssnit_number = ssnit_number;
            this.tin_number = tin_number;
        }

        public override void delete(string id)
        {
            query = "DELETE FROM Teacher WHERE teacher_id='" + id + "'";
            DbClient.query_execute(query);
        }

        public override void save()
        {
            query = "INSERT INTO Teacher (category, staff_position, f_name, l_name, gender, phone, address, email, bank, account_number, ssnit_number, tin_number,date_registered)" +
                "VALUES('"+category+"', '"+staff_position+"', '" + f_name + "','" + l_name + "','" + gender + "','" + phone + "','" + address + "','" + email + "', '"+bank+"', '"+account_number+"', '"+ssnit_number+"' , '"+tin_number+"', '"+ _date_registered + "')";
            DbClient.query_execute(query);
        }

        public override void show_data(DataGridView dataGrid)
        {
            query = "SELECT teacher_id,phone,email, CAST(class_id AS VARCHAR(10)) AS class, [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Teaching'";
            DbClient.dataGridFill(dataGrid, query);
        }

        public void show_non_teaching(DataGridView nonTeachingDataView)
        {
            query = "SELECT teacher_id,phone,email, staff_position, [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Non-Teaching'";
            DbClient.dataGridFill(nonTeachingDataView, query);
        }

        public override void update(string id)
        {
            query = "UPDATE Teacher SET class_id='" + _class +"', f_name='" + f_name + "', l_name='" + l_name + "', gender='" + gender + "', phone='" + phone + "', address='" + address + "', email='" + email + "', bank='"+bank+"', account_number='"+account_number+"', ssnit_number='"+ssnit_number+"', tin_number='"+tin_number+"', date_updated='" + DateTime.Now + "' WHERE teacher_id='" + id + "'";
            DbClient.query_execute(query);
        }
    }
}
