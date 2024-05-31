using X_ray_Images.Classes;

namespace X_ray_Images
{
  partial class Home
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button CreateButton;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (File.Exists(Paths.AudioTempDir)) File.Delete(Paths.AudioTempDir);
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
      CreateButton = new Button();
      label1 = new Label();
      panel1 = new Panel();
      button1 = new Button();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // CreateButton
      // 
      CreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      CreateButton.AutoSize = true;
      CreateButton.BackColor = SystemColors.MenuHighlight;
      CreateButton.Cursor = Cursors.Hand;
      CreateButton.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
      CreateButton.ForeColor = SystemColors.ButtonHighlight;
      CreateButton.Location = new Point(198, 228);
      CreateButton.Margin = new Padding(0);
      CreateButton.MaximumSize = new Size(286, 125);
      CreateButton.Name = "CreateButton";
      CreateButton.Size = new Size(286, 125);
      CreateButton.TabIndex = 1;
      CreateButton.Text = "إنشاء تقرير جديد";
      CreateButton.UseVisualStyleBackColor = false;
      CreateButton.Click += CreateButtonClick;
      // 
      // label1
      // 
      label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      label1.AutoSize = true;
      label1.BackColor = Color.Transparent;
      label1.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.ForeColor = Color.White;
      label1.Location = new Point(306, 17);
      label1.Name = "label1";
      label1.Size = new Size(397, 38);
      label1.TabIndex = 0;
      label1.Text = "أهلاً بكم في تطبيق التقارير الطبية";
      label1.TextAlign = ContentAlignment.TopCenter;
      // 
      // panel1
      // 
      panel1.Anchor = AnchorStyles.Top;
      panel1.BackColor = Color.FromArgb(0, 180, 216);
      panel1.Controls.Add(label1);
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(1008, 79);
      panel1.TabIndex = 2;
      // 
      // button1
      // 
      button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      button1.AutoSize = true;
      button1.BackColor = SystemColors.MenuHighlight;
      button1.Cursor = Cursors.Hand;
      button1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
      button1.ForeColor = SystemColors.ButtonHighlight;
      button1.Location = new Point(541, 228);
      button1.Margin = new Padding(0);
      button1.MaximumSize = new Size(286, 125);
      button1.Name = "button1";
      button1.Size = new Size(286, 125);
      button1.TabIndex = 3;
      button1.Text = "البحث في الصور";
      button1.UseVisualStyleBackColor = false;
      button1.Click += Search_for_Images;
      // 
      // Home
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(196, 211, 249);
      ClientSize = new Size(1008, 566);
      Controls.Add(button1);
      Controls.Add(panel1);
      Controls.Add(CreateButton);
      Margin = new Padding(3, 4, 3, 4);
      Name = "Home";
      Resize += this.Home_Resize;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Medications";
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    private Label label1;
    private Panel panel1;
    private Button button1;
  }
}