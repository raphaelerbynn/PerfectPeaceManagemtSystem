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
using System.Text.RegularExpressions;

namespace Perfect_Peace_System.Pages
{
    public partial class AddResult : Form
    {
        private string query;
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

        public AddResult()
        {
            InitializeComponent();
            showSubjectsWithFeilds();
            
        }



        private void showSubjectsWithFeilds()
        {
            /*subjectLbls = new List<Label>();
            classScoreLbls = new List<Label>();
            examScoreLbls = new List<Label>();
            classPercentageLbls = new List<Label>();
            examPercentageLbls = new List<Label>();
            totalMarksLbls = new List<Label>();
            remarkLbls = new List<Label>();

            classScoreCalcLbls = new List<Label>();

            classScoreTBs = new List<TextBox>();
            examScoreTBs = new List<TextBox>();*/

            int subLocationX = subjectName.Location.X;
            int classMarkLocationX = classMarkLbl.Location.X;
            int examMarkLocationX = examMarkLbl.Location.X;
            int totalMarksLocationX = totalMarkLbl.Location.X;
            int remarksLocationX = remarksLbl.Location.X;

            int subLocationY = subjectName.Location.Y + 48;

            query = "SELECT * FROM Subject";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                //subjects
                Label subjectLabel = new Label();
                subjectLabel.Text = reader["name"].ToString();
                subjectLabel.Location = new Point(subLocationX, subLocationY);
                subjectLabel.Anchor = AnchorStyles.Top;
                subjectLabel.AutoSize = true;
                subjectLabel.Font = new Font("Calibri", 12);
                subjectLbls.Add(subjectLabel);

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
                remarksLabel.Font = new Font("Calibri", 14);
                remarkLbls.Add(remarksLabel);

                subLocationY += 50;
            }
            reader.Close();            

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
        }

        private void tB_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Location.X == classMarkLbl.Location.X)
            {
                for(int i=0; i<subjectLbls.Count; i++)
                {
                    if(textBox.Location.Y == subjectLbls[i].Location.Y)
                    {
                        if (!String.IsNullOrEmpty(textBox.Text))
                        {
                            //calculate class mark with %
                            double percentage = classPercentages[i] / 100.0;
                            double mark = double.Parse(classScoreTBs[i].Text) * percentage;
                            classScoreCalcLbls[i].Text = mark.ToString("0.##");
                            Console.WriteLine(classScoreCalcLbls[i].Text);
                        }
                        else
                        {
                            classScoreCalcLbls[i].Text = "00";
                        }
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

    }
}
