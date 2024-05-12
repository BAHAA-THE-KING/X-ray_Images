using System.Drawing;
using System.Windows.Forms;
namespace X_ray_Images
{
    partial class Photos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Photos));
            this.CropImage = new System.Windows.Forms.PictureBox();
            this.Red2BlueImage = new System.Windows.Forms.PictureBox();
            this.TextImage = new System.Windows.Forms.PictureBox();
            this.SelectImage = new System.Windows.Forms.PictureBox();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.FileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AddImageToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImageToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteImageToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CompareToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CurveImage = new System.Windows.Forms.PictureBox();
            this.GeometryImage = new System.Windows.Forms.PictureBox();
            this.RecordImage = new System.Windows.Forms.PictureBox();
            this.Orange2PurpleImage = new System.Windows.Forms.PictureBox();
            this.ColorMapImage = new System.Windows.Forms.PictureBox();
            this.GalleryPanel = new System.Windows.Forms.Panel();
            this.DangerToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CropImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red2BlueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeometryImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange2PurpleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorMapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CropImage
            // 
            this.CropImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CropImage.Image = ((System.Drawing.Image)(resources.GetObject("CropImage.Image")));
            this.CropImage.Location = new System.Drawing.Point(7, 64);
            this.CropImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CropImage.Name = "CropImage";
            this.CropImage.Size = new System.Drawing.Size(50, 50);
            this.CropImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CropImage.TabIndex = 14;
            this.CropImage.TabStop = false;
            // 
            // Red2BlueImage
            // 
            this.Red2BlueImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Red2BlueImage.Image = ((System.Drawing.Image)(resources.GetObject("Red2BlueImage.Image")));
            this.Red2BlueImage.Location = new System.Drawing.Point(13, 200);
            this.Red2BlueImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Red2BlueImage.Name = "Red2BlueImage";
            this.Red2BlueImage.Size = new System.Drawing.Size(50, 50);
            this.Red2BlueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Red2BlueImage.TabIndex = 13;
            this.Red2BlueImage.TabStop = false;
            this.Red2BlueImage.Click += new System.EventHandler(this.Red2BlueImage_Click);
            // 
            // TextImage
            // 
            this.TextImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextImage.Image = ((System.Drawing.Image)(resources.GetObject("TextImage.Image")));
            this.TextImage.Location = new System.Drawing.Point(79, 200);
            this.TextImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextImage.Name = "TextImage";
            this.TextImage.Size = new System.Drawing.Size(50, 50);
            this.TextImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TextImage.TabIndex = 12;
            this.TextImage.TabStop = false;
            // 
            // SelectImage
            // 
            this.SelectImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectImage.Image = ((System.Drawing.Image)(resources.GetObject("SelectImage.Image")));
            this.SelectImage.Location = new System.Drawing.Point(7, 133);
            this.SelectImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(50, 50);
            this.SelectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectImage.TabIndex = 11;
            this.SelectImage.TabStop = false;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
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
            // 
            // ToolBar
            // 
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStrip,
            this.ToolsToolStrip});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolBar.Size = new System.Drawing.Size(1173, 28);
            this.ToolBar.TabIndex = 16;
            this.ToolBar.Text = "ToolBar";
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImageToolStrip,
            this.SaveImageToolStrip,
            this.DeleteImageToolStrip});
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(50, 24);
            this.FileToolStrip.Text = "ملف";
            // 
            // AddImageToolStrip
            // 
            this.AddImageToolStrip.Name = "AddImageToolStrip";
            this.AddImageToolStrip.Size = new System.Drawing.Size(123, 26);
            this.AddImageToolStrip.Text = "إضافة";
            this.AddImageToolStrip.Click += new System.EventHandler(this.New_Click);
            // 
            // SaveImageToolStrip
            // 
            this.SaveImageToolStrip.Name = "SaveImageToolStrip";
            this.SaveImageToolStrip.Size = new System.Drawing.Size(123, 26);
            this.SaveImageToolStrip.Text = "حفظ";
            this.SaveImageToolStrip.Click += saveToolStripMenuItem_Click;
            // 
            // DeleteImageToolStrip
            // 
            this.DeleteImageToolStrip.Name = "DeleteImageToolStrip";
            this.DeleteImageToolStrip.Size = new System.Drawing.Size(123, 26);
            this.DeleteImageToolStrip.Text = "حذف";
            // 
            // ToolsToolStrip
            // 
            this.ToolsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompareToolStrip,
            this.DangerToolStrip});
            this.ToolsToolStrip.Name = "ToolsToolStrip";
            this.ToolsToolStrip.Size = new System.Drawing.Size(68, 24);
            this.ToolsToolStrip.Text = "الأدوات";
            // 
            // CompareToolStrip
            // 
            this.CompareToolStrip.Name = "CompareToolStrip";
            this.CompareToolStrip.Size = new System.Drawing.Size(123, 26);
            this.CompareToolStrip.Text = "مقارنة";
            this.CompareToolStrip.Click += new System.EventHandler(this.Compare_Click);
            // 
            // DangerToolStrip
            // 
            this.DangerToolStrip.Name = "DangerToolStrip";
            this.DangerToolStrip.Size = new System.Drawing.Size(215, 26);
            this.DangerToolStrip.Text = "تحديد خطورة الإصابة";
            // 
            // CurveImage
            // 
            this.CurveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurveImage.Image = ((System.Drawing.Image)(resources.GetObject("CurveImage.Image")));
            this.CurveImage.Location = new System.Drawing.Point(79, 64);
            this.CurveImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CurveImage.Name = "CurveImage";
            this.CurveImage.Size = new System.Drawing.Size(50, 50);
            this.CurveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurveImage.TabIndex = 17;
            this.CurveImage.TabStop = false;
            // 
            // GeometryImage
            // 
            this.GeometryImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeometryImage.Image = ((System.Drawing.Image)(resources.GetObject("GeometryImage.Image")));
            this.GeometryImage.Location = new System.Drawing.Point(79, 133);
            this.GeometryImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GeometryImage.Name = "GeometryImage";
            this.GeometryImage.Size = new System.Drawing.Size(50, 50);
            this.GeometryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeometryImage.TabIndex = 18;
            this.GeometryImage.TabStop = false;
            // 
            // RecordImage
            // 
            this.RecordImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordImage.Image = ((System.Drawing.Image)(resources.GetObject("RecordImage.Image")));
            this.RecordImage.Location = new System.Drawing.Point(79, 270);
            this.RecordImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RecordImage.Name = "RecordImage";
            this.RecordImage.Size = new System.Drawing.Size(50, 50);
            this.RecordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecordImage.TabIndex = 19;
            this.RecordImage.TabStop = false;
            // 
            // Orange2PurpleImage
            // 
            this.Orange2PurpleImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orange2PurpleImage.Image = ((System.Drawing.Image)(resources.GetObject("Orange2PurpleImage.Image")));
            this.Orange2PurpleImage.Location = new System.Drawing.Point(13, 270);
            this.Orange2PurpleImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Orange2PurpleImage.Name = "Orange2PurpleImage";
            this.Orange2PurpleImage.Size = new System.Drawing.Size(50, 50);
            this.Orange2PurpleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Orange2PurpleImage.TabIndex = 21;
            this.Orange2PurpleImage.TabStop = false;
            // 
            // ColorMapImage
            // 
            this.ColorMapImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorMapImage.Image = ((System.Drawing.Image)(resources.GetObject("ColorMapImage.Image")));
            this.ColorMapImage.Location = new System.Drawing.Point(13, 340);
            this.ColorMapImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ColorMapImage.Name = "ColorMapImage";
            this.ColorMapImage.Size = new System.Drawing.Size(50, 50);
            this.ColorMapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ColorMapImage.TabIndex = 20;
            this.ColorMapImage.TabStop = false;
            // 
            // GalleryPanel
            // 
            this.GalleryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GalleryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GalleryPanel.Location = new System.Drawing.Point(0, 520);
            this.GalleryPanel.Name = "GalleryPanel";
            this.GalleryPanel.Size = new System.Drawing.Size(1173, 161);
            this.GalleryPanel.TabIndex = 23;
            // 
            // Photos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 681);
            this.Controls.Add(this.GalleryPanel);
            this.Controls.Add(this.Orange2PurpleImage);
            this.Controls.Add(this.ColorMapImage);
            this.Controls.Add(this.RecordImage);
            this.Controls.Add(this.GeometryImage);
            this.Controls.Add(this.CurveImage);
            this.Controls.Add(this.CropImage);
            this.Controls.Add(this.Red2BlueImage);
            this.Controls.Add(this.TextImage);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.MainImage);
            this.Controls.Add(this.ToolBar);
            this.MainMenuStrip = this.ToolBar;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Photos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Photos";
            ((System.ComponentModel.ISupportInitialize)(this.CropImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red2BlueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeometryImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orange2PurpleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorMapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox CropImage;
        private PictureBox Red2BlueImage;
        private PictureBox TextImage;
        private PictureBox SelectImage;
        private PictureBox MainImage;
        private MenuStrip ToolBar;
        private ToolStripMenuItem FileToolStrip;
        private ToolStripMenuItem SaveImageToolStrip;
        private ToolStripMenuItem ToolsToolStrip;
        private ToolStripMenuItem CompareToolStrip;
        private PictureBox CurveImage;
        private PictureBox GeometryImage;
        private System.Windows.Forms.PictureBox RecordImage;
        private System.Windows.Forms.PictureBox Orange2PurpleImage;
        private System.Windows.Forms.PictureBox ColorMapImage;
        private System.Windows.Forms.Panel GalleryPanel;
        private System.Windows.Forms.ToolStripMenuItem AddImageToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteImageToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DangerToolStrip;
    }
}
