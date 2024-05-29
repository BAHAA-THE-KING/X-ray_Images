

using Emgu.CV;
using QuestPDF.Fluent;

namespace X_ray_Images.Classes
{
    public class SeverityDetector
    {
        public static string detectHeartProblem(Bitmap image, int h1, int h2, int t1, int t2)
        {
            int thoracicSpace = Math.Abs(t2 - t1); ;
            int heartSpace = Math.Abs(h2 - h1);
            double heartToThoracicRatio = heartSpace / (thoracicSpace + 0.0);

            if (heartToThoracicRatio <= 0.5)
            {
                if (heartToThoracicRatio <= 0.3)
                    return "Make sure that you are selecting the entire heart.";
                else
                    return "Normal";
            }
            else if (heartToThoracicRatio <= 0.55)
                return "Mild Enlargement";
            else if (heartToThoracicRatio <= 0.60)
                return "Moderate Enlargement";
            else
                return "Severe Enlargement";
        }

        public static string detect(Bitmap image, int x1, int y1, int x2, int y2)
        {
            int startX = Math.Min(x1, x2);
            int endX = Math.Max(x1, x2);
            int startY = Math.Min(y1, y2);
            int endY = Math.Max(y1, y2);
            int width = endX - startX + 1;
            int height = endY - startY + 1;
            int totalPixels = width * height;
            // Count white pixels
            int whitePixelCount = 0;
            for (int y = startY; y <= endY; y++)
            {
                for (int x = startX; x <= endX; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    // Check if the pixel brightness is above the threshold
                    if (Comparer.IsWhite(pixelColor))
                    {
                        whitePixelCount++;
                    }
                }
            }

            // Calculate percentage of white pixels
            double whitePercentage = (double)whitePixelCount / totalPixels * 100;
            // MessageBox.Show("white percentage: "+whitePercentage);
            double low = 20, midLow = 40, mid = 60, midHigh = 80;
            if (whitePercentage < low)
                return "low illness";
            else if (whitePercentage < midLow)
                return "mid-low illness";
            else if (whitePercentage < mid)
                return "mid illness";
            else if (whitePercentage < midHigh)
                return "mid-heigh illness";
            else return "high illness";
        }
    }
}