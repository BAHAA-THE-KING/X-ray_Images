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
    public partial class UC_Counction : UserControl
    {
        public UC_Counction()
        {
            InitializeComponent();
            string[] names = new string[]
        {
             "مكان السكن",
             "رقم الهاتف",
        };

            foreach (string name in names)
            {
                guna2DataGridView1.Rows.Add(name);
            }
        }
    }
}
