namespace X_ray_Images
{
	partial class Home
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label WelcomeLabel;
		private System.Windows.Forms.Button CreateButton;

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
			this.WelcomeLabel = new System.Windows.Forms.Label();
			this.CreateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// WelcomeLabel
			// 
			this.WelcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.WelcomeLabel.Font = new System.Drawing.Font("Dubai", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelcomeLabel.Location = new System.Drawing.Point(0, 0);
			this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.WelcomeLabel.Name = "WelcomeLabel";
			this.WelcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.WelcomeLabel.Size = new System.Drawing.Size(882, 63);
			this.WelcomeLabel.TabIndex = 0;
			this.WelcomeLabel.Text = "أهلاً بكم في تطبيق التقارير الطبية";
			this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CreateButton
			// 
			this.CreateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CreateButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CreateButton.Location = new System.Drawing.Point(325, 139);
			this.CreateButton.Margin = new System.Windows.Forms.Padding(0);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(250, 100);
			this.CreateButton.TabIndex = 1;
			this.CreateButton.Text = "إنشاء تقرير جديد";
			this.CreateButton.UseVisualStyleBackColor = false;
			this.CreateButton.Click += new System.EventHandler(this.CreateButtonClick);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 453);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.WelcomeLabel);
			this.Name = "Home";
			this.Text = "Medications";
			this.ResumeLayout(false);

		}
	}
}
