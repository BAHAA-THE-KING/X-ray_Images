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
            ConfirmButton = new Button();
            RecordingLabel = new Label();
            StartImage = new PictureBox();
            StopImage = new PictureBox();
            PlayImage = new PictureBox();
            WhatsAppImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)StartImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StopImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).BeginInit();
            SuspendLayout();
            // 
            // ConfirmButton
            // 
            ConfirmButton.Cursor = Cursors.Hand;
            ConfirmButton.Font = new Font("Dubai", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmButton.Location = new Point(419, 475);
            ConfirmButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.RightToLeft = RightToLeft.Yes;
            ConfirmButton.Size = new Size(166, 76);
            ConfirmButton.TabIndex = 4;
            ConfirmButton.Text = "تأكيد";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += Confirm_Click;
            // 
            // RecordingLabel
            // 
            RecordingLabel.Font = new Font("Dubai", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordingLabel.Location = new Point(362, 335);
            RecordingLabel.Name = "RecordingLabel";
            RecordingLabel.RightToLeft = RightToLeft.Yes;
            RecordingLabel.Size = new Size(269, 96);
            RecordingLabel.TabIndex = 6;
            RecordingLabel.Text = "جارٍ التسجيل";
            // 
            // StartImage
            // 
            StartImage.Cursor = Cursors.Hand;
            StartImage.Image = (Image)resources.GetObject("StartImage.Image");
            StartImage.Location = new Point(155, 162);
            StartImage.Margin = new Padding(3, 4, 3, 4);
            StartImage.Name = "StartImage";
            StartImage.Size = new Size(139, 152);
            StartImage.SizeMode = PictureBoxSizeMode.Zoom;
            StartImage.TabIndex = 7;
            StartImage.TabStop = false;
            StartImage.Click += Start_Click;
            // 
            // StopImage
            // 
            StopImage.Cursor = Cursors.Hand;
            StopImage.Image = (Image)resources.GetObject("StopImage.Image");
            StopImage.Location = new Point(666, 162);
            StopImage.Margin = new Padding(3, 4, 3, 4);
            StopImage.Name = "StopImage";
            StopImage.Size = new Size(139, 152);
            StopImage.SizeMode = PictureBoxSizeMode.Zoom;
            StopImage.TabIndex = 8;
            StopImage.TabStop = false;
            StopImage.Click += Stop_Click;
            // 
            // PlayImage
            // 
            PlayImage.Cursor = Cursors.Hand;
            PlayImage.Image = (Image)resources.GetObject("PlayImage.Image");
            PlayImage.Location = new Point(431, 162);
            PlayImage.Margin = new Padding(3, 4, 3, 4);
            PlayImage.Name = "PlayImage";
            PlayImage.Size = new Size(139, 152);
            PlayImage.SizeMode = PictureBoxSizeMode.Zoom;
            PlayImage.TabIndex = 9;
            PlayImage.TabStop = false;
            PlayImage.Click += Play_Click;
            // 
            // WhatsAppImage
            // 
            WhatsAppImage.Cursor = Cursors.Hand;
            WhatsAppImage.Image = (Image)resources.GetObject("WhatsAppImage.Image");
            WhatsAppImage.Location = new Point(14, 12);
            WhatsAppImage.Margin = new Padding(5, 4, 5, 4);
            WhatsAppImage.Name = "WhatsAppImage";
            WhatsAppImage.Size = new Size(57, 62);
            WhatsAppImage.SizeMode = PictureBoxSizeMode.Zoom;
            WhatsAppImage.TabIndex = 21;
            WhatsAppImage.TabStop = false;
            WhatsAppImage.Click += WhatsAppImage_Click;
            // 
            // Audio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 566);
            Controls.Add(WhatsAppImage);
            Controls.Add(PlayImage);
            Controls.Add(StopImage);
            Controls.Add(StartImage);
            Controls.Add(RecordingLabel);
            Controls.Add(ConfirmButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Audio";
            Text = "Recording";
            ((System.ComponentModel.ISupportInitialize)StartImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)StopImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).EndInit();
            ResumeLayout(false);
        }

        private PictureBox WhatsAppImage;
    }
}
