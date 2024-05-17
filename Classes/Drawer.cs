using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class Drawer
    {
        static public Bitmap DrawCircle(Image image, Point firstPoint, Point secondPoint)
        {
            Point center = new Point();
            center.X = (firstPoint.X + secondPoint.X) / 2;
            center.Y = (firstPoint.Y + secondPoint.Y) / 2;
            double radius = Math.Sqrt(
                Math.Pow(firstPoint.X - secondPoint.X, 2) +
                Math.Pow(firstPoint.Y - secondPoint.Y, 2)
            );
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            Pen pen = new Pen(Color.Red, 5);
            graphics.DrawEllipse(pen, center.X, center.Y, (float)radius, (float)radius);
            return result;
        }
        static public Bitmap DrawTriangle(Image image, Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            Pen pen = new Pen(Color.Red, 5);
            graphics.DrawEllipse(pen, 100, 100, 200, 200);
            return result;
        }
        static public Bitmap DrawRectangle(Image image, Point firstPoint, Point secondPoint)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            Pen pen = new Pen(Color.Red, 5);
            graphics.DrawEllipse(pen, 100, 100, 200, 200);
            return result;
        }
    }
}