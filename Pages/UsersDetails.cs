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
    public partial class UsersDetails : Form
    {
        private string query;
        public static string user = "";

        public UsersDetails()
        {
            InitializeComponent();
            this.BackColor = Home.foreColor;

            accountDataView.ColumnHeadersDefaultCellStyle.BackColor = Home.themeColor;
            accountDataView.RowsDefaultCellStyle.BackColor = Home.cellColor;
            accountDataView.BackgroundColor = Home.foreColor;

            columnArrangement();
            query = "SELECT username, name, password, email, category FROM User_account";
            DbClient.dataGridFill(accountDataView, query);
            
        }

        private void columnArrangement()
        {
            accountDataView.AutoGenerateColumns = false;

            accountDataView.Columns["name"].DisplayIndex = 0;
            accountDataView.Columns["username"].DisplayIndex = 1;
            accountDataView.Columns["password"].DisplayIndex = 2;
            accountDataView.Columns["email"].DisplayIndex = 3;
            accountDataView.Columns["category"].DisplayIndex = 4;
            accountDataView.Columns["edit"].DisplayIndex = 5;
            accountDataView.Columns["delete"].DisplayIndex = 6;
        }

            private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
        }

        private void accountDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InternetConnectivity.checkConnectivity() == false)
            {
                MessageBox.Show("Check your internet connection");
                return;
            }
            try
            {
                DataGridViewRow row = accountDataView.Rows[e.RowIndex];
                user = row.Cells["username"].Value.ToString();


                if (accountDataView.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
                {
                    string message = "Are you sure you want to save all attendance for the term?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        Pages.ConfirmPassword confirmPassword = new Pages.ConfirmPassword();
                        confirmPassword.ShowDialog();
                        if (GetData.getConfirmedPassword() == true)
                        {
                            DbClient.query_execute("DELETE FROM User_account WHERE username='" + user + "'");
                            accountDataView.Rows.RemoveAt(e.RowIndex);
                            GetData.setConfirmPassword(false);
                        }
                    }
                }

                if (accountDataView.Columns[e.ColumnIndex].Name == "edit" && e.RowIndex >= 0)
                {
                    this.Hide();
                    Pages.EditUserDetails edit = new Pages.EditUserDetails();
                    edit.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
