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
     private  Contact _cInfo;
        public static List<Cell> cells = new List<Cell>();
        string[] names =
        {
             "مكان السكن",
             "رقم الهاتف",
        };
       
        public UC_Connection(Contact cInfo)
        {
            InitializeComponent();
            _cInfo = cInfo;
            if (cells.Count != 0)
            {
                foreach (Cell cell in cells)
                {
                    DataGridConnect.Rows.Add(cell.name, cell.value);
                }

            }
            else
            {
                foreach (string name in names)
                {
                    DataGridConnect.Rows.Add(name);
                }
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
                     _cInfo.Address= newValue;
                    break;
                case "رقم الهاتف":
                    _cInfo.phone = int.TryParse(newValue,out result) ? result : -1;
                    break;
            }

                    //Cell newCell = new Cell(attribValue, newValue); ;

                    //if (newValue == null || newValue == "")
                    //{

                    //    cells.Add(newCell);

                    //}
                    //else
                    //{
                    //    foreach (Cell cell in cells)
                    //    {
                    //        if (cell.name == attribValue)
                    //        { cell.value = newValue; }

                    //    }
                    //}

            }
       

    }
}
