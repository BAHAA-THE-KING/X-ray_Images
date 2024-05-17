using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace X_ray_Images
{
    public partial class Shapes : Form
    {
        static public int shape = 0;
        public Shapes()
        {
            InitializeComponent();
        }
        private void Circle_Click(object sender, EventArgs e)
        {
            shape = 1;
            Photos.mode = PhotosMode.Drawing;
            Close();
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            shape = 2;
            Photos.mode = PhotosMode.Drawing;
            Close();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            shape = 3;
            Photos.mode = PhotosMode.Drawing;
            Close();
        }
    }
}