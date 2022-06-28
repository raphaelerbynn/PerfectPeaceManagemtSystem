using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Peace_System
{
    internal class Resolution
    {
        float heightRatio = new float();
        float widthRatio = new float();
        int standardHeight;
        int standardWidth;

        public void ResizeForm(Form objForm, int DesignerHeight, int DesignerWidth)
        {
            standardHeight = DesignerHeight;
            standardWidth = DesignerWidth;
            int presentHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int presentWidth = Screen.PrimaryScreen.Bounds.Width;
            heightRatio = (float)((float)presentHeight / (float)standardHeight);
            widthRatio = (float)((float)presentWidth / (float)standardWidth);
            objForm.AutoScaleMode = AutoScaleMode.None;
            objForm.Scale(new SizeF(widthRatio, heightRatio));

            foreach(Control c in objForm.Controls)
            {
                if (c.HasChildren)
                {
                    ResizeControlStore(c);
                }
                else
                {
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size * heightRatio, c.Font.Style, c.Font.Unit, ((byte)(0)));
                }
                objForm.Font = new Font(objForm.Font.FontFamily, objForm.Font.Size * heightRatio, objForm.Font.Style, objForm.Font.Unit, ((byte)(0)));
            }
        }

        private void ResizeControlStore(Control objC)
        {
            if (objC.HasChildren)
            {
                foreach(Control c in objC.Controls)
                {
                    if (c.HasChildren)
                    {
                        ResizeControlStore(c);
                    }
                    else
                    {
                        c.Font = new Font(c.Font.FontFamily, c.Font.Size * heightRatio, c.Font.Style, c.Font.Unit, ((byte)(0)));
                    }
                    objC.Font = new Font(objC.Font.FontFamily, objC.Font.Size * heightRatio, objC.Font.Style, objC.Font.Unit, ((byte)(0)));
                }
            }
            else
            {
                objC.Font = new Font(objC.Font.FontFamily, objC.Font.Size * heightRatio, objC.Font.Style, objC.Font.Unit, ((byte)(0)));
            }
        }
    }
}
