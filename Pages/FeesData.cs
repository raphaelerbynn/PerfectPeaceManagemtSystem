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
    public partial class FeesData : Form
    {
        Fees fees = new Fees();
        private string query;

        public FeesData()
        {
            InitializeComponent();

            feesDataView.ColumnHeadersDefaultCellStyle.BackColor = Form1.themeColor;
            feesDataView.RowsDefaultCellStyle.BackColor = Form1.cellColor;
            feesDataView.BackgroundColor = Form1.foreColor;

           
            fees.show_data(feesDataView);
            getStudent();
            columnArrangement();

        }

        private void columnArrangement()
        {
            feesDataView.AutoGenerateColumns = false;

            feesDataView.Columns["fee_id"].DisplayIndex = 0;
            feesDataView.Columns["student_name"].DisplayIndex = 1;
            feesDataView.Columns["_class"].DisplayIndex = 2;
            feesDataView.Columns["amount"].DisplayIndex = 3;
            feesDataView.Columns["payment_mode"].DisplayIndex = 4;
            feesDataView.Columns["remaining"].DisplayIndex = 5;
            feesDataView.Columns["date_paid"].DisplayIndex = 6;
            
            feesDataView.Columns["student_id"].Visible = false;
        }

        private void getStudent()
        {
            try
            {
                foreach (DataGridViewRow item in feesDataView.Rows)
                {
                    string student_id = item.Cells["student_id"].Value.ToString();
                    item.Cells["student_name"].Value = "";
                    item.Cells["_class"].Value = "";

                    query = "SELECT class,[f_name]+' '+[l_name] AS name FROM Student WHERE student_id='" + student_id + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    feesDataView.ReadOnly = false;
                    while (reader.Read())
                    {
                        //if (reader.IsDBNull(0)) { continue; }
                        item.Cells["student_name"].Value = reader["name"].ToString();
                        item.Cells["_class"].Value = reader["class"].ToString();

                        Console.WriteLine(reader["name"].ToString());
                    }
                    reader.Close();
                    feesDataView.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
