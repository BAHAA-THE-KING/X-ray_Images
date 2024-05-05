using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    }
}