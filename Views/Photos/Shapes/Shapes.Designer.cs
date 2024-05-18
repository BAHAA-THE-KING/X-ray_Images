using System.Drawing;
using System.Windows.Forms;
namespace X_ray_Images
{
	partial class Shapes
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox CircleImage;
		private System.Windows.Forms.PictureBox TriangleImage;
		private System.Windows.Forms.PictureBox RectangleImage;
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shapes));
			this.CircleImage = new System.Windows.Forms.PictureBox();
			this.TriangleImage = new System.Windows.Forms.PictureBox();
			this.RectangleImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.CircleImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TriangleImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RectangleImage)).BeginInit();
			this.SuspendLayout();
			// 
			// CircleImage
			// 
			this.CircleImage.Image = ((System.Drawing.Image)(resources.GetObject("CircleImage.Image")));
			this.CircleImage.Cursor = Cursors.Hand;
			this.CircleImage.Location = new System.Drawing.Point(12, 12);
			this.CircleImage.Name = "CircleImage";
			this.CircleImage.Size = new System.Drawing.Size(129, 129);
			this.CircleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CircleImage.TabIndex = 0;
			this.CircleImage.TabStop = false;
			this.CircleImage.Click += new System.EventHandler(this.Circle_Click);
			// 
			// TriangleImage
			// 
			this.TriangleImage.Image = ((System.Drawing.Image)(resources.GetObject("TriangleImage.Image")));
			this.TriangleImage.Cursor = Cursors.Hand;
			this.TriangleImage.Location = new System.Drawing.Point(187, 12);
			this.TriangleImage.Name = "TriangleImage";
			this.TriangleImage.Size = new System.Drawing.Size(129, 129);
			this.TriangleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.TriangleImage.TabIndex = 1;
			this.TriangleImage.TabStop = false;
			this.TriangleImage.Click += new System.EventHandler(this.Triangle_Click);
			// 
			// RectangleImage
			// 
			this.RectangleImage.Image = ((System.Drawing.Image)(resources.GetObject("RectangleImage.Image")));
			this.RectangleImage.Cursor = Cursors.Hand;
			this.RectangleImage.Location = new System.Drawing.Point(368, 12);
			this.RectangleImage.Name = "RectangleImage";
			this.RectangleImage.Size = new System.Drawing.Size(129, 129);
			this.RectangleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.RectangleImage.TabIndex = 2;
			this.RectangleImage.TabStop = false;
			this.RectangleImage.Click += new System.EventHandler(this.Rectangle_Click);
			// 
			// Shapes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 153);
			this.Controls.Add(this.RectangleImage);
			this.Controls.Add(this.TriangleImage);
			this.Controls.Add(this.CircleImage);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Shapes";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Shapes";
			((System.ComponentModel.ISupportInitialize)(this.CircleImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TriangleImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RectangleImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

	}
}
