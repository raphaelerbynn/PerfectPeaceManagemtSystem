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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
            getTime();
        }

        public void getTime()
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "hh:mm tt".ToString();
            timePicker.ShowUpDown = true;
            timePicker.Value = DateTime.Now;
            datePicker.Value = DateTime.Now;
        }

        public void clearFeild()
        {
            lblName.Text = null;
            lblDescription.Text = null;
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(lblName.Text))
            {
                MessageBox.Show("Event name empty!!!");
                return;
            }
            School_Event _event = new School_Event(lblName.Text, lblDescription.Text, datePicker.Value.Date, timePicker.Value);
            _event.insert_event();
            MessageBox.Show("Event Added");
            clearFeild();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFeild();
        }
    }
}
