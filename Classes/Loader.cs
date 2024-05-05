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
            Mat image = new Mat(fileName);

            int boxWidth = 800;
            int boxHeight = 500;
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            if (imageWidth > imageHeight)
            {
                imageHeight = imageHeight * boxWidth / imageWidth;
                imageWidth = boxWidth;
            }
            else
            {
                imageWidth = imageWidth * boxHeight / imageHeight;
                imageHeight = boxHeight;
            }

            Mat resizedImage = new Mat();

            CvInvoke.Resize(image, resizedImage, new Size(imageWidth, imageHeight));

            CvInvoke.CvtColor(resizedImage, resizedImage, ColorConversion.Bgr2Gray);

            return ConvertMatToBitmap(resizedImage);
        }

        static Bitmap ConvertMatToBitmap(Mat matImage)
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

    }
}