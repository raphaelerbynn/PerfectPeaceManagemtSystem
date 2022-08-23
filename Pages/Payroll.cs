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

            topPanel.BackColor = Home.themeColor;
            empSalaryPanel.BackColor = Home.foreColor;
            paymentPanel.BackColor = Home.foreColor;
            salaryBasedPanel.BackColor = Home.foreColor;
            payrollPanel.BackColor = Home.foreColor;

            empSalaryBtn.BackColor = Color.Gray;
            paymentBtn.BackColor = Color.Gray;
            salaryBaseBtn.BackColor = Home.foreColor;

            salaryBasedPanel.Location = new Point(salaryBasedPanel.Location.X, paymentPanel.Location.Y);
            adjustColumns();
            populateSalaryData();

            query = "SELECT [title]+'('+[rank]+')' AS position FROM Salary";
            DbClient.query_reader(salaryBaseCb, query);

            query = "SELECT [f_name]+' '+[l_name] FROM Teacher";
            DbClient.query_reader(paymentNameCb, query);
        }

        //salary base
        private void salaryBaseDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
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
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            openNewPage.OpenChildForm(new Pages.AddSalary(), salaryBasedPanel);
        }

        private void salaryBaseBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            empSalaryBtn.BackColor = Color.Gray;
            paymentBtn.BackColor = Color.Gray;
            salaryBaseBtn.BackColor = Home.foreColor;

            salaryBasedPanel.Visible = true;
            addSalaryBtn.Visible = true;
            empSalaryPanel.Visible = false;
            paymentPanel.Visible = false;
            salaryBasedPanel.Location = new Point(salaryBasedPanel.Location.X, paymentPanel.Location.Y);
            populateSalaryData();
        }

        private void populateSalaryData()
        {
            salaryBaseDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            salaryBaseDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            salaryBaseDataView.BackgroundColor = Home.foreColor;

            //query = "SELECT *, amount AS net_amount, amount AS gross_amount FROM Salary";
            //DbClient.dataGridFill(salaryBaseDataView, query);
            salaryBaseDataView.DataSource = DataFromDb.getSalaryBaseData();

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
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            empSalaryBtn.BackColor = Home.foreColor;
            paymentBtn.BackColor = Color.Gray;
            salaryBaseBtn.BackColor = Color.Gray;

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
                empSalaryDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
                empSalaryDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
                empSalaryDataView.BackgroundColor = Home.foreColor;

                // query = "SELECT teacher_id, [f_name]+' '+[l_name] AS name, email, CAST(teacher_id AS VARCHAR(100)) AS salary_base FROM Teacher";
                // DbClient.dataGridFill(empSalaryDataView, query);
                
                empSalaryDataView.DataSource = DataFromDb.getEmployeeSalaryData();

               /* foreach (DataGridViewRow item in empSalaryDataView.Rows)
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
                    
                }*/
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }

        private string empSalaryId;
        private void empSalaryDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
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
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (salaryBaseCb.SelectedIndex != -1)
            {
                query = "SELECT salary_id FROM Salary WHERE [title]+'('+[rank]+')'='" + salaryBaseCb.SelectedItem.ToString() + "'";
                string salaryId = DbClient.query_executeScaler(query);

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
        private static string id;
        private void makePaymentBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (!String.IsNullOrEmpty(paymentNameCb.Text))
            {
                try
                {
                    query = "SELECT teacher_id FROM Teacher WHERE [f_name]+' '+[l_name]='" + paymentNameCb.Text + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {
                        id = reader["teacher_id"].ToString();
                    }
                    reader.Close();

                    if (!String.IsNullOrEmpty(id))
                    {
                        openNewPage.OpenChildForm(new Pages.PaySlip(), paymentPanel);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static string getPaymentNameId()
        {
            return id;
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            empSalaryBtn.BackColor = Color.Gray;
            paymentBtn.BackColor = Home.foreColor;
            salaryBaseBtn.BackColor = Color.Gray;

            salaryBasedPanel.Visible = false;
            addSalaryBtn.Visible = false;
            paymentPanel.Visible = true;
            empSalaryPanel.Visible = false;

            paymentPanel.Location = new Point(salaryBasedPanel.Location.X, paymentPanel.Location.Y);
            populatePaymentData();
        }

        private void populatePaymentData()
        {
            try
            {
                paymentDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
                paymentDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
                paymentDataView.BackgroundColor = Home.foreColor;

                //query = "SELECT salary_payment_id, name, amount, net, salary_date, payment_method, FORMAT(date_paid, 'dd-MMM-yyyy') AS date_paid FROM Salary_payment";
                //DbClient.dataGridFill(paymentDataView, query);
                paymentDataView.DataSource = DataFromDb.getSalaryPaymentData();
                adjustPaymentColumns();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void paymentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = paymentDataView.Rows[e.RowIndex];
                string id = row.Cells["payment_id"].Value.ToString();
                if (paymentDataView.Columns[e.ColumnIndex].Name == "deletePayment" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete this payment?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        paymentDataView.Rows.RemoveAt(e.RowIndex);
                        query = "DELETE FROM Salary_payment WHERE salary_payment_id='" + id + "'";
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

        public void adjustPaymentColumns()
        {
            paymentDataView.AutoGenerateColumns = false;

            paymentDataView.Columns["payment_name"].DisplayIndex = 0;
            paymentDataView.Columns["paymentNetAmount"].DisplayIndex = 1;
            paymentDataView.Columns["amountPaid"].DisplayIndex = 2;
            paymentDataView.Columns["mode_of_payment"].DisplayIndex = 3;
            paymentDataView.Columns["salary_month"].DisplayIndex = 4;
            paymentDataView.Columns["date_paid"].DisplayIndex = 5;
            paymentDataView.Columns["deletePayment"].DisplayIndex = 6;
        }

        private void searchEmpBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (!String.IsNullOrEmpty(searchEmpTb.Text))
            {
                try
                {
                    (empSalaryDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", searchEmpTb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                (empSalaryDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                
            }
        }

        private void searchPaidEmpBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (!String.IsNullOrEmpty(searchPaidEmpTb.Text))
            {
                try
                {
                    (paymentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", searchPaidEmpTb.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                (paymentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void Payroll_Load(object sender, EventArgs e)
        {

        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            if (salaryBasedPanel.Visible == true)
            {
                DataFromDb.getSalaryBase = DbClient.dataSource("SELECT *, amount AS net_amount, amount AS gross_amount FROM Salary");
                MessageBox.Show("Salary base refreshed");
                salaryBaseDataView.DataSource = DataFromDb.getSalaryBaseData();
            }
            else if(paymentPanel.Visible == true)
            {
                DataFromDb.getSalaryPayment = DbClient.dataSource("SELECT salary_payment_id, name, amount, net, salary_date, payment_method, FORMAT(date_paid, 'dd-MMM-yyyy') AS date_paid FROM Salary_payment");
                MessageBox.Show("Payment data refreshed");
                paymentDataView.DataSource = DataFromDb.getSalaryPaymentData();
            }
            else if(empSalaryPanel.Visible == true)
            {
                DataFromDb.getEmployeeSalary = DbClient.dataSource("SELECT teacher_id, [f_name] + ' ' +[l_name] AS name, email, " +
                                            "(SELECT [title]+'('+[rank]+')' AS position FROM Salary WHERE Salary.salary_id=(SELECT salary_id FROM Employee_salary WHERE Employee_salary.teacher_id=Teacher.teacher_id)) " +
                                            "AS salary_base FROM Teacher");
                MessageBox.Show("Employee salary refreshed");
                empSalaryDataView.DataSource = DataFromDb.getEmployeeSalaryData();
            }
            else { }
        }
    }
}
