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

    public partial class Account : Form
    {
        private string query;
        WaitFunc wait = new WaitFunc();
        List<Label> expdLbls = new List<Label>();
        List<Point> exp_total_location = new List<Point>();

        public Account()
        {
            InitializeComponent();
            showExpenses();
            showFeeding();
            showExtraClasses();
            showBusFees();

            bgPanel.BackColor = Home.themeColor;
            feedingPanel.BackColor = Home.foreColor;
            expensePanel.BackColor = Home.foreColor;
            classesPanel.BackColor = Home.foreColor;
            busPanel.BackColor = Home.foreColor;
            summaryPanel.BackColor = Home.foreColor;

        }

        private void loadInfoBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {


                string queryTeacher = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Teaching'";
                string queryClass = "SELECT name FROM Class";

                if (categoryCb.SelectedIndex == 0)
                {
                    refeshBtn.Visible = true;
                    classesPanel.Visible = false;
                    feedingPanel.Visible = false;
                    expensePanel.Visible = true;
                    busPanel.Visible = false;
                    summaryPanel.Visible = false;
                }
                else if (categoryCb.SelectedIndex == 1)
                {

                    wait.show();
                    refeshBtn.Visible = true;
                    expensePanel.Visible = false;
                    feedingPanel.Visible = false;
                    busPanel.Visible = false;
                    classesPanel.Visible = true;
                    summaryPanel.Visible = false;
                    classesPanel.Location = expensePanel.Location;
                    DbClient.query_reader(teacherCb, queryTeacher);
                    DbClient.query_reader(extraClassesClassCb, queryClass);
                    refeshBtn.Visible = true;
                    wait.close();
                }
                else if (categoryCb.SelectedIndex == 2)
                {
                    wait.show();
                    expensePanel.Visible = false;
                    classesPanel.Visible = false;
                    busPanel.Visible = false;
                    feedingPanel.Visible = true;
                    summaryPanel.Visible = false;
                    feedingPanel.Location = expensePanel.Location;
                    DbClient.query_reader(feedingTeacherCb, queryTeacher);
                    DbClient.query_reader(feedingClassCb, queryClass);
                    refeshBtn.Visible = true;
                    wait.close();
                }
                else if (categoryCb.SelectedIndex == 3)
                {
                    wait.show();
                    expensePanel.Visible = false;
                    classesPanel.Visible = false;
                    feedingPanel.Visible = false;
                    busPanel.Visible = true;
                    summaryPanel.Visible = false;
                    busPanel.Location = expensePanel.Location;
                    DbClient.query_reader(busTeacherCb, queryTeacher);
                    DbClient.query_reader(busClassCb, queryClass);
                    refeshBtn.Visible = true;
                    wait.close();
                }
                else if (categoryCb.SelectedIndex == 4)
                {
                   
                    expensePanel.Visible = false;
                    classesPanel.Visible = false;
                    feedingPanel.Visible = false;
                    busPanel.Visible = false;
                    summaryPanel.Visible = true;
                    summaryPanel.Location = expensePanel.Location;
                    refeshBtn.Visible = false;

                    int i = 0;
                    foreach(Control c in panel1.Controls)
                    {
                        if (c.Tag != null && c.Tag?.ToString() == "ex_total")
                        {
                            exp_total_location.Add(c.Location);
                            i++;
                          
                        }
                    }
                    
                }
                else
                {
                    expensePanel.Visible = false;
                    classesPanel.Visible = false;
                    feedingPanel.Visible = false;
                    busPanel.Visible = false;
                    summaryPanel.Visible = false;

                    //wait.close();
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

        private void showBusFees()
        {
            busFeeDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            busFeeDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            busFeeDataView.BackgroundColor = Home.foreColor;

            busFeeDataView.DataSource = DataFromDb.getBusFeeData();
            busTotalLbl.Text = totalAmountInDataView(busFeeDataView, "busFeeAmount");
        }



        //feeding
        private void addFeedingBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                try
                {
                    wait.show();
                    query = "INSERT INTO Feeding_fee(teacher, class, amount, date) " +
                        "VALUES('" + feedingTeacherCb.Text + "', '" + feedingClassCb.Text + "', '" + feedingAmntTb.Text + "', '" + DateTime.Today + "')";
                    DbClient.query_execute(query);

                    feedingTeacherCb.SelectedIndex = -1;
                    feedingClassCb.SelectedIndex = -1;
                    feedingAmntTb.Text = null;
                    feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
                    DataFromDb.getFeedingFee = DbClient.dataSource("SELECT feeding_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Feeding_fee");
                    showFeeding();
                    wait.close();
                }
                catch (Exception ex)
                {
                    wait.close();
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

        private void feedingLoadBtn_Click(object sender, EventArgs e)
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
                            wait.show();
                            feedingDataView.Rows.RemoveAt(e.RowIndex);
                            query = "DELETE FROM Feeding_fee WHERE feeding_fee_id='" + id + "'";
                            DbClient.query_execute(query);
                            wait.close();
                            MessageBox.Show("Data deleted from system");
                            feedinTotalLbl.Text = totalAmountInDataView(feedingDataView, "feedingAmount");
                        }

                    }
                }
                catch (Exception ex)
                {
                    wait.close();
                    //MessageBox.Show(ex.Message);
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
                    wait.show();
                    query = "INSERT INTO Extra_classes(teacher, class, amount, date) " +
                        "VALUES('" + teacherCb.Text + "', '" + extraClassesClassCb.Text + "', '" + extraClassesAmntTb.Text + "', '" + DateTime.Today + "')";
                    DbClient.query_execute(query);

                    teacherCb.SelectedIndex = -1;
                    extraClassesClassCb.SelectedIndex = -1;
                    extraClassesAmntTb.Text = null;
                    DataFromDb.getExtraClasses = DbClient.dataSource("SELECT extra_classes_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Extra_classes");
                    showExtraClasses();
                    wait.close();
                }
                catch (Exception ex)
                {
                    wait.close();
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

        private void loadExtraClassesBtn_Click(object sender, EventArgs e)
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
                            wait.show();
                            extraClassesDataView.Rows.RemoveAt(e.RowIndex);
                            query = "DELETE FROM Extra_classes WHERE extra_classes_id='" + id + "'";
                            DbClient.query_execute(query);
                            wait.close();
                            MessageBox.Show("Data deleted from system");
                            extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
                        }
                        extraClassesTotalLbl.Text = totalAmountInDataView(extraClassesDataView, "extraClassesAmount");
                    }
                }
                catch (Exception ex)
                {
                    wait.close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //MessageBox.Show("Check your internet connection");
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
            if (InternetConnectivity.checkConnectivity())
            {
                try
                {
                    wait.show();
                    query = "INSERT INTO Expense(expense, amount, date) " +
                        "VALUES('" + expenseTb.Text + "', '" + expAmountTb.Text + "', '" + DateTime.Today + "')";
                    DbClient.query_execute(query);

                    expenseTb.Text = null;
                    expAmountTb.Text = null;
                    totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");
                    DataFromDb.getExpenses = DbClient.dataSource("SELECT expense_id, expense, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Expense");
                    showExpenses();
                    wait.close();
                }
                catch (Exception ex)
                {
                    wait.close();
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

        private void loadExpBtn_Click(object sender, EventArgs e)
        {

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
                        wait.show();
                        expensesDataView.Rows.RemoveAt(e.RowIndex);
                        query = "DELETE FROM Expense WHERE expense_id='" + id + "'";
                        DbClient.query_execute(query);
                        wait.close();
                        MessageBox.Show("Expense deleted from system");
                        totalExpLbl.Text = totalAmountInDataView(expensesDataView, "exp_amount");
                    }
                }
            }
            catch (Exception ex)
            {
                wait.close();
                //MessageBox.Show(ex.Message);
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
            foreach (DataGridViewRow item in data.Rows)
            {
                total += double.Parse(item.Cells[amountColumnId].Value.ToString());
            }
            return total.ToString();
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            wait.show();
            if (feedingPanel.Visible == true)
            {
                DataFromDb.getFeedingFee = DbClient.dataSource("SELECT feeding_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Feeding_fee");
                //MessageBox.Show("Feeding data refreshed");
                showFeeding();
            }
            else if (expensePanel.Visible == true)
            {
                DataFromDb.getExpenses = DbClient.dataSource("SELECT expense_id, expense, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Expense");
                //MessageBox.Show("Expenses data refreshed");
                showExpenses();
            }
            else if (classesPanel.Visible == true)
            {
                DataFromDb.getExtraClasses = DbClient.dataSource("SELECT extra_classes_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Extra_classes");
                //MessageBox.Show("Extra classes data refreshed");
                showExtraClasses();

            }
            else { }
            wait.close();
            //MessageBox.Show("Data refreshed");
        }


        //bus fee
        private void addBusFeeBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                try
                {
                    wait.show();
                    query = "INSERT INTO Bus_fee(teacher, class, amount, date) " +
                        "VALUES('" + busTeacherCb.Text + "', '" + busClassCb.Text + "', '" + busAmountTb.Text + "', '" + DateTime.Today + "')";
                    DbClient.query_execute(query);

                    busTeacherCb.SelectedIndex = -1;
                    busClassCb.SelectedIndex = -1;
                    busAmountTb.Text = null;
                    busTotalLbl.Text = totalAmountInDataView(busFeeDataView, "busFeeAmount");
                    DataFromDb.getBusFee = DbClient.dataSource("SELECT bus_fee_id, teacher, class, amount, FORMAT(date, 'dd-MM-yyyy') AS date FROM Bus_fee");
                    showBusFees();
                    wait.close();
                }
                catch (Exception ex)
                {
                    wait.close();
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Input all fields correctly!");
                }

            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
        }

        private void loadBusList_Click(object sender, EventArgs e)
        {

            string loadListDateF = busYearPk.Text;
            if (busMonthPk.Visible == true)
            {
                loadListDateF = busMonthPk.Text + "-" + busYearPk.Text;
                if (dayExtraClassesPk.Visible == true)
                {
                    loadListDateF = busDayPk.Text + "-" + loadListDateF;
                }
            }
            (busFeeDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(Date, 'System.String') LIKE '%{0}%'", loadListDateF);
            busTotalLbl.Text = totalAmountInDataView(busFeeDataView, "busFeeAmount");

        }

        private void busSearchBtn_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(busFeeSearchTb.Text))
            {
                try
                {
                    (busFeeDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("teacher LIKE '%{0}%'", busFeeSearchTb.Text);
                    busTotalLbl.Text = totalAmountInDataView(busFeeDataView, "busFeeAmount");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                (busFeeDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                busTotalLbl.Text = totalAmountInDataView(busFeeDataView, "busFeeAmount");
            }

        }

        private void busAddMonth_CheckedChanged(object sender, EventArgs e)
        {

            if (busAddMonth.Checked)
            {
                busAddDay.Visible = true;
                busdMonthLbl.Visible = true;
                busMonthPk.Visible = true;
            }
            else
            {
                busAddDay.Visible = false;
                busdMonthLbl.Visible = false;
                busMonthPk.Visible = false;
            }
        }

        private void busAddDay_CheckedChanged(object sender, EventArgs e)
        {
            if (busAddDay.Checked)
            {
                busDayLbl.Visible = true;
                busDayPk.Visible = true;
            }
            else
            {
                busDayLbl.Visible = false;
                busDayPk.Visible = false;
            }
        }

        private void busFeeDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity())
            {
                try
                {
                    DataGridViewRow row = busFeeDataView.Rows[e.RowIndex];
                    string id = row.Cells["busFee_id"].Value.ToString();
                    if (busFeeDataView.Columns[e.ColumnIndex].Name == "busDelete" && e.RowIndex >= 0)
                    {
                        string message = "Do you want to delete this data?";
                        MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, "", deleteAction);
                        if (result == DialogResult.Yes)
                        {
                            wait.show();
                            busFeeDataView.Rows.RemoveAt(e.RowIndex);
                            query = "DELETE FROM Bus_fee WHERE bus_fee_id='" + id + "'";
                            DbClient.query_execute(query);
                            wait.close();
                            MessageBox.Show("Data deleted from system");
                            busTotalLbl.Text = totalAmountInDataView(busFeeDataView, "busFeeAmount");
                        }

                    }
                }
                catch (Exception ex)
                {
                    wait.close();
                    //MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Check your internet connection");
            }
        }

        //expenditure
        private void expdAddMonth_CheckedChanged(object sender, EventArgs e)
        {

            if (expdMonth.Checked)
            {
                expdAddDay.Visible = true;
                expdMonthLbl.Visible = true;
                expdMonthPk.Visible = true;
            }
            else
            {
                expdAddDay.Visible = false;
                expdMonthLbl.Visible = false;
                expdMonthPk.Visible = false;
            }
        }

        private void expdAddDay_CheckedChanged(object sender, EventArgs e)
        {
            if (expdAddDay.Checked)
            {
                expdDayLbl.Visible = true;
                expdDayPk.Visible = true;
            }
            else
            {
                expdDayLbl.Visible = false;
                expdDayPk.Visible = false;
            }
        }

        private double incomeTotal(string q)
        {
            string t=DbClient.query_executeScaler(q);
            if (String.IsNullOrEmpty(t))
            {
                return double.Parse("0.00");
            }
            else
            {
                return double.Parse(t);
            }
        }

        private void loadExpenditure()
        {
            try
            {
                wait.show();
                List<Label> expdNameLbls = new List<Label>();
                List<Label> expdSeparators = new List<Label>();
                List<Label> expdAmountLbls = new List<Label>();

                for (int i = 0; i < expdLbls.Count; i++)
                {
                    panel1.Controls.Remove(expdLbls[i]);
                }
                expdLbls.Clear();


                string loadListDateF = expdYearPk.Text;
                if (expdMonthPk.Visible == true)
                {
                    loadListDateF = expdMonthPk.Text + "-" + expdYearPk.Text;
                    
                }
                Console.WriteLine(loadListDateF);

                double total_income = 0;
                query = "SELECT SUM(amount) FROM Bus_fee WHERE FORMAT(date, 'dd-MM-yyyy') LIKE '%" + loadListDateF + "%'";
                busIncomeLbl.Text = "GHc " + incomeTotal(query);
                total_income += incomeTotal(query);
                
                query = "SELECT SUM(amount) FROM Feeding_fee WHERE FORMAT(date, 'dd-MM-yyyy') LIKE '%" + loadListDateF + "%'";
                feedingIncomeLbl.Text = "GHc " + incomeTotal(query);
                total_income += incomeTotal(query);

                query = "SELECT SUM(amount) FROM Extra_classes WHERE FORMAT(date, 'dd-MM-yyyy') LIKE '%" + loadListDateF + "%'";
                classesIncomeLbl.Text = "GHc " + incomeTotal(query);
                total_income += incomeTotal(query);

                incomeLbl.Text = "GHc " + total_income;

                //query = "SELECT SUM(amount) FROM Bus_fee WHERE FORMAT(date, 'dd-MM-yyyy') LIKE '%" + loadListDateF + "%'";
                //busIncomeLbl.Text = "GHc " + DbClient.query_executeScaler(query);

                int y_location = 384;
                int exp_count = 0;
                double total_expd = 0;
                query = "SELECT SUM(amount) AS amount, expense FROM Expense WHERE FORMAT(date, 'dd-MM-yyyy') LIKE '%" + loadListDateF + "%'  GROUP BY expense";
                SqlDataReader reader = DbClient.query_reader(query);
                if (reader != null)
                {
                    
                    while (reader.Read())
                    {
                        Label expdNameLbl = new Label();
                        expdNameLbl.Text = reader["expense"].ToString();
                        expdNameLbl.Location = new Point(69, y_location);
                        expdNameLbl.Anchor = AnchorStyles.Top;
                        expdNameLbl.AutoSize = true;
                        expdNameLbl.Font = new Font("Calibri", 12);
                        expdNameLbls.Add(expdNameLbl);

                        Label expdSeparatorLbl = new Label();
                        expdSeparatorLbl.Text = "----------------------";
                        expdSeparatorLbl.Location = new Point(403, y_location);
                        expdSeparatorLbl.Anchor = AnchorStyles.Top;
                        expdSeparatorLbl.AutoSize = true;
                        expdSeparatorLbl.Font = new Font("Calibri", 12);
                        expdSeparators.Add(expdSeparatorLbl);

                        Label expdAmountLbl = new Label();
                        expdAmountLbl.Text = "GHc "+reader["amount"].ToString();
                        expdAmountLbl.Location = new Point(534, y_location);
                        expdAmountLbl.Anchor = AnchorStyles.Top;
                        expdAmountLbl.AutoSize = true;
                        expdAmountLbl.Font = new Font("Calibri", 12);
                        expdAmountLbls.Add(expdAmountLbl);

                        y_location += 21;
                        exp_count++;
                        total_expd += double.Parse(reader["amount"].ToString());
                        
                    }
                    reader.Close();
                }

                totalExpdLbl.Text = "GHc " + Math.Round(total_expd, 2);

                int n = 0;
                foreach(Control control in panel1.Controls)
                {
                    if (control.Tag != null && control.Tag?.ToString() == "ex_total")
                    {
                        control.Location = new Point(exp_total_location[n].X, exp_total_location[n].Y + (20*exp_count));
                        Console.WriteLine(control.Location);
                        n++;
                    } 
                }

                int panelHeight = panel1.Height;

                for (int i = 0; i < expdNameLbls.Count; i++)
                {
                    if (expdNameLbls[i].Location.Y < (panelHeight/2))
                    expdLbls.Add(expdNameLbls[i]);
                    panel1.Controls.Add(expdLbls[i]);

                    expdLbls.Add(expdAmountLbls[i]);
                    panel1.Controls.Add(expdLbls[i + expdAmountLbls.Count]);

                    expdLbls.Add(expdSeparators[i]);
                    panel1.Controls.Add(expdLbls[i + expdAmountLbls.Count + expdSeparators.Count]);
                }
                /*for (int i = 0; i < expdAmountLbls.Count; i++)
                {
                    expdLbls.Add(expdAmountLbls[i]);
                    panel1.Controls.Add(expdLbls[i + expdAmountLbls.Count]);

                }
                for (int i = 0; i < expdSeparators.Count; i++)
                {
                    expdLbls.Add(expdSeparators[i]);
                    panel1.Controls.Add(expdLbls[i + expdAmountLbls.Count + expdSeparators.Count]);

                }*/

                totalExpdLbl.Text = "GHc " + (total_income - total_expd);
                wait.close();
            }
            catch(Exception ex) {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void summaryListBtn_Click(object sender, EventArgs e)
        {
            if (!InternetConnectivity.checkConnectivity())
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            loadExpenditure();
        }

        private void print_page_Click(object sender, EventArgs e)
        {

        }
    }

}
