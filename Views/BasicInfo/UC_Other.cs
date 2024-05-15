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
    public partial class UC_Other : UserControl
    {
        public UC_Other()
        {
            InitializeComponent();
            string[] names = new string[]
 {
             "تفاصيل المرض",
             "تاريخ المراجعة القادمة",
 };

            foreach (string name in names)
            {
                DataGridOther.Rows.Add(name);
            }
        }

      
    }
    

}
