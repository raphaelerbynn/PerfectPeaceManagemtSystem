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
            query = "SELECT [f_name]' '[l_name] AS name FROM Student WHERE parent_id='"+id+"'";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {

            }

        }


    }
}
