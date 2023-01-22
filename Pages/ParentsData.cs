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
    public partial class ParentsData : Form
    {
        private string query;
        WaitFunc wait = new WaitFunc();
        private string category = LoginInput.category;
        public static string report_name;
        public static string report_class;
        public static string report_week;
        public static string report_date;
        public static string _teacher_id;
        public static string _date;

        public ParentsData()
        {
            InitializeComponent();

            showParentDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            showParentDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            showParentDataView.BackgroundColor = Home.foreColor;
            topPanel.BackColor = Home.foreColor;

            columnArrangement();

            showParentDataView.DataSource = DataFromDb.getAllWeeklyReportData();
            if (category.Equals("Class Teacher"))
            {
                delete.Visible = false;
            }
        }

        private void columnArrangement()
        {
            showParentDataView.AutoGenerateColumns = false;

            showParentDataView.Columns["id"].DisplayIndex = 0;
            showParentDataView.Columns["name"].DisplayIndex = 1;
            showParentDataView.Columns["_class"].DisplayIndex = 2;
            showParentDataView.Columns["week"].DisplayIndex = 3;
            showParentDataView.Columns["date"].DisplayIndex = 4;
            showParentDataView.Columns["view"].DisplayIndex = 5;
            showParentDataView.Columns["delete"].DisplayIndex = 6;
            
            searchCb.SelectedIndex = 0;
        }


        private void showParentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = showParentDataView.Rows[e.RowIndex];
                _teacher_id = row.Cells["id"].Value.ToString();
                _date = row.Cells["date_raw"].Value.ToString();

                report_name = row.Cells["name"].Value.ToString();
                report_class = row.Cells["_class"].Value.ToString();
                report_week = row.Cells["week"].Value.ToString();
                report_date = row.Cells["date"].Value.ToString();

                if (showParentDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete this report?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        wait.show();
                        query = "DELETE FROM Teachers_weekly_report WHERE teacher_id='" + _teacher_id + "' AND class='" + report_class + "' AND week='" + report_week + "' AND date='" + _date + "'";
                        DbClient.query_execute(query);

                        showParentDataView.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show("Report deleted from system");
                        wait.close();
                    }
                }

                if (showParentDataView.Columns[e.ColumnIndex].Name == "view" && e.RowIndex >= 0)
                {
                    wait.show();
                    WeeklyReportDetails detail = new WeeklyReportDetails();
                    detail.Show();
                    Home home = (Home)Application.OpenForms["Home"];
                    home.Hide();
                    wait.close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                wait.close();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
           
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {
                    if (searchCb.SelectedIndex == 1)
                    {
                        (showParentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchCb.Text.ToLower() + " = " + int.Parse(searchTextBox.Text));
                    }
                    else
                    {
                        (showParentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchCb.Text.ToLower() + " LIKE '%{0}%'", searchTextBox.Text);
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
                (showParentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void refeshBtn_Click(object sender, EventArgs e)
        {
            if (!InternetConnectivity.checkConnectivity())
            {
                return;
            }
            try
            {
                wait.show();
                DataFromDb.getAllWeeklyReport = DbClient.dataSource("SELECT teacher_id, date, (SELECT [f_name]+' '+[l_name] FROM Teacher WHERE Teacher.teacher_id=Teachers_weekly_report.teacher_id) AS name, class, week, FORMAT(date, 'dd-MM-yyyy') AS dateF FROM Teachers_weekly_report GROUP BY teacher_id, class, week, date");
                showParentDataView.DataSource = DataFromDb.getAllWeeklyReportData();
                wait.close();
            }
            catch { }
        }
    }
}
