using Guna.UI2.WinForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_ray_Images
{
    public partial class UC_Base : UserControl
    {
        public UC_Base()
        {
            InitializeComponent();
        string[] names = new string[]
        {
             "اسم المريض",
             "المرض",
             "الحالة",
             "اسم الدكتور المشرف",
             "التاريخ"
        };

            foreach (string name in names)
            {
                guna2DataGridView1.Rows.Add(name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
