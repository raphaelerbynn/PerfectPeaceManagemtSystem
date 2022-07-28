using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class TeacherDetails : Form
    {
        private string query;
        public TeacherDetails()
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

        private void fillData()
        {
            string id = TeacherData.getIdFromSelectedRow();
            query = "SELECT * FROM Teacher WHERE teacher_id='" + id + "'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                lblFullName.Text = reader["f_name"].ToString() + " " + reader["l_name"].ToString();
                lblGender.Text = reader["gender"].ToString();
                lblEmail.Text = reader["email"].ToString();
                lblPhone.Text = reader["phone"].ToString();
                lblAddress.Text = reader["address"].ToString();

                lblBank.Text = reader["bank"].ToString();
                lblAcc.Text = reader["account_number"].ToString();
                lblSsnit.Text = reader["ssnit_number"].ToString();
                lblTin.Text = reader["tin_number"].ToString();
            }
            reader.Close();

            query = "SELECT name FROM class WHERE teacher_id='" + id + "'";
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                lblClass.Text = reader["name"].ToString();
            }
            reader.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
        }
    }
}
