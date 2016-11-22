using Scribble.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Scribble
{
    // add resize option
    // add select
    // stamp brush
    // animation
    // undo/redo [DONE]
    // colors [DONE]
    // draw line, Rec [DONE]
    // free draw [DONE]
    // Line and Rec flexible [DONE]
    // ignore list of points of rec and line [DONE]

    public partial class Form1 : Form
    {
        List<Shape> shapes;
        List<Shape> undo;

        List<PointF> points;
        Color color;
        ShapeStyle style;
        bool isDragging = false;
 
        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            undo = new List<Shape>();
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

        Random randomNum = new Random();

        private void draw(Graphics g, List<PointF> pts, ShapeStyle ss, Color cc)
        {
            Pen p = new Pen(cc);

            switch (ss)
            {
                case ShapeStyle.Line:
                    g.DrawLine(p, pts[0].X, pts[0].Y, pts[pts.Count - 1].X, pts[pts.Count - 1].Y);
                    break;
                case ShapeStyle.Rectangle:
                    float p1X = Math.Min(pts[0].X, pts[pts.Count - 1].X);
                    float p1Y = Math.Min(pts[0].Y, pts[pts.Count - 1].Y);

                    float width = Math.Abs(pts[0].X - pts[pts.Count - 1].X);
                    float height = Math.Abs(pts[0].Y - pts[pts.Count - 1].Y);

                    g.DrawRectangle(p, p1X, p1Y, width, height);
                    break;
                case ShapeStyle.FreeDraw:
                    g.DrawCurve(p, pts.ToArray());
                    break;
                case ShapeStyle.Stamp:
                    foreach (PointF pp in pts)
                    {
                        int r = randomNum.Next(5, 30);
                        g.DrawImage(Resources.star, pp.X, pp.Y, r, r);
                    }
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

            Shape p = new Shape(points, color, style);
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

        private void picker_button_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void undo_button_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                undo.Add(shapes[shapes.Count - 1]);
                shapes.RemoveAt(shapes.Count - 1);
                Invalidate();
            }
        }

        private void redo_button_Click(object sender, EventArgs e)
        {
            if (undo.Count > 0)
            {
                shapes.Add(undo[undo.Count - 1]);
                undo.RemoveAt(undo.Count - 1);
                Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Control)
            {
                undo_button.PerformClick();
            }
            if (e.KeyCode == Keys.Y && e.Control)
            {
                redo_button.PerformClick();
            }
        }

        private void stamp_brush_Click(object sender, EventArgs e)
        {
            style = ShapeStyle.Stamp;
        }
    }
}
