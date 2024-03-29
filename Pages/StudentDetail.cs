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
    public partial class StudentDetail : Form
    {
        string query;
        public StudentDetail()
        {
            InitializeComponent();
            fillData();
            bgPanel.BackColor = Home.foreColor;
            classPanel.BackColor = Home.themeColor;
            parentPanel.BackColor = Home.themeColor;
            studentPanel.BackColor = Home.themeColor;

            classPanel.ForeColor = Home.foreColor;
            parentPanel.ForeColor = Home.foreColor;
            studentPanel.ForeColor = Home.foreColor;
        }

        public void fillData()
        {

            string id = StudentDataDisplay.getIdFromSelectedRow();

            //Console.WriteLine(StudentDataDisplay.getIdFromSelectedRow());

            query = "SELECT * FROM Student WHERE student_id='" + id + "'";
            System.Data.SqlClient.SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                if (reader["m_name"].ToString() != "")
                {
                    lblFullName.Text = reader["f_name"].ToString() + " " + reader["m_name"].ToString() + " " + reader["l_name"].ToString();
                }
                else
                {
                    lblFullName.Text = reader["f_name"].ToString() + " " + reader["l_name"].ToString();
                }

                lblDob.Text = reader["dob"].ToString().Replace(" 12:00:00 AM", "");
                lblAge.Text = reader["age"].ToString();
                lblAddress.Text = reader["address"].ToString();
                lblGender.Text = reader["gender"].ToString();
                lblClass.Text = reader["class"].ToString();

                string fee = reader["fees_owing"].ToString();
                if (!String.IsNullOrEmpty(fee))
                {
                    if (int.Parse(fee) > 0)
                    {
                        lblFees.Text = "Owing(Ghc" + reader["fees_owing"].ToString() + ")";
                    }
                    else
                    {
                        lblFees.Text = "Paid In Full";
                    }
                }

            }
            reader.Close();

            query = "SELECT parent_id FROM Student WHERE student_id='" + id + "'";
            string parent_id = "";
            System.Data.SqlClient.SqlDataReader reader0 = DbClient.query_reader(query);
            while (reader0.Read())
            {
                parent_id = reader0["parent_id"].ToString();
            }
            reader0.Close();

            query = "SELECT * FROM Parent WHERE parent_id='" + parent_id + "'";
            System.Data.SqlClient.SqlDataReader reader1 = DbClient.query_reader(query);
            while (reader1.Read())
            {
                lblParentName.Text = reader1["f_name"].ToString() + " " + reader1["l_name"].ToString();
                lblContact.Text = reader1["contact"].ToString();
                lblOtherContact.Text = reader1["contact1"].ToString();
                lblRelationship.Text = reader1["relationship"].ToString();
                occupationLbl.Text = reader1["occupation"].ToString();
            }
            reader1.Close();
            Console.WriteLine(parent_id);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
        }
    }
}
