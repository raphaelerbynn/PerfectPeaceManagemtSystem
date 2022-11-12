using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    internal class OpenNewPage
    {
        //Form activeForm;

        public void OpenChildForm(Form childForm, Panel panel)
        {
            /*if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            */childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
