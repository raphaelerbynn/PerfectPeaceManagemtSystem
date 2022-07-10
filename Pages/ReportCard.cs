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
    public partial class ReportCard : Form
    {
        private string query;
        private string subject_idR;
        private int no_subject;
        PrintDocument printdoc = new PrintDocument();
        PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public ReportCard()
        {
            InitializeComponent();
            populateResults();
        }

        private void populateResults()
        {
            query = "SELECT COUNT(*) FROM Student";
            no_subject = int.Parse(DbClient.query_executeScaler(query));
            int length_of_subject = 30 * no_subject;
            resultDataView.Size = new Size(resultDataView.Width, resultDataView.Height + length_of_subject);

            query = "SELECT subject_id, name FROM Subject";
            DbClient.dataGridFill(resultDataView, query);

            remarksPanel.Location = new Point(remarksPanel.Location.X, remarksPanel.Location.Y + length_of_subject);
            printBtn.Location = new Point(printBtn.Location.X, printBtn.Location.Y + length_of_subject);
            //reportCardPanel.Size = new Size(reportCardPanel.Width, reportCardPanel.Height + remarksPanel.Height);
        }

        private void resultDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Print(reportCardPanel);
        }

        private void Print(Panel panel)
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
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.reportCardPanel, true, true);
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, reportCardPanel.Width, reportCardPanel.Height));
        }

        
    }
}
