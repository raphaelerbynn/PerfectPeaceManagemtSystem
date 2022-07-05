﻿using System;
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
    public partial class StudentReport : Form
    {
        private string query;
        Student student;

        public StudentReport()
        {
            InitializeComponent();
            student = new Student();
            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);
            classCb.SelectedIndex = 0;
            
        }

        private void loadListBtn_Click(object sender, EventArgs e)
        {
            query = "SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student WHERE class='"+classCb.Text+"'";
            DbClient.dataGridFill(studentDataView, query);
            studentDataView.Visible = true;
            adjustColumnOrder();
        }

        private void adjustColumnOrder()
        {
            studentDataView.Columns["student_Id"].DisplayIndex = 0;
            studentDataView.Columns["full_name"].DisplayIndex = 1;
            studentDataView.Columns["age"].DisplayIndex = 2;
            studentDataView.Columns["_class"].DisplayIndex = 4;
            studentDataView.Columns["fees_details"].DisplayIndex = 5;
            studentDataView.Columns["gender"].DisplayIndex = 3;
            studentDataView.Columns["input_results"].DisplayIndex = 6;

            studentDataView.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
