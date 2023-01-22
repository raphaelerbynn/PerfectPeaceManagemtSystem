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
    public partial class WeeklyReportDetails : Form
    {
        private string query;

        public WeeklyReportDetails()
        {
            InitializeComponent();
            showParentDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            showParentDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            showParentDataView.BackgroundColor = Home.foreColor;

            this.BackColor = Home.foreColor;

            fillLabels();
            query = "SELECT subject, " +
                "number_exercises, " +
                                "home_assignment, " +
                                "dictation, " +
                                "project_work, " +
                                "reading_assignment, " +
                                "topics_covered, " +
                                "group_work " +
                                "FROM Teachers_weekly_report WHERE teacher_id='" + ParentsData._teacher_id + "' AND class='" + ParentsData.report_class + "' AND week='" + ParentsData.report_week + "' AND date='" + ParentsData._date + "'";
            DbClient.dataGridFill(showParentDataView, query);
        }

        private void fillLabels()
        {
            nameLbl.Text = ParentsData.report_name;
            classLbl.Text = ParentsData.report_class;
            wkLbl.Text = ParentsData.report_week;
            dateLbl.Text = ParentsData.report_date;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
        }
    }
}
