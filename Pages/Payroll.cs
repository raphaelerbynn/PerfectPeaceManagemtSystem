using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perfect_Peace_System.Pages
{
    public partial class Payroll : Form
    {
        private string query;
        OpenNewPage openNewPage = new OpenNewPage();

        public Payroll()
        {
            InitializeComponent();
            populateSalaryData();
            adjustColumns();
        }

        //salary base
        private void salaryBaseDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = salaryBaseDataView.Rows[e.RowIndex];
                string id = row.Cells["salary_id"].Value.ToString();
                if (salaryBaseDataView.Columns[e.ColumnIndex].Name == "deleteSalary" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete this salary base?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        salaryBaseDataView.Rows.RemoveAt(e.RowIndex);
                        query = "DELETE FROM Salary WHERE salary_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Deductions WHERE salary_id='" + id + "'";
                        DbClient.query_execute(query);

                        query = "DELETE FROM Allowance WHERE salary_id='" + id + "'";
                        DbClient.query_execute(query);

                        MessageBox.Show("Data deleted from system");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSalaryBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new Pages.AddSalary(), salaryBasedPanel);
        }

        private void salaryBaseBtn_Click(object sender, EventArgs e)
        {
            salaryBasedPanel.Visible = true;
            addSalaryBtn.Visible = true;
        }

        private void populateSalaryData()
        {
            
            query = "SELECT *, amount AS net_amount, amount AS gross_amount FROM Salary";
            DbClient.dataGridFill(salaryBaseDataView, query);
            foreach (DataGridViewRow item in salaryBaseDataView.Rows)
            {
                double totalAllowance = 0;
                double totalDeductions = 0;
                string salaryId = item.Cells["salary_id"].Value.ToString();
                string salary = item.Cells["amountSalary"].Value.ToString();
                //allowance
                query = "SELECT amount FROM Allowance WHERE salary_id='"+salaryId+"'";
                SqlDataReader reader = DbClient.query_reader(query);   
                while (reader.Read())
                {
                    totalAllowance += double.Parse(reader["amount"].ToString());
                    Console.WriteLine(totalAllowance);
                }
                reader.Close();

                //deductions
                query = "SELECT amount FROM Deductions WHERE salary_id='" + salaryId + "'";
                reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    totalDeductions += double.Parse(reader["amount"].ToString());
                }
                reader.Close();
                
                item.Cells["grossAmount"].Value = totalAllowance + double.Parse(salary);
                item.Cells["netAmount"].Value = (totalAllowance + double.Parse(salary)) - totalDeductions;
            }
        }

        private void adjustColumns()
        {
            salaryBaseDataView.AutoGenerateColumns = false;

            salaryBaseDataView.Columns["salaryTitle"].DisplayIndex = 0;
            salaryBaseDataView.Columns["salaryRank"].DisplayIndex = 1;
            salaryBaseDataView.Columns["grossAmount"].DisplayIndex = 2;
            salaryBaseDataView.Columns["netAmount"].DisplayIndex = 3;
        }


        //employee salary
        private void empSalaryBtn_Click(object sender, EventArgs e)
        {
            salaryBasedPanel.Visible = false;
            empSalaryPanel.Visible = true;
        }
    }
}
