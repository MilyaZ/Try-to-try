using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drow
{
    public partial class Form1 : Form
    {
        //переменные
        Graphics g;
        int x, y,dx,dy;
        int tool = 0;
        Pen p = new Pen(System.Drawing.Color.Black, 5);
        public Form1()
        {
            InitializeComponent();
        }

    

        private void red_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                if ((sender as Button).Name.ToString() == "red") { p.Color = System.Drawing.Color.Red; }
                if ((sender as Button).Name.ToString() == "yellow") { p.Color = System.Drawing.Color.Yellow; }
                if ((sender as Button).Name.ToString() == "green") { p.Color = System.Drawing.Color.Green; }
                if ((sender as Button).Name.ToString() == "blue") { p.Color = System.Drawing.Color.Blue; }
                if ((sender as Button).Name.ToString() == "purple") { p.Color = System.Drawing.Color.Purple; }
                if ((sender as Button).Name.ToString() == "brown") { p.Color = System.Drawing.Color.Brown; }
                if ((sender as Button).Name.ToString() == "white") { p.Color = System.Drawing.Color.White; }
                if ((sender as Button).Name.ToString() == "black") { p.Color = System.Drawing.Color.Black; }
                if ((sender as Button).Name.ToString() == "orange") { p.Color = System.Drawing.Color.Orange; }
            }
        }

        private void Pencil_Click(object sender, EventArgs e)
        {

            if (sender.GetType() == typeof(Button))
            {
                if ((sender as Button).Name.ToString() == "pencil") { tool = 0; }
                if ((sender as Button).Name.ToString() == "ruler") { tool = 1; }
                if ((sender as Button).Name.ToString() == "eraser") { tool = 2; }
                if ((sender as Button).Name.ToString() == "background") { panel1.BackColor = p.Color; }
                if ((sender as Button).Name.ToString() == "clean")
                {
                    panel1.Invalidate();
                    panel1.Update();
                    panel1.BackColor = System.Drawing.Color.White;

                }
                if((sender as Button).Name.ToString() == "circle") { tool = 3; }
                if((sender as Button).Name.ToString() == "triangle") { tool = 4; }
                if((sender as Button).Name.ToString() == "rectangle") { tool = 5; }
                if ((sender as Button).Name.ToString() == "button1") { tool = 6; }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = Decimal.ToInt32(numericUpDown1.Value);
        }

        

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (tool == 0)
            { 
                
                if (e.Button == MouseButtons.Left)
                { 
                    int x2, y2;
                    x2 = e.Location.X;
                    y2 = e.Location.Y;
                    g.DrawLine(p, x, y, x2, y2);
                    x = x2;
                    y = y2;
                }
            }
            if (tool == 2) 
            {
                Pen p1 = new Pen(panel1.BackColor, p.Width +5);
                if (e.Button == MouseButtons.Left)
                {
                    int x2, y2;
                    x2 = e.Location.X;
                    y2 = e.Location.Y;
                    g.DrawLine(p1, x, y, x2, y2);
                    x = x2;
                    y = y2;
                }
            }
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tool == 1)
            {
                dx = e.Location.X;
                dy = e.Location.Y;
                //прямая линия
                g.DrawLine(p, x, y, dx, dy);
            }
            if (tool == 3)
            {
                dx = e.Location.X;
                dy = e.Location.Y;
                g.DrawEllipse(p,dx, dy, x - dx, y - dy); 
            }
            if (tool == 4)
            {
                dx = e.Location.X;
                dy = e.Location.Y;
                g.DrawLine(p, dx, y, (dx - x) / 2, (dy - y) / 2);
                g.DrawLine(p, (dx - x) / 2, (dy - y) / 2, dx, dy);
                g.DrawLine(p, dx, y, dx, dy);
            }
            if (tool == 5)
            {
                dx = e.Location.X;
                dy = e.Location.Y;
                g.DrawRectangle(p, x, y, dx-x, dy-y);
            }
            if (tool == 6)
            {
                dx = e.Location.X;
                dy = e.Location.Y;
                g.DrawArc(p, x, y,Math.Abs (dx - x),Math.Abs( dy - y), 0, 120);
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            g = panel1.CreateGraphics();
            x = e.Location.X;
            y = e.Location.Y;
        }
    }
}
