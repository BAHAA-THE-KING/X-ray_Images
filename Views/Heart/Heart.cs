using System;
using System.Drawing;
using System.Windows.Forms;
using X_ray_Images.Classes;

namespace X_ray_Images
{
	enum HeartMode
	{
		None = 0,
		Select = 1,
	};
	public partial class Heart : Form
	{
		HeartMode mode = HeartMode.None;
		Point startPoint = new Point(-1, -1);
		Rectangle tempRect = new Rectangle(0, 0, 0, 0);
		// Coloring Icons
		void ActiveImage(PictureBox pictureBox)
		{
			pictureBox.BackColor = SystemColors.ActiveCaption;
		}
		void InactiveImage(PictureBox pictureBox)
		{
			pictureBox.BackColor = SystemColors.Control;
		}

		public Heart()
		{
			InitializeComponent();
		}

		// Management
		private void ResetState()
		{
			if (mode == HeartMode.Select)
			{
				Reset();
				mode = HeartMode.None;
				InactiveImage(SelectImage);
			}
		}
		private void Reset()
		{
			startPoint = new Point(-1, -1);
			tempRect = new Rectangle(0, 0, 0, 0);
			MainImage.Invalidate();
		}
		private void SetImage(Image image)
		{
			if (image == null) return;
			MainImage.Image = image;
			MainImage.Size = new Size(image.Width, image.Height);
		}

		// MainImage Control
		private void MainImage_MouseDown(object sender, MouseEventArgs e)
		{
			if (MainImage.Image != null)
			{
				if (mode == HeartMode.Select)
				{
					if (e.Button == MouseButtons.Right)
					{
						Reset();
						return;
					}
					startPoint = Selector.BeginSelect(MainImage, e.X, e.Y);
					tempRect = new Rectangle(startPoint.X, startPoint.Y, 0, 0);
				}
			}
		}
		private void MainImage_MouseMove(object sender, MouseEventArgs e)
		{
			if (MainImage.Image != null)
			{
				if (mode == HeartMode.Select)
				{
					if (e.Button == MouseButtons.Left)
					{
						if (startPoint.X != -1)
						{
							tempRect = Selector.SelectMove(MainImage, startPoint, e.X, e.Y);
						}

						MainImage.Invalidate();
					}
					else if (e.Button == MouseButtons.Right)
					{
						Reset();
					}
				}
			}
		}
		private void MainImage_Paint(object sender, EventArgs e)
		{
			if (MainImage.Image != null)
			{
				PaintEventArgs paintEvent = (PaintEventArgs)e;
				if (tempRect.Width > 0 && tempRect.Height > 0)
				{
					paintEvent.Graphics.DrawRectangle(Pens.Red, tempRect);
				}
			}
		}

		// States Controls
		private void SelectImage_Click(object sender, EventArgs e)
		{
			if (MainImage.Image != null)
			{
				if (mode == HeartMode.None)
				{
					ActiveImage(SelectImage);
					mode = HeartMode.Select;
				}
				else if (mode == HeartMode.Select)
				{
					InactiveImage(SelectImage);
					ResetState();
				}
			}
		}

		// Functions
		private void Scan_Click(object sender, EventArgs e)
		{
			if (MainImage.Image != null)
			{
				if (mode == HeartMode.Select && tempRect.Width > 0 && tempRect.Height > 0)
				{
					int startX = tempRect.X;
					int startY = tempRect.Y;
					int endX = tempRect.X + tempRect.Width;
					int endY = tempRect.Y + tempRect.Height;
					string result = SeverityDetector.detectHeartProblem(new Bitmap(MainImage.Image), startX, startY, endX, endY);
					ResultLabel.Text = result;

					ResetState();
				}
			}
		}

		private void PickerButton_Click(object sender, EventArgs e)
		{
			ResetState();

			string initialDirectory = Paths.CreatePath("testImages");

			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.InitialDirectory = initialDirectory;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Bitmap image = ImageProcessor.LoadImageWithResize(openFileDialog1.FileName);

				SetImage(image);

				Reset();
			}
		}
	}
}
