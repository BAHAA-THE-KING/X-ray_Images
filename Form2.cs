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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(openFileDialog1.FileName);

                first.Image = b;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(openFileDialog1.FileName);

                second.Image = b;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Image firstImg = first.Image;
            Image secondImg = second.Image;
            Bitmap firstbitmap = new Bitmap(firstImg);
            Bitmap secondbitmap = new Bitmap(secondImg);
            firsttext.Text = Comparer.compareTwoImages(firstbitmap, secondbitmap);


        }

        private void first_Click(object sender, EventArgs e)
        {

        }
    }
}
