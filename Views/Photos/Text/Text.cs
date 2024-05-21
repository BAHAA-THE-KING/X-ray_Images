using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace X_ray_Images
{
    public partial class Text : Form
    {
        Action<string> setText;
        public Text(Action<string> setText)
        {
            InitializeComponent();

            this.setText = setText;
        }
        private void TextOK_Click(object sender, EventArgs e)
        {
            setText(TextTextBox.Text);
            Close();
        }
    }
}