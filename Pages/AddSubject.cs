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
    public partial class AddSubject : Form
    {
        Subject subject;
        WaitFunc wait = new WaitFunc();
        public AddSubject()
        {
            InitializeComponent();
            subjectDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            subjectDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            subjectDataView.BackgroundColor = Home.foreColor;
            topPanel.BackColor = Home.foreColor;
            bgPanel.BackColor = Home.foreColor;

            subject = new Subject();
            subjectDataView.DataSource = DataFromDb.getSubjectData();
            columnArrangement();
        }

        private void columnArrangement()
        {
            subjectDataView.Columns["subject_id"].DisplayIndex = 0;
            subjectDataView.Columns["subject_name"].DisplayIndex = 1;
            subjectDataView.Columns["class_total_marks"].DisplayIndex = 2;
            subjectDataView.Columns["exam_total_marks"].DisplayIndex = 3;
            subjectDataView.Columns["class_percentage"].DisplayIndex = 4;
            subjectDataView.Columns["exam_percentage"].DisplayIndex = 5;
            subjectDataView.Columns["pass_marks"].DisplayIndex = 6;
            subjectDataView.Columns["delete"].DisplayIndex = 7;

            subjectDataView.AutoGenerateColumns = false;


        }

        private void studentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = subjectDataView.Rows[e.RowIndex];
                string id = row.Cells["subject_id"].Value.ToString();
                string name = row.Cells["subject_name"].Value.ToString();


                if (subjectDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete " + name + "?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        wait.show();
                        string query = "DELETE FROM Student_marks WHERE subject_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM Student_result WHERE subject_id='" + id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM Teachers_weekly_report WHERE subject_id='" + id + "'";
                        DbClient.query_execute(query);


                        subjectDataView.Rows.RemoveAt(e.RowIndex);
                        subject.delete(id);
                        wait.close();
                        MessageBox.Show(name + " deleted from system");
                    }

                }
            } 
            catch (Exception ex)
            {
                wait.close();
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                
                if (!(String.IsNullOrEmpty(subjectNameTB.Text) && String.IsNullOrEmpty(examTotalMarkTB.Text) &&
                    String.IsNullOrEmpty(classTotalMarksTB.Text) && String.IsNullOrEmpty(examPercentageTB.Text) &&
                    String.IsNullOrEmpty(passMarksTB.Text)))
                {
                    wait.show();
                    subject = new Subject(subjectNameTB.Text, int.Parse(examTotalMarkTB.Text), int.Parse(classTotalMarksTB.Text), int.Parse(examPercentageTB.Text), int.Parse(classPercentageLB.Text), int.Parse(passMarksTB.Text));
                    subject.insert_data();
                    clearFeild();
                    DataFromDb.getSubject = DbClient.dataSource("SELECT subject_id, name, exam_total_marks, class_total_marks, exam_percentage, class_percentage, pass_marks FROM Subject");
                    subjectDataView.DataSource = DataFromDb.getSubjectData();
                    wait.close();
                }
                else
                {
                    MessageBox.Show("Every feild must be filled");
                }
            }
            catch(Exception ex)
            {
                wait.close();
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFeild()
        {
            subjectNameTB.Text = null;
            examTotalMarkTB.Text = null;
            examPercentageTB.Text = null;
            classTotalMarksTB.Text = null;
            passMarksTB.Text = null;
            classPercentageLB.Text = "00";
        }

        private void examPercentageTB_TextChanged(object sender, EventArgs e)
        {
            int outputValue = 0;
            bool isNumber = false;

            isNumber = int.TryParse(examPercentageTB.Text, out outputValue);
            if (!isNumber)
            {
                Console.WriteLine("Not a number");
            }
            else
            {
                classPercentageLB.Text = (100 - int.Parse(examPercentageTB.Text)).ToString();
            }
            
        }
    }
}
