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
    public partial class ClassData : Form
    {
        public ClassData()
        {
            InitializeComponent();
            ClassRoom classRoom = new ClassRoom();
            classRoom.show_data(classDataView);
        }
    }
}
