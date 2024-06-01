
namespace X_ray_Images
{
    internal class Comparer
    {
        public static string compareTwoImages(Bitmap first, Bitmap second)
        {
            double firstPercentage = whitePercetageOf(first);
            double secondPercentage = whitePercetageOf(second);
            double developmentPerecentage = 10.0;
            if (Math.Abs(firstPercentage - secondPercentage) >= developmentPerecentage)
            {
                return firstPercentage > secondPercentage ?
                "تم ملاحظة نقصان في الحجم" :
                "تم ملاحظة زيادة في الحجم";
            }
            return "حالة مماثلة , او تغير طفيف جداً";
        }

        private static double whitePercetageOf(Bitmap first)
        {
            int totalPixels = first.Width * first.Height;
            // Count white pixels
            int whitePixelCount = 0;

            for (int y = 0; y < first.Height; y++)
            {
                for (int x = 0; x < first.Width; x++)
                {
                    Color pixelColor = first.GetPixel(x, y);
                    // Check if the pixel color is white or very close to white
                    if (IsWhite(pixelColor))
                    {
                        whitePixelCount++;
                    }
                }
            }
            // Calculate percentage of white pixels
            double whitePercentage = (double)whitePixelCount / totalPixels * 100;
            return whitePercentage;
        }

        public static bool IsWhite(Color color)
        {
            double brightnessThreshold = 0.5;
            double brightness = color.GetBrightness();
            return brightness >= brightnessThreshold;
        }
    }
}
