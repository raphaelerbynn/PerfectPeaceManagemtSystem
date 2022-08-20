using System;
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
    public partial class Account : Form
    {
        private string query;

        public Account()
        {
            InitializeComponent();
            showExpenses();
            showFeeding();
            showExtraClasses();

            bgPanel.BackColor = Home.themeColor;
            feedingPanel.BackColor = Home.foreColor;
            expensePanel.BackColor = Home.foreColor;
            classesPanel.BackColor = Home.foreColor;

        }

        private void loadInfoBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                string queryTeacher = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Teaching'";
                string queryClass = "SELECT name FROM Class";
                if (categoryCb.SelectedIndex == 0)
                {
                    classesPanel.Visible = false;
                    feedingPanel.Visible = false;
                    expensePanel.Visible = true;
                }
                else if (categoryCb.SelectedIndex == 1)
                {
                    expensePanel.Visible = false;
                    feedingPanel.Visible = false;
                    classesPanel.Visible = true;
                    classesPanel.Location = expensePanel.Location;
                    DbClient.query_reader(teacherCb, queryTeacher);
                    DbClient.query_reader(extraClassesClassCb, queryClass);
                }
                else if (categoryCb.SelectedIndex == 2)
                {
                    expensePanel.Visible = false;
                    classesPanel.Visible = false;
                    feedingPanel.Visible = true;
                    feedingPanel.Location = expensePanel.Location;
                    DbClient.query_reader(feedingTeacherCb, queryTeacher);
                    DbClient.query_reader(feedingClassCb, queryClass);
                }
                else
                {
                    expensePanel.Visible = false;
                    classesPanel.Visible = false;
                    feedingPanel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
        }

        private void showExpenses()
        {
            expensesDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            expensesDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            expensesDataView.BackgroundColor = Home.foreColor;
            //load data
            //query = "SELECT expense_id, expense, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Expense";
            //DbClient.dataGridFill(expensesDataView, query);
            expensesDataView.DataSource = DataFromDb.getExpensesData();
            totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");

        }

        private void showExtraClasses()
        {
            extraClassesDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            extraClassesDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            extraClassesDataView.BackgroundColor = Home.foreColor;
            //query = "SELECT extra_classes_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Extra_classes";
            //DbClient.dataGridFill(extraClassesDataView, query);
            extraClassesDataView.DataSource = DataFromDb.getExtraClassesData();
            extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
        }

        private void showFeeding()
        {
            feedingDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            feedingDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            feedingDataView.BackgroundColor = Home.foreColor;

            //query = "SELECT feeding_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Feeding_fee";
            //DbClient.dataGridFill(feedingDataView, query);
            feedingDataView.DataSource = DataFromDb.getFeedingFeeData();
            feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
        }

        //feeding
        private void addFeedingBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                try
                {
                    query = "INSERT INTO Feeding_fee(teacher, class, amount, date) " +
                        "VALUES('" + feedingTeacherCb.Text + "', '" + feedingClassCb.Text + "', '" + feedingAmntTb.Text + "', '" + DateTime.Today + "')";
                    DbClient.query_execute(query);
                    
                    feedingTeacherCb.SelectedIndex = -1;
                    feedingClassCb.SelectedIndex = -1;
                    feedingAmntTb.Text = null;
                    feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
                    DataFromDb.getFeedingFee = DbClient.dataSource("SELECT feeding_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Feeding_fee");
                    showFeeding();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Input all fields correctly!");
                }

            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
            
        }

        private void feedingSearchBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                if (!String.IsNullOrEmpty(feedingSearchTb.Text))
                {
                    try
                    {
                        (feedingDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("teacher LIKE '%{0}%'", feedingSearchTb.Text);
                        feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Search Again");
                        Console.WriteLine(ex.Message);
                    }

                }
                else
                {
                    (feedingDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
            
        }

        private void feedingLoadBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                string loadListDateF = feedingYearPk.Text;
                if (monthFeedingPk.Visible == true)
                {
                    loadListDateF = monthFeedingPk.Text + "-" + feedingYearPk.Text;
                    if (dayExtraClassesPk.Visible == true)
                    {
                        loadListDateF = dayFeedingPk.Text + "-" + loadListDateF;
                    }
                }
            (feedingDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(Date, 'System.String') LIKE '%{0}%'", loadListDateF);
                feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
        }

        private void feedingDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                try
                {
                    DataGridViewRow row = feedingDataView.Rows[e.RowIndex];
                    string id = row.Cells["feeding_fee_id"].Value.ToString();
                    if (feedingDataView.Columns[e.ColumnIndex].Name == "deleteFeeding" && e.RowIndex >= 0)
                    {
                        string message = "Do you want to delete this data?";
                        MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, "", deleteAction);
                        if (result == DialogResult.Yes)
                        {
                            feedingDataView.Rows.RemoveAt(e.RowIndex);
                            query = "DELETE FROM Feeding_fee WHERE feeding_fee_id='" + id + "'";
                            DbClient.query_execute(query);
                            MessageBox.Show("Data deleted from system");
                            feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
            
        }

        private void addMonthCheckBF_CheckedChanged(object sender, EventArgs e)
        {
            if (addMonthCheckBF.Checked)
            {
                addDayCheckBF.Visible = true;
                monthLblF.Visible = true;
                monthFeedingPk.Visible = true;
            }
            else
            {
                addDayCheckBF.Visible = false;
                monthLblF.Visible = false;
                monthFeedingPk.Visible = false;
            }
        }

        private void addDayCheckBF_CheckedChanged(object sender, EventArgs e)
        {
            if (addDayCheckBF.Checked)
            {
                dayLblF.Visible = true;
                dayFeedingPk.Visible = true;
            }
            else
            {
                dayLblF.Visible = false;
                dayFeedingPk.Visible = false;
            }
        }

        //extra classes
        private void addExtraClassesBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {

                try
                {
                    query = "INSERT INTO Extra_classes(teacher, class, amount, date) " +
                        "VALUES('" + teacherCb.Text + "', '" + extraClassesClassCb.Text + "', '" + extraClassesAmntTb.Text + "', '" + DateTime.Today + "')";
                    DbClient.query_execute(query);
                    
                    teacherCb.SelectedIndex = -1;
                    extraClassesClassCb.SelectedIndex = -1;
                    extraClassesAmntTb.Text = null;
                    DataFromDb.getExtraClasses = DbClient.dataSource("SELECT extra_classes_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Extra_classes");
                    showExtraClasses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
        }

        private void extraClassesSearchBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                if (!String.IsNullOrEmpty(searchExtraClassesTb.Text))
                {
                    try
                    {
                        (extraClassesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("teacher LIKE '%{0}%'", searchExtraClassesTb.Text);
                        extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Search Again");
                        Console.WriteLine(ex.Message);
                    }

                }
                else
                {
                    (extraClassesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
            
        }

        private void loadExtraClassesBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                string loadListDateC = yearExtraClassesPk.Text;
                if (monthExtraClassesPk.Visible == true)
                {
                    loadListDateC = monthExtraClassesPk.Text + "-" + yearExtraClassesPk.Text;
                    if (dayExtraClassesPk.Visible == true)
                    {
                        loadListDateC = dayExtraClassesPk.Text + "-" + loadListDateC;
                    }
                }
            (extraClassesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(Date, 'System.String') LIKE '%{0}%'", loadListDateC);
                extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
            }

            else
            {
                MessageBox.Show("Check your internet connection");
            }
        }

        private void extraClassesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                try
                {
                    DataGridViewRow row = extraClassesDataView.Rows[e.RowIndex];
                    string id = row.Cells["extra_classes_id"].Value.ToString();
                    if (extraClassesDataView.Columns[e.ColumnIndex].Name == "ex_cl_delete" && e.RowIndex >= 0)
                    {
                        string message = "Do you want to delete this data?";
                        MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, "", deleteAction);
                        if (result == DialogResult.Yes)
                        {
                            extraClassesDataView.Rows.RemoveAt(e.RowIndex);
                            query = "DELETE FROM Extra_classes WHERE extra_classes_id='" + id + "'";
                            DbClient.query_execute(query);
                            MessageBox.Show("Data deleted from system");
                            extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
                        }
                        extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
           
        }

        private void addDayCheckBC_CheckedChanged(object sender, EventArgs e)
        {
            if (addDayCheckBC.Checked)
            {
                dayLblC.Visible = true;
                dayExtraClassesPk.Visible = true;
            }
            else
            {
                dayLblC.Visible = false;
                dayExtraClassesPk.Visible = false;
            }
        }

        private void addMonthCheckBC_CheckedChanged(object sender, EventArgs e)
        {
            if (addMonthBC.Checked)
            {
                addDayCheckBC.Visible = true;
                monthLblC.Visible = true;
                monthExtraClassesPk.Visible = true;
            }
            else
            {
                addDayCheckBC.Visible = false;
                monthLblC.Visible = false;
                monthExtraClassesPk.Visible = false;
            }
        }

        //expense
        private void addExpBtn_Click(object sender, EventArgs e)
        {
            if(InternetConnectivity.checkConnectivity())
            {
                try
                {
                    query = "INSERT INTO Expense(expense, amount, date) " +
                        "VALUES('" + expenseTb.Text + "', '" + expAmountTb.Text + "', '" + DateTime.Today + "')";
                    DbClient.query_execute(query);
                    
                    expenseTb.Text = null;
                    expAmountTb.Text = null;
                    totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");
                    DataFromDb.getExpenses = DbClient.dataSource("SELECT expense_id, expense, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Expense");
                    showExpenses();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Input all fields correctly!");
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
            
        }

        private void searchExpBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                if (!String.IsNullOrEmpty(expSearchTb.Text))
                {
                    try
                    {
                        (expensesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("expense LIKE '%{0}%'", expSearchTb.Text);
                        totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Search Again");
                        Console.WriteLine(ex.Message);
                    }

                }
                else
                {
                    (expensesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
            
        }

        private void loadExpBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }

            string loadListDateE = expYearPk.Text;
            if (expMonthPk.Visible == true)
            {
                loadListDateE = expMonthPk.Text + "-" + expYearPk.Text; 
            }
            Console.WriteLine(loadListDateE);
            (expensesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(Date, 'System.String') LIKE '%{0}%'", loadListDateE);
            totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");
        }

        private void expensesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = expensesDataView.Rows[e.RowIndex];
                string id = row.Cells["expense_id"].Value.ToString();
                if (expensesDataView.Columns[e.ColumnIndex].Name == "exp_delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete this expense?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        expensesDataView.Rows.RemoveAt(e.RowIndex);
                        query = "DELETE FROM Expense WHERE expense_id='" + id + "'";
                        DbClient.query_execute(query);
                        MessageBox.Show("Expense deleted from system");
                        totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addMonthCheckBE_CheckedChanged(object sender, EventArgs e)
        {
            if (addMonthCheckBE.Checked)
            {
                monthLblE.Visible = true;
                expMonthPk.Visible = true;
            }
            else
            {
                monthLblE.Visible = false;
                expMonthPk.Visible = false;
            }
        }

        //
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

        private string totalAmountInDataView(DataGridView data, string amountColumnId)
        {
            double total = 0;
            foreach(DataGridViewRow item in data.Rows)
            {
                total += double.Parse(item.Cells[amountColumnId].Value.ToString());
            }
            return total.ToString();
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            if(feedingPanel.Visible == true)
            {
                DataFromDb.getFeedingFee = DbClient.dataSource("SELECT feeding_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Feeding_fee");
                MessageBox.Show("Feeding data refreshed");
            }
            else if(expensePanel.Visible == true)
            {
                DataFromDb.getExpenses = DbClient.dataSource("SELECT expense_id, expense, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Expense");
                MessageBox.Show("Expenses data refreshed");
            }
            else if(classesPanel.Visible == true)
            {
                DataFromDb.getExtraClasses = DbClient.dataSource("SELECT extra_classes_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Extra_classes");
                MessageBox.Show("Extra classes data refreshed");
            }
            else { }
        }
    }
}
