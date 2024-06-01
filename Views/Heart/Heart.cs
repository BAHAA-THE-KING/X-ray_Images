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
		Point startPoint1 = new Point(-1, -1);
		Point startPoint2 = new Point(-1, -1);
		Rectangle tempRect1 = new Rectangle(0, 0, 0, 0);
		Rectangle tempRect2 = new Rectangle(0, 0, 0, 0);
		bool firstFinished = false;
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
			startPoint1 = new Point(-1, -1);
			startPoint2 = new Point(-1, -1);
			tempRect1 = new Rectangle(0, 0, 0, 0);
			tempRect2 = new Rectangle(0, 0, 0, 0);
			firstFinished = false;
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
					if (firstFinished)
					{
						startPoint2 = Selector.BeginSelect(MainImage, e.X, e.Y);
						tempRect2 = new Rectangle(startPoint1.X, startPoint1.Y, 0, 0);
					}
					else
					{
						startPoint1 = Selector.BeginSelect(MainImage, e.X, e.Y);
						tempRect1 = new Rectangle(startPoint2.X, startPoint2.Y, 0, 0);
					}
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
						if (firstFinished)
						{
							if (startPoint2.X != -1)
							{
								tempRect2 = Selector.SelectMove(MainImage, startPoint2, e.X, e.Y);
							}
						}
						else
						{
							if (startPoint1.X != -1)
							{
								tempRect1 = Selector.SelectMove(MainImage, startPoint1, e.X, e.Y);
							}
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
		private void MainImage_MouseUp(object sender, MouseEventArgs e)
		{
			if (MainImage.Image != null)
			{
				if (mode == HeartMode.Select)
				{
					if (e.Button == MouseButtons.Left)
					{
						if (!firstFinished)
						{
							firstFinished = true;
						}
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
				if (tempRect1.Width > 0 && tempRect1.Height > 0)
				{
					paintEvent.Graphics.DrawRectangle(Pens.Red, tempRect1);
				}
				if (tempRect2.Width > 0 && tempRect2.Height > 0)
				{
					paintEvent.Graphics.DrawRectangle(Pens.Blue, tempRect2);
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
				if (mode == HeartMode.Select && tempRect1.Width > 0 && tempRect1.Height > 0 && tempRect2.Width > 0 && tempRect2.Height > 0)
				{
					int startY1 = tempRect1.Y;
					int endY1 = tempRect1.Y + tempRect1.Height;
					int startY2 = tempRect2.Y;
					int endY2 = tempRect2.Y + tempRect2.Height;
					string result = SeverityDetector.detectHeartProblem(new Bitmap(MainImage.Image), startY1, endY1, startY2, endY2);
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
