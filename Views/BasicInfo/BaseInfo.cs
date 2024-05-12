using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_ray_Images.Views.BasicInfo
{
    public partial class BaseInfo : Form
    {
        public BaseInfo()
        {
            InitializeComponent();
            UC_BaseInfo baseinfo = new UC_BaseInfo();
            addUserControl(baseinfo);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaseInfo_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_BaseInfo baseinfo= new UC_BaseInfo();
            addUserControl(baseinfo);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
