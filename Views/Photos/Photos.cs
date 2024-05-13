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

        private void MainImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Reset();
                return;
            }
            startPoint = Selector.BeginSelect(MainImage, e.X, e.Y);
        }

        private void MainImage_MouseMove(object sender, MouseEventArgs e)
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

        private void MainImage_Paint(object sender, PaintEventArgs e)
        {
            if (selectionRect.Width > 0 && selectionRect.Height > 0)
            {
                e.Graphics.DrawRectangle(Pens.Red, selectionRect);
            }
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            if (mode == Mode.None)
            {
                MainImage.MouseDown += MainImage_MouseDown;
                MainImage.MouseMove += MainImage_MouseMove;
                MainImage.Paint += MainImage_Paint;
                mode = Mode.Select;
            }
            else if (mode == Mode.Select)
            {
                MainImage.MouseDown -= MainImage_MouseDown;
                MainImage.MouseMove -= MainImage_MouseMove;
                MainImage.Paint -= MainImage_Paint;
                Reset();
                mode = Mode.None;
            }
        }

        //TODO: Need To Fix.
        private void New_Click(object sender, EventArgs e)
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

        private void Red2BlueImage_Click(object sender, EventArgs e)
        {
            int startX = selectionRect.X;
            int startY = selectionRect.Y;
            int endX = selectionRect.X + selectionRect.Width;
            int endY = selectionRect.Y + selectionRect.Height;
            Bitmap newImage = Colorer.ProcessImage(MainImage.Image, startX, startY, endX, endY, Color.Red, Color.Blue);
            MainImage.Image = newImage;
            Reset();
        }

        private void Orange2PurpleImage_Click(object sender, EventArgs e)
        {
            int startX = selectionRect.X;
            int startY = selectionRect.Y;
            int endX = selectionRect.X + selectionRect.Width;
            int endY = selectionRect.Y + selectionRect.Height;
            Bitmap newImage = Colorer.ProcessImage(MainImage.Image, startX, startY, endX, endY, Color.Orange, Color.Purple);
            MainImage.Image = newImage;
            Reset();
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            new Compare().Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string newImagePath = "../../../testImages/savedImage.png";

            Image image = MainImage.Image;

            if (image != null)
            {
                image.Save(newImagePath);
                MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Danger_Click(object sender, EventArgs e)
        {
            new Danger().Show();
        }
    }
}