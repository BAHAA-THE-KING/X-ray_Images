

using Emgu.CV;

namespace X_ray_Images.Classes
{
    public class SeverityDetector
    {
        public static string detectHeartProblem(Bitmap image, int y1, int y2)
        {

            int imageWidth = image.Width;
            int heartSpace = Math.Abs(y2 - y1);
            double heartToThoracicRatio = heartSpace / (imageWidth + 0.0);

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
    
        public static string detect(Bitmap image,int x1, int y1, int x2, int y2){
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

                double low=20,midLow=40,mid=60,midHigh=80;
                if(whitePercentage<low)
                return "low density";
                else if(whitePercentage<midLow)
                return "mid-low density";
                else if(whitePercentage<mid)
                return "mid density";
                else if(whitePercentage<midHigh)
                return "mid-heigh density";
                else return "high density";
        }
    }
}