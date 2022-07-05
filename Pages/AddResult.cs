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
            showSubjectsWithFeilds();
            
        }

        private void showSubjectsWithFeilds()
        {
            subjectLabels = new List<Label>();
            int subLocationX = subjectName.Location.X;
            int subLocationY = subjectName.Location.Y + 48;

            query = "SELECT * FROM Subject";
            SqlDataReader reader = DbClient.query_reader(query);
            while (reader.Read())
            {
                Label label = new Label();
                label.Text = reader["name"].ToString();
                label.Name = reader["name"].ToString() + "Lbl";
                label.Location = new Point(subLocationX, subLocationY);
                label.Anchor = AnchorStyles.Top;
                label.AutoSize = true;
                label.Font = new Font("Calibri", 12);
                label.Margin = new Padding(0, 0, 20, 0);
                subjectLabels.Add(label);
                
                subLocationY += 50;
            }
            reader.Close();

            foreach (Label label in subjectLabels)
            {
                inputPanel.Controls.Add(label);
            }
            

        }
    }
}
