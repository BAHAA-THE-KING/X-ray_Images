using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
       private  Other _oInfo;
        
        public UC_Other(Other oInfo)
        {
            InitializeComponent();
            _oInfo = oInfo;
        foreach (string field in fields)
        {
            DataGridOther.Rows.Add(field);
        }
           
            DataGridOther.CellEndEdit += DataGridOther_CellEndEdit;
        }
        private void DataGridOther_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (DataGridView)sender;
            string attribValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value?.ToString() ?? "";
            string newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            DataGridOther.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
            switch (attribValue)
            {
                case "تفاصيل المرض":
                    _oInfo.details = newValue;
                    break;
                case "تاريخ المراجعة القادمة":
                    _oInfo.nextdate = newValue;
                    break;
            }
                    //Cell newCell = new Cell(attribValue, newValue); ;

                    //if (newValue == null || newValue == "")
                    //{

                    // cells.Add(newCell);

                    //}
                    //else
                    //{
                    //    foreach (Cell cell in cells)
                    //    {
                    //        if(cell.name == attribValue)
                    //        { cell.value = newValue; }

                    //    }    
                    //}
            }
      
    }
}
