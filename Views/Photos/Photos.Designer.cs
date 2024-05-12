using System.Drawing;
using System.Windows.Forms;

namespace X_ray_Images
{
    partial class Photos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Photos));
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            text = new PictureBox();
            select = new PictureBox();
            MainImage = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            ToolsToolStripMenuItem = new ToolStripMenuItem();
            CompareMenuItem = new ToolStripMenuItem();
            green2red = new PictureBox();
            orange2purple = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)select).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)green2red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orange2purple).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Italic);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(497, 44);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(464, 73);
            label1.TabIndex = 8;
            label1.Text = "Select a Photo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_crop_64;
            pictureBox2.Location = new Point(8, 267);
            pictureBox2.Margin = new Padding(5, 4, 5, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.icons8_color_64;
            pictureBox5.Location = new Point(8, 348);
            pictureBox5.Margin = new Padding(5, 4, 5, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 72);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // text
            // 
            text.Cursor = Cursors.Hand;
            text.Image = Properties.Resources.icons8_text_50;
            text.Location = new Point(8, 187);
            text.Margin = new Padding(5, 4, 5, 4);
            text.Name = "text";
            text.Size = new Size(57, 71);
            text.SizeMode = PictureBoxSizeMode.Zoom;
            text.TabIndex = 12;
            text.TabStop = false;
            // 
            // select
            // 
            select.Cursor = Cursors.Hand;
            select.Image = Properties.Resources.icons8_crop_58;
            select.Location = new Point(8, 115);
            select.Margin = new Padding(5, 4, 5, 4);
            select.Name = "select";
            select.Size = new Size(57, 63);
            select.SizeMode = PictureBoxSizeMode.Zoom;
            select.TabIndex = 11;
            select.TabStop = false;
            select.Click += select_Click;
            // 
            // MainImage
            // 
            MainImage.BackColor = SystemColors.ButtonFace;
            MainImage.BorderStyle = BorderStyle.Fixed3D;
            MainImage.Location = new Point(274, 163);
            MainImage.Margin = new Padding(5, 4, 5, 4);
            MainImage.Name = "MainImage";
            MainImage.Size = new Size(914, 665);
            MainImage.TabIndex = 10;
            MainImage.TabStop = false;
            MainImage.Click += MainImageClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1121, 55);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 87);
            button1.TabIndex = 9;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 592);
            pictureBox3.Margin = new Padding(5, 4, 5, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, ToolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1527, 30);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 24);
            fileToolStripMenuItem.Text = "ملف";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(122, 26);
            saveToolStripMenuItem.Text = "حفط";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(122, 26);
            openToolStripMenuItem.Text = "فتح";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // ToolsToolStripMenuItem
            // 
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CompareMenuItem });
            ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            ToolsToolStripMenuItem.Size = new Size(61, 24);
            ToolsToolStripMenuItem.Text = "أدوات";
            // 
            // CompareMenuItem
            // 
            CompareMenuItem.Name = "CompareMenuItem";
            CompareMenuItem.Size = new Size(224, 26);
            CompareMenuItem.Text = "مقارنة";
            // 
            // green2red
            // 
            green2red.Cursor = Cursors.Hand;
            green2red.Image = (Image)resources.GetObject("green2red.Image");
            green2red.Location = new Point(8, 428);
            green2red.Margin = new Padding(5, 4, 5, 4);
            green2red.Name = "green2red";
            green2red.Size = new Size(57, 72);
            green2red.SizeMode = PictureBoxSizeMode.Zoom;
            green2red.TabIndex = 17;
            green2red.TabStop = false;
            green2red.Click += pictureBox4_Click;
            // 
            // orange2purple
            // 
            orange2purple.Cursor = Cursors.Hand;
            orange2purple.Image = (Image)resources.GetObject("orange2purple.Image");
            orange2purple.Location = new Point(8, 508);
            orange2purple.Margin = new Padding(5, 4, 5, 4);
            orange2purple.Name = "orange2purple";
            orange2purple.Size = new Size(57, 72);
            orange2purple.SizeMode = PictureBoxSizeMode.Zoom;
            orange2purple.TabIndex = 18;
            orange2purple.TabStop = false;
            orange2purple.Click += pictureBox6_Click;
            // 
            // Photos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 959);
            Controls.Add(orange2purple);
            Controls.Add(green2red);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(text);
            Controls.Add(select);
            Controls.Add(MainImage);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Photos";
            Text = "Photos";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)text).EndInit();
            ((System.ComponentModel.ISupportInitialize)select).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)green2red).EndInit();
            ((System.ComponentModel.ISupportInitialize)orange2purple).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox text;
        private PictureBox select;
        private PictureBox MainImage;
        private Button button1;
        private PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem ToolsToolStripMenuItem;
        private ToolStripMenuItem CompareMenuItem;
        private PictureBox green2red;
        private PictureBox orange2purple;
    }
}