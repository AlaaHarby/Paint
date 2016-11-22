using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribble
{
    enum ShapeStyle
    {
        Line,
        Rectangle,
        FreeDraw,
        Stamp
    }

    class Shape
    {
        public List<PointF> points { get; set; }
        public Color color { get; set; }
        public ShapeStyle shape { get; set; }
        public List<int> sizes { get; set; }

        public Shape(List<PointF> pts, Color color, ShapeStyle shape)
        {
            this.color = color;
            this.shape = shape;
            normalize(pts);
        }

        void normalize(List<PointF> pts)
        {
            switch (shape)
            {
                case (ShapeStyle.FreeDraw):
                case (ShapeStyle.Stamp):
                    points = pts;
                    break;
                case (ShapeStyle.Line):
                case (ShapeStyle.Rectangle):
                    points = new List<PointF>();
                    points.Add(pts[0]);
                    points.Add(pts[pts.Count - 1]);
                    break;
            }
        }
    }
}
