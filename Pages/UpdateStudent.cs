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
    public partial class UpdateStudent : Form
    {
        string query;
        private string id = StudentDataDisplay.getIdFromSelectedRow();
        OpenNewPage openNewPage = new OpenNewPage();

        public UpdateStudent()
        {
            InitializeComponent();
            fillFields();
        }

        private void fillFields()
        {
            
            string _class = "";
            //Console.WriteLine(StudentDataDisplay.getIdFromSelectedRow());

            query = "SELECT * FROM Student WHERE student_id='" + id + "'";
            System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                fnameTb.Text = reader["f_name"].ToString(); 
                mnameTb.Text = reader["m_name"].ToString(); 
                lnameTb.Text = reader["l_name"].ToString(); 
                dobPicker.Text = reader["dob"].ToString();
                addressTb.Text = reader["address"].ToString();

                _class = reader["class"].ToString();
                
                
                //Console.WriteLine(index);

                if (reader["gender"].ToString() == "Female")
                {
                    femaleRadio.Checked = true;
                }
                maleRadio.Checked = true;
                
            }
            reader.Close();

            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);

            for(int i = 0; i < classCb.Items.Count; i++)
            {
                if (_class == classCb.Items[i].ToString())
                {
                    classCb.SelectedIndex = i;
                    Console.WriteLine(i);
                    break;
                }
            }
            //classCb.SelectedIndex = index;

            Console.WriteLine(_class);
        }

        private string getRadioBtnValue()
        {
            if (femaleRadio.Checked == true)
            {
                return "Female";
            }
            return "Male";
        }

        private void updateStntBnt_Click(object sender, EventArgs e)
        {
            Student student = new Student(DateTime.Parse(dobPicker.Text), classCb.Text, fnameTb.Text, mnameTb.Text, lnameTb.Text, addressTb.Text, getRadioBtnValue(), DateTime.Now);
            student.update(id);
            MessageBox.Show("Student updated successfully");
            
            
        }

        private void mnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
