﻿using X_ray_Images.Classes;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace X_ray_Images
{
    enum PhotosMode
    {
        None = 0,
        Select = 1,
    };
    public partial class Photos : Form
    {
        PhotosMode mode = PhotosMode.None;
        private Point startPoint = new Point(-1, -1);
        private Rectangle selectionRect = new Rectangle(0, 0, 0, 0);
        static public List<Image> images = [];
        static public List<GalleryItem> galleryItems = [];
        int active = 0;
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
            if (mode == PhotosMode.None)
            {
                MainImage.MouseDown += MainImage_MouseDown;
                MainImage.MouseMove += MainImage_MouseMove;
                MainImage.Paint += MainImage_Paint;
                mode = PhotosMode.Select;
            }
            else if (mode == PhotosMode.Select)
            {
                RemoveSelection();
            }
        }
        private void CropImage_Click(object sender, EventArgs e)
        {
            if (mode == PhotosMode.Select)
            {
                Bitmap image = ImageProcessor.Crop(MainImage.Image, selectionRect);
                SetImage(image);

                RemoveSelection();
            }
        }
        private void New_Click(object sender, EventArgs e)
        {
            RemoveSelection();

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
        private void Red2BlueImage_Click(object sender, EventArgs e)
        {
            int startX = selectionRect.X;
            int startY = selectionRect.Y;
            int endX = selectionRect.X + selectionRect.Width;
            int endY = selectionRect.Y + selectionRect.Height;
            Bitmap newImage = Colorer.ProcessImage(MainImage.Image, startX, startY, endX, endY, Color.Red, Color.Blue);
            SetImage(newImage);

            RemoveSelection();
        }
        private void Orange2PurpleImage_Click(object sender, EventArgs e)
        {
            int startX = selectionRect.X;
            int startY = selectionRect.Y;
            int endX = selectionRect.X + selectionRect.Width;
            int endY = selectionRect.Y + selectionRect.Height;
            Bitmap newImage = Colorer.ProcessImage(MainImage.Image, startX, startY, endX, endY, Color.Orange, Color.Purple);
            SetImage(newImage);

            RemoveSelection();
        }
        private void Compare_Click(object sender, EventArgs e)
        {
            RemoveSelection();

            new Compare().Show();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            RemoveSelection();

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
        private void Danger_Click(object sender, EventArgs e)
        {
            RemoveSelection();

            new Danger().Show();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            RemoveSelection();

            int goodDim = (int)Math.Max(Math.Ceiling(Math.Log2(MainImage.Image.Width)), Math.Ceiling(Math.Log2(MainImage.Image.Height)));
            goodDim = (int)Math.Pow(2, goodDim);

            Bitmap img = new Bitmap(MainImage.Image, new Size(goodDim, goodDim));

            Bitmap result = ImageEnhancer.ApplyHighPassFilter(img);

            Bitmap newImage = new Bitmap(result, new Size(MainImage.Image.Width, MainImage.Image.Height));

            SetImage(newImage);
        }
        private void SetImage(Image image)
        {
            MainImage.Image = image;
            MainImage.Size = new Size(image.Width, image.Height);

            images[active] = image;
            galleryItems[active].pictureBox.Image = image;
        }
        private void RemoveSelection()
        {
            if (mode == PhotosMode.Select)
            {
                MainImage.MouseDown -= MainImage_MouseDown;
                MainImage.MouseMove -= MainImage_MouseMove;
                MainImage.Paint -= MainImage_Paint;

                Reset();
                mode = PhotosMode.None;
            }
        }
    }
}