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
        ClassRoom classRoom;
        private string query;
        public static string class_id;

        public ClassData()
        {
            InitializeComponent();
            classRoom = new ClassRoom();

            classDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            classDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            classDataView.BackgroundColor = Home.foreColor;

            columnArrangement();
            classRoom.show_data(classDataView);
            getTeacher();
        }

        private void columnArrangement()
        {
            classDataView.AutoGenerateColumns = false;

            classDataView.Columns["name"].DisplayIndex = 0;
            classDataView.Columns["section"].DisplayIndex = 1;
            classDataView.Columns["capacity"].DisplayIndex = 2;
            classDataView.Columns["teacher"].DisplayIndex = 3;
            classDataView.Columns["fees"].DisplayIndex = 4;
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


                    query = "SELECT [f_name]+' '+[l_name] AS name FROM Teacher WHERE teacher_id='" + teacher_id + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    classDataView.ReadOnly = false;
                    while (reader.Read())
                     {
                         if (reader.IsDBNull(0)) { continue; }
                         item.Cells["teacher"].Value = reader["name"].ToString();
                        Console.WriteLine(reader["name"].ToString());
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

        private void classDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = classDataView.Rows[e.RowIndex];
                class_id = row.Cells["id"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();

                if (classDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete " + name + "?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        query = "UPDATE Teacher SET class_id=NULL WHERE class_id='" + class_id + "'";
                        DbClient.query_execute(query);
                        
                        query = "UPDATE Fee SET class_id=NULL WHERE class_id='" + class_id + "'";
                        DbClient.query_execute(query);

                        query = "UPDATE Student SET class_id=NULL, class=NULL WHERE class_id='" + class_id + "'";
                        DbClient.query_execute(query);
                        
                        query = "DELETE FROM Class WHERE class_id='" + class_id + "'";
                        DbClient.query_execute(query);

                        classDataView.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show(name + " deleted from system");
                    }
                }
                else if(classDataView.Columns[e.ColumnIndex].Name == "edit" && e.RowIndex >= 0)
                {
                    OpenNewPage openNewPage = new OpenNewPage();
                    openNewPage.OpenChildForm(new Pages.UpdateClass(), showDataPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


}
