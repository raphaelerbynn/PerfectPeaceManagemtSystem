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
        private string query;

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
            categoryCb.SelectedIndex = 0;
            termCb.SelectedIndex = 0;
        }

        private void compileResults()
        {
            foreach (Control control in languagePanel.Controls)
            {
                if (control is Label)
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
                if (control is Label)
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
                if (control is Label)
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
                if (control is Label)
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
            
            /*foreach (Control control in emotionalPanel.Controls)
            {
                if (control is Label)
                {
                    Console.WriteLine(((Label)control).Text);
                    emotionalAssessment.Add((Label)control);
                    emotionalSatisfactory.Add(0);
                    emotionalUnsatisfactory.Add(0);
                    emotionalImprove.Add(0);
                    emotionalNeeds.Add(0);
                }
                
            }foreach (Control control in physicalPanel.Controls)
            {
                if (control is Label)
                {
                    Console.WriteLine(((Label)control).Text);
                    physicalAssessment.Add((Label)control);
                    physicalSatisfactory.Add(0);
                    physicalUnsatisfactory.Add(0);
                    physicalImprove.Add(0);
                    physicalNeeds.Add(0);
                }
                
            }foreach (Control control in cognititvePanel.Controls)
            {
                if (control is Label)
                {
                    Console.WriteLine(((Label)control).Text);
                    cognitiveAssessment.Add((Label)control);
                    cognitiveSatisfactory.Add(0);
                    cognitiveUnsatisfactory.Add(0);
                    cognitiveImprove.Add(0);
                    cognitiveNeeds.Add(0);
                }
                
            }*/
        }

        private void getStudentInfo()
        {
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

                cognitiveLbl.Location = new Point(cognitiveLbl.Location.X, languageLbl.Location.Y);
                cognititvePanel.Location = new Point(cognititvePanel.Location.X, languagePanel.Location.Y);
            }
        }

        private void detailsToDb()
        {
            try
            {
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
                            "VALUES('" + emotionalAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '1', '"+termCb.SelectedItem.ToString()+"', '"+classLbl.Text+"', '"+DateTime.Today+"', '"+student_id+"')";
                        DbClient.query_execute(query);
                    }
                    else
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, term, class, date, student_id) " +
                           "VALUES('" + emotionalAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                        DbClient.query_execute(query);
                    }
                }
                
                for(int i = 0; i < physicalAssessment.Count; i++)
                {
                    if (physicalGrade[i].SelectedIndex > -1)
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, " + physicalGrade[i].SelectedItem.ToString() + ", term, class, date, student_id) " +
                            "VALUES('" + physicalAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '1', '"+termCb.SelectedItem.ToString()+"', '"+classLbl.Text+"', '"+DateTime.Today+"', '"+student_id+"')";
                        DbClient.query_execute(query);
                    }
                    else
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, term, class, date, student_id) " +
                           "VALUES('" + physicalAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                        DbClient.query_execute(query);
                    }
                }

                for(int i = 0; i < cognitiveAssessment.Count; i++)
                {
                    if (cognitiveGrade[i].SelectedIndex > -1)
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, " + cognitiveGrade[i].SelectedItem.ToString() + ", term, class, date, student_id) " +
                            "VALUES('" + cognitiveAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '1', '"+termCb.SelectedItem.ToString()+"', '"+classLbl.Text+"', '"+DateTime.Today+"', '"+student_id+"')";
                        DbClient.query_execute(query);
                    }
                    else
                    {
                        query = "INSERT INTO KG_assessment(assessment, category, term, class, date, student_id) " +
                           "VALUES('" + cognitiveAssessment[i].Text + "', 'LANGUAGE DEVELOPMENT (READING, LISTENING AND ORAL SKILLS)', '" + termCb.SelectedItem.ToString() + "', '" + classLbl.Text + "', '" + DateTime.Today + "', '" + student_id + "')";
                        DbClient.query_execute(query);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string message = "All Categories filled and you want to save?";
            MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", deleteAction);
            if (result == DialogResult.Yes)
            {
                detailsToDb();
                MessageBox.Show("Assessment Saved");
            }

        }
    }
}
