using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void Window_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.White, 2);

            formGraphics.FillEllipse(drawBrush, 50, 60, 5, 5);
            formGraphics.FillEllipse(drawBrush, 80, 65, 5, 5);
            formGraphics.FillEllipse(drawBrush, 95, 150, 5, 5);
            formGraphics.FillEllipse(drawBrush, 90, 50, 5, 5);
            formGraphics.FillEllipse(drawBrush, 105, 5, 5, 5);
            formGraphics.FillEllipse(drawBrush, 160, 25, 5, 5);
            formGraphics.FillEllipse(drawBrush, 155, 135, 5, 5);
            formGraphics.FillEllipse(drawBrush, 185, 70, 5, 5);
            formGraphics.FillEllipse(drawBrush, 195, 110, 5, 5);
            formGraphics.FillEllipse(drawBrush, 205, 104, 5, 5);

            formGraphics.DrawLine(drawPen, 52, 62, 82, 67);
            formGraphics.DrawLine(drawPen, 82, 67, 97, 152);
            formGraphics.DrawLine(drawPen, 82, 67, 92, 50);
            formGraphics.DrawLine(drawPen, 92, 50, 105, 5);
            formGraphics.DrawLine(drawPen, 105, 5, 160, 25);
            formGraphics.DrawLine(drawPen, 95, 150, 155, 135);
            formGraphics.DrawLine(drawPen, 155, 139, 195, 110);
            formGraphics.DrawLine(drawPen, 197, 112, 205, 104);
            formGraphics.DrawLine(drawPen, 197, 112, 185, 70);
            formGraphics.DrawLine(drawPen, 160, 25, 185, 70);




        }
    }
}
