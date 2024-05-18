using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class Line
    {
        public Point start;
        public Point end;
        public Line(float sx, float sy, float ex, float ey)
        {
            this.start = new Point((int)sx, (int)sy);
            this.end = new Point((int)ex, (int)ey);
        }
        public Line(Point start, Point end)
        {
            this.start = start;
            this.end = end;
        }
    }
}