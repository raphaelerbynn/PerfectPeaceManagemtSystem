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
    public partial class ReportForKG : Form
    {
        List<Label> cognitiveAssessment = new List<Label>();
        List<Label> physicalAssessment = new List<Label>();
        List<Label> emotionalAssessment = new List<Label>();
        List<Label> languageAssessment = new List<Label>();

        List<ComboBox> cognitiveGrade = new List<ComboBox>(); 
        List<ComboBox> physicalGrade = new List<ComboBox>(); 
        List<ComboBox> emotionalGrade = new List<ComboBox>(); 
        List<ComboBox> languageGrade = new List<ComboBox>();
       
        private string student_id = StudentReport.getIdFromSelectedRow();
        private string class_section = StudentReport.getClassCategory();
        private string query;
        private bool enable = true;

        private int exam_total;
        private int class_total;
        private int class_percentage;
        private int exam_percentage;

        WaitFunc wait = new WaitFunc();

        public ReportForKG()
        {
            InitializeComponent();
            topPanel.BackColor = Home.themeColor;
            languagePanel.BackColor = Home.foreColor;
            physicalPanel.BackColor = Home.foreColor;
            cognititvePanel.BackColor = Home.foreColor;
            emotionalPanel.BackColor = Home.foreColor;

            topPanel.ForeColor = Home.foreColor;

            bgPanel.BackColor = Home.foreColor;
            panel1.BackColor = Home.foreColor;
            
            getStudentInfo();
            compileResults();
            kg_score_values();
            categoryCb.SelectedIndex = 0;
            termCb.SelectedIndex = 0;
        }

        private void compileResults()
        {
            if (class_section.Equals("KG"))
            {
                changeLbl.Text = "Shows interest in writing";
                changeLbl.Location = new Point(changeLbl.Location.X - 20, changeLbl.Location.Y);

                colorsLbl.Text = "Recognizes colors";
                colorsLbl.Location = new Point(colorsLbl.Location.X - 20, colorsLbl.Location.Y);

                envLbl.Text = "OWOP";

                foreach (Control control in languagePanel.Controls)
                {
                    if (control.Tag?.ToString() == "notKg")
                    {
                        Label lbl = new Label();
                        lbl.Text = "Not applicable";
                        lbl.Anchor = AnchorStyles.Top;
                        lbl.Location = new Point(control.Location.X + control.Width + 5, control.Location.Y + 4);
                        control.Enabled = false;
                        lbl.Enabled = false;
                        languagePanel.Controls.Add(lbl);
                        foreach (Control c in languagePanel.Controls)
                        {
                            if (c.Location.Y == control.Location.Y)
                            {
                                c.Enabled = false;
                            }
                        }
                    }
                }

                foreach (Control control in emotionalPanel.Controls)
                {
                    if (control.Tag?.ToString() == "notKg")
                    {
                        Label lbl = new Label();
                        lbl.Text = "Not applicable";
                        lbl.Anchor = AnchorStyles.Top;
                        lbl.Location = new Point(control.Location.X + control.Width + 5, control.Location.Y + 4);
                        control.Enabled = false;
                        lbl.Enabled = false;
                        emotionalPanel.Controls.Add(lbl);
                        foreach (Control c in emotionalPanel.Controls)
                        {
                            if (c.Location.Y == control.Location.Y)
                            {
                                c.Enabled = false;
                            }
                        }
                    }
                }

                foreach (Control control in physicalPanel.Controls)
                {
                    if (control.Tag?.ToString() == "notKg")
                    {
                        Label lbl = new Label();
                        lbl.Text = "Not applicable";
                        lbl.Anchor = AnchorStyles.Top;
                        lbl.Location = new Point(control.Location.X + control.Width + 5, control.Location.Y + 4);
                        control.Enabled = false;
                        lbl.Enabled = false;
                        physicalPanel.Controls.Add(lbl);
                        foreach (Control c in physicalPanel.Controls)
                        {
                            if (c.Location.Y == control.Location.Y)
                            {
                                c.Enabled = false;
                            }
                        }
                    }
                }

                foreach (Control control in cognititvePanel.Controls)
                {

                    if (control.Tag?.ToString() == "notKg")
                    {
                        Label lbl = new Label();
                        lbl.Text = "Not applicable";
                        lbl.Anchor = AnchorStyles.Top;
                        lbl.Location = new Point(control.Location.X + control.Width + 5, control.Location.Y + 4);
                        control.Enabled = false;
                        lbl.Enabled = false;
                        cognititvePanel.Controls.Add(lbl);
                        foreach (Control c in cognititvePanel.Controls)
                        {
                            if (c.Location.Y == control.Location.Y)
                            {
                                c.Enabled = false;
                            }
                        }
                    }
                }
            }

            //
            foreach (Control control in languagePanel.Controls)
            {
                if (control is Label && control.Enabled == true)
                {
                    Console.WriteLine(((Label)control).Text);
                    languageAssessment.Add((Label)control);

                    foreach (Control c in languagePanel.Controls)
                    {
                        if (c is ComboBox && c.Location.Y == control.Location.Y)
                        {
                            languageGrade.Add((ComboBox)c);
                        }
                    }
                }

            }

            foreach (Control control in emotionalPanel.Controls)
            {
                if (control is Label && control.Enabled == true)
                {
                    Console.WriteLine(((Label)control).Text);
                    emotionalAssessment.Add((Label)control);

                    foreach (Control c in emotionalPanel.Controls)
                    {
                        if (c is ComboBox && c.Location.Y == control.Location.Y)
                        {
                            emotionalGrade.Add((ComboBox)c);
                        }
                    }
                }

            }

            foreach (Control control in physicalPanel.Controls)
            {
                if (control is Label && control.Enabled == true)
                {
                    Console.WriteLine(((Label)control).Text);
                    physicalAssessment.Add((Label)control);

                    foreach (Control c in physicalPanel.Controls)
                    {
                        if (c is ComboBox && c.Location.Y == control.Location.Y)
                        {
                            physicalGrade.Add((ComboBox)c);
                        }
                    }
                }
            }

            foreach (Control control in cognititvePanel.Controls)
            {
                if (control is Label && control.Enabled == true)
                {
                    Console.WriteLine(((Label)control).Text);
                    cognitiveAssessment.Add((Label)control);

                    foreach (Control c in cognititvePanel.Controls)
                    {
                        if (c is ComboBox && c.Location.Y == control.Location.Y)
                        {
                            cognitiveGrade.Add((ComboBox)c);
                        }
                    }
                }
            }
        }

        private void getStudentInfo()
        {
            lanTotalLbl.Text = "";
            artTotalLbl.Text = "";
            envTotalLbl.Text = "";
            mathTotalLbl.Text = "";
            phoTotalLbl.Text = "";

            query = "SELECT * FROM Student WHERE student_id='" + student_id + "'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                studentNameLbl.Text = reader["f_name"].ToString() + " " + reader["l_name"].ToString();
                classLbl.Text = reader["class"].ToString();
            }
            reader.Close();
        }

        private void categoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryCb.SelectedIndex == 0)
            {
                languageLbl.Visible = true;
                languagePanel.Visible = true;

                emotionalLbl.Visible = false;
                emotionalPanel.Visible = false;

                physicalLbl.Visible = false;
                physicalPanel.Visible = false;

                cognitiveLbl.Visible = false;
                cognititvePanel.Visible = false;
                
                academicLbl.Visible = false;
                academicPanel.Visible = false;
            }
            
            if(categoryCb.SelectedIndex == 1)
            {
                languageLbl.Visible = false;
                languagePanel.Visible = false;

                emotionalLbl.Visible = true;
                emotionalPanel.Visible = true;

                physicalLbl.Visible = false;
                physicalPanel.Visible = false;

                cognitiveLbl.Visible = false;
                cognititvePanel.Visible = false;
                
                academicLbl.Visible = false;
                academicPanel.Visible = false;

                emotionalLbl.Location = new Point(emotionalLbl.Location.X, languageLbl.Location.Y);
                emotionalPanel.Location = new Point(emotionalPanel.Location.X, languagePanel.Location.Y);
            }
            
            if(categoryCb.SelectedIndex == 2)
            {
                languageLbl.Visible = false;
                languagePanel.Visible = false;

                emotionalLbl.Visible = false;
                emotionalPanel.Visible = false;

                physicalLbl.Visible = true;
                physicalPanel.Visible = true;

                cognitiveLbl.Visible = false;
                cognititvePanel.Visible = false;
                
                academicLbl.Visible = false;
                academicPanel.Visible = false;

                physicalLbl.Location = new Point(physicalLbl.Location.X, languageLbl.Location.Y);
                physicalPanel.Location = new Point(physicalPanel.Location.X, languagePanel.Location.Y);
            }
            
            if(categoryCb.SelectedIndex == 3)
            {
                languageLbl.Visible = false;
                languagePanel.Visible = false;

                emotionalLbl.Visible = false;
                emotionalPanel.Visible = false;

                physicalLbl.Visible = false;
                physicalPanel.Visible = false;

                cognitiveLbl.Visible = true;
                cognititvePanel.Visible = true;
                
                academicLbl.Visible = false;
                academicPanel.Visible = false;

                cognitiveLbl.Location = new Point(cognitiveLbl.Location.X, languageLbl.Location.Y);
                cognititvePanel.Location = new Point(cognititvePanel.Location.X, languagePanel.Location.Y);
            }

            if(categoryCb.SelectedIndex == 4)
            {
                languageLbl.Visible = false;
                languagePanel.Visible = false;

                emotionalLbl.Visible = false;
                emotionalPanel.Visible = false;

                physicalLbl.Visible = false;
                physicalPanel.Visible = false;

                cognitiveLbl.Visible = false;
                cognititvePanel.Visible = false;
                
                academicLbl.Visible = true;
                academicPanel.Visible = true;

                academicLbl.Location = new Point(academicLbl.Location.X, languageLbl.Location.Y);
                academicPanel.Location = new Point(academicPanel.Location.X, languagePanel.Location.Y);
            }
        }

        private void detailsToDb()
        {
            try
            {
                wait.show();
                query = "DELETE FROM KG_assessment WHERE student_id='"+student_id+"' AND term='" + termCb.SelectedItem.ToString() + "' AND class='" + classLbl.Text + "' AND date LIKE '%" + DateTime.Now.Year + "%'";
                DbClient.query_execute(query);

                for(int i = 0; i < languageAssessment.Count; i++)
                {
                    if (languageGrade[i].SelectedIndex > -1)
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, " + languageGrade[i].SelectedItem.ToString() + ", term, class, date, student_id) " +
                            "VALUES('" + languageAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '1', '"+termCb.SelectedItem.ToString()+"', '"+classLbl.Text+"', '"+DateTime.Today+"', '"+student_id+"')";
                        DbClient.query_execute(query);
                    }
                    else
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, term, class, date, student_id) " +
                           "VALUES('" + languageAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                        DbClient.query_execute(query);
                    }
                }
                
                for(int i = 0; i < emotionalAssessment.Count; i++)
                {
                    if (emotionalGrade[i].SelectedIndex > -1)
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, " + emotionalGrade[i].SelectedItem.ToString() + ", term, class, date, student_id) " +
                            "VALUES('" + emotionalAssessment[i].Text + "', 'PERSONAL / SOCIAL / EMOTIONAL DEVELOPMENT', '1', '" + termCb.SelectedItem.ToString()+"', '"+classLbl.Text+"', '"+DateTime.Today+"', '"+student_id+"')";
                        DbClient.query_execute(query);
                    }
                    else
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, term, class, date, student_id) " +
                           "VALUES('" + emotionalAssessment[i].Text + "', 'PERSONAL / SOCIAL / EMOTIONAL DEVELOPMENT', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                        DbClient.query_execute(query);
                    }
                }
                
                for(int i = 0; i < physicalAssessment.Count; i++)
                {
                    if (physicalGrade[i].SelectedIndex > -1)
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, " + physicalGrade[i].SelectedItem.ToString() + ", term, class, date, student_id) " +
                            "VALUES('" + physicalAssessment[i].Text + "', 'PHYSICAL DEVELOPMENT', '1', '" + termCb.SelectedItem.ToString()+"', '"+classLbl.Text+"', '"+DateTime.Today+"', '"+student_id+"')";
                        DbClient.query_execute(query);
                    }
                    else
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, term, class, date, student_id) " +
                           "VALUES('" + physicalAssessment[i].Text + "', 'PHYSICAL DEVELOPMENT', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                        DbClient.query_execute(query);
                    }
                }

                for(int i = 0; i < cognitiveAssessment.Count; i++)
                {
                    if (cognitiveGrade[i].SelectedIndex > -1)
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, " + cognitiveGrade[i].SelectedItem.ToString() + ", term, class, date, student_id) " +
                            "VALUES('" + cognitiveAssessment[i].Text + "', 'COGNITIVE DEVELOPMENT (POSITION, DIRECTION, THINKING)', '1', '" + termCb.SelectedItem.ToString()+"', '"+classLbl.Text+"', '"+DateTime.Today+"', '"+student_id+"')";
                        DbClient.query_execute(query);
                    }
                    else
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, term, class, date, student_id) " +
                           "VALUES('" + cognitiveAssessment[i].Text + "', 'COGNITIVE DEVELOPMENT (POSITION, DIRECTION, THINKING)', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                        DbClient.query_execute(query);
                    }
                }

                kgScoresToDb(lanLbl.Text, lanClassScoreTb.Text, lanExamTb.Text, lanTotalLbl.Text);
                kgScoresToDb(artLbl.Text, artClassTb.Text, artExamTb.Text, artTotalLbl.Text);
                kgScoresToDb(envLbl.Text, envClassTb.Text, envExamTb.Text, envTotalLbl.Text);
                kgScoresToDb(mathLbl.Text, mathClassTb.Text, mathExamTb.Text, mathTotalLbl.Text);
                kgScoresToDb(phoLbl.Text, phoClassTb.Text, phoExamTb.Text, phoTotalLbl.Text);
                wait.close();

            }
            catch(Exception ex)
            {
                wait.close();
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void kgScoresToDb(string assessment, string cs, string es, string ts)
        {
            try
            {
                query = "INSERT INTO KG_assessment(assessment, category, class_score, exam_score, total_score, term, class, date, student_id) " +
                              "VALUES('" + assessment + "', 'ACADEMIC PROGRESS/EXAMINATION SCORES', " + cs + ", '" + es + "', '" + ts + "', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                DbClient.query_execute(query);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void kg_score_values()
        {
            try
            {
                query = "SELECT * FROM KG_calc_values";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    exam_percentage = int.Parse(reader["exam_percentage"].ToString());
                    class_percentage = int.Parse(reader["class_percentage"].ToString());
                    class_total = int.Parse(reader["class_total"].ToString());
                    exam_total = int.Parse(reader["exam_total"].ToString());
                    
                    examPercentageTB.Text = exam_percentage.ToString();
                    classPercentageLB.Text = class_percentage.ToString();
                    classTotalMarksTB.Text = class_total.ToString();
                    examTotalMarkTB.Text = exam_total.ToString();

                    if (!String.IsNullOrEmpty(examPercentageTB.Text))
                    {
                        examTotalMarkTB.Enabled = false;
                        classTotalMarksTB.Enabled = false;
                        examPercentageTB.Enabled = false;
                    }
                }
                reader.Close();
            }
            catch(Exception ex)
            {
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
            string message = "All Categories filled and you want to save?";
            MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", deleteAction);
            if (result == DialogResult.Yes)
            {
                detailsToDb();
                MessageBox.Show("Assessment Saved");
            }
        }

        private void setValBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                
                class_total = int.Parse(classTotalMarksTB.Text);
                class_percentage = int.Parse(classPercentageLB.Text);
                exam_total = int.Parse(examTotalMarkTB.Text);
                exam_percentage = int.Parse(examPercentageTB.Text);

                if (enable == true)
                {
                    wait.show();
                    DbClient.query_execute("DELETE FROM KG_calc_values");

                    query = "INSERT INTO KG_calc_values (exam_total, class_total, class_percentage, exam_percentage) " +
                        "VALUES('" + examTotalMarkTB.Text + "', '" + classTotalMarksTB.Text + "', '" + classPercentageLB.Text + "', '" + examPercentageTB.Text + "')";
                    DbClient.query_execute(query);
                    MessageBox.Show("Parameters set... You can input your scores");
                    classPercentageLB.Enabled = false;
                    examPercentageTB.Enabled = false;
                    classTotalMarksTB.Enabled = false;
                    examTotalMarkTB.Enabled = false;

                    enable = false;
                    wait.close();
                }

                else
                {
                    classPercentageLB.Enabled = true;
                    examPercentageTB.Enabled = true;
                    classTotalMarksTB.Enabled = true;
                    examTotalMarkTB.Enabled = true;

                    enable = true;
                }
            }
            catch
            {
                wait.close();
                MessageBox.Show("Check your input");
            }
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

        private void calcResult_TextChanged(object sender, EventArgs e)
        {
            decimal lanTotal = 0;
            if (!String.IsNullOrEmpty(lanClassScoreTb.Text))
            {
                if (int.Parse(lanClassScoreTb.Text) <= class_total)
                {
                    lanTotal += (decimal.Parse(lanClassScoreTb.Text) / class_total) * class_percentage;
                }
                else
                {
                    MessageBox.Show("Class score exceeds total");
                    lanClassScoreTb.Text = null;
                }
            }
            if (!String.IsNullOrEmpty(lanExamTb.Text))
            {
                if (int.Parse(lanExamTb.Text) <= exam_total)
                {
                    lanTotal += (decimal.Parse(lanExamTb.Text) / exam_total) * exam_percentage;
                }
                else
                {
                    MessageBox.Show("Exam score exceeds total");
                    lanExamTb.Text = null;
                }
            }
            lanTotalLbl.Text = String.Format("{0:0.00}", lanTotal);
            
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void art_TextChanged(object sender, EventArgs e)
        {
            decimal artTotal = 0;
            if (!String.IsNullOrEmpty(artClassTb.Text))
            {
                if (int.Parse(artClassTb.Text) <= class_total)
                {
                    artTotal += (decimal.Parse(artClassTb.Text) / class_total) * class_percentage;
                }
                else
                {
                    MessageBox.Show("Class score exceeds total");
                    artClassTb.Text = null;
                }
            }
            if (!String.IsNullOrEmpty(artExamTb.Text))
            {
                if (int.Parse(artExamTb.Text) <= exam_total)
                {
                    artTotal += (decimal.Parse(artExamTb.Text) / exam_total) * exam_percentage;
                }
                else
                {
                    MessageBox.Show("Exam score exceeds total");
                    artExamTb.Text = null;
                }
            }
            artTotalLbl.Text = String.Format("{0:0.00}", artTotal);
        }

        private void env_TextChanged(object sender, EventArgs e)
        {
            decimal envTotal = 0;
            if (!String.IsNullOrEmpty(envClassTb.Text))
            {
                if (int.Parse(envClassTb.Text) <= class_total)
                {
                    envTotal += (decimal.Parse(envClassTb.Text) / class_total) * class_percentage;
                }
                else
                {
                    MessageBox.Show("Class score exceeds total");
                    envClassTb.Text = null;
                }
            }
            if (!String.IsNullOrEmpty(envExamTb.Text))
            {
                if (int.Parse(envExamTb.Text) <= exam_total)
                {
                    envTotal += (decimal.Parse(envExamTb.Text) / exam_total) * exam_percentage;
                }
                else
                {
                    MessageBox.Show("Exam score exceeds total");
                    envExamTb.Text = null;
                }
            }
            envTotalLbl.Text = String.Format("{0:0.00}", envTotal);
        }

        private void math_TextChanged(object sender, EventArgs e)
        {
            decimal mathTotal = 0;
            if (!String.IsNullOrEmpty(mathClassTb.Text))
            {
                if (int.Parse(mathClassTb.Text) <= class_total)
                {
                    mathTotal += (decimal.Parse(mathClassTb.Text) / class_total) * class_percentage;
                }
                else
                {
                    MessageBox.Show("Class score exceeds total");
                    mathClassTb.Text = null;
                }
            }
            if (!String.IsNullOrEmpty(mathExamTb.Text))
            {
                if (int.Parse(mathExamTb.Text) <= exam_total)
                {
                    mathTotal += (decimal.Parse(mathExamTb.Text) / exam_total) * exam_percentage;
                }
                else
                {
                    MessageBox.Show("Exam score exceeds total");
                    mathExamTb.Text = null;
                }
            }
            mathTotalLbl.Text = String.Format("{0:0.00}", mathTotal);
        }

        private void pho_TextChanged(object sender, EventArgs e)
        {
            decimal phoTotal = 0;
            if (!String.IsNullOrEmpty(phoClassTb.Text))
            {
                if (int.Parse(phoClassTb.Text) <= class_total)
                {
                    phoTotal += (decimal.Parse(phoClassTb.Text) / class_total) * class_percentage;
                }
                else
                {
                    MessageBox.Show("Class score exceeds total");
                    phoClassTb.Text = null;
                }
            }
            if (!String.IsNullOrEmpty(phoExamTb.Text))
            {
                if (int.Parse(phoExamTb.Text) <= exam_total)
                {
                    phoTotal += (decimal.Parse(phoExamTb.Text) / exam_total) * exam_percentage;
                }
                else
                {
                    MessageBox.Show("Exam score exceeds total");
                    phoExamTb.Text = null;
                }
            }
            phoTotalLbl.Text = String.Format("{0:0.00}", phoTotal);
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
