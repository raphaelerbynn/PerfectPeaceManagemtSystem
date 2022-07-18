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
    public partial class Payroll : Form
    {
        private string query;
        OpenNewPage openNewPage = new OpenNewPage();

        public Payroll()
        {
            InitializeComponent();
        }

        private void salaryBaseDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = salaryBaseDataView.Rows[e.RowIndex];
                string id = row.Cells["salary_id"].Value.ToString();
                if (salaryBaseDataView.Columns[e.ColumnIndex].Name == "deleteSalary" && e.RowIndex >= 0)
                {
                    string message = "Do you want to delete this salary base?";
                    MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, "", deleteAction);
                    if (result == DialogResult.Yes)
                    {
                        salaryBaseDataView.Rows.RemoveAt(e.RowIndex);
                        query = "DELETE FROM Salary WHERE salary_id='" + id + "'";
                        DbClient.query_execute(query);
                        MessageBox.Show("Data deleted from system");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSalaryBtn_Click(object sender, EventArgs e)
        {
            openNewPage.OpenChildForm(new Pages.AddSalary(), salaryBasedPanel);
        }

        private void salaryBaseBtn_Click(object sender, EventArgs e)
        {
            salaryBasedPanel.Visible = true;
            addSalaryBtn.Visible = true;
        }
    }
}
