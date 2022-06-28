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
    public partial class FeeReceipt : Form
    {
        PrintDocument printdoc = new PrintDocument();
        PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public FeeReceipt()
        {
            InitializeComponent();
            Console.WriteLine(FeePaying.paidAmnt);
            updateLabels();
        }

        private void updateLabels()
        {
            amntLbl_0.Text = FeePaying.paidAmnt;
            totalAmntLbl.Text = FeePaying.totalAmnt;
            remainingLbl.Text = FeePaying.remainingAmnt;
            amntWordsLbl.Text = FeePaying.amntWords;

            idLbl.Text = DbClient.GetLastId("Fee");
            dateLbl.Text = DateTime.Today.ToString();
            nameLbl.Text = FeePaying.name;
            classLbl.Text = FeePaying._class;
            termLbl.Text = FeePaying.term;
            modeLbl.Text = FeePaying.mode;
            amntLbl_1.Text = amntLbl_0.Text;
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
