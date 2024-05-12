namespace X_ray_Images.Views.BasicInfo
{
    partial class UC_BaseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            FixColumn = new DataGridViewTextBoxColumn();
            varColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(guna2DataGridView1);
            panel1.Location = new Point(82, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 348);
            panel1.TabIndex = 0;
            panel1.UseWaitCursor = true;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AccessibleRole = AccessibleRole.TitleBar;
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 224, 244);
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.GhostWhite;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.BackgroundColor = Color.FromArgb(196, 211, 249);
            guna2DataGridView1.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 60;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { FixColumn, varColumn });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.GhostWhite;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.Dock = DockStyle.Fill;
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            guna2DataGridView1.GridColor = Color.FromArgb(187, 220, 242);
            guna2DataGridView1.ImeMode = ImeMode.NoControl;
            guna2DataGridView1.Location = new Point(0, 0);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RightToLeft = RightToLeft.Yes;
            guna2DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(214, 234, 247);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.GhostWhite;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            guna2DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            guna2DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            guna2DataGridView1.RowTemplate.DividerHeight = 10;
            guna2DataGridView1.RowTemplate.Height = 250;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            guna2DataGridView1.Size = new Size(799, 348);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 224, 244);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Black;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.SlateBlue;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.GhostWhite;
            guna2DataGridView1.ThemeStyle.BackColor = Color.FromArgb(196, 211, 249);
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(187, 220, 242);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.CornflowerBlue;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 60;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 234, 247);
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 250;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.SlateBlue;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.GhostWhite;
            guna2DataGridView1.UseWaitCursor = true;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick_1;
            // 
            // FixColumn
            // 
            FixColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            FixColumn.DefaultCellStyle = dataGridViewCellStyle3;
            FixColumn.DividerWidth = 10;
            FixColumn.Frozen = true;
            FixColumn.HeaderText = "الحقول";
            FixColumn.MinimumWidth = 400;
            FixColumn.Name = "FixColumn";
            FixColumn.ReadOnly = true;
            FixColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            FixColumn.Width = 400;
            // 
            // varColumn
            // 
            varColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            varColumn.DefaultCellStyle = dataGridViewCellStyle4;
            varColumn.DividerWidth = 10;
            varColumn.Frozen = true;
            varColumn.HeaderText = "ادخل المعلومات";
            varColumn.MinimumWidth = 400;
            varColumn.Name = "varColumn";
            varColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            varColumn.Width = 400;
            // 
            // UC_BaseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(196, 211, 249);
            Controls.Add(panel1);
            Name = "UC_BaseInfo";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(963, 406);
            UseWaitCursor = true;
            Load += UC_BaseInfo_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn FixColumn;
        private DataGridViewTextBoxColumn varColumn;
    }
}
