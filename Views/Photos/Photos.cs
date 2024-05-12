using X_ray_Images.Classes;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;

using System.Windows.Forms;
using System.Drawing;

namespace X_ray_Images
{
    enum Mode
    {
        None = 0,
        Select = 1,
    };
    public partial class Photos : Form
    {
        Mode mode = Mode.None;
        private Point startPoint = new Point(-1, -1);
        private Rectangle selectionRect = new Rectangle(0, 0, 0, 0);

        public Photos()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            startPoint = new Point(-1, -1);
            selectionRect = new Rectangle(0, 0, 0, 0);
            MainImage.Invalidate();
        }

        private void MainImageMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Reset();
                return;
            }
            startPoint = Selector.BeginSelect(MainImage, e.X, e.Y);
        }

        private void MainImageMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint.X != -1)
            {
                selectionRect = Selector.SelectMove(MainImage, startPoint, e.X, e.Y);
                MainImage.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Reset();
            }
        }

        private void MainImagePaint(object sender, PaintEventArgs e)
        {
            if (selectionRect.Width > 0 && selectionRect.Height > 0)
            {
                e.Graphics.DrawRectangle(Pens.Red, selectionRect);
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (mode == Mode.None)
            {
                MainImage.MouseDown += MainImageMouseDown;
                MainImage.MouseMove += MainImageMouseMove;
                MainImage.Paint += MainImagePaint;
                mode = Mode.Select;
            }
            else if (mode == Mode.Select)
            {
                MainImage.MouseDown -= MainImageMouseDown;
                MainImage.MouseMove -= MainImageMouseMove;
                MainImage.Paint -= MainImagePaint;
                Reset();
                mode = Mode.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = Loader.LoadImageWithResize(openFileDialog1.FileName);

                MainImage.Image = image;
                MainImage.Size = new Size(image.Width, image.Height);

                Reset();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int startX = selectionRect.X;
            int startY = selectionRect.Y;
            int endX = selectionRect.X + selectionRect.Width;
            int endY = selectionRect.Y + selectionRect.Height;
            Bitmap newImage = Colorer.ProcessImage(MainImage.Image, startX, startY, endX, endY, Color.Red, Color.Blue);
            MainImage.Image = newImage;
            Reset();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void MainImageClick(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
