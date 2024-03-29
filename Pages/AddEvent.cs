﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class AddEvent : Form
    {
        WaitFunc wait = new WaitFunc();
        public AddEvent()
        {
            InitializeComponent();
            getTime();
            bgPanel.BackColor = Home.foreColor;
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
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (String.IsNullOrWhiteSpace(lblName.Text))
            {
                MessageBox.Show("Event name empty!!!");
                return;
            }
            wait.show();
            School_Event _event = new School_Event(lblName.Text, lblDescription.Text, datePicker.Value, timePicker.Value);
            _event.insert_event();
            //MessageBox.Show(datePicker.Value + "\n" + new SqlDateTime(datePicker.Value) + "\n" + new SqlDateTime(DateTime.Now) + "\n" + new SqlDateTime(datePicker.Value.Date));
            
            clearFeild();
            DataFromDb.getAllEvent = DbClient.dataSource("SELECT event_id, name, description, FORMAT(date, 'dd-MM-yyyy') AS date, CONVERT(VARCHAR(10), CAST(time AS TIME), 0) AS time FROM Event");
            wait.close();
            MessageBox.Show("Event Added");

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFeild();
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
