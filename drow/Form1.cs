using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
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
        Pen p = new Pen(Color.Black, 5);
        bool style=false;
        
        HatchBrush b = new HatchBrush(HatchStyle.Percent90,Color.Black,Color.Black);
        HatchBrush b1 = new HatchBrush(HatchStyle.Percent90, Color.Black, Color.Black);
        public Form1()
        {
            InitializeComponent();
        }
        private Image img = null;
        private BufferedGraphicsContext bgc = BufferedGraphicsManager.Current;
        private BufferedGraphics bg;
        Graphics gimg;
        Graphics bgg;
        ColorDialog colorDialog = new ColorDialog();
        List<Point> points = new List<Point>();//ин
        GraphicsPath tr1;
        GraphicsPath tr;
        GraphicsPath tr2;
        bool col = true;



        int cnt;
        bool fill = false;
        private void red_Click(object sender, EventArgs e)
        {
            //if (sender.GetType() == typeof(Button))
            //{
               
            //        if ((sender as Button).Name.ToString() == "red")
            //        {
            //            if (col) { p.Color = Color.Red; }
            //            else { Pick1.BackColor = Color.Red; }
            //        }
            //        if ((sender as Button).Name.ToString() == "yellow")
            //        {
            //            if (col) { p.Color = Color.Yellow; }
            //            else { Pick1.BackColor = Color.Yellow; }
            //        }
            //        if ((sender as Button).Name.ToString() == "green")
            //        {
            //            if (col) { p.Color = Color.Green; }
            //            else { Pick1.BackColor = Color.Green; }
            //        }
            //        if ((sender as Button).Name.ToString() == "blue")
            //        {
            //            if (col) { p.Color = Color.Blue; }
            //            else { Pick1.BackColor = Color.Blue; }
            //        }
            //        if ((sender as Button).Name.ToString() == "purple")
            //        {
            //            if (col) { p.Color = Color.Purple; }
            //            else { Pick1.BackColor = Color.Purple; }
            //        }
            //        if ((sender as Button).Name.ToString() == "transparent")
            //        {
            //            if (col) { p.Color = Color.Transparent; }
            //            else { Pick1.BackColor = Color.Transparent; }
            //        }
            //        if ((sender as Button).Name.ToString() == "white")
            //        {
            //            if (col) { p.Color = Color.White; }
            //            else { Pick1.BackColor = Color.White; }
            //        }
            //        if ((sender as Button).Name.ToString() == "black")
            //        {
            //            if (col) { p.Color = Color.Black; }
            //            else { Pick1.BackColor = Color.Black; }
            //        }
            //        if ((sender as Button).Name.ToString() == "orange")
            //        {
            //            if (col) { p.Color = Color.Orange; }
            //            else { Pick1.BackColor = Color.Orange; }
            //        }
            //    Pick.BackColor = p.Color;
                    
                
             
            //}
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            
            if (sender.GetType() == typeof(Button))
            {
                if ((sender as Button).Name.ToString() == "pencil") { tool = 0; }
                if ((sender as Button).Name.ToString() == "ruler") { tool = 1; }
                if ((sender as Button).Name.ToString() == "eraser") { tool = 2; }
                if ((sender as Button).Name.ToString() == "background") 
                {
                    //panel1.BackColor = p.Color;
                    //bgg.DrawImage(img, 0, 0);
                    //gimg = Graphics.FromImage(img); 
                    gimg.Clear(p.Color);
                    g.DrawImage(img, 0, 0);
                }
                if ((sender as Button).Name.ToString() == "clean")
                {
                    //panel1.Invalidate();
                    //panel1.Update();
                    //panel1.BackColor = System.Drawing.Color.White;

                    gimg.Clear(System.Drawing.Color.White);
                    g.DrawImage(img, 0, 0);

                }
                if((sender as Button).Name.ToString() == "circle") { tool = 3; }
                if((sender as Button).Name.ToString() == "triangle") { tool = 4; }
                if((sender as Button).Name.ToString() == "rectangle") { tool = 5; }
                if ((sender as Button).Name.ToString() == "button1") { tool = 6; }
                if ((sender as Button).Name.ToString() == "t90") { tool = 7; }
                if ((sender as Button).Name.ToString() == "Polygon") { tool = 8; }
                if ((sender as Button).Name.ToString() == "Regular_polynom") { tool = 9; }
                if ((sender as Button).Name.ToString() == "Arrow") { tool = 10; }
                if ((sender as Button).Name.ToString() == "Star") { tool = 11; }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = Decimal.ToInt32(numericUpDown1.Value);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
            if (img == null)
            {
                g = panel1.CreateGraphics();
                var b1 = new SolidBrush(System.Drawing.Color.White);
                img = new Bitmap(panel1.Width, panel1.Height,g); 
                gimg = Graphics.FromImage(img);
                gimg.FillRectangle(b1, new Rectangle(0, 0, panel1.Width, panel1.Height));
            }
            bg = bgc.Allocate(panel1.CreateGraphics(), new Rectangle(0, 0, panel1.Width, panel1.Height));
            gimg.SmoothingMode = SmoothingMode.HighQuality;

            g = panel1.CreateGraphics();
            g.DrawImage(img, 0, 0);

        }

        private void Palette_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Pick.BackColor = colorDialog1.Color;
                p.Color = Pick.BackColor;
            }
        }

        //OPEN сделай 
        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            //saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.Filter = "Файлы картинок в формате JPG|*.jpg|Файлы картинок в формате PNG|*.png";
            var res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            { 
                img.Save(saveFileDialog1.FileName);  
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            tool = 12;
            //gimg = Graphics.FromImage(img);

            openFileDialog1.AddExtension = true;
            var res = openFileDialog1.ShowDialog();
            gimg.Clear(Color.White);

            if (res == DialogResult.OK)
            {
                
                Open1 ifrm = new Open1();
                ifrm.ShowDialog();
                if (ifrm.Result == 0)
                {
                    Image img2 = Image.FromFile(this.openFileDialog1.FileName.ToString());
                    img = new Bitmap(img2, img.Size);
                    gimg.Clear(Color.White);
                    gimg.Clear(p.Color);
                    g.DrawImage(img, 0, 0);
                    gimg.DrawImage(img2, 0, 0);
                    g.DrawImage(img, 0, 0);
                   
                    //ifrm.Hide();
                }
                if (ifrm.Result == 1)
                {
                    Image img2 = Image.FromFile(openFileDialog1.FileName.ToString());
                    //gimg.DrawImage(img2, 0, 

                    gimg.DrawImage(img2, 0, 0);
                    g.DrawImage(img, 0, 0);
                    
                    //ifrm.Hide();
                }

               
            }


            //drawImage

        }
    

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (bg == null) return;
            bgg = bg.Graphics;
            bgg.SmoothingMode = SmoothingMode.AntiAlias;
            gimg.SmoothingMode = SmoothingMode.AntiAlias;
            p.StartCap = p.EndCap = LineCap.Round;
            int x2, y2;
            x2 = e.Location.X;
            y2 = e.Location.Y;
            if (img == null) return;
            if (e.Button == MouseButtons.Left)
            {
                if (style) {b = new HatchBrush(b1.HatchStyle, Pick1.BackColor, Color.Transparent);}
                if (!style) { b = new HatchBrush(b1.HatchStyle, Pick1.BackColor, Pick1.BackColor); }
                if (tool == 0)
                {
                    g.DrawImage(img, 0, 0);
                    gimg.DrawLine(p, x, y, x2, y2);
                    //g.DrawLine(p, x, y, x2, y2);
                    x = x2;
                    y = y2;
                }
                if (tool == 1)
                {
                    bgg.DrawImage(img, 0, 0);
                    bgg.DrawLine(p, x, y, x2, y2);
                    bg.Render();
                }
                if (tool == 2)
                {
                    Pen p1 = new Pen(panel1.BackColor, p.Width + 5);
                    if (e.Button == MouseButtons.Left)
                    {
                        g.DrawImage(img, 0, 0);
                        gimg.DrawLine(p1, x, y, x2, y2);
                        
                        x = x2;
                        y = y2;
                       
                    }
                }
                if (tool == 3)
                {
                   
                    bgg.DrawImage(img, 0, 0);
                    bgg.DrawEllipse(p, x, y, x2 - x, y2 - y);
                    if (fill)
                    {
                        bgg.DrawImage(img, 0, 0);
                        bgg.DrawEllipse(p, x, y, x2 - x, y2 - y);
                        bgg.FillEllipse(b, x, y, x2 - x, y2 - y);
                        //bg.Render();
                    }
                    bg.Render();
                }
                if (tool == 4)
                {
                    
                    tr = new GraphicsPath();
                    tr.StartFigure();
                    tr.AddLine(x, y, x2, y2);
                    tr.AddLine(x2, y2, 2 * x - x2, y2);
                    tr.AddLine(2 * x - x2, y2, x, y);
                    tr.CloseFigure();
                    
                    bgg.DrawImage(img, 0, 0);
                    bgg.DrawPath(p, tr);
                    if (fill)
                    {
                        bgg.DrawImage(img, 0, 0);
                        bgg.DrawPath(p, tr);
                        bgg.FillPath(b, tr);
                        bg.Render();
                    }
                    //bgg.DrawLine(p, x, y, x2 , y2);
                    //bgg.DrawLine(p, x2, y2, 2*x-x2, y2);
                    //bgg.DrawLine(p, 2 * x - x2, y2, x, y);
                    bg.Render();
                }
                if (tool == 5)
                {
                    bgg.DrawImage(img, 0, 0);
                    if ((x2 - x)>0 &&( y2 - y)>0)
                    {
                        bgg.DrawRectangle(p, new Rectangle(x, y, Math.Abs(x2 - x), Math.Abs(y2 - y)));
                        if (fill)
                        {
                            bgg.FillRectangle(b, new Rectangle(x, y, Math.Abs(x2 - x), Math.Abs(y2 - y)));
                        }
                    }
                    else
                    {
                        bgg.DrawRectangle(p, new Rectangle(x2, y2, Math.Abs(x2 - x), Math.Abs(y2 - y)));
                        if (fill)
                        {
                            bgg.FillRectangle(b, new Rectangle(x2, y2, Math.Abs(x2 - x), Math.Abs(y2 - y)));
                        }

                    }

                    bg.Render();
                    //g.DrawRectangle(p, x, y, dx-x, dy-y);
                }
                if (tool == 7)
                {
                    tr1 = new GraphicsPath();
                    tr1.StartFigure();
                    tr1.AddLine(x, y, x + 10, y + 30);
                    tr1.AddArc(x - 10, y + 30, 20, 10, 0, 180);
                    tr1.AddLine( x - 10, y + 30,x,y);
                    tr1.CloseFigure();
                   
                    bgg.DrawImage(img, 0, 0);
                    bgg.DrawPath(p, tr1);
                    if (fill)
                    {
                        bgg.DrawImage(img, 0, 0);
                        bgg.FillPath(b, tr1);
                        bg.Render();
                    }
                    bg.Render();
                }
                if (tool == 9)
                {
                    Point r = new Point((x2 + x)/2,( y2 + y)/2);
                    bgg.DrawImage(img, 0, 0);
                    DrawRegularPolygon(r, 5, (y2-y)/2, bgg,p,b,fill);
                    bg.Render();

                }
                if (tool == 10)
                {
                    tr2 = new GraphicsPath();
                    tr2.StartFigure();
                    tr2.AddLine(x,y,(x+2*x2)/3+(x2-x)/12,y-(x2-x)/12);
                    tr2.AddLine((x + 2 * x2) / 3 + (x2 - x) / 12, y - (x2 - x) / 12,(x+2*x2)/3,y-(x2-x)/3);
                    tr2.AddLine((x + 2 * x2) / 3, y - (x2 - x) / 3, x2,y);
                    tr2.AddLine(x2,y, (x + 2 * x2) / 3, y +(x2 - x) / 3);
                    tr2.AddLine((x + 2 * x2) / 3, y + (x2 - x) / 3,(x + 2 * x2) / 3 + (x2 - x) / 12, y + (x2 - x) / 12);
                    tr2.AddLine((x + 2 * x2) / 3 + (x2 - x) / 12, y + (x2 - x) / 12,x,y);
                    tr2.CloseFigure();

                    bgg.DrawImage(img, 0, 0);
                    bgg.DrawPath(p, tr2);
                    if (fill)
                    {
                        //bgg.DrawPath(p, tr2);
                        bgg.DrawImage(img, 0, 0);
                        bgg.DrawPath(p, tr2);
                        bgg.FillPath(b, tr2);
                        bg.Render();
                    }
                    bg.Render();
                }
                if (tool == 11)
                {
                    Point r = new Point((x2 + x) / 2, (y2 + y) / 2);
                    bgg.DrawImage(img, 0, 0);
                    DrawStar(r, 5, (y2 - y) / 2, (y2 - y) / 4,bgg, p, b, fill);
                    bg.Render();

                }
            }

        }

        private void Fill_CheckedChanged(object sender, EventArgs e)
        {
            if (!fill) { fill = true; }
            else { fill = false; }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            if (panel1.Width < 0 || panel1.Height < 0) return;
            if (img == null) return;
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //var b1 = new SolidBrush(Color.White);
            Image img1 = new Bitmap(img);
            img = new Bitmap(panel1.Width, panel1.Height,g);
            gimg = Graphics.FromImage(img);
            gimg.Clear(Color.White);
            //gimg.FillRectangle(b1, new Rectangle(0, 0, panel1.Width, panel1.Height));
            gimg.DrawImage(img1, 0, 0);
            bg = bgc.Allocate(g, new Rectangle(0, 0, panel1.Width,panel1.Height));
            bg.Graphics.Clear(Color.White);
        }

        private void Pick_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                if ((sender as Button).Name.ToString() == "Pick") col = true;
                if ((sender as Button).Name.ToString() == "Pick1") col = false;
            }
        }

        private void StyleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = StyleCB.SelectedItem.ToString();
            style = true;
            if(select == "Квадратики") { b1 = new HatchBrush(HatchStyle.Cross, Pick1.BackColor, Color.Transparent); }
            if (select == "Полоски") { b1 = new HatchBrush(HatchStyle.Horizontal, Pick1.BackColor, Color.Transparent); }
            if (select == "Диоганальки") { b1 = new HatchBrush(HatchStyle.BackwardDiagonal, Pick1.BackColor, Color.Transparent); }
            if (select == "Шарики") { b1 = new HatchBrush(HatchStyle.Sphere, Pick1.BackColor, Color.Transparent); }
            if (select == "Сплошной") { b1 = new HatchBrush(HatchStyle.Sphere, Pick1.BackColor, Color.Transparent); style =false; }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tool == 12)
            {
                tool = 0;
                return;
            }
            if (style) { b = new HatchBrush(b1.HatchStyle, Pick1.BackColor, Color.Transparent); }
            if (!style) { b = new HatchBrush(b1.HatchStyle, Pick1.BackColor, Pick1.BackColor); }
            dx = e.X;
            dy = e.Y;
            //panel1.CreateGraphics().DrawImage(img, 0, 0);
            if (e.Button == MouseButtons.Left)
            {
                if (tool == 0)
                {
                    gimg = Graphics.FromImage(img);
                }
                
                if (tool == 1)
                {//прямая линия
                    gimg = Graphics.FromImage(img);
                    gimg.DrawLine(p, x, y, dx, dy);
                }
                if (tool == 3)
                {
                   
                    gimg = Graphics.FromImage(img);
                    gimg.DrawEllipse(p, x, y, dx - x, dy - y);
                    if (fill)
                    {
                        gimg.FillEllipse(b, x, y, dx - x, dy - y);
                    }
                }
                if (tool == 4)
                {
                    gimg = Graphics.FromImage(img);
                    gimg.DrawPath(p, tr);
                    if (fill)
                    {
                        gimg.FillPath(b, tr);
                    }

                }
                if (tool == 5)
                {

                    gimg = Graphics.FromImage(img);
                    if ((dx - x) > 0 && (dy - y) > 0)
                    {
                        gimg.DrawRectangle(p, new Rectangle(x, y, Math.Abs(dx - x), Math.Abs(dy - y)));
                        if (fill)
                        {
                            gimg.FillRectangle(b, new Rectangle(x, y, Math.Abs(dx - x), Math.Abs(dy - y)));

                        }
                    }
                    else
                    {
                        gimg.DrawRectangle(p, new Rectangle(dx, dy, Math.Abs(dx - x), Math.Abs(dy - y)));
                        if (fill)
                        {
                            gimg.FillRectangle(b, new Rectangle(dx, dy, Math.Abs(dx - x), Math.Abs(dy - y)));

                        }
                    }
                }
                if (tool == 6)
                {
                    g.DrawArc(p, x, y, Math.Abs(dx - x), Math.Abs(dy - y), 0, 120);
                }
                if (tool == 7)
                {
                    gimg = Graphics.FromImage(img);
                    gimg.DrawPath(p, tr1);
                    if (fill)
                    {
                        gimg.FillPath(b, tr1);
                    }
                   
                }
                if (tool == 8)
                {
                    if (cnt < 6)
                    { 
                    points.Add(new Point(e.X, e.Y));
                    cnt++;
                    }
                    if (cnt == 6)
                    {
                        Point[] pnts = new Point[points.Count];
                        for(int i = 0; i < points.Count; i++)
                        {
                            pnts[i] = points[i];

                        }
                        gimg = Graphics.FromImage(img);
                        gimg.DrawPolygon(p, pnts);
                        g.DrawImage(img, 0, 0);
                        points.Clear();
                        cnt = 0;
                    }
                }
                if (tool == 9)
                {
                    gimg = Graphics.FromImage(img);
                    Point r = new Point((dx + x) / 2, (dy + y) / 2);
                    gimg.DrawImage(img, 0, 0);
                    DrawRegularPolygon(r, 5, (dy - y) / 2, gimg,p,b,fill);
                    
                }
                if (tool == 10)
                {
                    gimg = Graphics.FromImage(img);
                    gimg.DrawPath(p, tr2);
                    if (fill)
                    {
                        gimg.FillPath(b, tr2);
                    }

                }
                if (tool == 11)
                {
                    Point r = new Point((dx + x) / 2, (dy + y) / 2);
                    gimg.DrawImage(img, 0, 0);
                    DrawStar(r, 5, (dy - y) / 2, (dy - y) / 4, gimg, p, b, fill);
                    bg.Render();

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void red_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((sender as Button).Name.ToString() == "red")
                {
                    Pick1.BackColor = Color.Red;
                }
                if ((sender as Button).Name.ToString() == "yellow")
                {
                    Pick1.BackColor = Color.Yellow;
                }
                if ((sender as Button).Name.ToString() == "green")
                {
                    Pick1.BackColor = Color.Green;
                }
                if ((sender as Button).Name.ToString() == "blue")
                {
                    Pick1.BackColor = Color.Blue;
                }
                if ((sender as Button).Name.ToString() == "purple")
                {
                    Pick1.BackColor = Color.Purple;
                }
                if ((sender as Button).Name.ToString() == "transparent")
                {
                    Pick1.BackColor = Color.Transparent;
                }
                if ((sender as Button).Name.ToString() == "white")
                {
                    Pick1.BackColor = Color.White;
                }
                if ((sender as Button).Name.ToString() == "black")
                {
                    Pick1.BackColor = Color.Black;
                }
                if ((sender as Button).Name.ToString() == "orange")
                {
                    Pick1.BackColor = Color.Orange;
                }
               
            }
            if (e.Button == MouseButtons.Left)
            {
                if (sender.GetType() == typeof(Button))
                {

                    if ((sender as Button).Name.ToString() == "red")
                    {
                        p.Color = Color.Red;

                    }
                    if ((sender as Button).Name.ToString() == "yellow")
                    {
                        p.Color = Color.Yellow;
                    }
                    if ((sender as Button).Name.ToString() == "green")
                    {
                        p.Color = Color.Green;
                    }
                    if ((sender as Button).Name.ToString() == "blue")
                    {
                        p.Color = Color.Blue;
                    }
                    if ((sender as Button).Name.ToString() == "purple")
                    {
                        p.Color = Color.Purple;
                    }
                    if ((sender as Button).Name.ToString() == "transparent")
                    {
                        p.Color = Color.Transparent;
                    }
                    if ((sender as Button).Name.ToString() == "white")
                    {
                        p.Color = Color.White;
                    }
                    if ((sender as Button).Name.ToString() == "black")
                    {
                        p.Color = Color.Black;
                    }
                    if ((sender as Button).Name.ToString() == "orange")
                    {
                        p.Color = Color.Orange;
                    }
                    Pick.BackColor = p.Color;
                }
            }
        
    

}

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            g = panel1.CreateGraphics();
            x = e.Location.X;
            y = e.Location.Y;
            if(e.Button == MouseButtons.Right)
            {
                col = false;
            }
        }
        private static void DrawRegularPolygon(PointF center, // Координаты центра окружности
        int vertexes, // Количество вершин
        float radius, // Радиус
        Graphics graphics,Pen p,Brush b, bool fill)
        {
            var angle = Math.PI * 2 / vertexes;

            var points = Enumerable.Range(0, vertexes)
                  .Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius)));

            graphics.DrawPolygon(p, points.ToArray());
            if (fill)
            {
                graphics.FillPolygon(b, points.ToArray());
            }
        }
        private static void DrawStar(PointF center,int vertexes,float R,float r, Graphics graphics, Pen p, Brush b, bool fill)
        {
            PointF[] points = new PointF[2 * vertexes + 1];
            double angle = Math.PI / vertexes;
            double a = 0;
            double l;
            for (int k = 0; k < 2 * vertexes + 1; k++)
            {
                l = k % 2 == 0 ? r : R;
                points[k] = new PointF((float)(center.X + l * Math.Cos(a)), (float)(center.Y + l * Math.Sin(a)));
                a += angle;
            }

            graphics.DrawPolygon(p, points.ToArray());
            if (fill)
            {
                graphics.FillPolygon(b, points.ToArray());
            }
        }
    }
}
