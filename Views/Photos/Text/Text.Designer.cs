using System.Drawing;
using System.Windows.Forms;
namespace X_ray_Images
{
	partial class Text
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox TextTextBox;
		private System.Windows.Forms.Button TextOKButton;
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
			this.TextTextBox = new System.Windows.Forms.TextBox();
			this.TextOKButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextTextBox
			// 
			this.TextTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.TextTextBox.Location = new System.Drawing.Point(0, 0);
			this.TextTextBox.Name = "TextTextBox";
			this.TextTextBox.Size = new System.Drawing.Size(357, 24);
			this.TextTextBox.TabIndex = 0;
			// 
			// TextOKButton
			// 
			this.TextOKButton.Location = new System.Drawing.Point(131, 55);
			this.TextOKButton.Name = "TextOKButton";
			this.TextOKButton.Size = new System.Drawing.Size(97, 47);
			this.TextOKButton.TabIndex = 1;
			this.TextOKButton.Text = "موافق";
			this.TextOKButton.UseVisualStyleBackColor = true;
			this.TextOKButton.Click += new System.EventHandler(this.TextOK_Click);
			// 
			// Text
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 114);
			this.Controls.Add(this.TextOKButton);
			this.Controls.Add(this.TextTextBox);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Text";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Shapes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

	}
}
