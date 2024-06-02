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
        private System.Windows.Forms.PictureBox WhatsAppImage;
        private System.Windows.Forms.PictureBox TelegramImage;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label StopLabel;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Panel StopPanel;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Label StartLabel;
        private OxyPlot.WindowsForms.PlotView AudioPlot;
        private System.Windows.Forms.Label TimerLabel;
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
            ConfirmButton = new Button();
            RecordingLabel = new Label();
            ListeningLabel = new Label();
            StartImage = new PictureBox();
            StopImage = new PictureBox();
            PlayImage = new PictureBox();
            WhatsAppImage = new PictureBox();
            TelegramImage = new PictureBox();
            MainLabel = new Label();
            StopPanel = new Panel();
            StopLabel = new Label();
            PlayPanel = new Panel();
            PlayLabel = new Label();
            StartPanel = new Panel();
            StartLabel = new Label();
            AudioPlot = new OxyPlot.WindowsForms.PlotView();
            TimerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)StartImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StopImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TelegramImage).BeginInit();
            StopPanel.SuspendLayout();
            PlayPanel.SuspendLayout();
            StartPanel.SuspendLayout();
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
            // ListeningLabel
            // 
            ListeningLabel.Font = new Font("Dubai", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListeningLabel.Location = new Point(362, 335);
            ListeningLabel.Name = "ListeningLabel";
            ListeningLabel.RightToLeft = RightToLeft.Yes;
            ListeningLabel.Size = new Size(269, 96);
            ListeningLabel.TabIndex = 6;
            ListeningLabel.Text = "جارٍ الاستماع";
            // 
            // StartImage
            // 
            StartImage.Cursor = Cursors.Hand;
            StartImage.Image = (Image)resources.GetObject("StartImage.Image");
            StartImage.Location = new Point(11, 4);
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
            StopImage.Location = new Point(11, 4);
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
            PlayImage.Location = new Point(11, 4);
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
            // TelegramImage
            // 
            TelegramImage.Cursor = Cursors.Hand;
            TelegramImage.Image = (Image)resources.GetObject("TelegramImage.Image");
            TelegramImage.Location = new Point(14, 91);
            TelegramImage.Margin = new Padding(5, 4, 5, 4);
            TelegramImage.Name = "TelegramImage";
            TelegramImage.Size = new Size(57, 62);
            TelegramImage.SizeMode = PictureBoxSizeMode.Zoom;
            TelegramImage.TabIndex = 22;
            TelegramImage.TabStop = false;
            TelegramImage.Click += TelegramImage_Click;
            // 
            // MainLabel
            // 
            MainLabel.Font = new Font("Dubai", 20F);
            MainLabel.Location = new Point(155, 16);
            MainLabel.Name = "MainLabel";
            MainLabel.RightToLeft = RightToLeft.Yes;
            MainLabel.Size = new Size(650, 71);
            MainLabel.TabIndex = 23;
            MainLabel.Text = "وصف الحالة المرضية";
            MainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StopPanel
            // 
            StopPanel.Controls.Add(StopLabel);
            StopPanel.Controls.Add(StopImage);
            StopPanel.Location = new Point(655, 150);
            StopPanel.Margin = new Padding(3, 4, 3, 4);
            StopPanel.Name = "StopPanel";
            StopPanel.Size = new Size(162, 230);
            StopPanel.TabIndex = 24;
            StopPanel.Click += Stop_Click;
            // 
            // StopLabel
            // 
            StopLabel.Font = new Font("Dubai", 15F);
            StopLabel.Location = new Point(11, 165);
            StopLabel.Name = "StopLabel";
            StopLabel.RightToLeft = RightToLeft.Yes;
            StopLabel.Size = new Size(139, 54);
            StopLabel.TabIndex = 9;
            StopLabel.Text = "إيقاف";
            StopLabel.TextAlign = ContentAlignment.MiddleCenter;
            StopLabel.Click += Stop_Click;
            // 
            // PlayPanel
            // 
            PlayPanel.Controls.Add(PlayLabel);
            PlayPanel.Controls.Add(PlayImage);
            PlayPanel.Location = new Point(419, 150);
            PlayPanel.Margin = new Padding(3, 4, 3, 4);
            PlayPanel.Name = "PlayPanel";
            PlayPanel.Size = new Size(162, 230);
            PlayPanel.TabIndex = 25;
            PlayPanel.Click += Play_Click;
            // 
            // PlayLabel
            // 
            PlayLabel.Font = new Font("Dubai", 15F);
            PlayLabel.Location = new Point(11, 165);
            PlayLabel.Name = "PlayLabel";
            PlayLabel.RightToLeft = RightToLeft.Yes;
            PlayLabel.Size = new Size(139, 54);
            PlayLabel.TabIndex = 9;
            PlayLabel.Text = "تشغيل";
            PlayLabel.TextAlign = ContentAlignment.MiddleCenter;
            PlayLabel.Click += Play_Click;
            // 
            // StartPanel
            // 
            StartPanel.Controls.Add(StartLabel);
            StartPanel.Controls.Add(StartImage);
            StartPanel.Location = new Point(144, 150);
            StartPanel.Margin = new Padding(3, 4, 3, 4);
            StartPanel.Name = "StartPanel";
            StartPanel.Size = new Size(162, 230);
            StartPanel.TabIndex = 26;
            StartPanel.Click += Start_Click;
            // 
            // StartLabel
            // 
            StartLabel.Font = new Font("Dubai", 15F);
            StartLabel.Location = new Point(11, 165);
            StartLabel.Name = "StartLabel";
            StartLabel.RightToLeft = RightToLeft.Yes;
            StartLabel.Size = new Size(139, 54);
            StartLabel.TabIndex = 9;
            StartLabel.Text = "تسجيل";
            StartLabel.TextAlign = ContentAlignment.MiddleCenter;
            StartLabel.Click += Start_Click;
            // 
            // AudioPlot
            // 
            AudioPlot.Location = new Point(778, 87);
            AudioPlot.Name = "AudioPlot";
            AudioPlot.PanCursor = Cursors.Hand;
            AudioPlot.Size = new Size(404, 293);
            AudioPlot.TabIndex = 27;
            AudioPlot.ZoomHorizontalCursor = Cursors.SizeWE;
            AudioPlot.ZoomRectangleCursor = Cursors.SizeNWSE;
            AudioPlot.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // TimerLabel
            // 
            TimerLabel.Font = new Font("Segoe UI", 25F);
            TimerLabel.Location = new Point(408, 188);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.RightToLeft = RightToLeft.Yes;
            TimerLabel.Size = new Size(185, 86);
            TimerLabel.TabIndex = 28;
            TimerLabel.Text = "00:00";
            TimerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Audio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 566);
            Controls.Add(TimerLabel);
            Controls.Add(StartPanel);
            Controls.Add(PlayPanel);
            Controls.Add(StopPanel);
            Controls.Add(MainLabel);
            Controls.Add(TelegramImage);
            Controls.Add(WhatsAppImage);
            Controls.Add(RecordingLabel);
            Controls.Add(ListeningLabel);
            Controls.Add(ConfirmButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Audio";
            Text = "تسجيل صوت";
            ((System.ComponentModel.ISupportInitialize)StartImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)StopImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)TelegramImage).EndInit();
            StopPanel.ResumeLayout(false);
            PlayPanel.ResumeLayout(false);
            StartPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
