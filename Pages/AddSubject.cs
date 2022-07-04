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
        public AddSubject()
        {
            InitializeComponent();
            subject = new Subject();
            subject.show_data(subjectDataView);
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
                        subjectDataView.Rows.RemoveAt(e.RowIndex);
                        subject.delete(id);

                        MessageBox.Show(name + " deleted from system");
                    }

                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                subject = new Subject(subjectNameTB.Text, int.Parse(examTotalMarkTB.Text), int.Parse(classTotalMarksTB.Text), int.Parse(examPercentageTB.Text), int.Parse(classPercentageLB.Text), int.Parse(passMarksTB.Text));
                subject.insert_data();
                clearFeild();
                subject.show_data(subjectDataView);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFeild()
        {
            subjectNameTB.Text = null;
            examTotalMarkTB.Text = null;
            examPercentageTB.Text = null;
        }
    }
}
