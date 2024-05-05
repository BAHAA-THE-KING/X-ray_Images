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
        private Point startPoint = new(-1, -1);
        private Rectangle selectionRect = new(0, 0, 0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            startPoint = new(-1, -1);
            selectionRect = new(0, 0, 0, 0);
            pictureBox1.Invalidate();
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Reset();
                return;
            }
            int ImageWidth = pictureBox1.Image.Width;
            int ImageHeight = pictureBox1.Image.Height;

            int selectX = e.X;
            if (selectX < 0) selectX = 0;
            if (selectX > ImageWidth) selectX = ImageWidth;

            int selectY = e.Y;
            if (selectY < 0) selectY = 0;
            if (selectY > ImageHeight) selectY = ImageHeight;

            startPoint = new(selectX, selectY);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint.X != -1)
            {
                int ImageWidth = pictureBox1.Image.Width;
                int ImageHeight = pictureBox1.Image.Height;

                int selectX = e.X;
                if (selectX < 0) selectX = 0;
                if (selectX > ImageWidth) selectX = ImageWidth;

                int selectY = e.Y;
                if (selectY < 0) selectY = 0;
                if (selectY > ImageHeight) selectY = ImageHeight;

                int startX = startPoint.X;
                int startY = startPoint.Y;

                int x = Math.Min(startX, selectX);
                int y = Math.Min(startY, selectY);

                int width = Math.Abs(selectX - startX);
                int height = Math.Abs(selectY - startY);

                selectionRect = new(x, y, width, height);
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
            OpenFileDialog openFileDialog1 = new();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new(openFileDialog1.FileName);


                int boxWidth = 800;
                int boxHeight = 500;
                int imageWidth = image.Width;
                int imageHeight = image.Height;

                if (imageWidth > imageHeight)
                {
                    imageHeight = imageHeight * boxWidth / imageWidth;
                    imageWidth = boxWidth;
                }
                else
                {
                    imageWidth = imageWidth * boxHeight / imageHeight;
                    imageHeight = boxHeight;
                }

                Bitmap resizedImage = new(imageWidth, imageHeight);

                Graphics g = Graphics.FromImage(resizedImage);

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                g.DrawImage(image, 0, 0, imageWidth, imageHeight);

                pictureBox1.Image = resizedImage;
                pictureBox1.Size = new(imageWidth, imageHeight);

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

    }

}
