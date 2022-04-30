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
    public partial class FeePaying : Form
    {
        PrintDocument printdoc = new PrintDocument();
        PrintPreviewDialog printPreview = new PrintPreviewDialog();

        public FeePaying()
        {
            InitializeComponent();
            initialisers();
            
        }

        private void amntTb_TextChanged(object sender, EventArgs e)
        {
            //amntTb.Text = string.Format("{0:#,###.00}", double.Parse(amntTb.Text));
            if (!string.IsNullOrEmpty(amntTb.Text))
            {
                double paidAmt = double.Parse(amntTb.Text);
                double total = double.Parse(totalAmntLbl.Text);
                double remain = double.Parse(remainAmntLbl.Text);

                remainAmntLbl.Text = (total - paidAmt).ToString();
            }
            else
            {
                remainAmntLbl.Text = totalAmntLbl.Text;
            }
        }

        private void amntTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            } 
        }

        private void initialisers()
        {
            dateDob.Value = DateTime.Now;
        }

        
        private void payFeesBtn_Click(object sender, EventArgs e)
        {
            Print(this.feePanel);
            
        }

        private void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            feePanel = panel;
            getPrintArea(panel);
            printPreview.Document = printdoc;
            printdoc.PrintPage += new PrintPageEventHandler(printdoc_printPage);
            printPreview.ShowDialog();
        }

        private void printdoc_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pageArea.Width / 2) - (this.feePanel.Width / 2), (pageArea.Height / 2) - (this.feePanel.Height / 2));
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
