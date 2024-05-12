using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class SeverityDetector
    {
        public static string detect(Bitmap image,int y1,int y2){
            int imageWidth = image.Width;
            int heartSpace = Math.Abs(y2-y1);
            double heartToThoracicRatio = heartSpace / (imageWidth+0.0);
            
            if (heartToThoracicRatio <= 0.5){
                if(heartToThoracicRatio <=0.3)
                return "Make sure that you are selecting the entire hear";
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
    }
}