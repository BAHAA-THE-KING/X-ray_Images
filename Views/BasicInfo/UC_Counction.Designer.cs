namespace X_ray_Images.Views.BasicInfo
{
    partial class UC_Connection
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Column2 = new DataGridViewTextBoxColumn();
            contant = new DataGridViewTextBoxColumn();
            DataGridConnect = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridConnect).BeginInit();
            SuspendLayout();
            // 
            // Column2
            // 
            Column2.HeaderText = "المعلومات";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // contant
            // 
            contant.DividerWidth = 5;
            contant.HeaderText = "الحقول";
            contant.MinimumWidth = 6;
            contant.Name = "contant";
            contant.ReadOnly = true;
            // 
            // DataGridConnect
            // 
            DataGridConnect.AllowUserToAddRows = false;
            DataGridConnect.AllowUserToDeleteRows = false;
            DataGridConnect.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(189, 223, 251);
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DataGridConnect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridConnect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridConnect.BackgroundColor = Color.FromArgb(196, 211, 249);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridConnect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridConnect.ColumnHeadersHeight = 50;
            DataGridConnect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridConnect.Columns.AddRange(new DataGridViewColumn[] { contant, Column2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridConnect.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridConnect.EditMode = DataGridViewEditMode.EditOnEnter;
            DataGridConnect.GridColor = Color.FromArgb(187, 222, 251);
            DataGridConnect.Location = new Point(116, 32);
            DataGridConnect.Name = "DataGridConnect";
            DataGridConnect.RightToLeft = RightToLeft.Yes;
            DataGridConnect.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridConnect.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridConnect.RowHeadersVisible = false;
            DataGridConnect.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridConnect.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DataGridConnect.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridConnect.RowTemplate.Height = 40;
            DataGridConnect.Size = new Size(730, 343);
            DataGridConnect.TabIndex = 1;
            DataGridConnect.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            DataGridConnect.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            DataGridConnect.ThemeStyle.AlternatingRowsStyle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridConnect.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            DataGridConnect.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            DataGridConnect.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            DataGridConnect.ThemeStyle.BackColor = Color.FromArgb(196, 211, 249);
            DataGridConnect.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            DataGridConnect.ThemeStyle.HeaderStyle.BackColor = Color.RoyalBlue;
            DataGridConnect.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridConnect.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridConnect.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridConnect.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridConnect.ThemeStyle.HeaderStyle.Height = 50;
            DataGridConnect.ThemeStyle.ReadOnly = false;
            DataGridConnect.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            DataGridConnect.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridConnect.ThemeStyle.RowsStyle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridConnect.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            DataGridConnect.ThemeStyle.RowsStyle.Height = 40;
            DataGridConnect.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            DataGridConnect.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // UC_Counction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 211, 249);
            Controls.Add(DataGridConnect);
            Name = "UC_Counction";
            Size = new Size(963, 406);
            ((System.ComponentModel.ISupportInitialize)DataGridConnect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn contant;
        public Guna.UI2.WinForms.Guna2DataGridView DataGridConnect;
    }
}
