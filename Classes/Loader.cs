using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.CvEnum;

namespace X_ray_Images.Classes
{
    public class Loader
    {
        public static Bitmap LoadImageWithResize(string fileName)
        {
            Bitmap image = new Bitmap(fileName);

            int boxWidth = 800;
            int boxHeight = 400;
            int imageWidth = image.Width;
            int imageHeight = image.Height;


            double ratioX = (double)boxWidth / imageWidth;
            double ratioY = (double)boxHeight / imageHeight;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(imageWidth * ratio);
            int newHeight = (int)(imageHeight * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);

            Graphics graphics = Graphics.FromImage(newImage);
            graphics.DrawImage(image, 0, 0, newWidth, newHeight);

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
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixelColor = original.GetPixel(x, y);
                    int grayscaleValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    original.SetPixel(x, y, Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue));
                }
            }

            return original;
        }

    }
}