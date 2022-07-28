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
    public partial class UpdateClass : Form
    {
        private string query;
        private string id = Pages.ClassData.class_id;
        public UpdateClass()
        {
            InitializeComponent();
            bgPanel.BackColor = Home.foreColor;
            fillData();
        }

        private void updateClassBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(teacherCb.Text))
            {
                query = "UPDATE Class SET name='"+nameTb.Text+"', section='"+sectionCb.SelectedItem.ToString()+"', capacity='"+capacityTb.Text+"', fees='"+feesBox.Value.ToString()+"' WHERE classs_id='"+id+"'";
                DbClient.query_execute(query);

                query = "SELECT teacher_id FROM Teacher WHERE [f_name]+' '+[l_name]='" + teacherCb.SelectedItem.ToString() + "'";
                string teacher_id = DbClient.query_executeScaler(query);

                query = "UPDATE Teacher SET class_id=NULL WHERE class_id='" + id + "'";
                DbClient.query_execute(query);

                query = "UPDATE Class SET teacher_id=" + teacher_id + " WHERE name='" + nameTb.Text + "'";
                DbClient.query_execute(query);

                query = "UPDATE Teacher SET class_id='"+id+"' WHERE teacher_id='" + teacher_id + "'";
                DbClient.query_execute(query);

            }
            MessageBox.Show("Class Updated");
        }

        private void fillData()
        {
            string teacher = "";
            query = "SELECT * FROM Class WHERE class_id='" + id + "'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                nameTb.Text = reader["name"].ToString();
                capacityTb.Text = reader["capacity"].ToString();
                feesBox.Value = decimal.Parse(reader["fees"].ToString());
                sectionCb.SelectedItem = reader["section"].ToString();
                teacher = reader["teacher_id"].ToString();
            }
            reader.Close();

            query = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE teacher_id='" + teacher + "'";
            reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                teacher = reader["name"].ToString();
            }
            reader.Close();

            query = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher EXCEPT SELECT [f_name]+' '+[l_name] FROM Teacher WHERE class_id IS NOT NULL AND class_id != '" + id + "'";
            DbClient.query_reader(teacherCb, query);
            for (int i = 0; i < teacherCb.Items.Count; i++)
            {
                if (teacher.Equals(teacherCb.Items[i].ToString()))
                {
                    teacherCb.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
