using X_ray_Images.Classes;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;

using System.Windows.Forms;


namespace X_ray_Images
{
    enum Mode
    {
        None = 0,
        Select = 1,
    };
    public partial class Form1 : Form
    {
        Mode mode = Mode.None;
        private Point startPoint = new Point(-1, -1);
        private Rectangle selectionRect = new Rectangle(0, 0, 0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            startPoint = new Point(-1, -1);
            selectionRect = new Rectangle(0, 0, 0, 0);
            pictureBox1.Invalidate();
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Reset();
                return;
            }
            startPoint = Selector.BeginSelect(pictureBox1, e.X, e.Y);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint.X != -1)
            {
                selectionRect = Selector.SelectMove(pictureBox1, startPoint, e.X, e.Y);
                pictureBox1.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Reset();
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
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
                pictureBox1.MouseDown += PictureBox1_MouseDown;
                pictureBox1.MouseMove += PictureBox1_MouseMove;
                pictureBox1.Paint += PictureBox1_Paint;
                mode = Mode.Select;
            }
            else if (mode == Mode.Select)
            {
                pictureBox1.MouseDown -= PictureBox1_MouseDown;
                pictureBox1.MouseMove -= PictureBox1_MouseMove;
                pictureBox1.Paint -= PictureBox1_Paint;
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

                pictureBox1.Image = image;
                pictureBox1.Size = new Size(image.Width, image.Height);

                Reset();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int startX = selectionRect.X;
            int startY = selectionRect.Y;
            int endX = selectionRect.X + selectionRect.Width;
            int endY = selectionRect.Y + selectionRect.Height;
            Bitmap newImage = Colorer.ProcessImage(pictureBox1.Image, startX, startY, endX, endY, Color.Red, Color.Blue);
            pictureBox1.Image = newImage;
            Reset();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();


            form2.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
