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
            bgPanel.BackColor = Home.foreColor;
            positionCb.SelectedIndex = 0;
            categoryCb.SelectedIndex = 0;
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

            bankTb.Text = null;
            accountNumTb.Text = null;
            ssnitTb.Text = null;
            tinTb.Text = null;
            positionCb.SelectedIndex = 0;
            categoryCb.SelectedIndex = 0;
        }

        private void registerTeacherBnt_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                Teacher teacher;
                if (positionCb.Visible == true)
                {
                    if (positionCb.SelectedIndex == 0)
                    {
                        teacher = new Teacher(categoryCb.SelectedItem.ToString(), "Accountant",
                            bankTb.Text, accountNumTb.Text, ssnitTb.Text, tinTb.Text, phoneTB.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, addressTb.Text,
                            getRadioBtnValue(), DateTime.Today
                        );
                    }
                    else
                    {
                        teacher = new Teacher(categoryCb.SelectedItem.ToString(), String.IsNullOrEmpty(specificLbl.Text) ? "Other" : specificLbl.Text,
                            bankTb.Text, accountNumTb.Text, ssnitTb.Text, tinTb.Text, phoneTB.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, addressTb.Text,
                            getRadioBtnValue(), DateTime.Today
                        );
                    }

                }
                else
                {
                    teacher = new Teacher(categoryCb.SelectedItem.ToString(), "Teacher",
                        bankTb.Text, accountNumTb.Text, ssnitTb.Text, tinTb.Text, phoneTB.Text, emailTb.Text, fnameTb.Text, lnameTb.Text, addressTb.Text,
                        getRadioBtnValue(), DateTime.Today
                    );
                }

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
                    MessageBox.Show("Staff Personnel Saved");
                    clearFeilds();
                    DataFromDb.getAllTeacher = DbClient.dataSource("SELECT teacher_id,phone,email, (SELECT name FROM Class WHERE Class.class_id=Teacher.class_id) AS class, [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Teaching'");
                    DataFromDb.totalTeachers = DbClient.query_executeScaler("SELECT COUNT(*) FROM Teacher");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void clearFeildBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void categoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryCb.SelectedIndex == 1)
            {
                positionCb.Visible = true;
                positionLbl.Visible = true;
            }
            else
            {
                positionCb.Visible = false;
                positionLbl.Visible = false;

                specificTb.Visible = false;
                specificLbl.Visible = false;
            }
        }

        private void positionCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryCb.SelectedIndex == 1)
            {
                specificLbl.Visible = true;
                specificTb.Visible = true;
            }
            else
            {
                specificTb.Visible = false;
                specificLbl.Visible = false;
            }
        }
    }
}
