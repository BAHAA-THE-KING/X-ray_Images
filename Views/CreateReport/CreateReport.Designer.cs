namespace X_ray_Images
{
    partial class CreateReport
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label CreateLabel;
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
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReport));
            CreateLabel = new Label();
            BasicInfoLabel = new Label();
            BasicInfoImage = new PictureBox();
            BasicInfoPanel = new Panel();
            PhotosPanel = new Panel();
            PhotosImage = new PictureBox();
            PhotosLabel = new Label();
            AudioPanel = new Panel();
            AudioImage = new PictureBox();
            AudioLabel = new Label();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)BasicInfoImage).BeginInit();
            BasicInfoPanel.SuspendLayout();
            PhotosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotosImage).BeginInit();
            AudioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AudioImage).BeginInit();
            SuspendLayout();
            // 
            // CreateLabel
            // 
            CreateLabel.Dock = DockStyle.Top;
            CreateLabel.Font = new Font("Dubai", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateLabel.Location = new Point(0, 0);
            CreateLabel.Name = "CreateLabel";
            CreateLabel.Size = new Size(1008, 88);
            CreateLabel.TabIndex = 0;
            CreateLabel.Text = "تقرير جديد";
            CreateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BasicInfoLabel
            // 
            BasicInfoLabel.Font = new Font("Dubai", 15F);
            BasicInfoLabel.Location = new Point(14, 202);
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
            BasicInfoImage.BackgroundImageLayout = ImageLayout.Center;
            BasicInfoImage.Image = (Image)resources.GetObject("BasicInfoImage.Image");
            BasicInfoImage.Location = new Point(22, 15);
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
            BasicInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            BasicInfoPanel.Controls.Add(BasicInfoImage);
            BasicInfoPanel.Controls.Add(BasicInfoLabel);
            BasicInfoPanel.Cursor = Cursors.Hand;
            BasicInfoPanel.Location = new Point(657, 180);
            BasicInfoPanel.Margin = new Padding(3, 4, 3, 4);
            BasicInfoPanel.Name = "BasicInfoPanel";
            BasicInfoPanel.Size = new Size(242, 263);
            BasicInfoPanel.TabIndex = 4;
            BasicInfoPanel.Click += BasicInfoPanelClick;
            // 
            // PhotosPanel
            // 
            PhotosPanel.BorderStyle = BorderStyle.FixedSingle;
            PhotosPanel.Controls.Add(PhotosImage);
            PhotosPanel.Controls.Add(PhotosLabel);
            PhotosPanel.Cursor = Cursors.Hand;
            PhotosPanel.Location = new Point(374, 180);
            PhotosPanel.Name = "PhotosPanel";
            PhotosPanel.Size = new Size(242, 263);
            PhotosPanel.TabIndex = 5;
            PhotosPanel.Click += PhotosPanelClick;
            // 
            // PhotosImage
            // 
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
            PhotosLabel.Font = new Font("Dubai", 15F);
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
            AudioPanel.BorderStyle = BorderStyle.FixedSingle;
            AudioPanel.Controls.Add(AudioImage);
            AudioPanel.Controls.Add(AudioLabel);
            AudioPanel.Cursor = Cursors.Hand;
            AudioPanel.Location = new Point(93, 180);
            AudioPanel.Margin = new Padding(3, 4, 3, 4);
            AudioPanel.Name = "AudioPanel";
            AudioPanel.Size = new Size(242, 263);
            AudioPanel.TabIndex = 6;
            AudioPanel.Click += AudioPanelClick;
            // 
            // AudioImage
            // 
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
            AudioLabel.Font = new Font("Dubai", 15F);
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
            this.SaveButton.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(374, 475);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RightToLeft = RightToLeft.Yes;
            this.SaveButton.Size = new System.Drawing.Size(242, 75);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "حفظ";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // CreateReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 566);
            this.Controls.Add(this.SaveButton);
            Controls.Add(AudioPanel);
            Controls.Add(PhotosPanel);
            Controls.Add(BasicInfoPanel);
            Controls.Add(CreateLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateReport";
            Text = "Medications";
            ((System.ComponentModel.ISupportInitialize)BasicInfoImage).EndInit();
            BasicInfoPanel.ResumeLayout(false);
            PhotosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PhotosImage).EndInit();
            AudioPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AudioImage).EndInit();
            ResumeLayout(false);
        }
    }
}
