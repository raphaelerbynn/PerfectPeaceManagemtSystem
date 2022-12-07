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
    public partial class MedicalReport : Form
    {
        readonly PrintDocument printdoc = new PrintDocument();
        readonly PrintPreviewDialog printPreview = new PrintPreviewDialog();
        private string id = StudentDataDisplay.getIdFromSelectedRow();
        public static string stu_name;
        public static string stu_class;
        private string query;
        public MedicalReport()
        {
            InitializeComponent();
            bgPanel.BackColor = Home.foreColor;
            fillLabels();
        }

        private void fillLabels()
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }

            try
            {
                SqlDataReader reader;
                query = "SELECT COUNT(1) FROM Medical_report WHERE student_id='" + id + "'";
                string check = DbClient.query_executeScaler(query);
                if (check.Equals("1"))
                {
                    query = "SELECT * FROM Medical_report WHERE student_id='" + id + "'";
                    reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {
                        bloodGroupLbl.Text = reader["blood_group"].ToString();
                        factorLbl.Text = reader["rhesus"].ToString();
                        sicklingLbl.Text = reader["sickling"].ToString();
                        hbLbl.Text = reader["hbsag"].ToString();
                        retroLbl.Text = reader["retro"].ToString();
                        hevLbl.Text = reader["hev"].ToString();
                        bloodCountLbl.Text = reader["blood_count"].ToString();
                        g6Lbl.Text = reader["g6pd"].ToString();
                        macLbl.Text = reader["mac"].ToString();
                        micLbl.Text = reader["mic"].ToString();
                        weightLbl.Text = reader["weight"].ToString();
                        heightLbl.Text = reader["height"].ToString();
                        bmiLbl.Text = reader["bmi"].ToString();
                        tempLbl.Text = reader["temp"].ToString();
                        pulseLbl.Text = reader["pulse"].ToString();
                        respirationLbl.Text = reader["respiration"].ToString();
                        eyeTestLbl.Text = reader["eye_test"].ToString();
                        appearanceLbl.Text = reader["appearance"].ToString();
                        colorLbl.Text = reader["color"].ToString();
                        leuLbl.Text = reader["leukocyte"].ToString();
                        uroLbl.Text = reader["urobili"].ToString();
                        biliLbl.Text = reader["bilirubin"].ToString();
                        bloodLbl.Text = reader["blood"].ToString();
                        nitritLbl.Text = reader["nitrit"].ToString();
                        phLbl.Text = reader["ph"].ToString();
                        gravityLbl.Text = reader["gravity"].ToString();
                        proteinLbl.Text = reader["protein"].ToString();
                        glucoseLbl.Text = reader["glucose"].ToString();
                        ketoLbl.Text = reader["ketones"].ToString();
                        epiLbl.Text = reader["epithelial"].ToString();
                        pusLbl.Text = reader["pus"].ToString();
                        rbcLbl.Text = reader["rbcs"].ToString();
                        otherLbl.Text = reader["others"].ToString();
                    }
                    reader.Close();
                }
                query = "SELECT f_name+' '+m_name+' '+l_name AS name, class FROM Student WHERE student_id='"+id+"'";
                reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    nameLbl.Text = reader["name"].ToString();
                    classLbl.Text = reader["class"].ToString();
                    
                    stu_name = reader["name"].ToString();
                    stu_class = reader["class"].ToString();
                }
                reader.Close();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Print()
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
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.reportPanel, true, true);
            e.Graphics.DrawImage(bitMap, new Rectangle((printdoc.DefaultPageSettings.PaperSize.Width - reportPanel.Width)/2, 0,  reportPanel.Width, reportPanel.Height));
            //MessageBox.Show(printdoc.DefaultPageSettings.PaperSize.Width.ToString());
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void addReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenNewPage opn = new OpenNewPage();
            opn.OpenChildForm(new Pages.AddMedicalReport(), bgPanel);
        }
    }
}
