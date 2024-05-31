using X_ray_Images.Classes;

namespace X_ray_Images
{
    partial class Audio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label RecordingLabel;
        private System.Windows.Forms.Label ListeningLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.PictureBox StartImage;
        private System.Windows.Forms.PictureBox StopImage;
        private System.Windows.Forms.PictureBox PlayImage;
        protected override void Dispose(bool disposing)
        {
            if (this.mode == AudioMode.Listening) return;
            if (this.mode == AudioMode.Recording) return;
            if (this.path.Equals(Paths.AudioTempFile)) CreateReport.isAudioOpen = false;
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
            this.ListeningLabel = new System.Windows.Forms.Label();
            this.StartImage = new System.Windows.Forms.PictureBox();
            this.StopImage = new System.Windows.Forms.PictureBox();
            this.PlayImage = new System.Windows.Forms.PictureBox();
            this.WhatsAppImage = new System.Windows.Forms.PictureBox();
            this.TelegramImage = new System.Windows.Forms.PictureBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.StopPanel = new System.Windows.Forms.Panel();
            this.StopLabel = new System.Windows.Forms.Label();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.StartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhatsAppImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramImage)).BeginInit();
            this.StopPanel.SuspendLayout();
            this.PlayPanel.SuspendLayout();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // ListeningLabel
            // 
            this.ListeningLabel.Font = new System.Drawing.Font("Dubai", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeningLabel.Location = new System.Drawing.Point(317, 268);
            this.ListeningLabel.Name = "ListeningLabel";
            this.ListeningLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListeningLabel.Size = new System.Drawing.Size(235, 77);
            this.ListeningLabel.TabIndex = 6;
            this.ListeningLabel.Text = "جارٍ الاستماع";
            // 
            // StartImage
            // 
            this.StartImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartImage.Image = ((System.Drawing.Image)(resources.GetObject("StartImage.Image")));
            this.StartImage.Location = new System.Drawing.Point(10, 3);
            this.StartImage.Name = "StartImage";
            this.StartImage.Size = new System.Drawing.Size(122, 122);
            this.StartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartImage.TabIndex = 7;
            this.StartImage.TabStop = false;
            this.StartImage.Click += new System.EventHandler(this.Start_Click);

            // 
            // StopImage
            // 
            this.StopImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopImage.Image = ((System.Drawing.Image)(resources.GetObject("StopImage.Image")));
            this.StopImage.Location = new System.Drawing.Point(10, 3);
            this.StopImage.Name = "StopImage";
            this.StopImage.Size = new System.Drawing.Size(122, 122);
            this.StopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopImage.TabIndex = 8;
            this.StopImage.TabStop = false;
            this.StopImage.Click += new System.EventHandler(this.Stop_Click);
            // 
            // PlayImage
            // 
            this.PlayImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayImage.Image = ((System.Drawing.Image)(resources.GetObject("PlayImage.Image")));
            this.PlayImage.Location = new System.Drawing.Point(10, 3);
            this.PlayImage.Name = "PlayImage";
            this.PlayImage.Size = new System.Drawing.Size(122, 122);
            this.PlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayImage.TabIndex = 9;
            this.PlayImage.TabStop = false;
            this.PlayImage.Click += new System.EventHandler(this.Play_Click);
            // 
            // WhatsAppImage
            // 
            this.WhatsAppImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WhatsAppImage.Image = ((System.Drawing.Image)(resources.GetObject("WhatsAppImage.Image")));
            this.WhatsAppImage.Location = new System.Drawing.Point(12, 10);
            this.WhatsAppImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WhatsAppImage.Name = "WhatsAppImage";
            this.WhatsAppImage.Size = new System.Drawing.Size(50, 50);
            this.WhatsAppImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WhatsAppImage.TabIndex = 21;
            this.WhatsAppImage.TabStop = false;
            this.WhatsAppImage.Click += new System.EventHandler(this.WhatsAppImage_Click);
            // 
            // TelegramImage
            // 
            this.TelegramImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TelegramImage.Image = ((System.Drawing.Image)(resources.GetObject("TelegramImage.Image")));
            this.TelegramImage.Location = new System.Drawing.Point(12, 73);
            this.TelegramImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TelegramImage.Name = "TelegramImage";
            this.TelegramImage.Size = new System.Drawing.Size(50, 50);
            this.TelegramImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TelegramImage.TabIndex = 22;
            this.TelegramImage.TabStop = false;
            this.TelegramImage.Click += new System.EventHandler(this.TelegramImage_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Dubai", 20F);
            this.MainLabel.Location = new System.Drawing.Point(136, 13);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainLabel.Size = new System.Drawing.Size(569, 57);
            this.MainLabel.TabIndex = 23;
            this.MainLabel.Text = "وصف الحالة المرضية";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopPanel
            // 
            this.StopPanel.Controls.Add(this.StopLabel);
            this.StopPanel.Controls.Add(this.StopImage);
            this.StopPanel.Location = new System.Drawing.Point(573, 120);
            this.StopPanel.Name = "StopPanel";
            this.StopPanel.Size = new System.Drawing.Size(142, 184);
            this.StopPanel.TabIndex = 24;
            this.StopPanel.Click += new System.EventHandler(this.Stop_Click);
            // 
            // StopLabel
            // 
            this.StopLabel.Font = new System.Drawing.Font("Dubai", 15F);
            this.StopLabel.Location = new System.Drawing.Point(10, 132);
            this.StopLabel.Name = "StopLabel";
            this.StopLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StopLabel.Size = new System.Drawing.Size(122, 43);
            this.StopLabel.TabIndex = 9;
            this.StopLabel.Text = "إيقاف";
            this.StopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StopLabel.Click += new System.EventHandler(this.Stop_Click);
            // 
            // PlayPanel
            // 
            this.PlayPanel.Controls.Add(this.PlayLabel);
            this.PlayPanel.Controls.Add(this.PlayImage);
            this.PlayPanel.Location = new System.Drawing.Point(367, 120);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(142, 184);
            this.PlayPanel.TabIndex = 25;
            this.PlayPanel.Click += new System.EventHandler(this.Play_Click);
            // 
            // PlayLabel
            // 
            this.PlayLabel.Font = new System.Drawing.Font("Dubai", 15F);
            this.PlayLabel.Location = new System.Drawing.Point(10, 132);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlayLabel.Size = new System.Drawing.Size(122, 43);
            this.PlayLabel.TabIndex = 9;
            this.PlayLabel.Text = "تشغيل";
            this.PlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayLabel.Click += new System.EventHandler(this.Play_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.StartLabel);
            this.StartPanel.Controls.Add(this.StartImage);
            this.StartPanel.Location = new System.Drawing.Point(126, 120);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(142, 184);
            this.StartPanel.TabIndex = 26;
            this.StartPanel.Click += new System.EventHandler(this.Start_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.Font = new System.Drawing.Font("Dubai", 15F);
            this.StartLabel.Location = new System.Drawing.Point(10, 132);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartLabel.Size = new System.Drawing.Size(122, 43);
            this.StartLabel.TabIndex = 9;
            this.StartLabel.Text = "تشغيل";
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartLabel.Click += new System.EventHandler(this.Start_Click);
            // 
            // Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.PlayPanel);
            this.Controls.Add(this.StopPanel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.TelegramImage);
            this.Controls.Add(this.WhatsAppImage);
            this.Controls.Add(this.RecordingLabel);
            this.Controls.Add(this.ListeningLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Audio";
            this.Text = "تسجيل صوت";
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhatsAppImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramImage)).EndInit();
            this.StopPanel.ResumeLayout(false);
            this.PlayPanel.ResumeLayout(false);
            this.StartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox WhatsAppImage;
        private System.Windows.Forms.PictureBox TelegramImage;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label StopLabel;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Panel StopPanel;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Label StartLabel;
    }
}
