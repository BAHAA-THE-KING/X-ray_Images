using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class GalleryItem
    {
        public PictureBox pictureBox;
        public GalleryItem(Image image, int id, System.EventHandler function)
        {
            this.pictureBox = new PictureBox();
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = image;
            this.pictureBox.Location = new System.Drawing.Point(1027 - 150 * id, 28);
            this.pictureBox.Name = "GalleryImage-" + id;
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += function;
        }
    }
}