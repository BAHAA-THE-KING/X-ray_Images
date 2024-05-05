
using Emgu.CV;
using Emgu.CV.Structure;
using System;

using System.Windows.Forms;


namespace X_ray_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> img = new Image<Bgr, Byte>(openFileDialog1.FileName);

                pictureBox1.Image = img.ToBitmap();
            }
        }
    }
}
