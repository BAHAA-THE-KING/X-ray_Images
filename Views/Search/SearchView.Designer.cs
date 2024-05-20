namespace X_ray_Images.Views.Search
{
    partial class SearchView
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
            showHome();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            Folder_Path = new TextBox();
            browse_button = new Button();
            numeric_minimumSize = new NumericUpDown();
            PhotosLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTime_from = new DateTimePicker();
            numeric_maximumSize = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            dateTime_to = new DateTimePicker();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            comboBox_maxSize = new ComboBox();
            comboBox_minSize = new ComboBox();
            panel3 = new Panel();
            label7 = new Label();
            filter_button = new Button();
            listView = new ListView();
            imageList = new ImageList(components);
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_minimumSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_maximumSize).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(0, 180, 216);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, -16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1501, 107);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 37);
            label1.Name = "label1";
            label1.Size = new Size(1478, 56);
            label1.TabIndex = 0;
            label1.Text = "البحث في الصور وفقاً للحجم وتاريخ التعديل";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Folder_Path
            // 
            Folder_Path.Location = new Point(54, 112);
            Folder_Path.Name = "Folder_Path";
            Folder_Path.ReadOnly = true;
            Folder_Path.Size = new Size(426, 27);
            Folder_Path.TabIndex = 9;
            // 
            // browse_button
            // 
            browse_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            browse_button.Location = new Point(486, 109);
            browse_button.Name = "browse_button";
            browse_button.Size = new Size(88, 34);
            browse_button.TabIndex = 10;
            browse_button.Text = "تصفح";
            browse_button.UseVisualStyleBackColor = true;
            browse_button.Click += browse_button_Click;
            // 
            // numeric_minimumSize
            // 
            numeric_minimumSize.Location = new Point(95, 102);
            numeric_minimumSize.Maximum = new decimal(new int[] { 16000, 0, 0, 0 });
            numeric_minimumSize.Name = "numeric_minimumSize";
            numeric_minimumSize.Size = new Size(77, 27);
            numeric_minimumSize.TabIndex = 11;
            // 
            // PhotosLabel
            // 
            PhotosLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhotosLabel.Font = new Font("Dubai", 15F);
            PhotosLabel.ForeColor = Color.FromArgb(0, 0, 64);
            PhotosLabel.Location = new Point(964, 108);
            PhotosLabel.Name = "PhotosLabel";
            PhotosLabel.RightToLeft = RightToLeft.Yes;
            PhotosLabel.Size = new Size(0, 56);
            PhotosLabel.TabIndex = 12;
            PhotosLabel.Text = "اختر المجلد المطلوب";
            PhotosLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.LightSeaGreen;
            label2.Font = new Font("Dubai", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 12);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(183, 86);
            label2.TabIndex = 13;
            label2.Text = "حجم الصور";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.LightSeaGreen;
            label3.Font = new Font("Dubai", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(298, 12);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(295, 86);
            label3.TabIndex = 14;
            label3.Text = "تاريخ آخر تعديل";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTime_from
            // 
            dateTime_from.Location = new Point(309, 99);
            dateTime_from.Name = "dateTime_from";
            dateTime_from.Size = new Size(250, 27);
            dateTime_from.TabIndex = 15;
            dateTime_from.Value = new DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // numeric_maximumSize
            // 
            numeric_maximumSize.Location = new Point(95, 156);
            numeric_maximumSize.Maximum = new decimal(new int[] { 16000, 0, 0, 0 });
            numeric_maximumSize.Name = "numeric_maximumSize";
            numeric_maximumSize.Size = new Size(77, 27);
            numeric_maximumSize.TabIndex = 17;
            numeric_maximumSize.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.LightSeaGreen;
            label5.Font = new Font("Dubai", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(562, 76);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(37, 66);
            label5.TabIndex = 19;
            label5.Text = "من";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.LightSeaGreen;
            label6.Font = new Font("Dubai", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(559, 131);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(49, 74);
            label6.TabIndex = 20;
            label6.Text = "حتّى";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTime_to
            // 
            dateTime_to.Location = new Point(309, 157);
            dateTime_to.Name = "dateTime_to";
            dateTime_to.Size = new Size(250, 27);
            dateTime_to.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dateTime_from);
            panel2.Controls.Add(dateTime_to);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox_maxSize);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox_minSize);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(numeric_maximumSize);
            panel2.Controls.Add(numeric_minimumSize);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(861, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 226);
            panel2.TabIndex = 22;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.BackColor = Color.LightSeaGreen;
            label9.Font = new Font("Dubai", 11F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(174, 136);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(113, 68);
            label9.TabIndex = 26;
            label9.Text = "الحجم الأعلى";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.BackColor = Color.LightSeaGreen;
            label8.Font = new Font("Dubai", 11F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(175, 80);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(105, 68);
            label8.TabIndex = 24;
            label8.Text = "الحجم الأدنى";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox_maxSize
            // 
            comboBox_maxSize.FormattingEnabled = true;
            comboBox_maxSize.Items.AddRange(new object[] { "MB", "KB" });
            comboBox_maxSize.Location = new Point(28, 156);
            comboBox_maxSize.Name = "comboBox_maxSize";
            comboBox_maxSize.Size = new Size(55, 28);
            comboBox_maxSize.TabIndex = 25;
            // 
            // comboBox_minSize
            // 
            comboBox_minSize.FormattingEnabled = true;
            comboBox_minSize.Items.AddRange(new object[] { "MB", "KB" });
            comboBox_minSize.Location = new Point(28, 102);
            comboBox_minSize.Name = "comboBox_minSize";
            comboBox_minSize.Size = new Size(55, 28);
            comboBox_minSize.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSeaGreen;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(browse_button);
            panel3.Controls.Add(Folder_Path);
            panel3.Location = new Point(861, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 202);
            panel3.TabIndex = 23;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = Color.MediumSeaGreen;
            label7.Font = new Font("Dubai", 15F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(146, 11);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(325, 73);
            label7.TabIndex = 15;
            label7.Text = "اختر المجلد الذي تريد البحث فيه";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filter_button
            // 
            filter_button.Font = new Font("Segoe UI", 30F);
            filter_button.Location = new Point(861, 537);
            filter_button.Name = "filter_button";
            filter_button.Size = new Size(623, 195);
            filter_button.TabIndex = 24;
            filter_button.Text = "فلترة";
            filter_button.UseVisualStyleBackColor = true;
            filter_button.Click += filter_button_Click;
            // 
            // listView
            // 
            listView.LargeImageList = imageList;
            listView.Location = new Point(6, 173);
            listView.Name = "listView";
            listView.Size = new Size(849, 559);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(100, 100);
            imageList.TransparentColor = Color.Transparent;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.BackColor = Color.FromArgb(196, 211, 249);
            label10.Font = new Font("Dubai", 20F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(6, 101);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(849, 66);
            label10.TabIndex = 25;
            label10.Text = "نتائج البحث";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 211, 249);
            ClientSize = new Size(1487, 744);
            Controls.Add(filter_button);
            Controls.Add(label10);
            Controls.Add(listView);
            Controls.Add(PhotosLabel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SearchView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchView";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numeric_minimumSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_maximumSize).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox Folder_Path;
        private Button browse_button;
        private NumericUpDown numeric_minimumSize;
        private Label PhotosLabel;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTime_from;
        private NumericUpDown numeric_maximumSize;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTime_to;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private ComboBox comboBox_maxSize;
        private ComboBox comboBox_minSize;
        private Button filter_button;
        private Label label9;
        private Label label8;
        private ListView listView;
        private ImageList imageList;
        private Label label10;
    }
}