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
            Home parentForm = (Home)Application.OpenForms["Home"];
            if (parentForm != null)
            {
                this.Location = new Point((parentForm.Location.X + (parentForm.Width - this.Width)) / 2 + 154, parentForm.Location.Y + 10);
            }
            else
            {
                int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                this.Location = new Point(x, y);
            }
            this.BackColor = Color.White;
            pic.BackColor = ColorTranslator.FromHtml(ThemeColor.cellColors[0]);

        }

        public WaitForm(Form parent)
        {
            InitializeComponent();
            Home parentForm = (Home)Application.OpenForms["Home"];
            this.Location = new Point((parentForm.Location.X + (parentForm.Width - this.Width))/2 + 154, parentForm.Location.Y + 10);
            this.BackColor = Color.White;
            pic.BackColor = ColorTranslator.FromHtml(ThemeColor.cellColors[0]);
            

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
