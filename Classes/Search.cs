using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    internal class Search
    {
        public static FileInfo[] SearchImages(string folderPath, long minSize, long maxSize, DateTime minDate, DateTime maxDate)
        {
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("The specified folder does not exist.");
                return new FileInfo[0];
            }

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff" };

            var files = new DirectoryInfo(folderPath).GetFiles()
                .Where(file => allowedExtensions.Contains(file.Extension.ToLower()))
                .Where(file => file.Length >= minSize && file.Length <= maxSize)
                .Where(file => file.LastWriteTime >= minDate && file.LastWriteTime <= maxDate)
                .ToArray();

            return files;
        }
    }
}
