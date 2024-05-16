using Emgu.CV.Face;
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
    public partial class UC_Status : UserControl
    {
        private Status _statusInfo;
        string[] fileds =
       {
             "التشخيص",
             "الوصف",
             "الاستطباب"
        };
        public UC_Status(Status statusInfo)
        {
            InitializeComponent();
            this._statusInfo = statusInfo;
            foreach (string filed in fileds)
            {
                DataGridStatus.Rows.Add(filed);
            }

            DataGridStatus.CellEndEdit += DataGridStatus_CellEndEdit;
        }
        private void DataGridStatus_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            string attribValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value?.ToString() ?? "";
            string newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            DataGridStatus.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
            switch (attribValue)
            {
                case "التشخيص":
                    _statusInfo.diagnosis = newValue;
                    break;
                case "الوصف":
                    _statusInfo.description = newValue;
                    break;
                case "الاستطباب":
                    _statusInfo.indication = newValue; break;
             
            }

        }
    }
}
