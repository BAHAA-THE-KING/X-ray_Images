using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using X_ray_Images.Classes;

namespace X_ray_Images
{
    public class Selector
    {
        public static Point BeginSelect(PictureBox pictureBox1, int X, int Y)
        {
            int ImageWidth = pictureBox1.Image.Width;
            int ImageHeight = pictureBox1.Image.Height;

            int selectX = X;
            if (selectX < 0) selectX = 0;
            if (selectX > ImageWidth) selectX = ImageWidth;

            int selectY = Y;
            if (selectY < 0) selectY = 0;
            if (selectY > ImageHeight) selectY = ImageHeight;

            return new Point(selectX, selectY);
        }

        public static Rectangle SelectMove(PictureBox pictureBox1, Point startPoint, int X, int Y)
        {
            int ImageWidth = pictureBox1.Image.Width;
            int ImageHeight = pictureBox1.Image.Height;

            int selectX = X;
            if (selectX < 0) selectX = 0;
            if (selectX > ImageWidth) selectX = ImageWidth;

            int selectY = Y;
            if (selectY < 0) selectY = 0;
            if (selectY > ImageHeight) selectY = ImageHeight;

            int startX = startPoint.X;
            int startY = startPoint.Y;

            int x = Math.Min(startX, selectX);
            int y = Math.Min(startY, selectY);

            int width = Math.Abs(selectX - startX);
            int height = Math.Abs(selectY - startY);

            return new Rectangle(x, y, width, height);
        }

        public static Circle SelectMoveCircle(PictureBox pictureBox1, Point startPoint, int X, int Y)
        {
            int ImageWidth = pictureBox1.Image.Width;
            int ImageHeight = pictureBox1.Image.Height;

            int selectX = X;
            if (selectX < 0) selectX = 0;
            if (selectX > ImageWidth) selectX = ImageWidth;

            int selectY = Y;
            if (selectY < 0) selectY = 0;
            if (selectY > ImageHeight) selectY = ImageHeight;

            int startX = startPoint.X;
            int startY = startPoint.Y;

            float x = (startX + selectX) / 2f;
            float y = (startY + selectY) / 2f;

            double r = Math.Sqrt(
                Math.Pow(startX - selectX, 2) +
                Math.Pow(startY - selectY, 2)
            );
            float rr = (float)r / 2f;

            return new Circle(x, y, rr);
        }

        public static Line SelectMoveHorizontal(Point startPoint, int X, int Y)
        {
            return new Line(startPoint.X, startPoint.Y, X, startPoint.Y);
        }

        public static Line SelectMoveVertical(Point startPoint, int X, int Y)
        {
            return new Line(startPoint.X, startPoint.Y, startPoint.X, Y);
        }

        public static Line SelectMoveSlope(Point startPoint, int X, int Y)
        {
            return new Line(startPoint.X, startPoint.Y, X, Y);
        }

        public static List<Point> SelectMoveFree(List<Point> points, int X, int Y)
        {
            points.Add(new Point(X, Y));
            return points;
        }
    }
}