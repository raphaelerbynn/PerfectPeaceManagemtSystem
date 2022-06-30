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
    public partial class StudentReport : Form
    {
        private string query;
        public StudentReport()
        {
            InitializeComponent();

            query = "SELECT name FROM Class";
            DbClient.query_reader(classCb, query);
            classCb.SelectedIndex = 0;
        }

        private void loadListBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
