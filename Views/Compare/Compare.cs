using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X_ray_Images.Classes;

namespace X_ray_Images
{
    public partial class Compare : Form
    {
        public Compare()
        {
            InitializeComponent();
        }

        private void PickerButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(openFileDialog1.FileName);

                first.Image = b;

            }
        }

        private void PickerButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(openFileDialog1.FileName);

                second.Image = b;

            }
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            if (first.Image != null && second.Image != null)
            {
                Image firstImg = first.Image;
                Image secondImg = second.Image;
                Bitmap firstbitmap = new Bitmap(firstImg);
                Bitmap secondbitmap = new Bitmap(secondImg);
                firsttext.Text = Comparer.compareTwoImages(firstbitmap, secondbitmap);
                MessageBox.Show(Comparer.compareTwoImages(firstbitmap, secondbitmap));
            }
            else
            {
                MessageBox.Show("Error No images found :(");
            }

        }

        private void first_Click(object sender, EventArgs e)
        {

        }
    }
}
