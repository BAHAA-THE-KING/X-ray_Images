using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using AForge.Imaging.Filters;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace X_ray_Images.Classes
{
    public class Loader
    {
        public static Bitmap LoadImageWithResize(string fileName)
        {
            Bitmap newImage = new Bitmap(fileName);

            //int boxWidth = 800;
            //int boxHeight = 400;
            //int imageWidth = image.Width;
            //int imageHeight = image.Height;


            //double ratioX = (double)boxWidth / imageWidth;
            //double ratioY = (double)boxHeight / imageHeight;
            //double ratio = Math.Min(ratioX, ratioY);

            //int newWidth = (int)(imageWidth * ratio);
            //int newHeight = (int)(imageHeight * ratio);

            //Bitmap newImage = new Bitmap(newWidth, newHeight);

            Graphics graphics = Graphics.FromImage(newImage);
            //graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return ConvertToGrayscale(newImage);
        }

        public static Bitmap ConvertMatToBitmap(Mat matImage)
        {
            // Convert Mat to byte array
            byte[] data = new byte[matImage.Width * matImage.Height];
            Marshal.Copy(matImage.DataPointer, data, 0, data.Length);

            // Create Bitmap
            Bitmap bitmap = new Bitmap(matImage.Width, matImage.Height, PixelFormat.Format8bppIndexed);
            ColorPalette palette = bitmap.Palette;
            for (int i = 0; i < 256; i++)
            {
                palette.Entries[i] = Color.FromArgb(i, i, i);
            }
            bitmap.Palette = palette;
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, matImage.Width, matImage.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);
            Marshal.Copy(data, 0, bitmapData.Scan0, data.Length);
            bitmap.UnlockBits(bitmapData);

            return bitmap;
        }

        public static Bitmap ConvertToGrayscale(Bitmap original)
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = filter.Apply(original);

            return grayImage;
        }

    }
}