using System.Drawing;
using System.Windows.Forms;

namespace X_ray_Images
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            text = new PictureBox();
            select = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            greyScaleToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)select).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(435, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(372, 59);
            label1.TabIndex = 8;
            label1.Text = "Select a Photo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.icons8_crop_64;
            pictureBox2.Location = new Point(7, 200);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.icons8_color_64;
            pictureBox5.Location = new Point(7, 261);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // text
            // 
            text.Cursor = Cursors.Hand;
            text.Image = Properties.Resources.icons8_text_50;
            text.Location = new Point(7, 140);
            text.Margin = new Padding(4, 3, 4, 3);
            text.Name = "text";
            text.Size = new Size(50, 53);
            text.SizeMode = PictureBoxSizeMode.Zoom;
            text.TabIndex = 12;
            text.TabStop = false;
            // 
            // select
            // 
            select.Cursor = Cursors.Hand;
            select.Image = Properties.Resources.icons8_crop_58;
            select.Location = new Point(7, 86);
            select.Margin = new Padding(4, 3, 4, 3);
            select.Name = "select";
            select.Size = new Size(50, 47);
            select.SizeMode = PictureBoxSizeMode.Zoom;
            select.TabIndex = 11;
            select.TabStop = false;
            select.Click += select_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(240, 122);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 500);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(981, 41);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(131, 65);
            button1.TabIndex = 9;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 321);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1336, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greyScaleToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // greyScaleToolStripMenuItem
            // 
            greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            greyScaleToolStripMenuItem.Size = new Size(180, 22);
            greyScaleToolStripMenuItem.Text = "GreyScale";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 719);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(text);
            Controls.Add(select);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)text).EndInit();
            ((System.ComponentModel.ISupportInitialize)select).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox text;
        private PictureBox select;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem greyScaleToolStripMenuItem;
    }
}