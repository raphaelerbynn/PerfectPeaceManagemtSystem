using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public class Parent : Person
    {
        private string contact;
        private string otherContact;
        private string relationship;

        private string query;

        public Parent() { }

        public Parent(string contact, string otherContact, string relationship)
        {
            this.contact = contact;
            this.otherContact = otherContact;
            this.relationship = relationship;
        }

        public Parent(string contact, string otherContact, string relationship,string f_name, string l_name, string gender, string _dateRegistered):
             base(f_name, l_name, gender, _dateRegistered)
        {
            this.contact = contact;
            this.otherContact = otherContact;
            this.relationship = relationship;
        }

        public override void save()
        {
            query = "INSERT INTO Parent (f_name, l_name, gender, contact, contact1, relationship, created_at)" +
                "VALUES('" + f_name + "','" + l_name + "','" + gender + "','" + contact + "','" + otherContact + "','" + relationship + "','" + _date_registered + "')";
            DbClient.query_execute(query);
        }
        
        public override void update(string id)
        {
            throw new NotImplementedException();
        }

        public override void delete(string id)
        {
            query = "DELETE FROM Parent WHERE parent_id='" + id + "'";
            DbClient.query_execute(query);
        }

        public override void show_data(DataGridView dataGrid)
        {
            query = "SELECT parent_id,contact, relationship, [f_name]+' '+[l_name] AS name, (SELECT [f_name]+' '+[l_name] FROM Student WHERE Student.parent_id=Parent.parent_id) AS child FROM Parent";
            DbClient.dataGridFill(dataGrid, query);
        }

    }
}
