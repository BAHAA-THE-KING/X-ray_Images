namespace X_ray_Images
{
    partial class CreateReport
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Label BasicInfoLabel;
        private System.Windows.Forms.PictureBox BasicInfoImage;
        private System.Windows.Forms.Panel BasicInfoPanel;
        private System.Windows.Forms.Panel PhotosPanel;
        private System.Windows.Forms.PictureBox PhotosImage;
        private System.Windows.Forms.Label PhotosLabel;
        private System.Windows.Forms.Panel AudioPanel;
        private System.Windows.Forms.PictureBox AudioImage;
        private System.Windows.Forms.Label AudioLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CompressButton;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
            showHome();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReport));
            BasicInfoLabel = new Label();
            BasicInfoImage = new PictureBox();
            BasicInfoPanel = new Panel();
            PhotosPanel = new Panel();
            PhotosImage = new PictureBox();
            PhotosLabel = new Label();
            AudioPanel = new Panel();
            AudioImage = new PictureBox();
            AudioLabel = new Label();
            SaveButton = new Button();
            CompressButton = new Button();
            CreateLabel = new Label();
            CreatePanel = new Panel();
            TelegramImage = new PictureBox();
            WhatsAppImage = new PictureBox();
            ShareZipFile = new Button();
            ((System.ComponentModel.ISupportInitialize)BasicInfoImage).BeginInit();
            BasicInfoPanel.SuspendLayout();
            PhotosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotosImage).BeginInit();
            AudioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AudioImage).BeginInit();
            CreatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TelegramImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).BeginInit();
            SuspendLayout();
            // 
            // BasicInfoLabel
            // 
            BasicInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BasicInfoLabel.Font = new Font("Dubai", 15F);
            BasicInfoLabel.Location = new Point(15, 203);
            BasicInfoLabel.Name = "BasicInfoLabel";
            BasicInfoLabel.RightToLeft = RightToLeft.Yes;
            BasicInfoLabel.Size = new Size(211, 56);
            BasicInfoLabel.TabIndex = 2;
            BasicInfoLabel.Text = "معلومات أساسية";
            BasicInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            BasicInfoLabel.Click += BasicInfoPanelClick;
            // 
            // BasicInfoImage
            // 
            BasicInfoImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BasicInfoImage.BackColor = Color.Transparent;
            BasicInfoImage.BackgroundImageLayout = ImageLayout.Center;
            BasicInfoImage.Image = (Image)resources.GetObject("BasicInfoImage.Image");
            BasicInfoImage.Location = new Point(19, 17);
            BasicInfoImage.Margin = new Padding(3, 4, 3, 4);
            BasicInfoImage.Name = "BasicInfoImage";
            BasicInfoImage.Size = new Size(203, 184);
            BasicInfoImage.SizeMode = PictureBoxSizeMode.Zoom;
            BasicInfoImage.TabIndex = 3;
            BasicInfoImage.TabStop = false;
            BasicInfoImage.Click += BasicInfoPanelClick;
            // 
            // BasicInfoPanel
            // 
            BasicInfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BasicInfoPanel.AutoScrollMargin = new Size(150, 150);
            BasicInfoPanel.BackColor = Color.FromArgb(0, 180, 216);
            BasicInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            BasicInfoPanel.Controls.Add(BasicInfoImage);
            BasicInfoPanel.Controls.Add(BasicInfoLabel);
            BasicInfoPanel.Cursor = Cursors.Hand;
            BasicInfoPanel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BasicInfoPanel.ForeColor = SystemColors.ButtonHighlight;
            BasicInfoPanel.Location = new Point(657, 180);
            BasicInfoPanel.Margin = new Padding(3, 4, 3, 4);
            BasicInfoPanel.MaximumSize = new Size(242, 263);
            BasicInfoPanel.MinimumSize = new Size(242, 263);
            BasicInfoPanel.Name = "BasicInfoPanel";
            BasicInfoPanel.Size = new Size(242, 263);
            BasicInfoPanel.TabIndex = 4;
            BasicInfoPanel.Click += BasicInfoPanelClick;
            // 
            // PhotosPanel
            // 
            PhotosPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhotosPanel.AutoScrollMargin = new Size(150, 150);
            PhotosPanel.BackColor = Color.FromArgb(0, 180, 216);
            PhotosPanel.BorderStyle = BorderStyle.FixedSingle;
            PhotosPanel.Controls.Add(PhotosImage);
            PhotosPanel.Controls.Add(PhotosLabel);
            PhotosPanel.Cursor = Cursors.Hand;
            PhotosPanel.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhotosPanel.Location = new Point(374, 180);
            PhotosPanel.MaximumSize = new Size(242, 263);
            PhotosPanel.MinimumSize = new Size(242, 263);
            PhotosPanel.Name = "PhotosPanel";
            PhotosPanel.Size = new Size(242, 263);
            PhotosPanel.TabIndex = 5;
            PhotosPanel.Click += PhotosPanelClick;
            // 
            // PhotosImage
            // 
            PhotosImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhotosImage.BackgroundImageLayout = ImageLayout.Center;
            PhotosImage.Image = (Image)resources.GetObject("PhotosImage.Image");
            PhotosImage.Location = new Point(22, 15);
            PhotosImage.Margin = new Padding(3, 4, 3, 4);
            PhotosImage.Name = "PhotosImage";
            PhotosImage.Size = new Size(203, 184);
            PhotosImage.SizeMode = PictureBoxSizeMode.Zoom;
            PhotosImage.TabIndex = 3;
            PhotosImage.TabStop = false;
            PhotosImage.Click += PhotosPanelClick;
            // 
            // PhotosLabel
            // 
            PhotosLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhotosLabel.Font = new Font("Dubai", 15F);
            PhotosLabel.ForeColor = SystemColors.ButtonHighlight;
            PhotosLabel.Location = new Point(14, 202);
            PhotosLabel.Name = "PhotosLabel";
            PhotosLabel.RightToLeft = RightToLeft.Yes;
            PhotosLabel.Size = new Size(211, 56);
            PhotosLabel.TabIndex = 2;
            PhotosLabel.Text = "صور الحالة";
            PhotosLabel.TextAlign = ContentAlignment.MiddleCenter;
            PhotosLabel.Click += PhotosPanelClick;
            // 
            // AudioPanel
            // 
            AudioPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AudioPanel.AutoScrollMargin = new Size(150, 150);
            AudioPanel.BackColor = Color.FromArgb(0, 180, 216);
            AudioPanel.BorderStyle = BorderStyle.FixedSingle;
            AudioPanel.Controls.Add(AudioImage);
            AudioPanel.Controls.Add(AudioLabel);
            AudioPanel.Cursor = Cursors.Hand;
            AudioPanel.Location = new Point(93, 180);
            AudioPanel.Margin = new Padding(3, 4, 3, 4);
            AudioPanel.MaximumSize = new Size(242, 263);
            AudioPanel.MinimumSize = new Size(242, 263);
            AudioPanel.Name = "AudioPanel";
            AudioPanel.Size = new Size(242, 263);
            AudioPanel.TabIndex = 6;
            AudioPanel.Click += AudioPanelClick;
            // 
            // AudioImage
            // 
            AudioImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AudioImage.BackgroundImageLayout = ImageLayout.Center;
            AudioImage.Image = (Image)resources.GetObject("AudioImage.Image");
            AudioImage.Location = new Point(22, 15);
            AudioImage.Margin = new Padding(3, 4, 3, 4);
            AudioImage.Name = "AudioImage";
            AudioImage.Size = new Size(203, 184);
            AudioImage.SizeMode = PictureBoxSizeMode.Zoom;
            AudioImage.TabIndex = 3;
            AudioImage.TabStop = false;
            AudioImage.Click += AudioPanelClick;
            // 
            // AudioLabel
            // 
            AudioLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AudioLabel.Font = new Font("Dubai", 15F);
            AudioLabel.ForeColor = SystemColors.ButtonHighlight;
            AudioLabel.Location = new Point(14, 202);
            AudioLabel.Name = "AudioLabel";
            AudioLabel.RightToLeft = RightToLeft.Yes;
            AudioLabel.Size = new Size(211, 56);
            AudioLabel.TabIndex = 2;
            AudioLabel.Text = "التشخيص الصوتي";
            AudioLabel.TextAlign = ContentAlignment.MiddleCenter;
            AudioLabel.Click += AudioPanelClick;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom;
            SaveButton.Font = new Font("Dubai", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(93, 479);
            SaveButton.Name = "SaveButton";
            SaveButton.RightToLeft = RightToLeft.Yes;
            SaveButton.Size = new Size(242, 75);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "حفظ";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButtonClick;
            // 
            // CompressButton
            // 
            CompressButton.Anchor = AnchorStyles.Bottom;
            CompressButton.Font = new Font("Dubai", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompressButton.Location = new Point(374, 479);
            CompressButton.Name = "CompressButton";
            CompressButton.RightToLeft = RightToLeft.Yes;
            CompressButton.Size = new Size(242, 75);
            CompressButton.TabIndex = 7;
            CompressButton.Text = "حفظ مع ضغط";
            CompressButton.UseVisualStyleBackColor = true;
            CompressButton.Click += CompressButtonClick;
            // 
            // CreateLabel
            // 
            CreateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateLabel.BackColor = Color.Transparent;
            CreateLabel.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateLabel.ForeColor = Color.White;
            CreateLabel.Location = new Point(417, 18);
            CreateLabel.Name = "CreateLabel";
            CreateLabel.Size = new Size(175, 49);
            CreateLabel.TabIndex = 0;
            CreateLabel.Text = "تقرير جديد";
            CreateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CreatePanel
            // 
            CreatePanel.Anchor = AnchorStyles.Top;
            CreatePanel.BackColor = Color.FromArgb(0, 180, 216);
            CreatePanel.Controls.Add(TelegramImage);
            CreatePanel.Controls.Add(WhatsAppImage);
            CreatePanel.Controls.Add(CreateLabel);
            CreatePanel.Location = new Point(0, 0);
            CreatePanel.Name = "CreatePanel";
            CreatePanel.Size = new Size(1008, 84);
            CreatePanel.TabIndex = 7;
            // 
            // TelegramImage
            // 
            TelegramImage.Cursor = Cursors.Hand;
            TelegramImage.Image = (Image)resources.GetObject("TelegramImage.Image");
            TelegramImage.Location = new Point(928, 11);
            TelegramImage.Margin = new Padding(5, 4, 5, 4);
            TelegramImage.Name = "TelegramImage";
            TelegramImage.Size = new Size(57, 62);
            TelegramImage.SizeMode = PictureBoxSizeMode.Zoom;
            TelegramImage.TabIndex = 26;
            TelegramImage.TabStop = false;
            TelegramImage.Click += TelegramImage_Click;
            // 
            // WhatsAppImage
            // 
            WhatsAppImage.Cursor = Cursors.Hand;
            WhatsAppImage.Image = (Image)resources.GetObject("WhatsAppImage.Image");
            WhatsAppImage.Location = new Point(861, 11);
            WhatsAppImage.Margin = new Padding(5, 4, 5, 4);
            WhatsAppImage.Name = "WhatsAppImage";
            WhatsAppImage.Size = new Size(57, 62);
            WhatsAppImage.SizeMode = PictureBoxSizeMode.Zoom;
            WhatsAppImage.TabIndex = 25;
            WhatsAppImage.TabStop = false;
            WhatsAppImage.Click += WhatsAppImage_Click;
            // 
            // ShareZipFile
            // 
            ShareZipFile.Anchor = AnchorStyles.Bottom;
            ShareZipFile.Font = new Font("Dubai", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShareZipFile.Location = new Point(638, 479);
            ShareZipFile.Name = "ShareZipFile";
            ShareZipFile.RightToLeft = RightToLeft.Yes;
            ShareZipFile.Size = new Size(290, 75);
            ShareZipFile.TabIndex = 8;
            ShareZipFile.Text = "حفظ الملف المضغوط";
            ShareZipFile.UseVisualStyleBackColor = true;
            ShareZipFile.Click += SaveZipFile_Click;
            // 
            // CreateReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 211, 249);
            ClientSize = new Size(1008, 566);
            Controls.Add(ShareZipFile);
            Controls.Add(SaveButton);
            Controls.Add(CompressButton);
            Controls.Add(CreatePanel);
            Controls.Add(AudioPanel);
            Controls.Add(PhotosPanel);
            Controls.Add(BasicInfoPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medications";
            ((System.ComponentModel.ISupportInitialize)BasicInfoImage).EndInit();
            BasicInfoPanel.ResumeLayout(false);
            PhotosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PhotosImage).EndInit();
            AudioPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AudioImage).EndInit();
            CreatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TelegramImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).EndInit();
            ResumeLayout(false);
        }

        private Button ShareZipFile;
        private PictureBox TelegramImage;
        private PictureBox WhatsAppImage;
    }
}
