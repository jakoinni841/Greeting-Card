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
            Graphics fg = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Pen drawPen = new Pen(Color.White, 2);

            //Random Stars
            formGraphics.FillEllipse(drawBrush, 16, 16, 5, 5);
            formGraphics.FillEllipse(drawBrush, 32, 48, 5, 5);
            formGraphics.FillEllipse(drawBrush, 48, 32, 5, 5);
            formGraphics.FillEllipse(drawBrush, 74, 5, 5, 5);
            formGraphics.FillEllipse(drawBrush, 89, 120, 5, 5);
            formGraphics.FillEllipse(drawBrush, 120, 89, 5, 5);
            formGraphics.FillEllipse(drawBrush,148, 183, 5, 5);
            formGraphics.FillEllipse(drawBrush, 183, 148, 5, 5);
            formGraphics.FillEllipse(drawBrush, 220, 39, 5, 5);
            formGraphics.FillEllipse(drawBrush, 48, 60, 5, 5);
            formGraphics.FillEllipse(drawBrush, 66,78, 5, 5);
            formGraphics.FillEllipse(drawBrush, 12, 120, 5, 5);
            formGraphics.FillEllipse(drawBrush, 1, 62, 5, 5);
            formGraphics.FillEllipse(drawBrush, 135, 27, 5, 5);
            formGraphics.FillEllipse(drawBrush, 50, 142, 5, 5);
            formGraphics.FillEllipse(drawBrush, 125, 155, 5, 5);
            formGraphics.FillEllipse(drawBrush, 100, 175, 5, 5);
            formGraphics.FillEllipse(drawBrush, 170, 15, 5, 5);


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
      
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 82, 67, 97, 152);
    
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 82, 67, 92, 50);
      
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 92, 50, 105, 5);
     
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 105, 5, 160, 25);
     
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 95, 152, 157, 138);
     
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 157, 138, 195, 112);
        
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 195, 112, 206, 106);
        
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen, 197, 112, 185, 70);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawPen, 160, 25, 185, 70);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawFact = new SolidBrush(Color.White);
            Font drawText = new Font("Arial", 12, FontStyle.Bold);

            fg.DrawString("Ophiuchus", drawFont, drawFact, 200, 175);
            fg.DrawString("ophiuchus has sometimes been used in sidereal astrology", drawText, drawFact, 175, 190);
            fg.DrawString("as a thirteenth sign in addition to the twelve signs of the tropical Zodiac", drawText, drawFact, 175, 200);



        }
    }
}
