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
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
        }

        public WaitForm(Form parent)
        {
            InitializeComponent();
            
        }

        public void closeWaitForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            //MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (pic.Image != null)
            {
                pic.Image.Dispose();
            }
        }
        
    }
}
