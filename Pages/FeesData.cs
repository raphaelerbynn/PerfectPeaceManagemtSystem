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
    public partial class FeesData : Form
    {
        Fees fees = new Fees();
        private string query;

        public FeesData()
        {
            InitializeComponent();
            topPanel.BackColor = Home.foreColor;
            bgPanel.BackColor = Home.foreColor;

            feesDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            feesDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            feesDataView.BackgroundColor = Home.foreColor;

           
            fees.show_data(feesDataView);
            getStudent();
            columnArrangement();

        }

        private void columnArrangement()
        {
            feesDataView.AutoGenerateColumns = false;

            feesDataView.Columns["fee_id"].DisplayIndex = 0;
            feesDataView.Columns["student_name"].DisplayIndex = 1;
            feesDataView.Columns["_class"].DisplayIndex = 2;
            feesDataView.Columns["amount"].DisplayIndex = 3;
            feesDataView.Columns["payment_mode"].DisplayIndex = 4;
            feesDataView.Columns["remaining"].DisplayIndex = 5;
            feesDataView.Columns["date_paid"].DisplayIndex = 7;
            feesDataView.Columns["term"].DisplayIndex = 6;
            feesDataView.Columns["print"].DisplayIndex = 8;
            feesDataView.Columns["delete"].DisplayIndex = 9;
            
            feesDataView.Columns["student_id"].Visible = false;

            searchCb.SelectedIndex = 0;
        }

        private void getStudent()
        {
            try
            {
                foreach (DataGridViewRow item in feesDataView.Rows)
                {
                    string student_id = item.Cells["student_id"].Value.ToString();
                    item.Cells["student_name"].Value = "";
                    item.Cells["_class"].Value = "";

                    query = "SELECT class,[f_name]+' '+[l_name] AS name FROM Student WHERE student_id='" + student_id + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    feesDataView.ReadOnly = false;
                    while (reader.Read())
                    {
                        //if (reader.IsDBNull(0)) { continue; }
                        item.Cells["student_name"].Value = reader["name"].ToString();
                        item.Cells["_class"].Value = reader["class"].ToString();

                        Console.WriteLine(reader["name"].ToString());
                    }
                    reader.Close();
                    feesDataView.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {

                    if (searchCb.Text == "Student Name")
                    {
                        string student_id = "";
                        query = "SELECT student_id FROM Student WHERE CONCAT(f_name,l_name) LIKE '%" + searchTextBox.Text + "%'";
                        SqlDataReader reader = DbClient.query_reader(query);
                        while (reader.Read())
                        {
                            student_id = reader["student_id"].ToString();
                        }
                        reader.Close();

                        query = "SELECT fee_id, student_id, paid, remaining, payment_mode, date_paid, " +
                            "CAST(student_id AS VARCHAR(50)) AS student, CAST(class_id AS VARCHAR(50)) AS class FROM Fee" +
                            " WHERE student_id='" + student_id + "'";
                        DbClient.dataGridFill(feesDataView, query);
                        getStudent();
                    }
                    else if (searchCb.Text == "Payment Mode")
                    {
                        (feesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("payment_mode LIKE '%{0}%'", searchTextBox.Text);
                    }
                    else if (searchCb.Text == "Date Paid")
                    {
                        string newText = searchCb.Text.Replace(" ", "_");
                        (feesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT("+newText+", 'System.String') LIKE '%{0}%'", searchTextBox.Text);
                    }

                    else
                    {
                        (feesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchCb.Text + " LIKE '%{0}%'", searchTextBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                fees.show_data(feesDataView);
                getStudent();
            }
        }

        private void feesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = feesDataView.Rows[e.RowIndex];
                string id = row.Cells["fee_id"].Value.ToString();

                if (feesDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete this fee data?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        feesDataView.Rows.RemoveAt(e.RowIndex);
                        //reverse payment
                        query = "DELETE FROM Fee WHERE fee_id='"+id+"'";
                        DbClient.query_execute(query);
                        MessageBox.Show(" Fee data deleted from system");
                    }
                }
                
                if (feesDataView.Columns[e.ColumnIndex].Name == "print" && e.RowIndex >= 0)
                {
                    string student_id = DbClient.query_executeScaler("SELECT student_id FROM Fee WHERE fee_id='" + id + "'");
                    GetData.setStudentIdReceipt(student_id);
                    GetData.setFeeId(id);
                    GetData.setFromTableReceiptQuery(true);

                    OpenNewPage openNewPage = new OpenNewPage();
                    openNewPage.OpenChildForm(new Pages.FeeReceipt(), bgPanel);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
