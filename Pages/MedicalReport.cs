using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class MedicalReport : Form
    {
        readonly PrintDocument printdoc = new PrintDocument();
        readonly PrintPreviewDialog printPreview = new PrintPreviewDialog();
        private string id = StudentDataDisplay.getIdFromSelectedRow();
        private string query;
        public MedicalReport()
        {
            InitializeComponent();
            bgPanel.BackColor = Home.foreColor;
            fillLabels();
        }

        private void fillLabels()
        {
            try
            {
                query = "SELECT f_name+' '+m_name+' '+l_name AS name, class FROM Student WHERE student_id='"+id+"'";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    nameLbl.Text = reader["name"].ToString();
                    classLbl.Text = reader["class"].ToString();
                }
                reader.Close();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Print()
        {
            PrinterSettings ps = new PrinterSettings();
            //reportCardPanel = panel;
            //getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printPage);
            ((Form)printPreview).Size = new Size(950, 539);
            printPreview.ShowDialog();
        }

        private void printdoc_printPage(object sender, PrintPageEventArgs e)
        {
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.reportPanel, true, true);
            e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, reportPanel.Width, reportPanel.Height));
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
