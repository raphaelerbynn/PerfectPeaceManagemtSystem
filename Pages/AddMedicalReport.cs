using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AddMedicalReport()
        {
            InitializeComponent();
            bgPanel.BackColor = Home.foreColor;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool getInput = false;
                foreach(Control c in bgPanel.Controls)
                {
                    if(c is TextBox && !String.IsNullOrEmpty(c.Text))
                    {
                        getInput = true;
                        break;
                    }
                }

                if (getInput)
                {
                    query = "UPDATE Medical_report SET " +
                        "blood_group='"+TBBloodGroup.Text+"'" +
                        ", rhesus='" + TBFactor.Text+"'" +
                        ", sickling='" + TBSickling.Text+"'" +
                        ", hbsag='" + TBHB.Text+"'" +
                        ", hev='" + TBHev.Text+"'" +
                        ", blood_count='" + TBFullBlood.Text+"'" +
                        ", g6pd='" + TBG6.Text+"'" +
                        ", mac='" + TBMac.Text+"'" +
                        ", mic='" + TBMic.Text+"'" +
                        ", weight='" + TBWeight.Text+"'" +
                        ", height='" + TBHeight.Text+"'" +
                        ", bmi='" + TBbmi.Text+"'" +
                        ", temp='" + TBTemp.Text+"'" +
                        ", pulse='" + TBPulse.Text+"'" +
                        ", respiration='" + TBRespiration.Text+"'" +
                        ", eye_test='" + TBEyeTest.Text+"'" +
                        ", appearance='" + TBAppearance.Text+"'" +
                        ", color='" + TBColor.Text+"'" +
                        ", leukocyte='" + TBLeuk.Text+"'" +
                        ", urobili='" + TBUrobil.Text+"'" +
                        ", bilirubin='" + TBBili.Text+"'" +
                        ", blood='" + TBBlood.Text+"'" +
                        ", nitrit='" + TBNitrit.Text+"'" +
                        ", ph='" + TBPH.Text+"'" +
                        ", gravity='" + TBGravity.Text+"'" +
                        ", protein='" + TBProtein.Text+"'" +
                        ", glucose='" + TBGlucose.Text+"'" +
                        ", ketones='" + TBKetone.Text+"'" +
                        ", epithelial='" + TBEpi.Text+"'" +
                        ", pus='" + TBPus.Text+"'" +
                        ", rbcs='" + TBRBC.Text+"'" +
                        ", others='"+TBother.Text+"'" +
                        " WHERE student_id = '" +StudentDataDisplay.getIdFromSelectedRow()+"'";
                    DbClient.query_execute(query);
                }
                else
                {
                    query = "INSERT INTO Medical_report " +
                        "(student_id, " +
                        "blood_group, " +
                        "rhesus, " +
                        "sickling, " +
                        "hbsag, " +
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
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
