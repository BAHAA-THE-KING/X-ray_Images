using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class Circle
    {
        public float cx;
        public float cy;
        public float radius;
        public Circle(float cx, float cy, float radius)
        {
            this.cx = cx;
            this.cy = cy;
            this.radius = radius;
        }
    }
}