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
    public partial class AddStudent : Form
    {
        OpenNewPage openNewPage = new OpenNewPage();
        ClassRoom classroom = new ClassRoom();
        public static string class_name = "";

        string query;

        public AddStudent()
        {
            InitializeComponent();
            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);
            registerPanel.BackColor = Home.foreColor;
        } 

        private string getRadioBtnValue()
        {
            if (femaleRadio.Checked == true)
            {
                return "Female";
            }
            return "Male";
        }

        public void clearFeilds()
        {
            fnameTb.Text = null;
            mnameTb.Text = null;
            lnameTb.Text = null;
            dobPicker.Text = null;
            addressTb.Text = null;
            femaleRadio.Checked = false;
            classCb.SelectedIndex = -1;

        }

        private void registerStntBnt_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                Person person = new Student(
                    dobPicker.Value.Date.ToString(), classCb.Text, 0.00f,
                    fnameTb.Text, mnameTb.Text, lnameTb.Text, addressTb.Text,
                    getRadioBtnValue(), DateTime.Today.Date.ToString()
                    );

                class_name = classCb.Text;
                Console.WriteLine("class name: " + class_name);

                if (String.IsNullOrWhiteSpace(fnameTb.Text) ||
                    String.IsNullOrWhiteSpace(lnameTb.Text) ||
                    String.IsNullOrWhiteSpace(dobPicker.Text) ||
                    String.IsNullOrWhiteSpace(addressTb.Text))
                {
                    MessageBox.Show("Feilds with * must be filled!");
                }
                else
                {
                    if (classCb.SelectedIndex > -1 || !String.IsNullOrEmpty(classCb.Text))
                    {
                        if (classroom.maxCapacity(classCb.Text) > classroom.curCapacity(classCb.Text))
                        {

                            person.save();
                            MessageBox.Show("Student Saved");
                            clearFeilds();
                            openNewPage.OpenChildForm(new Pages.AddParent(), registerPanel);
                        }
                        else
                        {
                            MessageBox.Show("Class full!!!");
                        }
                    }
                    else
                    {
                        person.save();
                        MessageBox.Show("Student Saved");
                        clearFeilds();
                        openNewPage.OpenChildForm(new Pages.AddParent(), registerPanel);
                    }

                    DataFromDb.getAllStudent = DbClient.dataSource("SELECT student_id,age,gender,class, fees_owing, [f_name]+' '+[l_name] AS name FROM Student");
                    DataFromDb.totalStudents = DbClient.query_executeScaler("SELECT COUNT(*) FROM Student");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }

        }










        private void classCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dobPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearFeildBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void fnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
