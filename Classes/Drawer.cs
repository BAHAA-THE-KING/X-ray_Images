using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class Drawer
    {
        public static Bitmap DrawCircle(Image image, Circle circle)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            graphics.DrawEllipse(Pens.Red, circle.cx - circle.radius, circle.cy - circle.radius, circle.radius * 2, circle.radius * 2);
            return result;
        }
        public static Bitmap DrawTriangle(Image image, Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            Point[] points = [firstPoint, secondPoint, thirdPoint];
            graphics.DrawPolygon(Pens.Red, points);
            return result;
        }
        public static Bitmap DrawRectangle(Image image, Rectangle rectangle)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            graphics.DrawRectangle(Pens.Red, rectangle);
            return result;
        }
        public static Bitmap DrawRuler(Image image, Line line)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            Pen arrowedPen = new Pen(Color.Red);
            arrowedPen.CustomStartCap = new AdjustableArrowCap(5, 5);
            arrowedPen.CustomEndCap = new AdjustableArrowCap(5, 5);
            Point firstPoint = line.start;
            Point secondPoint = line.end;
            graphics.DrawLine(arrowedPen, firstPoint, secondPoint);

            // Dashes
            Pen dashedPen = new Pen(Color.Red);
            dashedPen.DashStyle = DashStyle.Dash;

            Point startTemp = new Point();
            startTemp.X = (int)(firstPoint.X * 0.75 + secondPoint.X * 0.25);
            startTemp.Y = (int)(firstPoint.Y * 0.75 + secondPoint.Y * 0.25);

            Point start1 = Rotate(startTemp, 90, firstPoint);
            Point start2 = Rotate(startTemp, -90, firstPoint);
            graphics.DrawLine(dashedPen, start1, start2);

            Point endTemp = new Point();
            endTemp.X = (int)(firstPoint.X * 0.25 + secondPoint.X * 0.75);
            endTemp.Y = (int)(firstPoint.Y * 0.25 + secondPoint.Y * 0.75);

            Point end1 = Rotate(endTemp, 90, secondPoint);
            Point end2 = Rotate(endTemp, -90, secondPoint);
            graphics.DrawLine(dashedPen, end1, end2);

            return result;
        }
        public static Bitmap DrawFree(Image image, List<Point> points)
        {
            Bitmap result = new Bitmap(image);
            Graphics graphics = Graphics.FromImage(result);
            graphics.DrawLines(Pens.Red, points.ToArray());
            return result;
        }
        private static Point Rotate(Point from, float angle, Point around)
        {
            double radianAngle = Math.PI * angle / 180.0;

            double dx = from.X - around.X;
            double dy = from.Y - around.Y;

            double newX = around.X + (dx * Math.Cos(radianAngle)) - (dy * Math.Sin(radianAngle));
            double newY = around.Y + (dx * Math.Sin(radianAngle)) + (dy * Math.Cos(radianAngle));

            return new Point((int)newX, (int)newY);
        }

    }
}