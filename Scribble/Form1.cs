using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Scribble
{
    // add resize option
    // add select
    // undo/redo
    // stamp brush
    // animation
    // colors [DONE]
    // draw line, Rec [DONE]
    // free draw
    // Line and Rec flixable
    // ignore list of points of rec and line ?

    public partial class Form1 : Form
    {
        List<Shape> shapes;

        List<PointF> points;
        Color color;
        ShapeStyle style;
        bool isDragging = false;

        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            color = Color.Red;
            style = ShapeStyle.FreeDraw;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Shape s in shapes)
            {
                draw(g, s.points, s.shape, s.color);
            }

            if (isDragging)
            {
                draw(g, points, style, color);
            }
        }

        private void draw(Graphics g, List<PointF> pts, ShapeStyle ss, Color cc)
        {
            Pen p = Pens.Red;
            if (cc == Color.RoyalBlue)
                p = Pens.RoyalBlue;

            switch (ss)
            {
                case ShapeStyle.Line:
                    g.DrawLine(p, pts[0].X, pts[0].Y, pts[pts.Count - 1].X, pts[pts.Count - 1].Y);
                    break;
                case ShapeStyle.Rectangle:
                    g.DrawRectangle(p, pts[0].X, pts[0].Y,
                        pts[pts.Count - 1].X - pts[0].X, pts[pts.Count - 1].Y - pts[0].Y);
                    break;
                case ShapeStyle.FreeDraw:
                    g.DrawCurve(p, pts.ToArray());
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None)
            {
                points.Add(e.Location);
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        { 
            points = new List<PointF>();

            isDragging = true;
            points.Add(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

            points.Add(e.Location);

            Shape p = new Shape();
            p.points = points;
            p.color = color;
            p.shape = style;

            shapes.Add(p);
        }

        private void line_button_Click(object sender, EventArgs e)
        {
            style = ShapeStyle.Line;
        }

        private void free_button_Click(object sender, EventArgs e)
        {
            style = ShapeStyle.FreeDraw;
        }

        private void rec_button_Click(object sender, EventArgs e)
        {
            style = ShapeStyle.Rectangle;
        }

        private void red_button_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void blue_button_Click(object sender, EventArgs e)
        {
            color = Color.RoyalBlue;
        }
    }
}
