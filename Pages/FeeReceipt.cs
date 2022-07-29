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
    public partial class FeeReceipt : Form
    {
        private string query;
        PrintDocument printdoc = new PrintDocument();
        PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public FeeReceipt()
        {
            InitializeComponent();
            updateLabels();
            bgPanel.BackColor = Home.foreColor;
        }

        private void updateLabels()
        {
            try
            {
                string student_id = GetData.getStudentIdReceipt();
                query = "SELECT *, FORMAT(date_paid, 'ddd, dd-MMM-yyyy') AS date FROM Fee WHERE student_id='" + student_id + "'";
                SqlDataReader reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    idLbl.Text = reader["fee_id"].ToString();
                    amntLbl_0.Text = "GHc " + reader["paid"].ToString();
                    remainingLbl.Text = "GHc " + reader["remaining"].ToString();
                    amntWordsLbl.Text = reader["amount_in_words"].ToString();
                    modeLbl.Text = reader["payment_mode"].ToString();
                    termLbl.Text = reader["term"].ToString();
                    totalAmntLbl.Text = "GHc " + reader["total"].ToString();
                    amntLbl_0.Text = reader["paid"].ToString();
                    dateLbl.Text = reader["date"].ToString();
                }
                reader.Close();

                query = "SELECT [f_name]+' '+[m_name]+' '+[l_name] AS name, class FROM Student WHERE student_id='" + student_id + "'";
                reader = DbClient.query_reader(query);
                while (reader.Read())
                {
                    nameLbl.Text = reader["name"].ToString();
                    classLbl.Text = reader["class"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Print(this.receiptPanel);
        }

        private void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            receiptPanel = panel;
            getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printPage);
            ((Form) printPreview).Size = new Size(950, 539);
            printPreview.ShowDialog();
        }

        private void printdoc_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pageArea.Width / 2) - (this.receiptPanel.Width / 2), this.receiptPanel.Location.Y);
        }

        Bitmap memoryImg;
        private void getPrintArea(Panel panel)
        {
            memoryImg = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryImg, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void feePanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
