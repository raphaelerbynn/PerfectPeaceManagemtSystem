using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System.Pages
{
    public partial class PaySlip : Form
    {
        readonly PrintDocument printdoc = new PrintDocument();
        readonly PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public PaySlip()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Print();
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
            var bitMap = ControlPrinter.ScrollableControlToBitmap(this.payslipPanel, true, true);
            e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, payslipPanel.Width, payslipPanel.Height));
        }
    }
}
