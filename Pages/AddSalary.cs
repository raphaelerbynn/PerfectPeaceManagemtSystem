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
    public partial class AddSalary : Form
    {
        private string query;
        WaitFunc wait = new WaitFunc();

        public AddSalary()
        {
            InitializeComponent();
            addSalaryPanel.BackColor = Home.foreColor;
        }

        private void addSalaryBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                wait.show();
                string salary_id = "";
                if (!(String.IsNullOrEmpty(titleTb.Text) || String.IsNullOrEmpty(salaryTb.Text)))
                {
                    query = "INSERT INTO Salary (title, rank, amount) VALUES('" + titleTb.Text + "', '" + rankTb.Text + "', '" + salaryTb.Text + "')";
                    DbClient.query_execute(query);

                    salary_id = DbClient.GetLastId("Salary");

                    for (int i = 1; i <= 6; i++)
                    {
                        if (!(String.IsNullOrEmpty(addSalaryPanel.Controls["DT" + i].Text) &&
                            String.IsNullOrEmpty(addSalaryPanel.Controls["DA" + i].Text)))
                        {
                            Control dT = addSalaryPanel.Controls["DT" + i];
                            Control dA = addSalaryPanel.Controls["DA" + i];

                            query = "INSERT INTO Deductions (salary_id, title, amount) VALUES('" + salary_id + "', '" + dT.Text + "', '" + dA.Text + "')";
                            DbClient.query_execute(query);
                        }
                        
                        if (!(String.IsNullOrEmpty(addSalaryPanel.Controls["AT" + i].Text) &&
                            String.IsNullOrEmpty(addSalaryPanel.Controls["AA" + i].Text)))
                        {
                            Control aT = addSalaryPanel.Controls["AT" + i];
                            Control aA = addSalaryPanel.Controls["AA" + i];

                            query = "INSERT INTO Allowance (salary_id, title, amount) VALUES('" + salary_id + "', '" + aT.Text + "', '" + aA.Text + "')";
                            DbClient.query_execute(query);
                        }
                    }

                    Console.WriteLine(salary_id);
                    wait.close();
                    MessageBox.Show("Salary Base added to system");
                    clearFields();
                    this.Close();
                }
                else
                {
                    wait.close();
                    MessageBox.Show("Title and Amount of Salary must be field!");
                }
                
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFields()
        {
            foreach(TextBox box in addSalaryPanel.Controls.OfType<TextBox>())
            {
                box.Text = null;
            }
        }

        private void tB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
