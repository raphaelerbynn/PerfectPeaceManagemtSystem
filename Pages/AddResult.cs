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
    public partial class AddResult : Form
    {
        private string query;
        List<Label> subjectLabels;

        public AddResult()
        {
            InitializeComponent();
            showSubjects();
            Label label = new Label();
            label.Text = "Nana";
            label.Location = new Point(375, 235);
            label.AutoSize = true;
            label.ForeColor = Color.Black;
            this.Controls.Add(label);
        }

        private void showSubjects()
        {
            subjectLabels = new List<Label>();
            int subLocationX = subjectName0.Location.X;
            int subLocationY = subjectName0.Location.Y;

            query = "SELECT * FROM Subject";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                /*Label label = new Label();
                label.Text = reader["name"].ToString();
                label.Location = new Point(subLocationX, subLocationY);
                subjectLabels.Add(label);

                subLocationY += 5;*/
            }
            reader.Close();
            Label label = new Label();
            label.Text = "Nana";
            label.Location = new Point(100, 200);

        }

    }
}
