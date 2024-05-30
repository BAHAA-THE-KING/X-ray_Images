using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace X_ray_Images.Views.BasicInfo
{
    public partial class UC_Other : UserControl
    {
        string[] fields =
        {
        "تفاصيل المرض",
        "تاريخ المراجعة القادمة",
        };
        private Other _oInfo;
        private DateTime datevalue = DateTime.Now;

        public UC_Other(Other oInfo)
        {
            InitializeComponent();
            _oInfo = oInfo;
            foreach (string field in fields)
            {
                DataGridOther.Rows.Add(field);
            }
            DataGridOther.Rows[0].Cells[1].Value = _oInfo.details;
            DataGridOther.Rows[1].Cells[1].Value = _oInfo.nextdate;

            DataGridOther.CellEndEdit += DataGridOther_CellEndEdit;
        }
        private void DataGridOther_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            string attribValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value?.ToString() ?? "";
            string newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            DataGridOther.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
            if (e.RowIndex == 1)
            {
                bool success = DateTime.TryParseExact(
                    newValue,
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime result
                    );
                if (success)
                    datevalue = result;
                else
                {
                    MessageBox.Show("التاريخ غير صحيح", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DataGridOther.Rows[1].Cells[1].Value = datevalue.ToString("d/M/yyyy");
                }
            }

            switch (attribValue)
            {
                case "تفاصيل المرض":
                    _oInfo.details = newValue;
                    break;
                case "تاريخ المراجعة القادمة":
                    _oInfo.nextdate = datevalue.ToString("d/M/yyyy");
                    break;
            }

        }

    }
}
