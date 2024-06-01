using System.Drawing;
using System.Windows.Forms;
namespace X_ray_Images
{
    partial class Photos
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            CreateReport.isPhotosOpen = false;
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
            CropImage = new PictureBox();
            Red2BlueImage = new PictureBox();
            TextImage = new PictureBox();
            SelectImage = new PictureBox();
            MainImage = new PictureBox();
            ToolBar = new MenuStrip();
            FileToolStrip = new ToolStripMenuItem();
            AddImageToolStrip = new ToolStripMenuItem();
            SaveImageToolStrip = new ToolStripMenuItem();
            DeleteImageToolStrip = new ToolStripMenuItem();
            ToolsToolStrip = new ToolStripMenuItem();
            CompareToolStrip = new ToolStripMenuItem();
            DangerToolStrip = new ToolStripMenuItem();
            HeartToolStrip = new ToolStripMenuItem();
            CurveImage = new PictureBox();
            GeometryImage = new PictureBox();
            RecordImage = new PictureBox();
            Orange2PurpleImage = new PictureBox();
            WhatsAppImage = new PictureBox();
            GalleryPanel = new Panel();
            ClearImage = new PictureBox();
            CreateButton = new Button();
            Telegram = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CropImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Red2BlueImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TextImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).BeginInit();
            ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CurveImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GeometryImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecordImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Orange2PurpleImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClearImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Telegram).BeginInit();
            SuspendLayout();
            // 
            // CropImage
            // 
            CropImage.Cursor = Cursors.Hand;
            CropImage.Image = (Image)resources.GetObject("CropImage.Image");
            CropImage.Location = new Point(8, 50);
            CropImage.Margin = new Padding(5, 4, 5, 4);
            CropImage.Name = "CropImage";
            CropImage.Size = new Size(57, 62);
            CropImage.SizeMode = PictureBoxSizeMode.Zoom;
            CropImage.TabIndex = 14;
            CropImage.TabStop = false;
            CropImage.Click += CropImage_Click;
            // 
            // Red2BlueImage
            // 
            Red2BlueImage.Cursor = Cursors.Hand;
            Red2BlueImage.Image = (Image)resources.GetObject("Red2BlueImage.Image");
            Red2BlueImage.Location = new Point(15, 220);
            Red2BlueImage.Margin = new Padding(5, 4, 5, 4);
            Red2BlueImage.Name = "Red2BlueImage";
            Red2BlueImage.Size = new Size(57, 62);
            Red2BlueImage.SizeMode = PictureBoxSizeMode.Zoom;
            Red2BlueImage.TabIndex = 13;
            Red2BlueImage.TabStop = false;
            Red2BlueImage.Click += Red2BlueImage_Click;
            // 
            // TextImage
            // 
            TextImage.Cursor = Cursors.Hand;
            TextImage.Image = (Image)resources.GetObject("TextImage.Image");
            TextImage.Location = new Point(90, 220);
            TextImage.Margin = new Padding(5, 4, 5, 4);
            TextImage.Name = "TextImage";
            TextImage.Size = new Size(57, 62);
            TextImage.SizeMode = PictureBoxSizeMode.Zoom;
            TextImage.TabIndex = 12;
            TextImage.TabStop = false;
            TextImage.Click += TextImage_Click;
            // 
            // SelectImage
            // 
            SelectImage.Cursor = Cursors.Hand;
            SelectImage.Image = (Image)resources.GetObject("SelectImage.Image");
            SelectImage.Location = new Point(8, 136);
            SelectImage.Margin = new Padding(5, 4, 5, 4);
            SelectImage.Name = "SelectImage";
            SelectImage.Size = new Size(57, 62);
            SelectImage.SizeMode = PictureBoxSizeMode.Zoom;
            SelectImage.TabIndex = 11;
            SelectImage.TabStop = false;
            SelectImage.Click += SelectImage_Click;
            // 
            // MainImage
            // 
            MainImage.BackColor = SystemColors.ButtonFace;
            MainImage.BorderStyle = BorderStyle.Fixed3D;
            MainImage.Location = new Point(187, 55);
            MainImage.Margin = new Padding(5, 4, 5, 4);
            MainImage.Name = "MainImage";
            MainImage.Size = new Size(1124, 565);
            MainImage.TabIndex = 10;
            MainImage.TabStop = false;
            MainImage.Click += MainImage_Click;
            MainImage.Paint += MainImage_Paint;
            MainImage.MouseDown += MainImage_MouseDown;
            MainImage.MouseMove += MainImage_MouseMove;
            MainImage.MouseUp += MainImage_MouseUp;
            // 
            // ToolBar
            // 
            ToolBar.ImageScalingSize = new Size(20, 20);
            ToolBar.Items.AddRange(new ToolStripItem[] { FileToolStrip, ToolsToolStrip });
            ToolBar.Location = new Point(0, 0);
            ToolBar.Name = "ToolBar";
            ToolBar.Padding = new Padding(7, 2, 0, 2);
            ToolBar.RightToLeft = RightToLeft.Yes;
            ToolBar.Size = new Size(1341, 28);
            ToolBar.TabIndex = 16;
            ToolBar.Text = "ToolBar";
            // 
            // FileToolStrip
            // 
            FileToolStrip.DropDownItems.AddRange(new ToolStripItem[] { AddImageToolStrip, SaveImageToolStrip, DeleteImageToolStrip });
            FileToolStrip.Name = "FileToolStrip";
            FileToolStrip.Size = new Size(52, 24);
            FileToolStrip.Text = "ملف";
            // 
            // AddImageToolStrip
            // 
            AddImageToolStrip.Name = "AddImageToolStrip";
            AddImageToolStrip.Size = new Size(131, 26);
            AddImageToolStrip.Text = "إضافة";
            AddImageToolStrip.Click += New_Click;
            // 
            // SaveImageToolStrip
            // 
            SaveImageToolStrip.Name = "SaveImageToolStrip";
            SaveImageToolStrip.Size = new Size(131, 26);
            SaveImageToolStrip.Text = "حفظ";
            SaveImageToolStrip.Click += Save_Click;
            // 
            // DeleteImageToolStrip
            // 
            DeleteImageToolStrip.Name = "DeleteImageToolStrip";
            DeleteImageToolStrip.Size = new Size(131, 26);
            DeleteImageToolStrip.Text = "حذف";
            DeleteImageToolStrip.Click += Delete_Click;
            // 
            // ToolsToolStrip
            // 
            ToolsToolStrip.DropDownItems.AddRange(new ToolStripItem[] { CompareToolStrip, DangerToolStrip, HeartToolStrip });
            ToolsToolStrip.Name = "ToolsToolStrip";
            ToolsToolStrip.Size = new Size(70, 24);
            ToolsToolStrip.Text = "الأدوات";
            // 
            // CompareToolStrip
            // 
            CompareToolStrip.Name = "CompareToolStrip";
            CompareToolStrip.Size = new Size(223, 26);
            CompareToolStrip.Text = "مقارنة";
            CompareToolStrip.Click += Compare_Click;
            // 
            // DangerToolStrip
            // 
            DangerToolStrip.Name = "DangerToolStrip";
            DangerToolStrip.Size = new Size(223, 26);
            DangerToolStrip.Text = "تحديد خطورة الإصابة";
            DangerToolStrip.Click += Danger_Click;
            // 
            // HeartToolStrip
            // 
            HeartToolStrip.Name = "HeartToolStrip";
            HeartToolStrip.Size = new Size(223, 26);
            HeartToolStrip.Text = "الكشف عن مرض تضخم القلب";
            HeartToolStrip.Click += Heart_Click;
            // 
            // CurveImage
            // 
            CurveImage.Cursor = Cursors.Hand;
            CurveImage.Image = (Image)resources.GetObject("CurveImage.Image");
            CurveImage.Location = new Point(90, 50);
            CurveImage.Margin = new Padding(5, 4, 5, 4);
            CurveImage.Name = "CurveImage";
            CurveImage.Size = new Size(57, 62);
            CurveImage.SizeMode = PictureBoxSizeMode.Zoom;
            CurveImage.TabIndex = 17;
            CurveImage.TabStop = false;
            CurveImage.Click += Free_Click;
            // 
            // GeometryImage
            // 
            GeometryImage.Cursor = Cursors.Hand;
            GeometryImage.Image = (Image)resources.GetObject("GeometryImage.Image");
            GeometryImage.Location = new Point(90, 136);
            GeometryImage.Margin = new Padding(5, 4, 5, 4);
            GeometryImage.Name = "GeometryImage";
            GeometryImage.Size = new Size(57, 62);
            GeometryImage.SizeMode = PictureBoxSizeMode.Zoom;
            GeometryImage.TabIndex = 18;
            GeometryImage.TabStop = false;
            GeometryImage.Click += Shape_Click;
            // 
            // RecordImage
            // 
            RecordImage.Cursor = Cursors.Hand;
            RecordImage.Image = (Image)resources.GetObject("RecordImage.Image");
            RecordImage.Location = new Point(90, 308);
            RecordImage.Margin = new Padding(5, 4, 5, 4);
            RecordImage.Name = "RecordImage";
            RecordImage.Size = new Size(57, 62);
            RecordImage.SizeMode = PictureBoxSizeMode.Zoom;
            RecordImage.TabIndex = 19;
            RecordImage.TabStop = false;
            RecordImage.Click += RecordImage_Click;
            // 
            // Orange2PurpleImage
            // 
            Orange2PurpleImage.Cursor = Cursors.Hand;
            Orange2PurpleImage.Image = (Image)resources.GetObject("Orange2PurpleImage.Image");
            Orange2PurpleImage.Location = new Point(15, 308);
            Orange2PurpleImage.Margin = new Padding(5, 4, 5, 4);
            Orange2PurpleImage.Name = "Orange2PurpleImage";
            Orange2PurpleImage.Size = new Size(57, 62);
            Orange2PurpleImage.SizeMode = PictureBoxSizeMode.Zoom;
            Orange2PurpleImage.TabIndex = 21;
            Orange2PurpleImage.TabStop = false;
            Orange2PurpleImage.Click += Orange2PurpleImage_Click;
            // 
            // WhatsAppImage
            // 
            WhatsAppImage.Cursor = Cursors.Hand;
            WhatsAppImage.Image = (Image)resources.GetObject("WhatsAppImage.Image");
            WhatsAppImage.Location = new Point(15, 395);
            WhatsAppImage.Margin = new Padding(5, 4, 5, 4);
            WhatsAppImage.Name = "WhatsAppImage";
            WhatsAppImage.Size = new Size(57, 62);
            WhatsAppImage.SizeMode = PictureBoxSizeMode.Zoom;
            WhatsAppImage.TabIndex = 20;
            WhatsAppImage.TabStop = false;
            WhatsAppImage.Click += WhatsApp_Click;
            // 
            // GalleryPanel
            // 
            GalleryPanel.BorderStyle = BorderStyle.FixedSingle;
            GalleryPanel.Dock = DockStyle.Bottom;
            GalleryPanel.Location = new Point(0, 650);
            GalleryPanel.Margin = new Padding(3, 4, 3, 4);
            GalleryPanel.Name = "GalleryPanel";
            GalleryPanel.Size = new Size(1341, 201);
            GalleryPanel.TabIndex = 23;
            // 
            // ClearImage
            // 
            ClearImage.Cursor = Cursors.Hand;
            ClearImage.Image = (Image)resources.GetObject("ClearImage.Image");
            ClearImage.Location = new Point(90, 395);
            ClearImage.Margin = new Padding(5, 4, 5, 4);
            ClearImage.Name = "ClearImage";
            ClearImage.Size = new Size(57, 62);
            ClearImage.SizeMode = PictureBoxSizeMode.Zoom;
            ClearImage.TabIndex = 24;
            ClearImage.TabStop = false;
            ClearImage.Click += Clear_Click;
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateButton.BackColor = SystemColors.MenuHighlight;
            CreateButton.Cursor = Cursors.Hand;
            CreateButton.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateButton.ForeColor = SystemColors.ButtonHighlight;
            CreateButton.Location = new Point(8, 550);
            CreateButton.Margin = new Padding(0);
            CreateButton.MaximumSize = new Size(167, 95);
            CreateButton.MinimumSize = new Size(167, 95);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(167, 95);
            CreateButton.TabIndex = 26;
            CreateButton.Text = "إضافة صورة";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += New_Click;
            // 
            // Telegram
            // 
            Telegram.Cursor = Cursors.Hand;
            Telegram.Image = (Image)resources.GetObject("Telegram.Image");
            Telegram.Location = new Point(15, 483);
            Telegram.Margin = new Padding(5, 4, 5, 4);
            Telegram.Name = "Telegram";
            Telegram.Size = new Size(57, 62);
            Telegram.SizeMode = PictureBoxSizeMode.Zoom;
            Telegram.TabIndex = 27;
            Telegram.TabStop = false;
            Telegram.Click += Telegram_Click;
            // 
            // Photos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 851);
            Controls.Add(Telegram);
            Controls.Add(CreateButton);
            Controls.Add(ClearImage);
            Controls.Add(GalleryPanel);
            Controls.Add(Orange2PurpleImage);
            Controls.Add(WhatsAppImage);
            Controls.Add(RecordImage);
            Controls.Add(GeometryImage);
            Controls.Add(CurveImage);
            Controls.Add(CropImage);
            Controls.Add(Red2BlueImage);
            Controls.Add(TextImage);
            Controls.Add(SelectImage);
            Controls.Add(MainImage);
            Controls.Add(ToolBar);
            MainMenuStrip = ToolBar;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Photos";
            RightToLeft = RightToLeft.Yes;
            Text = "Photos";
            ((System.ComponentModel.ISupportInitialize)CropImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Red2BlueImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)TextImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).EndInit();
            ToolBar.ResumeLayout(false);
            ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CurveImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)GeometryImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecordImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Orange2PurpleImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClearImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Telegram).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.PictureBox WhatsAppImage;
        private System.Windows.Forms.Panel GalleryPanel;
        private System.Windows.Forms.ToolStripMenuItem AddImageToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteImageToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DangerToolStrip;
        private System.Windows.Forms.ToolStripMenuItem HeartToolStrip;
        private System.Windows.Forms.PictureBox ClearImage;
        private Button CreateButton;
        private PictureBox Telegram;
    }
}
