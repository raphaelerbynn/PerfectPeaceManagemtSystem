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
        }

        private void loadInfoBtn_Click(object sender, EventArgs e)
        {
            string queryTeacher = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher";
            string queryClass = "SELECT name FROM Class";
            if(categoryCb.SelectedIndex == 0)
            {
                classesPanel.Visible = false;
                feedingPanel.Visible = false;
                expensePanel.Visible = true;
            }
            else if(categoryCb.SelectedIndex == 1)
            {
                expensePanel.Visible = false;
                feedingPanel.Visible = false;
                classesPanel.Visible = true;
                classesPanel.Location = expensePanel.Location;
                DbClient.query_reader(teacherCb, queryTeacher);
                DbClient.query_reader(extraClassesClassCb, queryClass);
            }
            else if(categoryCb.SelectedIndex == 2)
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

        private void showExpenses()
        {
            //load data
            query = "SELECT * FROM Expense";
            DbClient.dataGridFill(expensesDataView, query);

        }

        private void showExtraClasses()
        {
            query = "SELECT * FROM Extra_classes";
            DbClient.dataGridFill(extraClassesDataView, query);
        }

        private void showFeeding()
        {
            query = "SELECT * FROM Feeding_fee";
            DbClient.dataGridFill(feedingDataView, query);
        }

        //feeding
        private void addFeedingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO Feeding_fee(teacher, class, amount, date) " +
                    "VALUES('" + feedingTeacherCb.Text + "', '" + feedingClassCb.Text + "', '" + feedingAmntTb.Text + "', '" + DateTime.Today + "')";
                DbClient.query_execute(query);
                showFeeding();
                feedingTeacherCb.SelectedIndex = -1;
                feedingClassCb.SelectedIndex = -1;
                feedingAmntTb.Text = null;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Input all fields correctly!");
            }
        }

        private void feedingSearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void feedingLoadBtn_Click(object sender, EventArgs e)
        {
            (feedingDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(Date, 'System.String') LIKE '%{0}%'", expYearPk.Text);
        }

        private void feedingDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //extra classes
        private void addExtraClassesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO Extra_classes(teacher, class, amount, date) " +
                    "VALUES('" + teacherCb.Text + "', '" + extraClassesClassCb.Text + "', '" + extraClassesAmntTb.Text + "', '" + DateTime.Today + "')";
                DbClient.query_execute(query);
                showExtraClasses();
                teacherCb.SelectedIndex = -1;
                extraClassesClassCb.SelectedIndex = -1;
                extraClassesAmntTb.Text = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Input all fields correctly!");
            }
        }

        private void extraClassesSearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void loadExtraClassesBtn_Click(object sender, EventArgs e)
        {
            (extraClassesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(Date, 'System.String') LIKE '%{0}%'", expYearPk.Text);
        }

        private void extraClassesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //expense
        private void addExpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO Expense(expense, amount, date) " +
                    "VALUES('" + expenseTb.Text + "', '" + expAmountTb.Text + "', '" + DateTime.Today + "')";
                DbClient.query_execute(query);
                showExpenses();
                expenseTb.Text = null;
                expAmountTb.Text = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Input all fields correctly!");
            }
        }

        private void searchExpBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadExpBtn_Click(object sender, EventArgs e)
        {
            (expensesDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(Date, 'System.String') LIKE '%{0}%'", expYearPk.Text);
        }

        private void expensesDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
