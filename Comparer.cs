using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace X_ray_Images
{
    internal class Comparer
    {
        public static string compareTwoImages(Bitmap first, Bitmap second)
        {
            double firstPercentage = whitePercetageOf(first);
            double secondPercentage = whitePercetageOf(second);
            Console.WriteLine("first:" + firstPercentage + "\n second:" + secondPercentage);
            double developmentPerecentage = 10.0;
            if(Math.Abs(firstPercentage - secondPercentage) >= developmentPerecentage)
            {
                return firstPercentage>secondPercentage? "decrease in size noticed" : "Growth in size noticed";
            }
            return "similar";
        }

        private static double whitePercetageOf(Bitmap first) {
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

        private static bool IsWhite(Color color)
        {
            // Define a threshold for what constitutes white (adjust as needed)
            int threshold = 130; // Example threshold value (adjust as needed)

            return (color.R >= threshold && color.G >= threshold && color.B >= threshold);
        }
    }
}
