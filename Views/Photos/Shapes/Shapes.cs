using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace X_ray_Images
{
    public partial class Shapes : Form
    {
        Action<Shape> attachShapeDrawer;
        public Shapes(Action<Shape> attachShapeDrawer)
        {
            InitializeComponent();
            this.attachShapeDrawer = attachShapeDrawer;
        }
        private void Circle_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(Shape.Circle);
            Close();
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(Shape.Triangle);
            Close();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(Shape.Rectangle);
            Close();
        }
        private void Vertical_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(Shape.Vertical);
            Close();
        }
        private void Horizontal_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(Shape.Horizontal);
            Close();
        }
        private void Slope_Click(object sender, EventArgs e)
        {
            attachShapeDrawer(Shape.Slope);
            Close();
        }
    }
}