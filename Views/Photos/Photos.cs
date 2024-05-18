using X_ray_Images.Classes;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace X_ray_Images
{
    public enum PhotosMode
    {
        None = 0,
        Select = 1,
        Drawing = 2,
        Free = 3,
    };
    public enum Shape
    {
        None = 0,
        Circle = 1,
        Triangle = 2,
        Rectangle = 3,
        Horizontal = 4,
        Vertical = 5,
        Slope = 6,
    };
    public partial class Photos : Form
    {
        static public PhotosMode mode = PhotosMode.None;
        Shape shapeType = Shape.None;
        private Point firstPoint = new Point(-1, -1);
        private Point secondPoint = new Point(-1, -1);
        private Point thirdPoint = new Point(-1, -1);
        private Point startPoint = new Point(-1, -1);
        private Rectangle tempRect = new Rectangle(0, 0, 0, 0);
        private Circle tempCircle = new Circle(0, 0, 0);
        private Line tempLine = new Line(-1, -1, -1, -1);
        private List<Point> tempFree = [];
        static public List<Image> images = [];
        static public List<GalleryItem> galleryItems = [];
        int active = 0;

        // Coloring Icons
        static void ActiveImage(PictureBox pictureBox)
        {
            pictureBox.BackColor = SystemColors.ActiveCaption;
        }
        static void InactiveImage(PictureBox pictureBox)
        {
            pictureBox.BackColor = SystemColors.Control;
        }

        public Photos()
        {
            InitializeComponent();
            if (images.Count > 0)
            {
                GalleryPanel.Controls.Clear();
                galleryItems.Clear();

                for (int i = 0; i < images.Count; i++)
                {
                    int id = i;
                    GalleryItem galleryItem = new GalleryItem(
                        images[id],
                         id,
                          (object sender, EventArgs e) =>
                          {
                              active = id;
                              MainImage.Image = images[id];
                              MainImage.Size = new Size(images[id].Width, images[id].Height);
                          }
                                );

                    galleryItems.Add(galleryItem);
                    GalleryPanel.Controls.Add(galleryItem.pictureBox);
                }

                active = 0;
                SetImage(images[0]);
            }
        }

        // Management
        private void ResetState()
        {
            if (mode == PhotosMode.Select || mode == PhotosMode.Drawing || mode == PhotosMode.Free)
            {
                Reset();
                mode = PhotosMode.None;
                shapeType = Shape.None;
            }
        }
        private void Reset()
        {
            startPoint = new Point(-1, -1);
            firstPoint = new Point(-1, -1);
            secondPoint = new Point(-1, -1);
            thirdPoint = new Point(-1, -1);
            tempRect = new Rectangle(0, 0, 0, 0);
            tempCircle = new Circle(0, 0, 0);
            tempFree = [];
            MainImage.Invalidate();
        }
        private void SetImage(Image image)
        {
            MainImage.Image = image;
            if (image == null) return;
            MainImage.Size = new Size(image.Width, image.Height);

            images[active] = image;
            galleryItems[active].pictureBox.Image = image;
        }

        // File ToolStrip
        private void New_Click(object sender, EventArgs e)
        {
            ResetState();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = ImageProcessor.LoadImageWithResize(openFileDialog1.FileName);

                images.Add(MainImage.Image);
                int id = images.Count - 1;
                active = id;

                GalleryItem galleryItem = new GalleryItem(images[id], id, (object sender, EventArgs e) =>
            {
                active = id;
                MainImage.Image = images[id];
                MainImage.Size = new Size(images[id].Width, images[id].Height);
            });

                galleryItems.Add(galleryItem);
                GalleryPanel.Controls.Add(galleryItem.pictureBox);
                SetImage(image);

                Reset();
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            ResetState();

            string initialDirectory = Path.Combine(Application.StartupPath, "testImages");
            string initialFileName = "savedImage.png";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = initialDirectory;
                saveFileDialog.FileName = initialFileName;
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|All Files|*.*";
                saveFileDialog.Title = "Save Image As";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string newImagePath = saveFileDialog.FileName;

                    Image imageToSave = MainImage.Image;

                    if (imageToSave != null)
                    {
                        // Determine the image format based on the selected file extension
                        ImageFormat imageFormat = ImageFormat.Png; // Default to PNG
                        string extension = Path.GetExtension(newImagePath);
                        if (extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                            extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                        {
                            imageFormat = ImageFormat.Jpeg;
                        }

                        // Save the image to the specified file path with the determined format
                        try
                        {
                            imageToSave.Save(newImagePath, imageFormat);
                            MessageBox.Show("Image saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            ResetState();

            if (images.Count > 0)
            {
                images.RemoveAt(active);
                active = Math.Max(0, active - 1);
                GalleryPanel.Controls.Clear();
                galleryItems.Clear();

                if (images.Count > 0)
                    SetImage(images[active]);
                else
                    SetImage(null);

                for (int i = 0; i < images.Count; i++)
                {
                    int id = i;
                    GalleryItem galleryItem = new GalleryItem(
                        images[id],
                         id,
                          (object sender, EventArgs e) =>
                          {
                              active = id;
                              MainImage.Image = images[id];
                              MainImage.Size = new Size(images[id].Width, images[id].Height);
                          }
                                );

                    galleryItems.Add(galleryItem);
                    GalleryPanel.Controls.Add(galleryItem.pictureBox);
                }

            }
        }

        // Function ToolStrip
        private void Compare_Click(object sender, EventArgs e)
        {
            ResetState();

            new Compare().Show();
        }
        private void Danger_Click(object sender, EventArgs e)
        {
            ResetState();

            new Danger().Show();
        }

        // MainImage Control
        private void MainImage_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseArgs = (MouseEventArgs)e;

            if (mode == PhotosMode.Drawing)
            {
                if (shapeType == Shape.Triangle)
                {
                    if (firstPoint.X == -1)
                    {
                        firstPoint.X = mouseArgs.X;
                        firstPoint.Y = mouseArgs.Y;
                        MainImage.Invalidate();
                    }
                    else if (secondPoint.X == -1)
                    {
                        secondPoint.X = mouseArgs.X;
                        secondPoint.Y = mouseArgs.Y;
                        MainImage.Invalidate();
                    }
                    else if (thirdPoint.X == -1)
                    {
                        thirdPoint.X = mouseArgs.X;
                        thirdPoint.Y = mouseArgs.Y;

                        SetImage(Drawer.DrawTriangle(MainImage.Image, firstPoint, secondPoint, thirdPoint));
                        Reset();
                    }
                }
            }
        }
        private void MainImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode == PhotosMode.Select || mode == PhotosMode.Drawing || mode == PhotosMode.Free)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Reset();
                    return;
                }
                if (mode == PhotosMode.Free)
                    tempFree = Selector.SelectMoveFree(tempFree, e.X, e.Y);
                else
                    startPoint = Selector.BeginSelect(MainImage, e.X, e.Y);
            }
        }
        private void MainImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode == PhotosMode.Select || mode == PhotosMode.Drawing || mode == PhotosMode.Free)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (startPoint.X != -1)
                    {
                        if (mode == PhotosMode.Select || (mode == PhotosMode.Drawing && shapeType == Shape.Rectangle))
                            tempRect = Selector.SelectMove(MainImage, startPoint, e.X, e.Y);
                        else if (mode == PhotosMode.Drawing && shapeType == Shape.Circle)
                            tempCircle = Selector.SelectMoveCircle(MainImage, startPoint, e.X, e.Y);
                        else if (mode == PhotosMode.Drawing && shapeType == Shape.Horizontal)
                            tempLine = Selector.SelectMoveHorizontal(startPoint, e.X, e.Y);
                        else if (mode == PhotosMode.Drawing && shapeType == Shape.Vertical)
                            tempLine = Selector.SelectMoveVertical(startPoint, e.X, e.Y);
                        else if (mode == PhotosMode.Drawing && shapeType == Shape.Slope)
                            tempLine = Selector.SelectMoveSlope(startPoint, e.X, e.Y);
                    }
                    if (mode == PhotosMode.Free)
                        tempFree = Selector.SelectMoveFree(tempFree, e.X, e.Y);

                    MainImage.Invalidate();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    Reset();
                }
            }
        }
        private void MainImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (mode == PhotosMode.Drawing)
            {
                if (shapeType == Shape.Circle)
                {
                    SetImage(Drawer.DrawCircle(MainImage.Image, tempCircle));
                    Reset();
                }
                if (shapeType == Shape.Rectangle)
                {
                    SetImage(Drawer.DrawRectangle(MainImage.Image, tempRect));
                    Reset();
                }
                if (shapeType == Shape.Horizontal || shapeType == Shape.Vertical || shapeType == Shape.Slope)
                {
                    SetImage(Drawer.DrawRuler(MainImage.Image, tempLine));
                    Reset();
                }
            }
            else if (mode == PhotosMode.Free)
            {
                SetImage(Drawer.DrawFree(MainImage.Image, tempFree));
                Reset();
            }
        }
        private void MainImage_Paint(object sender, EventArgs e)
        {
            PaintEventArgs paintEvent = (PaintEventArgs)e;
            if (tempRect.Width > 0 && tempRect.Height > 0)
            {
                paintEvent.Graphics.DrawRectangle(Pens.Red, tempRect);
            }
            if (tempCircle.radius > 0)
            {
                paintEvent.Graphics.DrawEllipse(Pens.Red, tempCircle.cx - tempCircle.radius, tempCircle.cy - tempCircle.radius, tempCircle.radius * 2, tempCircle.radius * 2);
            }
            if (firstPoint.X != -1)
            {
                paintEvent.Graphics.DrawEllipse(Pens.Red, firstPoint.X - 10, firstPoint.Y - 10, 10 * 2, 10 * 2);
            }
            if (secondPoint.X != -1)
            {
                paintEvent.Graphics.DrawEllipse(Pens.Red, secondPoint.X - 10, secondPoint.Y - 10, 10 * 2, 10 * 2);
            }
            if (tempLine.start.X != -1)
            {
                paintEvent.Graphics.DrawLine(Pens.Red, tempLine.start, tempLine.end);
            }
            if (tempFree.Count > 1)
            {
                paintEvent.Graphics.DrawLines(Pens.Red, tempFree.ToArray());
            }
        }

        // States Controls
        private void SelectImage_Click(object sender, EventArgs e)
        {
            if (mode == PhotosMode.None)
            {
                ActiveImage(SelectImage);
                mode = PhotosMode.Select;
            }
            else if (mode == PhotosMode.Select)
            {
                InactiveImage(SelectImage);
                ResetState();
            }
        }
        private void Free_Click(object sender, EventArgs e)
        {
            if (mode == PhotosMode.None)
            {
                ActiveImage(CurveImage);
                mode = PhotosMode.Free;
            }
            else if (mode == PhotosMode.Free)
            {
                InactiveImage(CurveImage);
                ResetState();
            }
        }
        private void Shape_Click(object sender, EventArgs e)
        {
            if (mode == PhotosMode.None)
            {
                new Shapes(attachShapeDrawer).Show();
            }
            else if (mode == PhotosMode.Drawing)
            {
                InactiveImage(GeometryImage);
                ResetState();
            }
        }
        public void attachShapeDrawer(Shape shapeType)
        {
            ActiveImage(GeometryImage);
            this.shapeType = shapeType;
            mode = PhotosMode.Drawing;

        }

        // Functions
        private void CropImage_Click(object sender, EventArgs e)
        {
            if (mode == PhotosMode.Select && tempRect.Width > 0 && tempRect.Height > 0)
            {
                Bitmap image = ImageProcessor.Crop(MainImage.Image, tempRect);
                SetImage(image);

                Reset();
            }
        }
        private void Red2BlueImage_Click(object sender, EventArgs e)
        {
            if (mode == PhotosMode.Select && tempRect.Width > 0 && tempRect.Height > 0)
            {
                int startX = tempRect.X;
                int startY = tempRect.Y;
                int endX = tempRect.X + tempRect.Width;
                int endY = tempRect.Y + tempRect.Height;
                Bitmap newImage = Colorer.ProcessImage(MainImage.Image, startX, startY, endX, endY, Color.Red, Color.Blue);
                SetImage(newImage);

                Reset();
            }
        }
        private void Orange2PurpleImage_Click(object sender, EventArgs e)
        {
            if (mode == PhotosMode.Select && tempRect.Width > 0 && tempRect.Height > 0)
            {
                int startX = tempRect.X;
                int startY = tempRect.Y;
                int endX = tempRect.X + tempRect.Width;
                int endY = tempRect.Y + tempRect.Height;
                Bitmap newImage = Colorer.ProcessImage(MainImage.Image, startX, startY, endX, endY, Color.Orange, Color.Purple);
                SetImage(newImage);

                Reset();
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            ResetState();

            int goodDim = (int)Math.Max(Math.Ceiling(Math.Log2(MainImage.Image.Width)), Math.Ceiling(Math.Log2(MainImage.Image.Height)));
            goodDim = (int)Math.Pow(2, goodDim);

            Bitmap img = new Bitmap(MainImage.Image, new Size(goodDim, goodDim));

            Bitmap result = ImageEnhancer.ApplyHighPassFilter(img);

            Bitmap newImage = new Bitmap(result, new Size(MainImage.Image.Width, MainImage.Image.Height));

            SetImage(newImage);
        }

    }
}