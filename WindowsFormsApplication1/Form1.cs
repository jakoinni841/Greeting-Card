using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            greeting.Visible = false;
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.White, 2);

            //First Point
            formGraphics.FillEllipse(drawBrush, 50, 60, 5, 5);
            //Second Point
            formGraphics.FillEllipse(drawBrush, 80, 65, 5, 5);
            //First Point up
            formGraphics.FillEllipse(drawBrush, 90, 50, 5, 5);
            //Second Point up
            formGraphics.FillEllipse(drawBrush, 105, 5, 5, 5);
            //Third point up
            formGraphics.FillEllipse(drawBrush, 160, 25, 5, 5);
            //Fourth point up
            formGraphics.FillEllipse(drawBrush, 185, 70, 5, 5);
            //Fifth point up
            formGraphics.FillEllipse(drawBrush, 195, 110, 5, 5);
            //Sixth point up
            formGraphics.FillEllipse(drawBrush, 155, 135, 5, 5);
            //Seventh point up
            formGraphics.FillEllipse(drawBrush, 95, 150, 5, 5);
            //Farthest Right
            formGraphics.FillEllipse(drawBrush, 205, 104, 5, 5);

        
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 52, 62, 82, 67);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 82, 67, 97, 152);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 82, 67, 92, 50);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 92, 50, 105, 5);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 105, 5, 160, 25);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 95, 152, 157, 138);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 157, 138, 195, 112);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 195, 112, 206, 106);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 197, 112, 185, 70);
            Refresh();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 160, 25, 185, 70);
            Refresh();
            
        }
    }
}
