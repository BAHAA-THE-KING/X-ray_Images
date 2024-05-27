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
using System.Xml.Linq;

namespace X_ray_Images.Views.BasicInfo
{
    public partial class UC_Connection : UserControl
    {
        private Contact _cInfo;
        string[] fields =
        {
             "مكان السكن",
             "رقم الهاتف"
        };

        public UC_Connection(Contact cInfo)
        {
            InitializeComponent();
            _cInfo = cInfo;

            foreach (string field in fields)
            {
                DataGridConnect.Rows.Add(field);
            }

            DataGridConnect.CellEndEdit += DataGridConnect_CellEndEdit;
        }

        private void DataGridConnect_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            string attribValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value?.ToString() ?? "";
            string newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            DataGridConnect.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
            int result;
            switch (attribValue)
            {
                case "مكان السكن":
                    _cInfo.address = newValue;
                    break;
                case "رقم الهاتف":
                    _cInfo.phone = newValue;
                    break;
            }
        }


    }
}
