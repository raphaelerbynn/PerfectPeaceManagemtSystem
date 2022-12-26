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
    public partial class AddMedicalReport : Form
    {
        private string query;
        private string check;
        WaitFunc wait = new WaitFunc();

        public AddMedicalReport()
        {
            InitializeComponent();
            bgPanel.BackColor = Home.foreColor;
            nameLbl.Text = MedicalReport.stu_name;
            classLbl.Text = MedicalReport.stu_class;
            fillData();
        }

        private void fillData()
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            query = "SELECT COUNT(1) FROM Medical_report WHERE student_id='" + StudentDataDisplay.getIdFromSelectedRow() + "'";
            check = DbClient.query_executeScaler(query);
            if (check.Equals("1"))
            {
                query = "SELECT * FROM Medical_report WHERE student_id='" + StudentDataDisplay.getIdFromSelectedRow() + "'";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    TBBloodGroup.Text = reader["blood_group"].ToString();
                    TBFactor.Text = reader["rhesus"].ToString();
                    TBSickling.Text = reader["sickling"].ToString();
                    TBHB.Text  = reader["hbsag"].ToString();
                    TBRetro.Text  = reader["retro"].ToString();
                    TBHev.Text = reader["hev"].ToString();
                    TBFullBlood.Text = reader["blood_count"].ToString();
                    TBG6.Text  = reader["g6pd"].ToString();
                    TBMac.Text = reader["mac"].ToString();
                    TBMic.Text = reader["mic"].ToString();
                    TBWeight.Text = reader["weight"].ToString();
                    TBHeight.Text = reader["height"].ToString();
                    TBbmi.Text = reader["bmi"].ToString();
                    TBTemp.Text = reader["temp"].ToString();
                    TBPulse.Text = reader["pulse"].ToString();
                    TBRespiration.Text = reader["respiration"].ToString();
                    TBEyeTest.Text = reader["eye_test"].ToString();
                    TBAppearance.Text = reader["appearance"].ToString();
                    TBColor.Text = reader["color"].ToString();
                    TBLeuk.Text = reader["leukocyte"].ToString();
                    TBUrobil.Text = reader["urobili"].ToString();
                    TBBili.Text = reader["bilirubin"].ToString();
                    TBBlood.Text = reader["blood"].ToString();
                    TBNitrit.Text = reader["nitrit"].ToString();
                    TBPH.Text  = reader["ph"].ToString();
                    TBGravity.Text = reader["gravity"].ToString();
                    TBProtein.Text = reader["protein"].ToString();
                    TBGlucose.Text = reader["glucose"].ToString();
                    TBKetone.Text = reader["ketones"].ToString();
                    TBEpi.Text = reader["epithelial"].ToString();
                    TBPus.Text = reader["pus"].ToString();
                    TBRBC.Text = reader["rbcs"].ToString();
                    TBother.Text = reader["others"].ToString();
                }
                reader.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                wait.show();
                //MessageBox.Show(check);
                if (check.Equals("0")) {
                    query = "INSERT INTO Medical_report " +
                        "(student_id, " +
                        "blood_group, " +
                        "rhesus, " +
                        "sickling, " +
                        "hbsag, " +
                        "retro, " +
                        "hev, " +
                        "blood_count, " +
                        "g6pd, " +
                        "mac, " +
                        "mic, " +
                        "weight, " +
                        "height, " +
                        "bmi, " +
                        "temp, " +
                        "pulse, " +
                        "respiration, " +
                        "eye_test, " +
                        "appearance, " +
                        "color, " +
                        "leukocyte, " +
                        "urobili, " +
                        "bilirubin, " +
                        "blood, " +
                        "nitrit, " +
                        "ph, " +
                        "gravity, " +
                        "protein, " +
                        "glucose, " +
                        "ketones, " +
                        "epithelial, " +
                        "pus, " +
                        "rbcs, " +
                        "others" +
                        ")" +
                        " VALUES('" +
                        StudentDataDisplay.getIdFromSelectedRow() + "', '" +
                        TBBloodGroup.Text + "', '" +
                        TBFactor.Text + "', '" +
                        TBSickling.Text + "', '" +
                        TBHB.Text + "', '" +
                        TBRetro.Text + "', '" +
                        TBHev.Text + "', '" +
                        TBFullBlood.Text + "', '" +
                        TBG6.Text + "', '" +
                        TBMac.Text + "', '" +
                        TBMic.Text + "', '" +
                        TBWeight.Text + "', '" +
                        TBHeight.Text + "', '" +
                        TBbmi.Text + "', '" +
                        TBTemp.Text + "', '" +
                        TBPulse.Text + "', '" +
                        TBRespiration.Text + "', '" +
                        TBEyeTest.Text + "', '" +
                        TBAppearance.Text + "', '" +
                        TBColor.Text + "', '" +
                        TBLeuk.Text + "', '" +
                        TBUrobil.Text + "', '" +
                        TBBili.Text + "', '" +
                        TBBlood.Text + "', '" +
                        TBNitrit.Text + "', '" +
                        TBPH.Text + "', '" +
                        TBGravity.Text + "', '" +
                        TBProtein.Text + "', '" +
                        TBGlucose.Text + "', '" +
                        TBKetone.Text + "', '" +
                        TBEpi.Text + "', '" +
                        TBPus.Text + "', '" +
                        TBRBC.Text + "', '" +
                        TBother.Text + "'" +
                        ")";
                    DbClient.query_execute(query);
                    wait.close();
                    MessageBox.Show("Data saved succcessfully");
                }
                else
                {
                    query = "UPDATE Medical_report SET " +
                        "blood_group='" + TBBloodGroup.Text + "'" +
                        ", rhesus='" + TBFactor.Text + "'" +
                        ", sickling='" + TBSickling.Text + "'" +
                        ", hbsag='" + TBHB.Text + "'" +
                        ", hev='" + TBHev.Text + "'" +
                        ", retro='" + TBRetro.Text + "'" +
                        ", blood_count='" + TBFullBlood.Text + "'" +
                        ", g6pd='" + TBG6.Text + "'" +
                        ", mac='" + TBMac.Text + "'" +
                        ", mic='" + TBMic.Text + "'" +
                        ", weight='" + TBWeight.Text + "'" +
                        ", height='" + TBHeight.Text + "'" +
                        ", bmi='" + TBbmi.Text + "'" +
                        ", temp='" + TBTemp.Text + "'" +
                        ", pulse='" + TBPulse.Text + "'" +
                        ", respiration='" + TBRespiration.Text + "'" +
                        ", eye_test='" + TBEyeTest.Text + "'" +
                        ", appearance='" + TBAppearance.Text + "'" +
                        ", color='" + TBColor.Text + "'" +
                        ", leukocyte='" + TBLeuk.Text + "'" +
                        ", urobili='" + TBUrobil.Text + "'" +
                        ", bilirubin='" + TBBili.Text + "'" +
                        ", blood='" + TBBlood.Text + "'" +
                        ", nitrit='" + TBNitrit.Text + "'" +
                        ", ph='" + TBPH.Text + "'" +
                        ", gravity='" + TBGravity.Text + "'" +
                        ", protein='" + TBProtein.Text + "'" +
                        ", glucose='" + TBGlucose.Text + "'" +
                        ", ketones='" + TBKetone.Text + "'" +
                        ", epithelial='" + TBEpi.Text + "'" +
                        ", pus='" + TBPus.Text + "'" +
                        ", rbcs='" + TBRBC.Text + "'" +
                        ", others='" + TBother.Text + "'" +
                        " WHERE student_id = '" + StudentDataDisplay.getIdFromSelectedRow() + "'";
                    DbClient.query_execute(query);
                    wait.close();

                    MessageBox.Show("Data updated succcessfully");
                }
            }
            catch (Exception ex)
            {
                //if(ex.Message.Contains(""))
                /*query = "UPDATE Medical_report SET " +
                        "blood_group='" + TBBloodGroup.Text + "'" +
                        ", rhesus='" + TBFactor.Text + "'" +
                        ", sickling='" + TBSickling.Text + "'" +
                        ", hbsag='" + TBHB.Text + "'" +
                        ", hev='" + TBHev.Text + "'" +
                        ", blood_count='" + TBFullBlood.Text + "'" +
                        ", g6pd='" + TBG6.Text + "'" +
                        ", mac='" + TBMac.Text + "'" +
                        ", mic='" + TBMic.Text + "'" +
                        ", weight='" + TBWeight.Text + "'" +
                        ", height='" + TBHeight.Text + "'" +
                        ", bmi='" + TBbmi.Text + "'" +
                        ", temp='" + TBTemp.Text + "'" +
                        ", pulse='" + TBPulse.Text + "'" +
                        ", respiration='" + TBRespiration.Text + "'" +
                        ", eye_test='" + TBEyeTest.Text + "'" +
                        ", appearance='" + TBAppearance.Text + "'" +
                        ", color='" + TBColor.Text + "'" +
                        ", leukocyte='" + TBLeuk.Text + "'" +
                        ", urobili='" + TBUrobil.Text + "'" +
                        ", bilirubin='" + TBBili.Text + "'" +
                        ", blood='" + TBBlood.Text + "'" +
                        ", nitrit='" + TBNitrit.Text + "'" +
                        ", ph='" + TBPH.Text + "'" +
                        ", gravity='" + TBGravity.Text + "'" +
                        ", protein='" + TBProtein.Text + "'" +
                        ", glucose='" + TBGlucose.Text + "'" +
                        ", ketones='" + TBKetone.Text + "'" +
                        ", epithelial='" + TBEpi.Text + "'" +
                        ", pus='" + TBPus.Text + "'" +
                        ", rbcs='" + TBRBC.Text + "'" +
                        ", others='" + TBother.Text + "'" +
                        " WHERE student_id = '" + StudentDataDisplay.getIdFromSelectedRow() + "'";
                DbClient.query_execute(query);
                MessageBox.Show("Data updated succcessfully");*/
                MessageBox.Show(ex.Message);
            }
        }

        private void backLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
