using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Nikita_Shchitinin_Laba_1__KGiGM_
{
    public partial class Form1 : Form
    {
        Size s;
        Graphics g;

        //Для анимации
        int part = 7;

        //Для анимации "Z"
        int x1 = 114;
        int x2 = 190;
        int x3 = 124;
        int x4 = 130;
        int x5 = 164;
        int x6 = 138;
        int x7 = 190;

        int y1 = 37;
        int y2 = -23;
        int y3 = 17;
        int y4 = -13;

        //Для анимации "Ctrl"
        int x8 = -180;
        int x9 = -100;
        int x10 = -164;
        int x11 = -116;
        int x12 = -160;

        Pen a1 = new Pen(Color.White, 8);
        Pen a2 = new Pen(Color.White, 6);
        Pen a3 = new Pen(Color.White, 4);

        Pen b1 = new Pen(Color.LightSlateGray, 2);

        SolidBrush q1 = new SolidBrush(Color.LightGray);
        SolidBrush q2 = new SolidBrush(Color.DarkGray);
        SolidBrush q3 = new SolidBrush(Color.LightSlateGray);
        SolidBrush q4 = new SolidBrush(Color.White);

        Font f = new Font("Arial", 30, FontStyle.Bold);

        void Draw(Graphics g)
        {
            g.Clear(Color.SteelBlue);

            int h = ((ClientSize.Height / s.Height));

            //Клавиша "ctrl"
            Point p1 = new Point(-190 * h, -23 * h);
            Point p2 = new Point(-190 * h, 37 * h);
            Point p3 = new Point(-100 * h, 37 * h);
            Point p4 = new Point(-100 * h, -23 * h);
            Point[] ctrl1 = { p1, p2, p3, p4 };

            Point p5 = new Point(x8 * h, -23 * h);
            Point p6 = new Point(x8 * h, 37 * h);
            Point p7 = new Point(x9 * h, 37 * h);
            Point p8 = new Point(x9 * h, -23 * h);
            Point[] ctrl2 = { p5, p6, p7, p8 };

            //Клавиша "z"
            Point p9 = new Point(x1 * h, y1 * h);
            Point p10 = new Point(x2 * h, y1 * h);
            Point p11 = new Point(x2 * h, y2 * h);
            Point p12 = new Point(x1 * h, y2 * h);
            Point[] z1 = { p9, p10, p11, p12 };

            Point p13 = new Point(x3 * h, y1 * h);
            Point p14 = new Point(x7 * h, y1 * h);
            Point p15 = new Point(x7 * h, y2 * h);
            Point p16 = new Point(x3 * h, y2 * h);
            Point[] z2 = { p13, p14, p15, p16 };

            g.TranslateTransform((ClientSize.Width) / 2, (ClientSize.Height) / 2);
            
            //линия
            g.DrawLine(a1, -210*h, 40*h, 210*h, 40*h);

            //Клавиша "ctrl"
            g.FillClosedCurve(q2, ctrl1, FillMode.Alternate, 0f);
            g.DrawClosedCurve(a2, ctrl1, 0f, FillMode.Alternate);

            g.FillClosedCurve(q1, ctrl2, FillMode.Alternate, 0f);
            g.DrawClosedCurve(a3, ctrl2, 0f, FillMode.Alternate);

            //Глаза
            g.FillEllipse(q3, x10 * h, 17 * h, 10, 10);
            g.DrawEllipse(b1, x10 * h, 17 * h, 10, 10);

            g.FillEllipse(q3, x11 * h, 17 * h, 10, 10);
            g.DrawEllipse(b1, x11 * h, 17 * h, 10, 10);

            //Текст
            g.DrawString("Ctrl", f, q4, x12*h, -7*h);

            //Клавиша "z"
            g.FillClosedCurve(q2, z1, FillMode.Alternate, 0f);
            g.DrawClosedCurve(a2, z1, 0f, FillMode.Alternate);

            g.FillClosedCurve(q1, z2, FillMode.Alternate, 0f);
            g.DrawClosedCurve(a3, z2, 0f, FillMode.Alternate);

            //Глаза
            g.FillEllipse(q3, x4 * h, y3 * h, 10, 10);
            g.DrawEllipse(b1, x4 * h, y3 * h, 10, 10);

            g.FillEllipse(q3, x5 * h, y3 * h, 10, 10);
            g.DrawEllipse(b1, x5 * h, y3 * h, 10, 10);

            //Текст
            g.DrawString("Z", f, q4, x6 * h, y4 * h);

            Animated();
        }

        void Animated()
        {
            int h = ((ClientSize.Height / s.Height));

            if (part == -2)
            {
                g.Clear(Color.SteelBlue);
            }

            if (part == -1)
            {
                x1 = 114;
                x2 = 190;
                x3 = 124;
                x4 = 130;
                x5 = 164;
                x6 = 138;
                x7 = 190;
                x8 = -180;
                x9 = -100;
                x10 = -164;
                x11 = -116;
                x12 = -160;

                y1 = 37;
                y2 = -23;
                y3 = 17;
                y4 = -13;

                part++;
            }

            if (part == 0)
            {
                x3--;
                x7--;
                x4--;
                x5--;
                x6--;

                if (x3 == 114) part++;
            }

            if (part == 1)
            {
                y1-=3;
                y2-=3;
                y3-=3;
                y4-=3;

                if (y1 == 25) part++;
            }

            if (part == 2)
            {
                y1+=3;
                y2+=3;
                y3+=3;
                y4+=3;

                if (y1 == 37) part++;
            }

            if (part == 3)
            {
                x1 += 3;
                x2 += 3;
                x3 += 3;
                x4 += 3;
                x5 += 3;
                x6 += 3;
                x7 += 3;

                if (x3 == 120) part++;
            }

            if (part == 4)
            { 
                x1-=20;
                x2-=20;
                x3-=20;
                x4-=20;
                x5-=20;
                x6-=20;
                x7-=20;

                if (x3 == 20 ) part++;
            }

            if (part == 5)
            {
                x8 -= 2;
                x9 -= 2;
                x10 -= 2;
                x11 -= 2;
                x12 -= 2;

                if (x8 == -190) part++;
            }

            if (part == 6)
            { 
                x1 -= 20;
                x2 -= 20;
                x3 -= 20;
                x4 -= 20;
                x5 -= 20;
                x6 -= 20;
                x7 -= 20;

                if (x3 == -100)
                {
                    part = -2;

                    button1.Enabled = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(500, 450);
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = new Size(ClientRectangle.Width, ClientSize.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Draw(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            part = -1;
            button1.Enabled = false;
        }
    }
}