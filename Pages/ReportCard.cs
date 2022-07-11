using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class ReportCard : Form
    {
        private string query;
        private string student_id = StudentReport.getIdFromSelectedRow();
        private string term = StudentReport.getTermFromSelectedRow();
        private string date = StudentReport.getDate();
        private string result_id = StudentReport.getResultId();
        private int no_subject;
        PrintDocument printdoc = new PrintDocument();
        PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public ReportCard()
        {
            InitializeComponent();
            populateResults();
            fillLabels();
        }

        private void populateResults()
        {
            try
            {
                query = "SELECT COUNT(*) FROM Subject";
                no_subject = int.Parse(DbClient.query_executeScaler(query)) + 1;
                int length_of_subject = 30 * no_subject;
                resultDataView.Size = new Size(resultDataView.Width, resultDataView.Height + length_of_subject);

                query = "SELECT subject_id, name, CAST(class_total_marks AS VARCHAR(5)) AS class_total_marks, CAST(exam_total_marks AS VARCHAR(5)) AS exam_total_marks, CAST(pass_marks AS VARCHAR(5)) AS pass_marks, CAST(exam_percentage AS VARCHAR(5)) AS position, CAST(class_percentage AS VARCHAR(10)) AS remarks FROM Subject";
                DbClient.dataGridFill(resultDataView, query);

                remarksPanel.Location = new Point(remarksPanel.Location.X, remarksPanel.Location.Y + length_of_subject);
                printBtn.Location = new Point(printBtn.Location.X, printBtn.Location.Y + length_of_subject);

                foreach (DataGridViewRow item in resultDataView.Rows)
                {
                    resultDataView.ReadOnly = false;
                    item.Cells["exam_score"].Value = "---";
                    item.Cells["class_score"].Value = "---";
                    item.Cells["total_score"].Value = "---";
                    item.Cells["total_score"].Value = "---";
                    item.Cells["position_in_subject"].Value = "---";
                    item.Cells["remarks"].Value = "--------";

                    string id = item.Cells["subject_id"].Value.ToString();
                    query = "SELECT * FROM Student_marks WHERE subject_id='"+id+"' AND student_id='"+student_id+"' AND term='"+term+"' AND date LIKE '%"+date+"%'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    
                    while (reader.Read())
                    {
                        
                        item.Cells["exam_score"].Value = reader["exam_score_percentage"].ToString();
                        item.Cells["class_score"].Value = reader["class_score_percentage"].ToString();
                        item.Cells["total_score"].Value = reader["total_score"].ToString();
                        item.Cells["remarks"].Value = reader["remarks"].ToString();
                        
                    }
                    reader.Close();
                    resultDataView.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillLabels()
        {
            nameLbl.Text = "--------";
            classLbl.Text = "---";
            positionLbl.Text = "---";//
            termLbl.Text = "---";
            noInClassLbl.Text = "---";//
            nextTermDateLbl.Text = "-------";//
            rawScoreLbl.Text = "---";
            totalScoreLbl.Text = "---";
            conductLbl.Text = "-------------------";
            attitudeLbl.Text = "-------------------";
            interestLbl.Text = "-------------------";
            tRemarksLbl.Text = "-------------------";
            owingLbl.Text = "---";
            feesLbl.Text = "---";//
            examsFeesLbl.Text = "---";//
            extraClassesLbl.Text = "---";//
            PtaLbl.Text = "---";//
            totalFeesLbl.Text = "---";//

            query = "SELECT * FROM Student WHERE student_id='" + student_id + "'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                nameLbl.Text = reader["f_name"].ToString() + " " + reader["m_name"].ToString() + " " + reader["l_name"].ToString();
                classLbl.Text = reader["class"].ToString();
                termLbl.Text = term;
                owingLbl.Text = reader["fees_owing"].ToString();
            }
            reader.Close();

            query = "SELECT * FROM Student_result WHERE student_result_id='"+result_id+"'";
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                totalScoreLbl.Text = reader["total_raw_score"].ToString();
                rawScoreLbl.Text = reader["raw_score"].ToString();
                conductLbl.Text = reader["conduct"].ToString();
                attitudeLbl.Text = reader["attitude"].ToString();
                interestLbl.Text = reader["interest"].ToString();
                tRemarksLbl.Text = reader["teacher_remarks"].ToString();

            }
            reader.Close();

        }

        private void resultDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Print(reportCardPanel);
        }

        private void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            //reportCardPanel = panel;
            //getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printPage);
            ((Form)printPreview).Size = new Size(950, 539);
            printPreview.ShowDialog();
        }

        private void printdoc_printPage(object sender, PrintPageEventArgs e)
        {
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.reportCardPanel, true, true);
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, reportCardPanel.Width, reportCardPanel.Height));
        }

        
    }
}
