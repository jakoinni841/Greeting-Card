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
using System.Media;

// Jakob Innis, September 28, 2016. Constellation Program.

namespace WindowsFormsApplication1
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Twankle);
            player.Play();
        }

        private void Window_Click(object sender, EventArgs e)
        {
            // Create Graphics, Pens, and Brushes for Constellation
            greeting.Visible = false;
            this.BackgroundImage = null;
            design.Visible = false;
            design2.Visible = false;
            Refresh();
            Graphics formGraphics = this.CreateGraphics();
            Graphics fg = this.CreateGraphics();
            SolidBrush drawStar = new SolidBrush(Color.Yellow);
            Pen drawWhite = new Pen(Color.White, 2);
            Pen drawYellow = new Pen(Color.Yellow, 2);

            //Random Stars
            formGraphics.FillEllipse(drawStar, 16, 16, 5, 5);
            formGraphics.FillEllipse(drawStar, 32, 48, 5, 5);
            formGraphics.FillEllipse(drawStar, 48, 32, 5, 5);
            formGraphics.FillEllipse(drawStar, 74, 5, 5, 5);
            formGraphics.FillEllipse(drawStar, 89, 120, 5, 5);
            formGraphics.FillEllipse(drawStar, 120, 89, 5, 5);
            formGraphics.FillEllipse(drawStar, 150, 54, 5, 5);
            formGraphics.FillEllipse(drawStar, 183, 148, 5, 5);
            formGraphics.FillEllipse(drawStar, 220, 39, 5, 5);
            formGraphics.FillEllipse(drawStar, 48, 60, 5, 5);
            formGraphics.FillEllipse(drawStar, 66, 78, 5, 5);
            formGraphics.FillEllipse(drawStar, 12, 120, 5, 5);
            formGraphics.FillEllipse(drawStar, 1, 62, 5, 5);
            formGraphics.FillEllipse(drawStar, 135, 27, 5, 5);
            formGraphics.FillEllipse(drawStar, 50, 142, 5, 5);
            formGraphics.FillEllipse(drawStar, 125, 155, 5, 5);
            formGraphics.FillEllipse(drawStar, 200, 125, 5, 5);
            formGraphics.FillEllipse(drawStar, 170, 15, 5, 5);

            // Points go in order from left clockwise
            formGraphics.FillEllipse(drawStar, 50, 60, 5, 5);
            formGraphics.FillEllipse(drawStar, 80, 65, 5, 5);
            formGraphics.FillEllipse(drawStar, 90, 50, 5, 5);
            formGraphics.FillEllipse(drawStar, 105, 5, 5, 5);
            formGraphics.FillEllipse(drawStar, 160, 25, 5, 5);
            formGraphics.FillEllipse(drawStar, 185, 70, 5, 5);
            formGraphics.FillEllipse(drawStar, 195, 110, 5, 5);
            formGraphics.FillEllipse(drawStar, 155, 135, 5, 5);
            formGraphics.FillEllipse(drawStar, 95, 150, 5, 5);
            formGraphics.FillEllipse(drawStar, 205, 104, 5, 5);

            // Form Lines connecting stars 
            SoundPlayer player = new SoundPlayer(Properties.Resources.twinkle);
            player.Play();
            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);

            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);


            // Make the Ophiuchus definition
            formGraphics.DrawLine(drawWhite, 160, 25, 185, 70);
            Font drawFont = new Font("Times New Roman", 16, FontStyle.Bold);
            SolidBrush drawFact = new SolidBrush(Color.White);
            SolidBrush drawFact2 = new SolidBrush(Color.Blue);
            Font drawText = new Font("Arial", 8, FontStyle.Bold);

            fg.DrawString("Ophiuchus Constellation", drawFont, drawFact2, 120, 175);
            fg.DrawString("Ophiuchus has sometimes been used", drawText, drawFact, 127, 200);
            fg.DrawString("in sidereal astrology as a", drawText, drawFact, 127, 210);
            fg.DrawString("thirteenth sign in addition to the", drawText, drawFact, 127, 220);
            fg.DrawString("twelve signs of the tropical Zodiac.", drawText, drawFact, 127, 230);

            // Long Thing of changing colors
            Thread.Sleep(500);
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
           
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
          
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
          
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
        
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
       
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
      
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
          
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
            
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
          
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
          
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
          
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
           
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
        
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
            
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
          
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);
           
            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawYellow, 197, 112, 185, 70);
            formGraphics.DrawLine(drawWhite, 195, 112, 206, 106);
            formGraphics.DrawLine(drawYellow, 157, 138, 195, 112);
            formGraphics.DrawLine(drawWhite, 95, 152, 157, 138);
            formGraphics.DrawLine(drawYellow, 105, 5, 160, 25);
            formGraphics.DrawLine(drawWhite, 92, 50, 105, 5);
            formGraphics.DrawLine(drawYellow, 82, 67, 92, 50);
            formGraphics.DrawLine(drawWhite, 82, 67, 97, 152);
            formGraphics.DrawLine(drawYellow, 52, 62, 82, 67);
            Thread.Sleep(500);

            formGraphics.DrawLine(drawWhite, 197, 112, 185, 70);
            formGraphics.DrawLine(drawYellow, 195, 112, 206, 106);
            formGraphics.DrawLine(drawWhite, 157, 138, 195, 112);
            formGraphics.DrawLine(drawYellow, 95, 152, 157, 138);
            formGraphics.DrawLine(drawWhite, 105, 5, 160, 25);
            formGraphics.DrawLine(drawYellow, 92, 50, 105, 5);
            formGraphics.DrawLine(drawWhite, 82, 67, 92, 50);
            formGraphics.DrawLine(drawYellow, 82, 67, 97, 152);
            formGraphics.DrawLine(drawWhite, 52, 62, 82, 67);
            Thread.Sleep(500);

        }
    }
}
