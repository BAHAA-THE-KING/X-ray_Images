using System;
using System.Drawing;
using System.Windows.Forms;
using X_ray_Images.Classes;

namespace X_ray_Images
{
	enum DangerMode
	{
		None = 0,
		Select = 1,
	};
	public partial class Danger : Form
	{
		DangerMode mode = DangerMode.None;
		private Point startPoint = new Point(-1, -1);
		private Rectangle selectionRect = new Rectangle(0, 0, 0, 0);

		public Danger()
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
			if (mode == DangerMode.None)
			{
				MainImage.MouseDown += MainImage_MouseDown;
				MainImage.MouseMove += MainImage_MouseMove;
				MainImage.Paint += MainImage_Paint;
				mode = DangerMode.Select;
			}
			else if (mode == DangerMode.Select)
			{
				MainImage.MouseDown -= MainImage_MouseDown;
				MainImage.MouseMove -= MainImage_MouseMove;
				MainImage.Paint -= MainImage_Paint;
				Reset();
				mode = DangerMode.None;
			}
		}

		private void Scan_Click(object sender, EventArgs e)
		{
			int startX = selectionRect.X;
			int startY = selectionRect.Y;
			int endX = selectionRect.X + selectionRect.Width;
			int endY = selectionRect.Y + selectionRect.Height;
			string result = SeverityDetector.detect(MainImage.Image, startY, endY);
			ResultLabel.Text = result;
		}

		private void PickerButton_Click(object sender, EventArgs e)
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

	}
}
