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
        private string parent_id;
        Person parent;

        public ParentsData()
        {
            parent = new Parent();
            InitializeComponent();

            showParentDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            showParentDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            showParentDataView.BackgroundColor = Home.foreColor;
            topPanel.BackColor = Home.foreColor;
            
            columnArrangement();

            parent.show_data(showParentDataView);
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
            
            searchCb.SelectedIndex = 0;
        }

        private void getChild()
        {
            try
            {
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

        private void showParentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = showParentDataView.Rows[e.RowIndex];
                parent_id = row.Cells["id"].Value.ToString();
                string name = row.Cells["name"].Value.ToString();


                if (showParentDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete " + name + "?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        query = "UPDATE Student SET parent_id=NULL WHERE parent_id='"+parent_id+"'";
                        DbClient.query_execute(query);

                        showParentDataView.Rows.RemoveAt(e.RowIndex);
                        parent.delete(parent_id);

                        MessageBox.Show(name + " deleted from system");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchTextBox.Text))
            {
                try
                {
                    (showParentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchCb.Text + " LIKE '%{0}%'", searchTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Again");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                (showParentDataView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }
    }
}
