namespace X_ray_Images
{
    public class Colorer
    {

        public static Bitmap ProcessImage(Image image, int startX, int startY, int endX, int endY, Color first, Color second)
        {
            Bitmap newImage = new Bitmap(image);

            //color range 
            Color firstColor = first;
            Color secondColor = second;
            Color sickEnd = Color.FromArgb(255, 255, 255);
            Color sickStart = Color.FromArgb(167, 167, 167);

            Color normalEnd = Color.FromArgb(50, 50, 50);
            Color normalStart = Color.FromArgb(0, 0, 0);

            for (int x = startX; x < endX; x++)
            {
                for (int y = startY; y < endY; y++)
                {
                    Color pixelColor = newImage.GetPixel(x, y);
                    // newImage.SetPixel(x, y, selectedColor);
                    if (pixelColor.R >= 150)
                    {
                        if (IsInRange(pixelColor.R, sickStart.R, sickEnd.R))
                        {
                            newImage.SetPixel(x, y, firstColor);
                        }
                        else
                        {
                            newImage.SetPixel(x, y, getRedShadeColor(pixelColor.R / 10, firstColor));
                        }
                    }
                    else
                    {
                        if (IsInRange(pixelColor.R, normalStart.R, normalEnd.R))
                        {
                            newImage.SetPixel(x, y, secondColor);
                        }
                        else
                        {
                            newImage.SetPixel(x, y, getBlueShadeColor(pixelColor.R / 10, secondColor));

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

        static Color getRedShadeColor(int selectedColor, Color color)
        {
            int shadeValue = (int)Math.Round((double)10 * selectedColor);
            return Color.FromArgb(255, color.R - shadeValue <= 0 ? 0 : color.R - shadeValue, color.G + shadeValue >= 255 ? 255 : color.G + shadeValue, color.B); //
        }

        static Color getBlueShadeColor(int selectedColor, Color color)
        {
            int shadeValue = (int)Math.Round((double)10 * selectedColor);
            return Color.FromArgb(255, color.R, color.G + shadeValue >= 255 ? 255 : color.G + shadeValue, color.B - shadeValue <= 0 ? 0 : color.B - shadeValue); //
        }

    }
}