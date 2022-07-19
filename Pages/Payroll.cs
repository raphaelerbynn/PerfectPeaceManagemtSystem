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
            salaryBasedPanel.Location = new Point(salaryBasedPanel.Location.X, paymentPanel.Location.Y);
            populateSalaryData();
            adjustColumns();
            
            query = "SELECT [title]+'('+[rank]+')' AS position FROM Salary";
            DbClient.query_reader(salaryBaseCb, query);

            query = "SELECT [f_name]+' '+[l_name] FROM Teacher";
            DbClient.query_reader(paymentNameCb, query);
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
            empSalaryPanel.Visible = false;
            paymentPanel.Visible = false;
            salaryBasedPanel.Location = new Point(salaryBasedPanel.Location.X, paymentPanel.Location.Y);
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
            addSalaryBtn.Visible = false;
            paymentPanel.Visible = false;
            empSalaryPanel.Visible = true;
            empSalaryPanel.Location = new Point(salaryBasedPanel.Location.X, paymentPanel.Location.Y);

            populateEmpSalary();

        }

        private void populateEmpSalary()
        {
            try
            {
                query = "SELECT teacher_id, [f_name]+' '+[l_name] AS name, email, CAST(teacher_id AS VARCHAR(100)) AS salary_base FROM Teacher";
                DbClient.dataGridFill(empSalaryDataView, query);

                foreach (DataGridViewRow item in empSalaryDataView.Rows)
                {
                    string salary_id = "";
                    item.Cells["emp_salary_base"].Value = null;
                    string empId = item.Cells["teacher_id"].Value.ToString();

                    query = "SELECT salary_id FROM Employee_salary WHERE teacher_id='" + empId + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {
                        salary_id = reader["salary_id"].ToString();
                    }
                    reader.Close();
                    query = "SELECT [title]+'('+[rank]+')' AS position FROM Salary WHERE salary_id='" + salary_id + "'";
                    reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {
                        item.Cells["emp_salary_base"].Value = reader["position"].ToString();
                    }
                    reader.Close();
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }

        private string empSalaryId;
        private void empSalaryDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = empSalaryDataView.Rows[e.RowIndex];
                empSalaryId = row.Cells["teacher_id"].Value.ToString();
                string salaryBase = row.Cells["emp_salary_base"].Value.ToString();
                if (empSalaryDataView.Columns[e.ColumnIndex].Name == "assignSalary" && e.RowIndex >= 0)
                {

                    empNameTb.Text = row.Cells["employee_name"].Value.ToString();
                    if (String.IsNullOrEmpty(salaryBase))
                    {
                        salaryBaseCb.SelectedIndex = -1;
                    }
                    else
                    {
                        salaryBaseCb.SelectedItem = salaryBase;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void assignSalaryBaseBtn_Click(object sender, EventArgs e)
        {
            if (salaryBaseCb.SelectedIndex != -1)
            {
                query = "SELECT salary_id FROM Salary WHERE [title]+'('+[rank]+')'='" + salaryBaseCb.SelectedItem.ToString() + "'";
                string salaryId = DbClient.getIdFromCombo(query, salaryBaseCb.SelectedItem.ToString()).ToString();

                if (!String.IsNullOrEmpty(empNameTb.Text))
                {
                    query = "INSERT INTO Employee_salary(teacher_id, salary_id) VALUES('" + empSalaryId + "', '" + salaryId + "')";
                    DbClient.query_execute(query);

                    MessageBox.Show("Salary Assigned to Employee");
                    populateEmpSalary();
                }
            }
        }


        //salary payment
        private void makePaymentBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new Pages.PaySlip(), paymentPanel);
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            salaryBasedPanel.Visible = false;
            addSalaryBtn.Visible = false;
            paymentPanel.Visible = true;
            empSalaryPanel.Visible = false;

            paymentPanel.Location = new Point(salaryBasedPanel.Location.X, paymentPanel.Location.Y);
            //populatePaymentData();
        }

        private void populatePaymentData()
        {
            try
            {
                query = "SELECT * FROM Salary_payment";
                DbClient.dataGridFill(paymentDataView, query);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
