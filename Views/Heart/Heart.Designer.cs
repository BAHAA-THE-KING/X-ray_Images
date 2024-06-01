using System.Drawing;
using System.Windows.Forms;
namespace X_ray_Images
{
	partial class Heart
	{
		private System.ComponentModel.IContainer components = null;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Heart));
			this.MainImage = new System.Windows.Forms.PictureBox();
			this.SelectImage = new System.Windows.Forms.PictureBox();
			this.ScanImage = new System.Windows.Forms.PictureBox();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.ResultText = new System.Windows.Forms.Label();
			this.PickerButton = new Button();
			((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SelectImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ScanImage)).BeginInit();
			this.SuspendLayout();
			// 
			// MainImage
			// 
			this.MainImage.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.MainImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.MainImage.Location = new System.Drawing.Point(164, 44);
			this.MainImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MainImage.Name = "MainImage";
			this.MainImage.Size = new System.Drawing.Size(984, 453);
			this.MainImage.TabIndex = 10;
			this.MainImage.TabStop = false;
			this.MainImage.MouseDown += MainImage_MouseDown;
			this.MainImage.MouseMove += MainImage_MouseMove;
			this.MainImage.MouseUp += MainImage_MouseUp;
			this.MainImage.Paint += MainImage_Paint;
			// 
			// SelectImage
			// 
			this.SelectImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SelectImage.Image = ((System.Drawing.Image)(resources.GetObject("SelectImage.Image")));
			this.SelectImage.Location = new System.Drawing.Point(7, 64);
			this.SelectImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SelectImage.Name = "SelectImage";
			this.SelectImage.Size = new System.Drawing.Size(50, 50);
			this.SelectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SelectImage.TabIndex = 11;
			this.SelectImage.TabStop = false;
			this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
			// 
			// ScanImage
			// 
			this.ScanImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ScanImage.Image = ((System.Drawing.Image)(resources.GetObject("ScanImage.Image")));
			this.ScanImage.Location = new System.Drawing.Point(80, 64);
			this.ScanImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ScanImage.Name = "ScanImage";
			this.ScanImage.Size = new System.Drawing.Size(50, 50);
			this.ScanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ScanImage.TabIndex = 12;
			this.ScanImage.TabStop = false;
			this.ScanImage.Click += new System.EventHandler(this.Scan_Click);
			// 
			// ResultLabel
			// 
			this.ResultLabel.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultLabel.Location = new System.Drawing.Point(384, 548);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(439, 53);
			this.ResultLabel.TabIndex = 13;
			// 
			// ResultText
			// 
			this.ResultText.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultText.Location = new System.Drawing.Point(830, 548);
			this.ResultText.Name = "ResultText";
			this.ResultText.Size = new System.Drawing.Size(72, 53);
			this.ResultText.TabIndex = 14;
			this.ResultText.Text = "النتيجة:";
			// 
			// PickerButton
			// 
			PickerButton.BackColor = SystemColors.ActiveCaption;
			PickerButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			PickerButton.ForeColor = Color.White;
			PickerButton.Location = new Point(943, 548);
			PickerButton.Margin = new Padding(4, 3, 4, 3);
			PickerButton.Name = "PickerButton";
			PickerButton.Size = new Size(131, 65);
			PickerButton.TabIndex = 11;
			PickerButton.Text = "Browse";
			PickerButton.UseVisualStyleBackColor = false;
			PickerButton.Click += PickerButton_Click;
			// 
			// Heart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1173, 681);
			this.Controls.Add(this.PickerButton);
			this.Controls.Add(this.ResultText);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.ScanImage);
			this.Controls.Add(this.SelectImage);
			this.Controls.Add(this.MainImage);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Heart";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "الكشف عن تضخم القلب";
			((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SelectImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ScanImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureBox SelectImage;
		private PictureBox MainImage;
		private System.Windows.Forms.PictureBox ScanImage;
		private System.Windows.Forms.Label ResultLabel;
		private System.Windows.Forms.Label ResultText;
		private Button PickerButton;
	}
}
