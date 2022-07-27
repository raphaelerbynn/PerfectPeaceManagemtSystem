using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    static class DbClient
    {
        public const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOUNTAIN\Desktop\Perfect Peace System\PerfectPeace.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection connection;
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;
        public static SqlDataReader reader;
        public static DataTable dataTable;

        static DbClient()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }


        public static void query_execute(string query)
        {
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
        
        public static string query_executeScaler(string query)
        {
            cmd = new SqlCommand(query, connection);
            string value = cmd.ExecuteScalar().ToString();
            

            return value;
        }

        public static void query_reader(ComboBox combo, string query)
        {
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                combo.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        
        public static SqlDataReader query_reader(string query)
        {
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();

            return reader;
        }

        public static string GetLastId(string table)
        {
            var fetchSql = new SqlCommand("SELECT MAX("+table.ToLower()+"_id) FROM " + table, connection);
            var dr = fetchSql.ExecuteScalar();
            return dr.ToString();
        }
        
        /*public static int getIdFromCombo(string query,string selectedItem)
        {
            dataAdapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return id;
        }*/

        public static void dataGridFill(DataGridView dataGrid, string query)
        {
            dataTable = new DataTable();
            query_execute(query);
            dataAdapter = new SqlDataAdapter(query, connection);
            dataAdapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
        }





        public static void connection_close()
        {
            connection.Close();
        }
    }
}
