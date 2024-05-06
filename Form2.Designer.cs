namespace X_ray_Images
{
    partial class Form2
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
            first = new PictureBox();
            second = new PictureBox();
            firsttext = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)first).BeginInit();
            ((System.ComponentModel.ISupportInitialize)second).BeginInit();
            SuspendLayout();
            // 
            // first
            // 
            first.Location = new Point(70, 62);
            first.Name = "first";
            first.Size = new Size(489, 440);
            first.SizeMode = PictureBoxSizeMode.Zoom;
            first.TabIndex = 0;
            first.TabStop = false;
            first.Click += first_Click;
            // 
            // second
            // 
            second.Location = new Point(582, 62);
            second.Name = "second";
            second.Size = new Size(496, 440);
            second.SizeMode = PictureBoxSizeMode.Zoom;
            second.TabIndex = 1;
            second.TabStop = false;
            // 
            // firsttext
            // 
            firsttext.AutoSize = true;
            firsttext.Location = new Point(541, 529);
            firsttext.Name = "firsttext";
            firsttext.Size = new Size(0, 15);
            firsttext.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(507, 22);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 4;
            label3.Text = "Compare Two Images";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(195, 564);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(131, 65);
            button1.TabIndex = 10;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(773, 564);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(131, 65);
            button2.TabIndex = 11;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(483, 564);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(131, 65);
            button3.TabIndex = 12;
            button3.Text = "Compare";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 641);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(firsttext);
            Controls.Add(second);
            Controls.Add(first);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)first).EndInit();
            ((System.ComponentModel.ISupportInitialize)second).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox first;
        private PictureBox second;
        private Label firsttext;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}