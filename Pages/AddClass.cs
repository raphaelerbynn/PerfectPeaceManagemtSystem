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
            query = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher EXCEPT SELECT [f_name]+' '+[l_name] FROM Teacher WHERE class_id IS NOT NULL";
            DbClient.query_reader(teacherCb, query);
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            ClassRoom classRoom = new ClassRoom(nameTb.Text, int.Parse(capacityTb.Text), sectionCb.SelectedItem.ToString(), double.Parse(feesBox.Value.ToString()));
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
            MessageBox.Show("Class Added");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFeild();
        }

        private void clearFeild()
        {
            nameTb.Text = null;
            capacityTb.Text = null;
            feesBox.Value = 0;
            sectionCb.SelectedIndex = -1;
            teacherCb.SelectedIndex = -1;
        }
    }
}
