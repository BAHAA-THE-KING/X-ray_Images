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
        public static Bitmap EnhanceWithFourier(Bitmap img)
        {
            //converting image to grayScale
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = filter.Apply(img);

            //creating the Complex Image and applying FFT
            ComplexImage complex = ComplexImage.FromBitmap(grayImage);
            complex.ForwardFourierTransform();

            //getting the fourier result in an array to manipulate it
            Complex[,] fftResult = complex.Data;

            //manipulating the fft array by increasing the high frequencies value
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
