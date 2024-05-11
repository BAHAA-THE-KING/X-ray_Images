namespace X_ray_Images
{
	partial class CreateReport
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
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

		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReport));
			this.CreateLabel = new System.Windows.Forms.Label();
			this.BasicInfoLabel = new System.Windows.Forms.Label();
			this.BasicInfoImage = new System.Windows.Forms.PictureBox();
			this.BasicInfoPanel = new System.Windows.Forms.Panel();
			this.PhotosPanel = new System.Windows.Forms.Panel();
			this.PhotosImage = new System.Windows.Forms.PictureBox();
			this.PhotosLabel = new System.Windows.Forms.Label();
			this.AudioPanel = new System.Windows.Forms.Panel();
			this.AudioImage = new System.Windows.Forms.PictureBox();
			this.AudioLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.BasicInfoImage)).BeginInit();
			this.BasicInfoPanel.SuspendLayout();
			this.PhotosPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PhotosImage)).BeginInit();
			this.AudioPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AudioImage)).BeginInit();
			this.SuspendLayout();
			// 
			// CreateLabel
			// 
			this.CreateLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.CreateLabel.Font = new System.Drawing.Font("Dubai", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateLabel.Location = new System.Drawing.Point(0, 0);
			this.CreateLabel.Name = "CreateLabel";
			this.CreateLabel.Size = new System.Drawing.Size(882, 70);
			this.CreateLabel.TabIndex = 0;
			this.CreateLabel.Text = "تقرير جديد";
			this.CreateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// BasicInfoPanel
			// 
			this.BasicInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BasicInfoPanel.Controls.Add(this.BasicInfoImage);
			this.BasicInfoPanel.Controls.Add(this.BasicInfoLabel);
			this.BasicInfoPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BasicInfoPanel.Location = new System.Drawing.Point(575, 144);
			this.BasicInfoPanel.Name = "BasicInfoPanel";
			this.BasicInfoPanel.Size = new System.Drawing.Size(212, 211);
			this.BasicInfoPanel.TabIndex = 4;
			this.BasicInfoPanel.Click += new System.EventHandler(this.BasicInfoPanelClick);
			this.BasicInfoLabel.Click += new System.EventHandler(this.BasicInfoPanelClick);
			this.BasicInfoImage.Click += new System.EventHandler(this.BasicInfoPanelClick);
			// 
			// BasicInfoLabel
			// 
			this.BasicInfoLabel.Font = new System.Drawing.Font("Dubai", 15F);
			this.BasicInfoLabel.Location = new System.Drawing.Point(12, 162);
			this.BasicInfoLabel.Name = "BasicInfoLabel";
			this.BasicInfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.BasicInfoLabel.Size = new System.Drawing.Size(185, 45);
			this.BasicInfoLabel.TabIndex = 2;
			this.BasicInfoLabel.Text = "معلومات أساسية";
			this.BasicInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BasicInfoImage
			// 
			this.BasicInfoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BasicInfoImage.Image = ((System.Drawing.Image)(resources.GetObject("BasicInfoImage.Image")));
			this.BasicInfoImage.Location = new System.Drawing.Point(19, 12);
			this.BasicInfoImage.Name = "BasicInfoImage";
			this.BasicInfoImage.Size = new System.Drawing.Size(178, 147);
			this.BasicInfoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.BasicInfoImage.TabIndex = 3;
			this.BasicInfoImage.TabStop = false;
			// 
			// PhotosPanel
			// 
			this.PhotosPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PhotosPanel.Controls.Add(this.PhotosImage);
			this.PhotosPanel.Controls.Add(this.PhotosLabel);
			this.PhotosPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PhotosPanel.Location = new System.Drawing.Point(327, 144);
			this.PhotosPanel.Name = "PhotosPanel";
			this.PhotosPanel.Size = new System.Drawing.Size(212, 211);
			this.PhotosPanel.TabIndex = 5;
			this.PhotosPanel.Click += new System.EventHandler(this.PhotosPanelClick);
			this.PhotosLabel.Click += new System.EventHandler(this.PhotosPanelClick);
			this.PhotosImage.Click += new System.EventHandler(this.PhotosPanelClick);
			// 
			// PhotosLabel
			// 
			this.PhotosLabel.Font = new System.Drawing.Font("Dubai", 15F);
			this.PhotosLabel.Location = new System.Drawing.Point(12, 162);
			this.PhotosLabel.Name = "PhotosLabel";
			this.PhotosLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.PhotosLabel.Size = new System.Drawing.Size(185, 45);
			this.PhotosLabel.TabIndex = 2;
			this.PhotosLabel.Text = "صور الحالة";
			this.PhotosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PhotosImage
			// 
			this.PhotosImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.PhotosImage.Image = ((System.Drawing.Image)(resources.GetObject("PhotosImage.Image")));
			this.PhotosImage.Location = new System.Drawing.Point(19, 12);
			this.PhotosImage.Name = "PhotosImage";
			this.PhotosImage.Size = new System.Drawing.Size(178, 147);
			this.PhotosImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PhotosImage.TabIndex = 3;
			this.PhotosImage.TabStop = false;
			// 
			// AudioPanel
			// 
			this.AudioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AudioPanel.Controls.Add(this.AudioImage);
			this.AudioPanel.Controls.Add(this.AudioLabel);
			this.AudioPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AudioPanel.Location = new System.Drawing.Point(81, 144);
			this.AudioPanel.Name = "AudioPanel";
			this.AudioPanel.Size = new System.Drawing.Size(212, 211);
			this.AudioPanel.TabIndex = 6;
			this.AudioPanel.Click += new System.EventHandler(this.AudioPanelClick);
			this.AudioLabel.Click += new System.EventHandler(this.AudioPanelClick);
			this.AudioImage.Click += new System.EventHandler(this.AudioPanelClick);
			// 
			// AudioLabel
			// 
			this.AudioLabel.Font = new System.Drawing.Font("Dubai", 15F);
			this.AudioLabel.Location = new System.Drawing.Point(12, 162);
			this.AudioLabel.Name = "AudioLabel";
			this.AudioLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.AudioLabel.Size = new System.Drawing.Size(185, 45);
			this.AudioLabel.TabIndex = 2;
			this.AudioLabel.Text = "التشخيص الصوتي";
			this.AudioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AudioImage
			// 
			this.AudioImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.AudioImage.Image = ((System.Drawing.Image)(resources.GetObject("AudioImage.Image")));
			this.AudioImage.Location = new System.Drawing.Point(19, 12);
			this.AudioImage.Name = "AudioImage";
			this.AudioImage.Size = new System.Drawing.Size(178, 147);
			this.AudioImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.AudioImage.TabIndex = 3;
			this.AudioImage.TabStop = false;
			// 
			// CreateReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 453);
			this.Controls.Add(this.AudioPanel);
			this.Controls.Add(this.PhotosPanel);
			this.Controls.Add(this.BasicInfoPanel);
			this.Controls.Add(this.CreateLabel);
			this.Name = "CreateReport";
			this.Text = "Medications";
			((System.ComponentModel.ISupportInitialize)(this.BasicInfoImage)).EndInit();
			this.BasicInfoPanel.ResumeLayout(false);
			this.PhotosPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PhotosImage)).EndInit();
			this.AudioPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AudioImage)).EndInit();
			this.ResumeLayout(false);
		}
	}
}
