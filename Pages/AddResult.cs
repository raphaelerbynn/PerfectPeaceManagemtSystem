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
                classScoreLabel.Text = reader["class_percentage"].ToString();
                classScoreLabel.Location = new Point(classMarkLocationX + 75, subLocationY);
                classScoreLabel.Anchor = AnchorStyles.Top;
                classScoreLabel.AutoSize = true;
                classScoreLabel.Font = new Font("Calibri", 12);
                classScoreLbls.Add(classScoreLabel);
                //classScoreLabel.Text = classScoreLabel.Text + "% = ";

                //class %
                int class_percentage = int.Parse(reader["class_percentage"].ToString());
                classPercentages.Add(class_percentage);

                //class marks label
                Label classScoreCalcLabel = new Label();
                classScoreCalcLabel.Text = "00";
                classScoreCalcLabel.Location = new Point(classMarkLocationX + 100, subLocationY);
                classScoreCalcLabel.Anchor = AnchorStyles.Top;
                classScoreCalcLabel.AutoSize = true;
                classScoreCalcLabel.Font = new Font("Calibri", 12);
                classScoreCalcLbls.Add(classScoreCalcLabel);

                classScoreLabel.Text = classScoreLabel.Text + "% = " + classScoreCalcLabel.Text;

                //exam score textboxes
                TextBox examScoreTB = new TextBox();
                examScoreTB.Location = new Point(examMarkLocationX, subLocationY);
                examScoreTB.Anchor = AnchorStyles.Top;
                examScoreTB.Size = new Size(73, 20);
                examScoreTBs.Add(examScoreTB);

                //exam score labels
                Label examScoreLabel = new Label();
                examScoreLabel.Text = reader["exam_percentage"].ToString();
                examScoreLabel.Location = new Point(examMarkLocationX + 75, subLocationY);
                examScoreLabel.Anchor = AnchorStyles.Top;
                examScoreLabel.AutoSize = true;
                examScoreLabel.Font = new Font("Calibri", 12);
                examScoreLbls.Add(examScoreLabel);
                //classScoreLabel.Text = classScoreLabel.Text + "% = ";

                //exam %
                int exam_percentage = int.Parse(reader["exam_percentage"].ToString());
                examPercentages.Add(exam_percentage);

                //exam marks label
                Label examScoreCalcLabel = new Label();
                examScoreCalcLabel.Text = "00";
                examScoreCalcLabel.Location = new Point(examMarkLocationX + 100, subLocationY);
                examScoreCalcLabel.Anchor = AnchorStyles.Top;
                examScoreCalcLabel.AutoSize = true;
                examScoreCalcLabel.Font = new Font("Calibri", 12);
                examScoreCalcLbls.Add(examScoreCalcLabel);

                examScoreLabel.Text = examScoreLabel.Text + "% = " + examScoreCalcLabel.Text;

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
                inputPanel.Controls.Add(examScoreTBs[i]);
                inputPanel.Controls.Add(examScoreLbls[i]);
                inputPanel.Controls.Add(totalMarksLbls[i]);
                inputPanel.Controls.Add(remarkLbls[i]);

                classScoreTBs[i].TextChanged += tB_TextChanged;
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
                        //calculate class mark with %
                        double percentage = int.Parse(Regex.Match("10% = ", @"\d+").Value) / 100.0;
                        double mark;
                        Console.WriteLine(classPercentages.Count);
                        Console.WriteLine(classPercentages.Count);
                    }
                }
            }
        }
    }
}
