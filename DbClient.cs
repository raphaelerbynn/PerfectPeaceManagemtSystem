using System;
using System.Collections.Generic;
using System.Configuration;
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

        public const string connectionString = @"Server=tcp:perfect-peace-server.database.windows.net,1433;Initial Catalog=PerfectPeace;Persist Security Info=False;User ID=perfectpeace;Password=peace@2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; 
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
            /*try
            {*/
                cmd = new SqlCommand(query, connection);
                
                cmd.ExecuteNonQuery();/*
            }catch(Exception ex)
            {
                if (ex.ToString().Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Data with same id already exists");
                }
                else
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }*/
        }
        
        public static string query_executeScaler(string query)
        {
            try
            {
                cmd = new SqlCommand(query, connection);
                string value = cmd.ExecuteScalar().ToString();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;
            }
                
        }

        public static SqlDataReader get_reader(string query)
        {
            try
            {
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;
            }
        }

        public static void query_reader(ComboBox combo, string query)
        {
            try
            {
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combo.Items.Add(reader[0].ToString());
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }
        
        public static SqlDataReader query_reader(string query)
        {
            try
            {
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                //reader.Close();
                return reader;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;
            }
        }

        public static string GetLastId(string table)
        {
            try
            {
                var fetchSql = new SqlCommand("SELECT MAX(" + table.ToLower() + "_id) FROM " + table, connection);
                var dr = fetchSql.ExecuteScalar();
                return dr.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;
            }
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
            try
            {
                dataTable = new DataTable();
                query_execute(query);
                dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        public static DataTable dataSource(string query)
        {
            try
            {
                dataTable = new DataTable();
                query_execute(query);
                dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
                return null;
            }
        }

        public static void connection_close()
        {
            connection.Close();
        }
    }
}
