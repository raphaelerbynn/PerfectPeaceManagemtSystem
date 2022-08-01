﻿using System;
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
        private readonly string student_id = StudentReport.getIdFromSelectedRow();
        private readonly string term = StudentReport.getTermFromSelectedRow();
        private readonly string date = StudentReport.getDate();
        private readonly string result_id = StudentReport.getResultId();
        private readonly string class_position = StudentReport.getClassPosition();
        private int no_subject;
        private double total_fees = 0;
        

        public ReportCard()
        {
            InitializeComponent();
            
            fillLabels();
            populateResults();
            MessageBox.Show("Before printing result, Admin must save term attendance to get total student attendance", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgPanel.BackColor = Home.foreColor;

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
                printBillBtn.Location = new Point(printBillBtn.Location.X, printBillBtn.Location.Y + length_of_subject);
                testPanel.Location = new Point(testPanel.Location.X, testPanel.Location.Y + length_of_subject);
                printResultBtn.Location = new Point(printResultBtn.Location.X, printResultBtn.Location.Y + length_of_subject);

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

                    query = "SELECT student_id, RANK() OVER(ORDER BY total_score DESC) AS subject_position FROM Student_marks " +
                        "WHERE class='"+classLbl.Text+"' AND term='"+term+"' AND date LIKE '%"+date+"%' AND subject_id='"+id+"'";
                    reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {
                        if (student_id.Equals(reader["student_id"].ToString()))
                        {
                            item.Cells["position_in_subject"].Value = getSubjectPosition(reader["subject_position"].ToString());
                        }
                    }
                    reader.Close();
                    
                    resultDataView.ReadOnly = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void fillLabels()
        {
            termDate.Value = DateTime.Today;
            nameLbl.Text = "--------";
            classLbl.Text = "---";
            positionLbl.Text = "---";
            termLbl.Text = "---";
            noInClassLbl.Text = "---";
            nextTermDateLbl.Text = "-------";//
            rawScoreLbl.Text = "---";
            totalScoreLbl.Text = "---";
            conductLbl.Text = "-------------------";
            attitudeLbl.Text = "-------------------";
            interestLbl.Text = "-------------------";
            tRemarksLbl.Text = "-------------------";
            owingLbl.Text = "---";
            feesLbl.Text = "---";
            examsFeesLbl.Text = "---";
            transportLbl.Text = "---";
            extraClassesLbl.Text = "---";
            PtaLbl.Text = "---";//
            totalFeesLbl.Text = "---";//
            promotedClassLbl.Text = "";

            query = "SELECT * FROM Student WHERE student_id='" + student_id + "'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                nameLbl.Text = reader["f_name"].ToString() + " " + reader["m_name"].ToString() + " " + reader["l_name"].ToString();
                stntNameLbl.Text = nameLbl.Text;
                stntClassLbl.Text = nameLbl.Text;
                termLbl.Text = term;
                termLbl2.Text = term;
                owingLbl.Text = "Ghc "+reader["fees_owing"].ToString();
                total_fees += double.Parse(reader["fees_owing"].ToString());
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
                classLbl.Text = reader["class"].ToString();
                stntClassLbl.Text = classLbl.Text;
                promotedClassLbl.Text = reader["promoted_to"].ToString();
                noInClassLbl.Text = reader["class_total"].ToString();
            }
            reader.Close();
            positionLbl.Text = class_position;

            if(promotedClassLbl.Text == "")
            {
                query = "SELECT * FROM Class WHERE name='" + classLbl.Text + "'";
            }
            else
            {
                query = "SELECT * FROM Class WHERE name='" + promotedClassLbl.Text + "'";
            }
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                tuitionLbl.Text = reader["tuition"].ToString();
                firstAidLbl.Text = reader["firstAid"].ToString();
                PtaLbl.Text = reader["PTA"].ToString();
                waterLbl.Text = reader["water"].ToString();
                maintenanceLbl.Text = reader["maintenance"].ToString();
                stationaryLbl.Text = reader["stationary"].ToString();
                cocurricularLbl.Text = reader["cocurricular"].ToString();
                feesLbl.Text = reader["fees"].ToString();

            }
            reader.Close();
            

            query = "SELECT FORMAT(term_end_date, 'MMM-yyyy') FROM Total_attendance";
            DbClient.query_reader(termEndCb, query);
            
            if(termEndCb.Items.Count > 0)
            {
                termEndCb.SelectedIndex = termEndCb.Items.Count - 1;
            }

            //for bill
            if(term.Equals("3"))
            {
                total_fees += double.Parse(feesLbl.Text);
            }
            totalFeesLbl.Text = "Ghc " + total_fees.ToString();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            resultPrint(); 
        }

        private void resultPrint()
        {
            PrintDocument printdoc = new PrintDocument();
            PrintPreviewDialog printPreview = new PrintPreviewDialog();

            PrinterSettings ps = new PrinterSettings();
            //reportCardPanel = panel;
            //getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printResult_printPage);
            ((Form)printPreview).Size = new Size(950, 539);
            printPreview.ShowDialog();
        }

        private void printResult_printPage(object sender, PrintPageEventArgs e)
        {
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.reportCardPanel, true, true);
            e.Graphics.DrawImage(bitMap, new Rectangle(5, 5, reportCardPanel.Width, reportCardPanel.Height));
        }
        
        private void billsPrint()
        {
            PrintDocument printdoc = new PrintDocument();
            PrintPreviewDialog printPreview = new PrintPreviewDialog();

            PrinterSettings ps = new PrinterSettings();
            //reportCardPanel = panel;
            //getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printBills_printPage);
            ((Form)printPreview).Size = new Size(950, 539);
            printPreview.ShowDialog();
        }

        private void printBills_printPage(object sender, PrintPageEventArgs e)
        {
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.testPanel, true, true);
            e.Graphics.DrawImage(bitMap, new Rectangle(5, 5, testPanel.Width, testPanel.Height));
        }

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

        private void resultInputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double inputTotal = 0;
                if (!String.IsNullOrEmpty(transportTb.Text))
                {
                    transportLbl.Text = "Ghc " + transportTb.Text;
                    inputTotal += double.Parse(transportTb.Text);
                }
                else
                {
                    transportLbl.Text = "---";
                }
/*
                if (!String.IsNullOrEmpty(ptaDuesTb.Text))
                {
                    PtaLbl.Text = "Ghc " + ptaDuesTb.Text;
                    total_fees += double.Parse(ptaDuesTb.Text);
                }
                else
                {
                    PtaLbl.Text = "---";
                }*/

                if (!String.IsNullOrEmpty(examFeesTb.Text))
                {
                    examsFeesLbl.Text = "Ghc " + examFeesTb.Text;
                    inputTotal += double.Parse(examFeesTb.Text);
                }
                else
                {
                    extraClassesLbl.Text = "---";
                }

                if (!String.IsNullOrEmpty(extraClassesTb.Text))
                {
                    extraClassesLbl.Text = "Ghc " + extraClassesTb.Text;
                    inputTotal += double.Parse(extraClassesTb.Text);
                }
                else
                {
                    extraClassesLbl.Text = "---";
                }
                double total_fees_ = total_fees + inputTotal;
                totalFeesLbl.Text = "Ghc " + total_fees_.ToString();

                nextTermDateLbl.Text = termDate.Text;

                if (termEndCb.SelectedIndex > -1)
                {
                    query = "SELECT present, attendance FROM Total_attendance WHERE student_id='" + student_id + "' AND FORMAT(term_end_date, 'MMM-yyyy')='" + termEndCb.SelectedItem + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {
                        attendanceLbl.Text = reader["present"].ToString();
                        attendanceTotalLbl.Text = reader["attendance"].ToString();
                    }
                    reader.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string getSubjectPosition(string pos)
        {
            if (pos.EndsWith("11") || pos.EndsWith("12") || pos.EndsWith("13"))
            {
                return pos + "TH";
            }
            else if (pos.EndsWith("1"))
            {
                return pos + "ST";
            }
            else if (pos.EndsWith("2"))
            {
                return pos + "ND";
            }
            else if (pos.EndsWith("3"))
            {
                return pos + "RD";
            }
            return pos + "TH";
        }

        private void printBillBtn_Click(object sender, EventArgs e)
        {
            billsPrint();
        }
    }
}
