using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace X_ray_Images
{
    public partial class Shapes : Form
    {
        Action<int> attachShapeDrawer;
        public Shapes(Action<int> attachShapeDrawer)
        {
            InitializeComponent();
            this.attachShapeDrawer = attachShapeDrawer;
        }
        private void Circle_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(1);
            Close();
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(2);
            Close();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(3);
            Close();
        }
    }
}