﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Perfect_Peace_System.Pages
{
    public partial class AddResult : Form
    {
        WaitFunc wait = new WaitFunc();
        private string query;
        private string student_id = StudentReport.getIdFromSelectedRow();

        List<Label> subjectLbls = new List<Label>();
        List<Label> classScoreLbls = new List<Label>();
        List<Label> examScoreLbls = new List<Label>();
        List<Label> classScoreCalcLbls = new List<Label>();
        List<Label> examScoreCalcLbls = new List<Label>();
        List<Label> totalMarksLbls = new List<Label>();
        List<Label> remarkLbls = new List<Label>();

        List<TextBox> classScoreTBs = new List<TextBox>();
        List<TextBox> examScoreTBs = new List<TextBox>();

        List<int> classPercentages = new List<int>();
        List<int> examPercentages = new List<int>();
        List<string> subject_ids = new List<string>();

        List<int> classScores = new List<int>();
        List<int> examScores = new List<int>();


        public AddResult()
        {
            InitializeComponent();
            showSubjectsWithFeilds();
            getStudentInfo();
            getPreviousInput();

            topPanel.BackColor = Home.themeColor;
            topPanel.ForeColor = Home.foreColor;
            bgPanel.BackColor = Home.foreColor;
            inputPanel.BackColor = Home.foreColor;
            teacherRemarksPanel.BackColor = Home.foreColor;
        }

        private void getStudentInfo()
        {
            query = "SELECT * FROM Student WHERE student_id='"+student_id+"'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                studentNameLbl.Text = reader["f_name"].ToString() + " " + reader["l_name"].ToString();
                classLbl.Text = reader["class"].ToString();
            }
            reader.Close();
        }

        private void getPreviousInput()
        {
            try
            {
                query = "SELECT " +
                    "subject_id, exam_score, exam_score_percentage, class_score, class_score_percentage, total_score, remarks " +
                    "FROM Student_marks " +
                    "WHERE student_id='"+student_id+"' AND  class='"+classLbl.Text+"' AND term='"+termCb.Text+"' AND FORMAT(date, 'yyyy')='"+DateTime.Now.Year+"' ";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    
                    string _subj_id = reader["subject_id"].ToString();
                    if (_subj_id != null)
                    {
                        int _index_sub_id = subject_ids.IndexOf(_subj_id);

                        remarkLbls[_index_sub_id].Text = reader["remarks"].ToString();
                        //classScoreLbls[_index_sub_id].Text = reader["class_score_percentage"].ToString() + "";
                        classScoreTBs[_index_sub_id].Text = reader["class_score"].ToString();
                        examScoreTBs[_index_sub_id].Text = reader["exam_score"].ToString();

                    }
                    Console.WriteLine(reader["subject_id"].ToString());
                }
                reader.Close();

                Console.WriteLine(DateTime.Now.Year);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showSubjectsWithFeilds()
        {
            termCb.SelectedIndex = 0;

            int subLocationX = subjectName.Location.X;
            int classMarkLocationX = classMarkLbl.Location.X;
            int examMarkLocationX = examMarkLbl.Location.X;
            int totalMarksLocationX = totalMarkLbl.Location.X;
            int remarksLocationX = remarksLbl.Location.X;

            int subLocationY = subjectName.Location.Y + 48;

            query = "SELECT * FROM Subject";
            SqlDataReader reader = DbClient.query_reader(query);
            if (reader != null)
            {
                while (reader.Read())
                {
                    int classTotal = int.Parse(reader["class_total_marks"].ToString());
                    classScores.Add(classTotal);
                    int examTotal = int.Parse(reader["exam_total_marks"].ToString());
                    examScores.Add(examTotal);

                    //subjects
                    Label subjectLabel = new Label();
                    subjectLabel.Text = reader["name"].ToString();
                    subjectLabel.Location = new Point(subLocationX, subLocationY);
                    subjectLabel.Anchor = AnchorStyles.Top;
                    subjectLabel.AutoSize = true;
                    subjectLabel.Font = new Font("Calibri", 12);
                    subjectLbls.Add(subjectLabel);

                    //subject_ids
                    string id = reader["subject_id"].ToString();
                    subject_ids.Add(id);

                    //class score textboxes
                    TextBox classScoreTB = new TextBox();
                    classScoreTB.Location = new Point(classMarkLocationX, subLocationY);
                    classScoreTB.Anchor = AnchorStyles.Top;
                    classScoreTB.Size = new Size(73, 20);
                    classScoreTBs.Add(classScoreTB);

                    //class score labels
                    Label classScoreLabel = new Label();
                    classScoreLabel.Text = reader["class_percentage"].ToString() + "% =";
                    classScoreLabel.Location = new Point(classMarkLocationX + 75, subLocationY);
                    classScoreLabel.Anchor = AnchorStyles.Top;
                    classScoreLabel.AutoSize = true;
                    classScoreLabel.Font = new Font("Calibri", 12);
                    classScoreLbls.Add(classScoreLabel);

                    //class %
                    int class_percentage = int.Parse(reader["class_percentage"].ToString());
                    classPercentages.Add(class_percentage);

                    //class marks label
                    Label classScoreCalcLabel = new Label();
                    classScoreCalcLabel.Text = "00";
                    classScoreCalcLabel.Location = new Point(classMarkLocationX + 120, subLocationY);
                    classScoreCalcLabel.Anchor = AnchorStyles.Top;
                    classScoreCalcLabel.AutoSize = true;
                    classScoreCalcLabel.Font = new Font("Calibri", 12, FontStyle.Bold);
                    classScoreCalcLabel.ForeColor = Color.BlueViolet;
                    classScoreCalcLbls.Add(classScoreCalcLabel);

                    //exam score textboxes
                    TextBox examScoreTB = new TextBox();
                    examScoreTB.Location = new Point(examMarkLocationX, subLocationY);
                    examScoreTB.Anchor = AnchorStyles.Top;
                    examScoreTB.Size = new Size(73, 20);
                    examScoreTBs.Add(examScoreTB);

                    //exam score labels
                    Label examScoreLabel = new Label();
                    examScoreLabel.Text = reader["exam_percentage"].ToString() + "% =";
                    examScoreLabel.Location = new Point(examMarkLocationX + 75, subLocationY);
                    examScoreLabel.Anchor = AnchorStyles.Top;
                    examScoreLabel.AutoSize = true;
                    examScoreLabel.Font = new Font("Calibri", 12);
                    examScoreLbls.Add(examScoreLabel);

                    //exam %
                    int exam_percentage = int.Parse(reader["exam_percentage"].ToString());
                    examPercentages.Add(exam_percentage);

                    //exam marks label
                    Label examScoreCalcLabel = new Label();
                    examScoreCalcLabel.Text = "00";
                    examScoreCalcLabel.Location = new Point(examMarkLocationX + 120, subLocationY);
                    examScoreCalcLabel.Anchor = AnchorStyles.Top;
                    examScoreCalcLabel.AutoSize = true;
                    examScoreCalcLabel.Font = new Font("Calibri", 12, FontStyle.Bold);
                    examScoreCalcLabel.ForeColor = Color.BlueViolet;
                    examScoreCalcLbls.Add(examScoreCalcLabel);



                    //total marks label
                    Label totalMarksLabel = new Label();
                    totalMarksLabel.Text = "00";
                    totalMarksLabel.Location = new Point(totalMarksLocationX, subLocationY);
                    totalMarksLabel.Anchor = AnchorStyles.Top;
                    totalMarksLabel.AutoSize = true;
                    totalMarksLabel.Font = new Font("Calibri", 14, FontStyle.Bold);
                    totalMarksLbls.Add(totalMarksLabel);

                    //remarks label
                    Label remarksLabel = new Label();
                    remarksLabel.Text = "----------";
                    remarksLabel.Location = new Point(remarksLocationX, subLocationY);
                    remarksLabel.Anchor = AnchorStyles.Top;
                    remarksLabel.AutoSize = true;
                    remarksLabel.Font = new Font("Calibri", 14, FontStyle.Bold);
                    remarkLbls.Add(remarksLabel);

                    subLocationY += 50;
                }
                reader.Close();
            }

            for(int i=0; i<subjectLbls.Count; i++)
            {
                inputPanel.Controls.Add(subjectLbls[i]);
                inputPanel.Controls.Add(classScoreTBs[i]);
                inputPanel.Controls.Add(classScoreLbls[i]);
                inputPanel.Controls.Add(classScoreCalcLbls[i]);
                inputPanel.Controls.Add(examScoreTBs[i]);
                inputPanel.Controls.Add(examScoreLbls[i]);
                inputPanel.Controls.Add(examScoreCalcLbls[i]);
                inputPanel.Controls.Add(totalMarksLbls[i]);
                inputPanel.Controls.Add(remarkLbls[i]);
                

                classScoreTBs[i].TextChanged += tB_TextChanged;
                examScoreTBs[i].TextChanged += tB_TextChanged;
                classScoreTBs[i].KeyPress += tB_KeyPress;
                examScoreTBs[i].KeyPress += tB_KeyPress;
            }

            Label getLastRemarkLbl = remarkLbls[remarkLbls.Count-1];
            Button nextPageBtn = new Button();
            nextPageBtn.Text = "Next Page";
            nextPageBtn.Location = new Point(getLastRemarkLbl.Location.X, getLastRemarkLbl.Location.Y + 40);
            nextPageBtn.FlatStyle = FlatStyle.Flat;
            nextPageBtn.FlatAppearance.BorderSize = 0;
            nextPageBtn.ForeColor = Color.White;
            nextPageBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            inputPanel.Controls.Add(nextPageBtn);
            nextPageBtn.Click += nextPageBtn_Click;

        }

        private void tB_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            for (int i = 0; i < subjectLbls.Count; i++)
            {
                if (textBox.Location.Y == subjectLbls[i].Location.Y)
                {
                    if (textBox.Location.X == classMarkLbl.Location.X)
                    {
                        if (!String.IsNullOrEmpty(textBox.Text))
                        {
                            if (double.Parse(classScoreTBs[i].Text) > classScores[i])
                            {
                                MessageBox.Show("Class score greater than total class mark");
                                classScoreTBs[i].Text = null;
                            }
                            else
                            {
                                //calculate class mark with %
                                //double class_percentage = classPercentages[i] / 100.0;
                                double class_mark = (double.Parse(classScoreTBs[i].Text) / classScores[i]) * classPercentages[i];
                                classScoreCalcLbls[i].Text = class_mark.ToString("0.##");
                            }
                        }
                        else
                        {
                            classScoreCalcLbls[i].Text = "00";
                        }
                    }
                    if (textBox.Location.X == examMarkLbl.Location.X)
                    {
                        if (!String.IsNullOrEmpty(textBox.Text))
                        {
                            if (double.Parse(examScoreTBs[i].Text) > examScores[i])
                            {
                                MessageBox.Show("Exam score greater than total exam mark");
                                examScoreTBs[i].Text = null;
                            }
                            else
                            {
                                //calculate exam mark with %
                                //double exam_percentage = examPercentages[i] / 100.0;
                                double exam_mark = (double.Parse(examScoreTBs[i].Text) / examScores[i]) * examPercentages[i];
                                examScoreCalcLbls[i].Text = exam_mark.ToString("0.##");
                                Console.WriteLine(examScoreCalcLbls[i].Text);
                            }
                        }
                        else
                        {
                            examScoreCalcLbls[i].Text = "00";
                        }
                    }
                    //upddating total score
                    totalMarksLbls[i].Text = (double.Parse(examScoreCalcLbls[i].Text) + double.Parse(classScoreCalcLbls[i].Text)).ToString();
                    
                    if (double.Parse(totalMarksLbls[i].Text) >= 80)
                    {
                        remarkLbls[i].Text = "Excellent"; 
                    }
                    else if (double.Parse(totalMarksLbls[i].Text) >= 70 && double.Parse(totalMarksLbls[i].Text) < 80)
                    {
                        remarkLbls[i].Text = "Very Good";
                    }
                    else if (double.Parse(totalMarksLbls[i].Text) >= 65 && double.Parse(totalMarksLbls[i].Text) < 70)
                    {
                        remarkLbls[i].Text = "Good";
                    }
                    else if (double.Parse(totalMarksLbls[i].Text) >= 50 && double.Parse(totalMarksLbls[i].Text) < 65)
                    {
                        remarkLbls[i].Text = "Credit";
                    }
                    else if (double.Parse(totalMarksLbls[i].Text) >= 40 && double.Parse(totalMarksLbls[i].Text) < 50)
                    {
                        remarkLbls[i].Text = "Pass";
                    }
                    else 
                    {
                        remarkLbls[i].Text = "Fail";
                    }
                }
            }
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            teacherRemarksPanel.Visible = false;
            inputPanel.Visible = true;
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            teacherRemarksPanel.Visible = true;
            teacherRemarksPanel.Location = inputPanel.Location;
            inputPanel.Visible = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            string message = "Do you want to save this result?";

            MessageBoxButtons action = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", action);
            if (result == DialogResult.Yes)
            {
                
                detailsToDB();
                
            }
        }

        private void detailsToDB()
        {
            try
            {
                ClassRoom classRoom = new ClassRoom();
                string result_status = "";
                string promoted_to = "";
                double raw_score = 0;
                int pass_score = 0;
                int total_raw_score = 0;
                wait.show();
                query = "DELETE FROM Student_marks WHERE student_id='" + student_id + "' AND  class='" + classLbl.Text + "' AND term='" + termCb.Text + "' AND FORMAT(date, 'yyyy')='" + DateTime.Now.Year + "' ";
                DbClient.query_execute(query);
                
                query = "DELETE FROM Student_result WHERE student_id='" + student_id + "' AND  class='" + classLbl.Text + "' AND term='" + termCb.Text + "' AND FORMAT(date, 'yyyy')='" + DateTime.Now.Year + "' ";
                DbClient.query_execute(query);

                for (int i = 0; i < subject_ids.Count; i++)
                {
                    if (!(String.IsNullOrEmpty(classScoreTBs[i].Text) || String.IsNullOrEmpty(examScoreTBs[i].Text)))
                    {
                        query = "INSERT INTO Student_marks(subject_id, student_id, exam_score, exam_score_percentage, class_score, class_score_percentage, total_score, remarks, class, term, date) " +
                            "VALUES('" + subject_ids[i] + "', '" + student_id + "', '" + examScoreTBs[i].Text + "', '" + examScoreCalcLbls[i].Text + "', '" + classScoreTBs[i].Text + "', '" + classScoreCalcLbls[i].Text + "', '" + totalMarksLbls[i].Text + "', '" + remarkLbls[i].Text+"', '" + classLbl.Text + "','"+termCb.Text+"', '"+DateTime.Today+"')";
                        DbClient.query_execute(query);

                        query = "SELECT * FROM Subject WHERE subject_id='" + subject_ids[i] + "'";
                        SqlDataReader reader = DbClient.query_reader(query);
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                pass_score += int.Parse(reader["pass_marks"].ToString());
                                total_raw_score += 100;
                            }
                            reader.Close();
                        }
                        raw_score += double.Parse(totalMarksLbls[i].Text);
                    }
                }

                query = "SELECT COUNT(*) FROM Student WHERE class='" + classLbl.Text + "'";
                string class_total = DbClient.query_executeScaler(query);
                if (statusCb.Visible == true)
                {
                    result_status = statusCb.Text;
                    if (classCb.Visible == true)
                    {
                        promoted_to = classCb.Text;
                    }
                }
                query = "INSERT INTO Student_result(student_id, raw_score, pass_raw_score, total_raw_score, result_status, class_total, promoted_to, class, term, conduct, attitude, interest, teacher_remarks, date) " +
                        "VALUES('" + student_id + "', '" + raw_score + "', '" + pass_score + "', '" + total_raw_score + "', '" + result_status + "', '"+class_total+"', '"+promoted_to+"', '" + classLbl.Text + "', '" + termCb.Text + "', '" + conductTB.Text + "', '" + attitudeTB.Text + "', '" + interestTB.Text + "', '" + teacherRemarksTB.Text + "', '" + DateTime.Today + "')";
                DbClient.query_execute(query);
                wait.close();
                //MessageBox.Show("Take Note: After printing all result. Go to student module and update student to promoted class", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                this.Close();
            }catch(Exception ex)
            {
                wait.close();
                MessageBox.Show(ex.Message);
            }
        }


        private void termCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(termCb.SelectedIndex == 2)
            {
                statusLbl.Visible = true;
                statusCb.Visible = true;
            }
            else
            {
                statusLbl.Visible = false;
                statusCb.Visible = false;
                statusCb.SelectedIndex = -1;
            }
        }

        private void statusCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusCb.SelectedIndex == 1)
            {
                promotedLbl.Visible = true;
                classCb.Visible = true;
                loadClassrooms();
            }
            else
            {
                promotedLbl.Visible = false;
                classCb.Visible = false;
            }
        }
        
        private void loadClassrooms()
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            wait.show();
            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);
            wait.close();
        }

        private void classCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassRoom classRoom = new ClassRoom();
            if (!(classRoom.maxCapacity(classCb.Text) > classRoom.curCapacity(classCb.Text)))
            {
                MessageBox.Show("Class full!!! Change class");
                classCb.SelectedIndex = -1;
            }
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
