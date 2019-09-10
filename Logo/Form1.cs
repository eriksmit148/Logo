using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Logo Project
            //Erik Smith

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Palatino Linotype", 150, FontStyle.Regular);
            Font drawFont2 = new Font("Palatino Linotype", 35, FontStyle.Regular);
            Font drawFont3 = new Font("Palatino Linotype", 10, FontStyle.Regular);
            SolidBrush drawBrush2 = new SolidBrush(Color.White);

            //Background
            g.Clear(Color.IndianRed);

            //Black Rectangle with white border
            g.FillRectangle(drawBrush, 325, 100, 200, 350);
            g.DrawRectangle(drawPen, 335, 110, 180, 330);

            //White horizontal lines
            g.DrawLine(drawPen, 335, 170, 515, 170);
            g.DrawLine(drawPen, 335, 380, 515, 380);

            //2 Rs in middle
            g.DrawString("R", drawFont, drawBrush2, 340, 150);
            g.DrawString("R", drawFont, drawBrush2, 305, 120);

            //Rolls Ryce
            g.DrawString("ROLLS", drawFont2, drawBrush2, 340, 110);
            g.DrawString("ROYCE", drawFont2, drawBrush2, 340, 380);

            //Rotated Text
            g.TranslateTransform(525, 445);
            g.RotateTransform(270);
            g.DrawString("ROLLS ROYCE®", drawFont3, drawBrush2, new Rectangle());
            g.ResetTransform();
        }
    }
}
