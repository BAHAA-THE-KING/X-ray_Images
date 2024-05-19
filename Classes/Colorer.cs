using System;
using System.Drawing;

namespace X_ray_Images
{
    public class Colorer
    {

        public static Bitmap ProcessImage(Image image, int startX, int startY,
            int endX, int endY, Color firstColor, Color secondColor)
        {
            Bitmap newImage = new Bitmap(image);
            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    Color pixelColor = newImage.GetPixel(x, y);

                    //If Pixel color is closer to white
                    if (pixelColor.R >= 150)
                    {
                        //Strong color
                        if (IsInRange(pixelColor.R, 180, 255))
                        {
                            newImage.SetPixel(x, y, firstColor);
                        }
                        //Shading color
                        else
                        {
                            newImage.SetPixel(x, y, getFirstColorShade(pixelColor.R / 10, firstColor));
                        }
                    }
                    //Else if Pixel color is closer to black
                    else
                    {
                        //Strong color
                        if (IsInRange(pixelColor.R, 0, 50))
                        {
                            newImage.SetPixel(x, y, secondColor);
                        }
                        //Shading color
                        else
                        {
                            newImage.SetPixel(x, y, getSecondColorShade(pixelColor.R / 10, secondColor));

                        }
                    }
                }
            }
            return newImage;
        }

        static bool IsInRange(int color, int start, int end)
        {
            return color >= start && color <= end;
        }

        static Color getFirstColorShade(int selectedColor, Color color)
        {
            int shadeValue = (int)Math.Round((double)10 * selectedColor);
            return Color.FromArgb(255, color.R - shadeValue <= 0 ? 0 : color.R - shadeValue, color.G + shadeValue >= 255 ? 255 : color.G + shadeValue, color.B);
        }

        static Color getSecondColorShade(int selectedColor, Color color)
        {
            int shadeValue = (int)Math.Round((double)10 * selectedColor);
            return Color.FromArgb(255, color.R, color.G + shadeValue >= 255 ? 255 : color.G + shadeValue, color.B - shadeValue <= 0 ? 0 : color.B - shadeValue);
        }

    }
}