namespace X_ray_Images.Classes
{
    public class Loader
    {
        public static Bitmap LoadImageWithResize(string fileName)
        {
            Bitmap image = new(fileName);

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

            Bitmap resizedImage = new(imageWidth, imageHeight);

            Graphics g = Graphics.FromImage(resizedImage);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            g.DrawImage(image, 0, 0, imageWidth, imageHeight);

            return resizedImage;
        }
    }
}