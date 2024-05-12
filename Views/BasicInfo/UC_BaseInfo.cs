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

    public partial class UC_BaseInfo : UserControl
    {
        public UC_BaseInfo()
        {

            InitializeComponent();
            string[] names = new string[]
            {
             "اسم المريض",
             "المرض",
             "الحالة",
             "اسم الدكتور المشرف"
             };

            foreach (string name in names)
            {
                guna2DataGridView1.Rows.Add(name);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_BaseInfo_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
