using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    internal class ImageEnhancer
    {
        public static Bitmap ApplyHighPassFilter(Bitmap img)
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = filter.Apply(img);
            ComplexImage complex = ComplexImage.FromBitmap(grayImage);
            complex.ForwardFourierTransform();

            Complex[,] fftResult = complex.Data;

            int width = fftResult.GetLength(1);
            int height = fftResult.GetLength(0);

            int centerX = width / 2;
            int centerY = height / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {

                    //calculate the distance
                    double frequencyX = (double)(x - centerX) / width;
                    double frequencyY = (double)(y - centerY) / height;
                    double distance = Math.Sqrt(frequencyX * frequencyX + frequencyY * frequencyY);

                    // Apply edge enhancing
                    if (distance > 0.01)
                    {
                        fftResult[y, x] *= 2.2;
                    }
                    // Apply high pass filter
                    else
                    {
                        //fftResult[y, x] = Complex.Zero;
                    }
                }
            }

            complex.BackwardFourierTransform();

            Bitmap result = complex.ToBitmap();
            return result;
        }
    }
}
