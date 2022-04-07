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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private string getRadioBtnValue()
        {
            if (femaleRadio.Checked == true)
            {
                return "Female";
            }
            return "Male";
        }

        private void clearFeilds()
        {
            fnameTb.Text = null;
            lnameTb.Text = null;
            phoneTB.Text = null;
            addressTb.Text = null;
            emailTb.Text = null;
        }

        private void registerTeacherBnt_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher (
                    phoneTB.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, addressTb.Text,
                    getRadioBtnValue(), DateTime.Parse(DateTime.Now.ToString())
                    );

                if (String.IsNullOrWhiteSpace(fnameTb.Text) ||
                    String.IsNullOrWhiteSpace(lnameTb.Text) ||
                    String.IsNullOrWhiteSpace(phoneTB.Text) ||
                    String.IsNullOrWhiteSpace(fnameTb.Text))
                {
                    MessageBox.Show("Feilds with * must be filled");
                }
                else
                {
                    teacher.save();
                    MessageBox.Show("Teacher Saved");
                    clearFeilds();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearFeildBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }
    }
}
