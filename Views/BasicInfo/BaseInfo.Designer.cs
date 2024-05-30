namespace X_ray_Images.Views.BasicInfo
{
    partial class BaseInfo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            CreateReport.isBasicOpen = false;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
            { 
                foreach (var control in loadedUserControls.Values)
                {
                    control.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseInfo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            TelegramImage = new PictureBox();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            WhatsAppImage = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            process1 = new System.Diagnostics.Process();
            panel3 = new Panel();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TelegramImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 180, 216);
            panel1.Controls.Add(TelegramImage);
            panel1.Controls.Add(guna2Button4);
            panel1.Controls.Add(WhatsAppImage);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 67);
            panel1.TabIndex = 0;
            // 
            // TelegramImage
            // 
            TelegramImage.Cursor = Cursors.Hand;
            TelegramImage.Image = (Image)resources.GetObject("TelegramImage.Image");
            TelegramImage.Location = new Point(901, 4);
            TelegramImage.Margin = new Padding(5, 4, 5, 4);
            TelegramImage.Name = "TelegramImage";
            TelegramImage.Size = new Size(57, 62);
            TelegramImage.SizeMode = PictureBoxSizeMode.Zoom;
            TelegramImage.TabIndex = 24;
            TelegramImage.TabStop = false;
            TelegramImage.Click += TelegramImage_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.BorderColor = Color.BlanchedAlmond;
            guna2Button4.BorderRadius = 5;
            guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button4.CheckedState.FillColor = Color.Transparent;
            guna2Button4.CustomBorderColor = Color.White;
            guna2Button4.CustomBorderThickness = new Padding(3);
            guna2Button4.CustomizableEdges = customizableEdges1;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = Color.Transparent;
            guna2Button4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.HoverState.CustomBorderColor = Color.Indigo;
            guna2Button4.Location = new Point(3, 2);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button4.Size = new Size(225, 65);
            guna2Button4.TabIndex = 3;
            guna2Button4.Text = "تأكيد المعلومات";
            guna2Button4.Click += guna2Button4_Click;
            // 
            // WhatsAppImage
            // 
            WhatsAppImage.Cursor = Cursors.Hand;
            WhatsAppImage.Image = (Image)resources.GetObject("WhatsAppImage.Image");
            WhatsAppImage.Location = new Point(834, 4);
            WhatsAppImage.Margin = new Padding(5, 4, 5, 4);
            WhatsAppImage.Name = "WhatsAppImage";
            WhatsAppImage.Size = new Size(57, 62);
            WhatsAppImage.SizeMode = PictureBoxSizeMode.Zoom;
            WhatsAppImage.TabIndex = 23;
            WhatsAppImage.TabStop = false;
            WhatsAppImage.Click += WhatsAppImage_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 81);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(347, 14);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 0;
            label1.Text = "أدخل معلومات التقرير";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(173, 232, 244);
            panel3.Controls.Add(guna2Button5);
            panel3.Controls.Add(guna2Button3);
            panel3.Controls.Add(guna2Button2);
            panel3.Controls.Add(guna2Button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(963, 80);
            panel3.TabIndex = 1;
            // 
            // guna2Button5
            // 
            guna2Button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button5.CustomBorderColor = Color.White;
            guna2Button5.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button5.CustomizableEdges = customizableEdges3;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.Transparent;
            guna2Button5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button5.ForeColor = Color.Black;
            guna2Button5.HoverState.CustomBorderColor = Color.Blue;
            guna2Button5.Location = new Point(499, 11);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button5.Size = new Size(225, 65);
            guna2Button5.TabIndex = 3;
            guna2Button5.Text = "معلومات الحالة";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button3.CustomBorderColor = Color.White;
            guna2Button3.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button3.CustomizableEdges = customizableEdges5;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Transparent;
            guna2Button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.Black;
            guna2Button3.HoverState.CustomBorderColor = Color.Blue;
            guna2Button3.Location = new Point(20, 12);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button3.Size = new Size(225, 65);
            guna2Button3.TabIndex = 2;
            guna2Button3.Text = "معلومات أخرى";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button2.CustomBorderColor = Color.White;
            guna2Button2.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.HoverState.CustomBorderColor = Color.Blue;
            guna2Button2.Location = new Point(262, 11);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(225, 65);
            guna2Button2.TabIndex = 1;
            guna2Button2.Text = "معلومات التواصل";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button1.Checked = true;
            guna2Button1.CustomBorderColor = Color.White;
            guna2Button1.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.HoverState.CustomBorderColor = Color.Blue;
            guna2Button1.Location = new Point(733, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(225, 65);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "معلومات أساسية";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 147);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(963, 406);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // BaseInfo
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(963, 553);
            Controls.Add(panelContainer);
            Controls.Add(panel3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "BaseInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TelegramImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)WhatsAppImage).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private System.Diagnostics.Process process1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private PictureBox TelegramImage;
        private PictureBox WhatsAppImage;
    }
}