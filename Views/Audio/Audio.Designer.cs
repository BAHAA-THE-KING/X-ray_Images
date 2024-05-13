namespace X_ray_Images
{
	partial class Audio
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label RecordingLabel;
		private System.Windows.Forms.Button ConfirmButton;
		private System.Windows.Forms.PictureBox StartImage;
		private System.Windows.Forms.PictureBox StopImage;
		private System.Windows.Forms.PictureBox PlayImage;
		protected override void Dispose(bool disposing)
		{
			CreateReport.isAudioOpen = false;
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audio));
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.RecordingLabel = new System.Windows.Forms.Label();
			this.StartImage = new System.Windows.Forms.PictureBox();
			this.StopImage = new System.Windows.Forms.PictureBox();
			this.PlayImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.StartImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.StopImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
			this.SuspendLayout();
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.Cursor = Cursors.Hand;
			this.ConfirmButton.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConfirmButton.Location = new System.Drawing.Point(367, 380);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ConfirmButton.Size = new System.Drawing.Size(145, 61);
			this.ConfirmButton.TabIndex = 4;
			this.ConfirmButton.Text = "تأكيد";
			this.ConfirmButton.UseVisualStyleBackColor = true;
			this.ConfirmButton.Click += new System.EventHandler(this.Confirm_Click);
			// 
			// RecordingLabel
			// 
			this.RecordingLabel.Font = new System.Drawing.Font("Dubai", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RecordingLabel.Location = new System.Drawing.Point(317, 268);
			this.RecordingLabel.Name = "RecordingLabel";
			this.RecordingLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RecordingLabel.Size = new System.Drawing.Size(235, 77);
			this.RecordingLabel.TabIndex = 6;
			this.RecordingLabel.Text = "جارٍ التسجيل";
			// 
			// StartImage
			// 
			this.StartImage.Cursor = Cursors.Hand;
			this.StartImage.Image = ((System.Drawing.Image)(resources.GetObject("StartImage.Image")));
			this.StartImage.Location = new System.Drawing.Point(136, 130);
			this.StartImage.Name = "StartImage";
			this.StartImage.Size = new System.Drawing.Size(122, 122);
			this.StartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.StartImage.TabIndex = 7;
			this.StartImage.TabStop = false;
			this.StartImage.Click += new System.EventHandler(this.Start_Click);
			// 
			// StopImage
			// 
			this.StopImage.Cursor = Cursors.Hand;
			this.StopImage.Image = ((System.Drawing.Image)(resources.GetObject("StopImage.Image")));
			this.StopImage.Location = new System.Drawing.Point(583, 130);
			this.StopImage.Name = "StopImage";
			this.StopImage.Size = new System.Drawing.Size(122, 122);
			this.StopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.StopImage.TabIndex = 8;
			this.StopImage.TabStop = false;
			this.StopImage.Click += new System.EventHandler(this.Stop_Click);
			// 
			// PlayImage
			// 
			this.PlayImage.Cursor = Cursors.Hand;
			this.PlayImage.Image = ((System.Drawing.Image)(resources.GetObject("PlayImage.Image")));
			this.PlayImage.Location = new System.Drawing.Point(377, 130);
			this.PlayImage.Name = "PlayImage";
			this.PlayImage.Size = new System.Drawing.Size(122, 122);
			this.PlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PlayImage.TabIndex = 9;
			this.PlayImage.TabStop = false;
			this.PlayImage.Click += new System.EventHandler(this.Play_Click);
			// 
			// Audio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 453);
			this.Controls.Add(this.PlayImage);
			this.Controls.Add(this.StopImage);
			this.Controls.Add(this.StartImage);
			this.Controls.Add(this.RecordingLabel);
			this.Controls.Add(this.ConfirmButton);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Audio";
			this.Text = "Recording";
			((System.ComponentModel.ISupportInitialize)(this.StartImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.StopImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PlayImage)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
