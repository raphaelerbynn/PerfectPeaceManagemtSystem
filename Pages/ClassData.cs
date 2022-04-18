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
    public partial class ClassData : Form
    {
        string query;

        public ClassData()
        {
            InitializeComponent();
            ClassRoom classRoom = new ClassRoom();

            classRoom.show_data(classDataView);
            getTeacher();
            columnArrangement();
        }

        private void columnArrangement()
        {
            classDataView.AutoGenerateColumns = false;

            classDataView.Columns["name"].DisplayIndex = 0;
            classDataView.Columns["section"].DisplayIndex = 1;
            classDataView.Columns["capacity"].DisplayIndex = 2;
            classDataView.Columns["teacher"].DisplayIndex = 3;
            classDataView.Columns["view"].DisplayIndex = 4;
            classDataView.Columns["edit"].DisplayIndex = 5;
            classDataView.Columns["delete"].DisplayIndex = 6;

            classDataView.Columns["id"].Visible = false;
            classDataView.Columns["teacher_id"].Visible = false;


        }

        private void getTeacher()
        {
            try
            {
                foreach (DataGridViewRow item in classDataView.Rows)
                {
                    string teacher_id = item.Cells["teacher_id"].Value.ToString();
                    item.Cells["teacher"].Value = "";

                    Console.WriteLine(item.Cells["teacher"].Value.ToString());

                    query = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE teacher_id='" + teacher_id + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    classDataView.ReadOnly = false;
                    while (reader.Read())
                     {
                         if (reader.IsDBNull(0)) { continue; }
                         item.Cells["teacher"].Value = reader["name"].ToString();
                     }
                     reader.Close();
                     classDataView.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void classDataView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void maxCapacity()
        {

        }
    }


}
