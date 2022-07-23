using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    public partial class Login : Form
    {
        private Random random;
        private int tempIndex;
        public static Color foreColor;
        public static Color themeColor;

        public Login()
        {
            InitializeComponent();
            random = new Random();
            themeColor = SelectedThemeColor();
            bgPanel.BackColor = themeColor;
            loginPanel.BackColor = themeColor;
            loadingPanel.BackColor = foreColor;
            pictureBox.BackColor = foreColor;
            loadingLbl.ForeColor = foreColor;
            welcomeLbl.ForeColor = foreColor;
            label2.ForeColor = foreColor;
        }

        private Color SelectedThemeColor()
        {
            int index = random.Next(ThemeColor.darkColors.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.darkColors.Count);
            }
            tempIndex = index;
            string themeColor = ThemeColor.darkColors[index];
            foreColor = ColorTranslator.FromHtml(ThemeColor.lightColors[index]);

            return ColorTranslator.FromHtml(themeColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingPanel.Width += 3;
            if(loadingPanel.Width >= loadingPlaceholderPanel.Width)
            {
                timer1.Stop();
                OpenNewPage openNewPage = new OpenNewPage();
                openNewPage.OpenChildForm(new Pages.LoginAs(), loginPanel);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close the application?";
            MessageBoxButtons action = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, "", action);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

    
}
