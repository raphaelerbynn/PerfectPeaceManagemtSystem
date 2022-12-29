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
        private readonly string student_id = StudentReport.getIdFromSelectedRow();
        private readonly string term = StudentReport.getTermFromSelectedRow();
        private readonly string date = StudentReport.getDate();
        private readonly string result_id = StudentReport.getResultId();
        private readonly string class_position = StudentReport.getClassPosition();
        private readonly string class_section = StudentReport.getClassCategory();
        private readonly string class_name = StudentReport.getClassName();
        private int no_subject;
        private double total_fees = 0;
        WaitFunc wait = new WaitFunc();

        public ReportCard()
        {
            InitializeComponent();
            
            bgPanel.BackColor = Home.foreColor;
            orderColumn();
            showReport();
            MessageBox.Show("Before printing result, Admin must save term attendance to get total student attendance", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void orderColumn()
        {
            resultDataView.ReadOnly = false;
            resultDataView.Columns["subject"].DisplayIndex = 0;
            resultDataView.Columns["exam_score"].DisplayIndex = 1;
            resultDataView.Columns["class_score"].DisplayIndex = 2;
            resultDataView.Columns["total_score"].DisplayIndex = 3;
            resultDataView.Columns["position_in_subject"].DisplayIndex = 4;
            resultDataView.Columns["remarks"].DisplayIndex = 6;
            resultDataView.Columns["grade"].DisplayIndex = 5;
            
            //grade.DisplayIndex = 6;
            //remarks.DisplayIndex = 5;

            resultDataView.AutoGenerateColumns = false;
            resultDataView.ReadOnly = true;
        }

        private void showReport()
        {
            if(class_section.Equals("Crech") ||
                class_section.Equals("Nursury") ||
                class_section.Equals("KG"))
            {
                fillLabelsKg();
                populateAssessment();
                reportCardPanel.Visible = false;
                printResultBtn.Visible = false;

                assessmentPanel.Visible = true;
                printAssBtn.Visible = true;
                assessmentPanel.Location = reportCardPanel.Location;
                printAssBtn.Location = new Point(printAssBtn.Location.X, assessmentPanel.Location.Y + assessmentPanel.Height + 18);

                testPanel.Location = new Point(assessmentPanel.Location.X, assessmentPanel.Location.Y + assessmentPanel.Height + 100);
                printBillBtn.Location = new Point(printBillBtn.Location.X, testPanel.Location.Y + testPanel.Height + 18);
                
            }
            else
            {
                fillLabels();
                populateResults();
                reportCardPanel.Visible = true;
                printResultBtn.Visible = true;
                printResultBtn.Location = new Point(printResultBtn.Location.X, reportCardPanel.Location.Y + reportCardPanel.Height + 18);

                testPanel.Location = new Point(reportCardPanel.Location.X, reportCardPanel.Location.Y + reportCardPanel.Height + 100);
                printBillBtn.Location = new Point(printBillBtn.Location.X, testPanel.Location.Y + testPanel.Height + 18);

                assessmentPanel.Visible = false;
                printAssBtn.Visible = false;

                
            }
        }

        private void populateAssessment()
        {
            try
            {
                nextTermLbl.Text = "";
                int row_height = languageDataView.RowTemplate.Height;
                
                int lang_length = row_height*10;
                languageDataView.Size = new Size(languageDataView.Width, languageDataView.Height + lang_length);
                emotioalDataVeiw.Location = new Point(emotioalDataVeiw.Location.X, emotioalDataVeiw.Location.Y + lang_length);
                physicalDataView.Location = new Point(physicalDataView.Location.X, physicalDataView.Location.Y + lang_length);
                cognitiveDataView.Location = new Point(cognitiveDataView.Location.X, cognitiveDataView.Location.Y + lang_length);
                academicDataView.Location = new Point(academicDataView.Location.X, academicDataView.Location.Y + lang_length);
                
                query = "SELECT assessment, CAST(SATISFACTORY AS NVARCHAR(5)) AS SATISFACTORY, CAST(IMPROVED AS NVARCHAR(5)) AS IMPROVED, CAST(NEEDS_IMPROVEMENT AS NVARCHAR(5)) AS NEEDS_IMPROVEMENT, CAST(UNSATISFACTORY AS NVARCHAR(5)) AS UNSATISFACTORY FROM KG_assessment WHERE student_id='"+student_id+ "' AND category LIKE '%LANGUAGE%' AND class='" + classKgLbl.Text + "'";
                DbClient.dataGridFill(languageDataView, query);

                foreach(DataGridViewRow row in languageDataView.Rows)
                {
                    if (row.Cells["satisfactoryR"].Value.ToString() == "1")
                    {
                        row.Cells["satisfactoryR"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["satisfactoryR"].Value = " ";
                    }
                    
                    if (row.Cells["improvingR"].Value.ToString() == "1")
                    {
                        row.Cells["improvingR"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["improvingR"].Value = " ";
                    }
                    
                    if (row.Cells["needs_improvementR"].Value.ToString() == "1")
                    {
                        row.Cells["needs_improvementR"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["needs_improvementR"].Value = " ";
                    }
                    
                    if (row.Cells["unsatisfactoryR"].Value.ToString() == "1")
                    {
                        row.Cells["unsatisfactoryR"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["unsatisfactoryR"].Value = " ";
                    }
                    
                }
                
                int emotional_length = row_height*6;
                emotioalDataVeiw.Size = new Size(emotioalDataVeiw.Width, emotioalDataVeiw.Height + emotional_length);
                physicalDataView.Location = new Point(physicalDataView.Location.X, physicalDataView.Location.Y + emotional_length);
                cognitiveDataView.Location = new Point(cognitiveDataView.Location.X, cognitiveDataView.Location.Y + emotional_length);
                academicDataView.Location = new Point(academicDataView.Location.X, academicDataView.Location.Y + emotional_length);

                query = "SELECT assessment, CAST(SATISFACTORY AS NVARCHAR(5)) AS SATISFACTORY, CAST(IMPROVED AS NVARCHAR(5)) AS IMPROVED, CAST(NEEDS_IMPROVEMENT AS NVARCHAR(5)) AS NEEDS_IMPROVEMENT, CAST(UNSATISFACTORY AS NVARCHAR(5)) AS UNSATISFACTORY FROM KG_assessment WHERE student_id='"+student_id+ "' AND category LIKE '%EMOTIONAL%' AND class='" + classKgLbl.Text + "'";
                DbClient.dataGridFill(emotioalDataVeiw, query);

                foreach(DataGridViewRow row in emotioalDataVeiw.Rows)
                {
                    if (row.Cells["satisfactoryE"].Value.ToString() == "1")
                    {
                        row.Cells["satisfactoryE"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["satisfactoryE"].Value = " ";
                    }
                    
                    if (row.Cells["improvedE"].Value.ToString() == "1")
                    {
                        row.Cells["improvedE"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["improvedE"].Value = " ";
                    }
                    
                    if (row.Cells["needs_improvementE"].Value.ToString() == "1")
                    {
                        row.Cells["needs_improvementE"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["needs_improvementE"].Value = " ";
                    }
                    
                    if (row.Cells["unsatisfactoryE"].Value.ToString() == "1")
                    {
                        row.Cells["unsatisfactoryE"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["unsatisfactoryE"].Value = " ";
                    }
                    
                }
                
                int physical_length = row_height*5;
                physicalDataView.Size = new Size(physicalDataView.Width, physicalDataView.Height + physical_length);
                cognitiveDataView.Location = new Point(cognitiveDataView.Location.X, cognitiveDataView.Location.Y + physical_length);
                academicDataView.Location = new Point(academicDataView.Location.X, academicDataView.Location.Y + physical_length);

                //cognitiveDataView.Size = new Size(cognitiveDataView.Width, cognitiveDataView.Height + physical_length);
                query = "SELECT assessment, CAST(SATISFACTORY AS NVARCHAR(5)) AS SATISFACTORY, CAST(IMPROVED AS NVARCHAR(5)) AS IMPROVED, CAST(NEEDS_IMPROVEMENT AS NVARCHAR(5)) AS NEEDS_IMPROVEMENT, CAST(UNSATISFACTORY AS NVARCHAR(5)) AS UNSATISFACTORY FROM KG_assessment WHERE student_id='"+student_id+ "' AND category LIKE '%PHYSICAL%' AND class='" + classKgLbl.Text + "'";
                DbClient.dataGridFill(physicalDataView, query);

                foreach(DataGridViewRow row in physicalDataView.Rows)
                {
                    if (row.Cells["satisfactoryP"].Value.ToString() == "1")
                    {
                        row.Cells["satisfactoryP"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["satisfactoryP"].Value = " ";
                    }
                    
                    if (row.Cells["improvedP"].Value.ToString() == "1")
                    {
                        row.Cells["improvedP"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["improvedP"].Value = " ";
                    }
                    
                    if (row.Cells["needs_improvementP"].Value.ToString() == "1")
                    {
                        row.Cells["needs_improvementP"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["needs_improvementP"].Value = " ";
                    }
                    
                    if (row.Cells["unsatisfactoryP"].Value.ToString() == "1")
                    {
                        row.Cells["unsatisfactoryP"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["unsatisfactoryP"].Value = " ";
                    }
                    
                }
                
                int cognitive_length = row_height*9;
                cognitiveDataView.Size = new Size(cognitiveDataView.Width, cognitiveDataView.Height + cognitive_length);
                academicDataView.Location = new Point(academicDataView.Location.X, academicDataView.Location.Y + cognitive_length+5);

                query = "SELECT assessment, CAST(SATISFACTORY AS NVARCHAR(5)) AS SATISFACTORY, CAST(IMPROVED AS NVARCHAR(5)) AS IMPROVED, CAST(NEEDS_IMPROVEMENT AS NVARCHAR(5)) AS NEEDS_IMPROVEMENT, CAST(UNSATISFACTORY AS NVARCHAR(5)) AS UNSATISFACTORY FROM KG_assessment WHERE student_id='"+student_id+"' AND category LIKE '%COGNITIVE%' AND class='"+classKgLbl.Text+"'";
                DbClient.dataGridFill(cognitiveDataView, query);

                foreach (DataGridViewRow row in cognitiveDataView.Rows)
                {
                    if (row.Cells["satisfactoryC"].Value.ToString() == "1")
                    {
                        row.Cells["satisfactoryC"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["satisfactoryC"].Value = " ";
                    }

                    if (row.Cells["improvedC"].Value.ToString() == "1")
                    {
                        row.Cells["improvedC"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["improvedC"].Value = " ";
                    }

                    if (row.Cells["needs_improvementC"].Value.ToString() == "1")
                    {
                        row.Cells["needs_improvementC"].Value = "✔";
                    }
                    else
                    {
                        row.Cells["needs_improvementC"].Value = " ";
                        if (row.Cells["unsatisfactoryC"].Value.ToString() == "1")
                        {
                            row.Cells["unsatisfactoryC"].Value = "✔";
                        }
                        else
                        {
                            row.Cells["unsatisfactoryC"].Value = " ";
                        }

                    }

                    int academic_length = academicDataView.RowTemplate.Height * 5;
                    academicDataView.Size = new Size(academicDataView.Width, academicDataView.Height + academic_length);
                    titleLbl.Location = new Point(titleLbl.Location.X, academicDataView.Location.Y - 15);

                    query = "SELECT assessment, class_score, exam_score, total_score FROM KG_assessment WHERE student_id='" + student_id + "' AND category LIKE '%ACADEMIC%'";
                    DbClient.dataGridFill(academicDataView, query);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void populateResults()
        {
            try
            {
                query = "SELECT COUNT(*) FROM Subject";
                no_subject = int.Parse(DbClient.query_executeScaler(query)) + 1;
                int length_of_subject = 30 * no_subject;
                resultDataView.Size = new Size(resultDataView.Width, resultDataView.Height + length_of_subject);

                query = "SELECT subject_id, name, CAST(class_total_marks AS VARCHAR(5)) AS class_total_marks, CAST(exam_total_marks AS VARCHAR(5)) AS exam_total_marks, CAST(pass_marks AS VARCHAR(5)) AS pass_marks, CAST(exam_percentage AS VARCHAR(5)) AS position, CAST(class_percentage AS VARCHAR(10)) AS remarks, CAST(pass_marks AS VARCHAR(5)) AS grade FROM Subject";
                DbClient.dataGridFill(resultDataView, query);

                remarksPanel.Location = new Point(remarksPanel.Location.X, remarksPanel.Location.Y + length_of_subject);
                printBillBtn.Location = new Point(printBillBtn.Location.X, printBillBtn.Location.Y + length_of_subject);
                testPanel.Location = new Point(testPanel.Location.X, testPanel.Location.Y + length_of_subject);
                printResultBtn.Location = new Point(printResultBtn.Location.X, printResultBtn.Location.Y + length_of_subject);
                feesControls.Location = new Point(feesControls.Location.X, feesControls.Location.Y + length_of_subject);
                assessmentPanel.Location = new Point(assessmentPanel.Location.X, assessmentPanel.Location.Y + length_of_subject);
                printAssBtn.Location = new Point(printAssBtn.Location.X, printAssBtn.Location.Y + length_of_subject);
               
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

                    if (class_section.Equals("JHS"))
                    {
                        
                        grade.Visible = true;
                        
                        grading();
                        //resultDataView.Rows[1].Cells["grade"].Value = 1;
                    }
                    
                    resultDataView.ReadOnly = true;

                }

            }
            catch (Exception ex)
            {
                wait.close();
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void grading()
        {
            resultDataView.ReadOnly = false;
            foreach (DataGridViewRow row in resultDataView.Rows)
            {
                try
                {
                    string score = row.Cells["total_score"].Value.ToString();
                    
                    if (!score.Equals("---"))
                    {
                        
                        if (double.Parse(score) >= 80)
                        {
                            row.Cells["grade"].Value = "1";
                            
                            Console.WriteLine("score : " + row.Cells["grade"].Value.ToString());
                        }
                        else if (double.Parse(score) >= 70 && double.Parse(score) < 80)
                        {
                            row.Cells["grade"].Value = "2";
                        }
                        else if (double.Parse(score) >= 65 && double.Parse(score) < 70)
                        {
                            row.Cells["grade"].Value = "3";
                        }
                        else if (double.Parse(score) >= 60 && double.Parse(score) < 65)
                        {
                            row.Cells["grade"].Value = "4";
                        }
                        else if (double.Parse(score) >= 55 && double.Parse(score) < 60)
                        {
                            row.Cells["grade"].Value = "5";
                        }
                        else if (double.Parse(score) >= 50 && double.Parse(score) < 55)
                        {
                            row.Cells["grade"].Value = "6";
                        }
                        else if (double.Parse(score) >= 45 && double.Parse(score) < 50)
                        {
                            row.Cells["grade"].Value = "7";
                        }else if (double.Parse(score) >= 40 && double.Parse(score) < 45)
                        {
                            row.Cells["grade"].Value = "8";
                        }
                        else
                        {
                            row.Cells["grade"].Value = "9";
                        }
                    }
                    else
                    {
                        row.Cells["grade"].Value = "---";
                    }
                }
                catch (Exception ex){ Console.WriteLine(ex.StackTrace); }
            }
        }

        private void fillLabelsKg()
        {
            teacherKgLbl.Text = "";
            string _class = "";
            string _class_for_teacher = "";
            query = "SELECT class, class_id, [f_name]+' '+[m_name]+' '+[l_name] AS name FROM Student WHERE student_id='" + student_id + "'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                nameKgLbl.Text = reader["name"].ToString();
                termKgLbl.Text = term;
                classKgLbl.Text = class_name;
                classLbl.Text = reader["class"].ToString();
                _class = reader["class_id"].ToString();

                stntNameLbl.Text = nameKgLbl.Text;
                stntClassLbl.Text = classKgLbl.Text;
                dateLbl.Text = DateTime.Now.ToString("dd-MMM-yyyy");
                termLbl2.Text = termLbl.Text;
            }
            reader.Close();

            query = "SELECT class_id FROM Class WHERE name='" + class_name + "'"; ;
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                _class_for_teacher = reader["class_id"].ToString();
            }
            reader.Close();


            query = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE class_id='" + _class_for_teacher + "'"; ;
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                teacherKgLbl.Text = reader["name"].ToString();
            }
            reader.Close();

            

            query = "SELECT * FROM Class WHERE class_id='" + _class + "'";
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
        }

        private void fillLabels()
        {
            try
            {
                dateLbl.Text = DateTime.Now.ToString("dd-MMM-yyyy");
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

                query = "SELECT fees_owing, [f_name]+' '+[m_name]+' '+[l_name] AS name FROM Student WHERE student_id='" + student_id + "'";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    nameLbl.Text = reader["name"].ToString();
                    stntNameLbl.Text = nameLbl.Text;
                    stntClassLbl.Text = nameLbl.Text;
                    termLbl.Text = term;
                    termLbl2.Text = term;
                    owingLbl.Text = "Ghc " + reader["fees_owing"].ToString();
                    total_fees += double.Parse(reader["fees_owing"].ToString());
                }
                reader.Close();


                query = "SELECT * FROM Student_result WHERE student_result_id='" + result_id + "'";
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

                if (promotedClassLbl.Text == "")
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


                query = "SELECT FORMAT(term_end_date, 'MMM-yyyy') FROM Total_attendance GROUP BY term_end_date";
                DbClient.query_reader(termEndCb, query);

                if (termEndCb.Items.Count > 0)
                {
                    termEndCb.SelectedIndex = termEndCb.Items.Count - 1;
                }

                //for bill
                if (term.Equals("3"))
                {
                    total_fees += double.Parse(feesLbl.Text);
                }
                totalFeesLbl.Text = "Ghc " + total_fees.ToString();

                Console.WriteLine(promotedClassLbl.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
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
        
        private void assessmentPrint()
        {
            PrintDocument printdoc = new PrintDocument();
            PrintPreviewDialog printPreview = new PrintPreviewDialog();

            PrinterSettings ps = new PrinterSettings();
            //reportCardPanel = panel;
            //getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printAssessment_printPage);
            ((Form)printPreview).Size = new Size(950, 539);
            printPreview.ShowDialog();
        }

        private void printAssessment_printPage(object sender, PrintPageEventArgs e)
        {
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.assessmentPanel, true, true);
            e.Graphics.DrawImage(bitMap, new Rectangle(5, 5, assessmentPanel.Width, assessmentPanel.Height));
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
                wait.show();
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
                nextTermLbl.Text = termDate.Text;

                if (termEndCb.SelectedIndex > -1)
                {
                    query = "SELECT present, attendance FROM Total_attendance WHERE student_id='" + student_id + "' AND FORMAT(term_end_date, 'MMM-yyyy')='" + termEndCb.SelectedItem + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {
                        attendanceLbl.Text = reader["present"].ToString();
                        attendanceTotalLbl.Text = reader["attendance"].ToString();
                        Console.WriteLine(reader["attendance"].ToString());
                    }
                    reader.Close();
                    wait.close();
                }
            }catch(Exception ex)
            {
                wait.close();
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

        private void printAssBtn_Click(object sender, EventArgs e)
        {
            assessmentPrint();
        }

        private void languageDataView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            this.Close();
        }

        private void setFeesBtn_Click(object sender, EventArgs e)
        {
            totalFeesLbl.Text = feesTb.Text;
        }
    }
}
