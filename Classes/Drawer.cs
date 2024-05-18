using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class Drawer
    {
        static public Bitmap DrawCircle(Image image, Circle circle)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            graphics.DrawEllipse(Pens.Red, circle.cx - circle.radius, circle.cy - circle.radius, circle.radius * 2, circle.radius * 2);
            return result;
        }
        static public Bitmap DrawTriangle(Image image, Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            Point[] points = [firstPoint, secondPoint, thirdPoint, firstPoint];
            graphics.DrawLines(Pens.Red, points);
            return result;
        }
        static public Bitmap DrawRectangle(Image image, Rectangle rectangle)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            graphics.DrawRectangle(Pens.Red, rectangle);
            return result;
        }
    }
}