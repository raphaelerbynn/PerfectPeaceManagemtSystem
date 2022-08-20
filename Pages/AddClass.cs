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
    public partial class AddClass : Form
    {
        private string query;

        public AddClass()
        {
            InitializeComponent();
            bgPanel.BackColor = Home.foreColor;

            query = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE category='Teaching' EXCEPT SELECT [f_name]+' '+[l_name] FROM Teacher WHERE class_id IS NOT NULL";
            DbClient.query_reader(teacherCb, query);
            
            totalFeesLbl.Text = "0.00";
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            if (!(String.IsNullOrEmpty(nameTb.Text) || String.IsNullOrEmpty(capacityTb.Text)) && sectionCb.SelectedIndex > -1)
            {
                ClassRoom classRoom = new ClassRoom(
                    nameTb.Text, int.Parse(capacityTb.Text), 
                    sectionCb.SelectedItem.ToString(), 
                    double.Parse(tuition.Value.ToString()), 
                    double.Parse(firstAid.Value.ToString()), 
                    double.Parse(PTA.Value.ToString()), 
                    double.Parse(water.Value.ToString()), 
                    double.Parse(maintenance.Value.ToString()), 
                    double.Parse(stationary.Value.ToString()), 
                    double.Parse(cocurricular.Value.ToString()), 
                    double.Parse(totalFeesLbl.Text.ToString())
                    );
                classRoom.insert_class();

                if (!String.IsNullOrEmpty(teacherCb.Text))
                {
                    query = "SELECT teacher_id FROM Teacher WHERE [f_name]+' '+[l_name]='" + teacherCb.SelectedItem.ToString() + "'";
                    string teacher_id = DbClient.query_executeScaler(query);

                    query = "UPDATE Class SET teacher_id=" + teacher_id + " WHERE name='" + nameTb.Text + "'";
                    DbClient.query_execute(query);

                    query = "UPDATE Teacher SET class_id='" + DbClient.GetLastId("Class") + "' WHERE teacher_id='" + teacher_id + "'";
                    DbClient.query_execute(query);
                }
                DataFromDb.getAllClass = DbClient.dataSource("SELECT class_id, name, section, capacity, fees, teacher_id, (SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE Teacher.teacher_id=Class.teacher_id AS teacher) FROM Class");
                MessageBox.Show("Class Added");
            }
            else
            {
                MessageBox.Show("Fill class name and capacity!!!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFeild();
        }

        private void clearFeild()
        {
            nameTb.Text = null;
            capacityTb.Text = null;
            foreach(Control box in bgPanel.Controls)
            {
                if (box is NumericUpDown)
                {
                    ((NumericUpDown)box).Value = 0;
                }
            }
            sectionCb.SelectedIndex = -1;
            teacherCb.SelectedIndex = -1;
            totalFeesLbl.Text = "0.00";
        }

        private void tuition_ValueChanged(object sender, EventArgs e)
        {
            decimal totalFees = 0;
            totalFees += tuition.Value;
            totalFees += firstAid.Value;
            totalFees += PTA.Value;
            totalFees += water.Value;
            totalFees += maintenance.Value;
            totalFees += stationary.Value;
            totalFees += cocurricular.Value;

            totalFeesLbl.Text = totalFees.ToString();
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
