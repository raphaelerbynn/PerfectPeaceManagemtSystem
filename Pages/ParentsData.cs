using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perfect_Peace_System.Pages
{
    public partial class ParentsData : Form
    {
        private string query;

        public ParentsData()
        {
            Person parent = new Parent();
            InitializeComponent();
            
            parent.show_data(showParentDataView);
            columnArrangement();
            getChild();

        }

        private void columnArrangement()
        {
            showParentDataView.AutoGenerateColumns = false;

            showParentDataView.Columns["id"].DisplayIndex = 0;
            showParentDataView.Columns["name"].DisplayIndex = 1;
            showParentDataView.Columns["child"].DisplayIndex = 2;
            showParentDataView.Columns["relationship"].DisplayIndex = 3;
            showParentDataView.Columns["contact"].DisplayIndex = 4;
            showParentDataView.Columns["message"].DisplayIndex = 5;
            showParentDataView.Columns["view"].DisplayIndex = 6;
            showParentDataView.Columns["edit"].DisplayIndex = 7;
            showParentDataView.Columns["delete"].DisplayIndex = 8;
            

        }

        private void getChild()
        {
            try
            {
                //List<string> children = new List<string>();
                //List<string> parent_ids = new List<string>();
                /*foreach (DataGridViewRow item in showParentDataView.Rows)
                {
                    parent_ids.Add(item.Cells["id"].Value.ToString());
                }

                foreach (string id_ in parent_ids)
                {
                    query = "SELECT [f_name]+' '+[l_name] AS name FROM Student WHERE parent_id='" + id_ + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    while (reader.Read())
                    {   
                        if (reader.IsDBNull(0)) { continue; }
                        children.Add(reader["name"].ToString());
                    }
                    reader.Close();
                } */

                foreach (DataGridViewRow item in showParentDataView.Rows)
                {
                    string id = item.Cells["id"].Value.ToString();
                    item.Cells["child"].Value = "";

                    query = "SELECT [f_name]+' '+[l_name] AS name FROM Student WHERE parent_id='" + id + "'";
                    SqlDataReader reader = DbClient.query_reader(query);
                    showParentDataView.ReadOnly = false;
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(0)) { continue; }
                        item.Cells["child"].Value = reader["name"].ToString();
                    }
                    reader.Close();
                    showParentDataView.ReadOnly = true;
                }

            }catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            
        }


    }
}
