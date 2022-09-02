using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public abstract class Person
    {
        protected long id;
        protected string f_name;
        protected string m_name;
        protected string l_name;
        protected string dob;
        protected string address;
        protected string gender;
        protected string _dateUpdated;
        protected string _date_registered;

        public Person()
        {

        }

        public Person(string f_name, string l_name, string address, string gender, string _date_registered)
        {

            this.f_name = f_name;
            this.l_name = l_name;
            this.address = address;
            this.gender = gender;
            this._date_registered = _date_registered;

        }

        public Person(string f_name, string l_name, string gender, string _date_registered)
        {

            this.f_name = f_name;
            this.l_name = l_name;
            this.gender = gender;
            this._date_registered = _date_registered;

        }

        public Person(string f_name, string m_name, string l_name, string address, string gender, string _date_registered)
        {
            this.f_name = f_name;
            this.m_name = m_name;
            this.l_name = l_name;
            this.address = address;
            this.gender = gender;
            this._date_registered = _date_registered;


        }


        public abstract void save();

        public abstract void update(string id);

        public abstract void delete(string id);

        public abstract void show_data(DataGridView dataGrid);

    }
}
