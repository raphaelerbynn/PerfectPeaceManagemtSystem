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
    public partial class FeePaying : Form
    {
        public FeePaying()
        {
            InitializeComponent();
        }

        private void amntTb_TextChanged(object sender, EventArgs e)
        {
            amntTb.Text = string.Format("{0:#,##0.00}", double.Parse(amntTb.Text));
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
    }
}
