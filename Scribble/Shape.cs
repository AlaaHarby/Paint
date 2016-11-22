using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribble
{
    enum ShapeStyle {
        Line,
        Rectangle,
        FreeDraw
    }

    class Shape
    {
        public List<PointF> points { get; set; }
        public Color color { get; set; }
        public ShapeStyle shape { get; set; }
    }
}
