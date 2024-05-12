using System.Drawing;
using System.Windows.Forms;

namespace X_ray_Images
{
    partial class Compare
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
            first = new PictureBox();
            second = new PictureBox();
            firsttext = new Label();
            CompareLabel = new Label();
            PickerButton1 = new Button();
            PickerButton2 = new Button();
            CompareButton = new Button();
            ((System.ComponentModel.ISupportInitialize)first).BeginInit();
            ((System.ComponentModel.ISupportInitialize)second).BeginInit();
            SuspendLayout();
            // 
            // first
            // 
            first.BackColor = SystemColors.ButtonFace;
            first.BorderStyle = BorderStyle.Fixed3D;
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
            second.BackColor = SystemColors.ButtonFace;
            second.BorderStyle = BorderStyle.Fixed3D;
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
            // CompareLabel
            // 
            CompareLabel.AutoSize = true;
            CompareLabel.BackColor = SystemColors.GradientInactiveCaption;
            CompareLabel.BorderStyle = BorderStyle.Fixed3D;
            CompareLabel.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CompareLabel.ForeColor = Color.Green;
            CompareLabel.ImageAlign = ContentAlignment.BottomCenter;
            CompareLabel.Location = new Point(471, 15);
            CompareLabel.Name = "CompareLabel";
            CompareLabel.Size = new Size(196, 27);
            CompareLabel.TabIndex = 4;
            CompareLabel.Text = "Compare Two Images";
            // 
            // PickerButton1
            // 
            PickerButton1.BackColor = SystemColors.ActiveCaption;
            PickerButton1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PickerButton1.ForeColor = Color.White;
            PickerButton1.Location = new Point(200, 564);
            PickerButton1.Margin = new Padding(4, 3, 4, 3);
            PickerButton1.Name = "PickerButton1";
            PickerButton1.Size = new Size(131, 65);
            PickerButton1.TabIndex = 10;
            PickerButton1.Text = "Browse";
            PickerButton1.UseVisualStyleBackColor = false;
            PickerButton1.Click += PickerButton1_Click;
            // 
            // PickerButton2
            // 
            PickerButton2.BackColor = SystemColors.ActiveCaption;
            PickerButton2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PickerButton2.ForeColor = Color.White;
            PickerButton2.Location = new Point(773, 564);
            PickerButton2.Margin = new Padding(4, 3, 4, 3);
            PickerButton2.Name = "PickerButton2";
            PickerButton2.Size = new Size(131, 65);
            PickerButton2.TabIndex = 11;
            PickerButton2.Text = "Browse";
            PickerButton2.UseVisualStyleBackColor = false;
            PickerButton2.Click += PickerButton2_Click;
            // 
            // CompareButton
            // 
            CompareButton.BackColor = SystemColors.ActiveCaption;
            CompareButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CompareButton.ForeColor = Color.White;
            CompareButton.Location = new Point(507, 564);
            CompareButton.Margin = new Padding(4, 3, 4, 3);
            CompareButton.Name = "CompareButton";
            CompareButton.Size = new Size(131, 65);
            CompareButton.TabIndex = 12;
            CompareButton.Text = "Compare";
            CompareButton.UseVisualStyleBackColor = false;
            CompareButton.Click += CompareButton_Click;
            // 
            // Compare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 641);
            Controls.Add(CompareButton);
            Controls.Add(PickerButton2);
            Controls.Add(PickerButton1);
            Controls.Add(CompareLabel);
            Controls.Add(firsttext);
            Controls.Add(second);
            Controls.Add(first);
            Name = "Compare";
            Text = "Compare";
            ((System.ComponentModel.ISupportInitialize)first).EndInit();
            ((System.ComponentModel.ISupportInitialize)second).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox first;
        private PictureBox second;
        private Label firsttext;
        private Label CompareLabel;
        private Button PickerButton1;
        private Button PickerButton2;
        private Button CompareButton;
    }
}