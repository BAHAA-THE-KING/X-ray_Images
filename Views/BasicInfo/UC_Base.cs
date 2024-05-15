using Emgu.CV.Face;

namespace X_ray_Images.Views.BasicInfo
{
 
    public partial class UC_Base : UserControl
    {
        public static List<Cell> cells = new List<Cell>();
        string[] fileds = 
        {
             "اسم المريض",
             "المرض",
             "الحالة",
             "اسم الدكتور المشرف",
             "التاريخ"
        };
        private Base _binfo;
        public UC_Base(Base binfo)
        {
            InitializeComponent();
            this._binfo = binfo;
            foreach (string filed in fileds)
            {
                DataGridBasic.Rows.Add(filed);
            }

            DataGridBasic.Rows[0].Cells[1].Value = _binfo.name;
            DataGridBasic.Rows[1].Cells[1].Value = this._binfo.sickness.Count == 0 ? "" : this._binfo.sickness[0];

            DataGridBasic.Rows[2].Cells[1].Value = _binfo.status;
            DataGridBasic.Rows[3].Cells[1].Value = this._binfo.doctors.Count == 0 ? "" : this._binfo.doctors[0];
            ;
            DataGridBasic.Rows[4].Cells[1].Value = _binfo.date;





            //if (cells.Count != 0)
            //{
            //    foreach (Cell cell in cells)
            //    {
            //        DataGridBasic.Rows.Add(cell.name,cell.value);
            //    }

            //}
            //else
            //{
            //    foreach (string filed in fileds)
            //    {
            //        DataGridBasic.Rows.Add(filed);
            //    }
            //} 
            DataGridBasic.CellEndEdit += DataGridBasic_CellEndEdit;
        }

        private void DataGridBasic_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                var dgv = (DataGridView)sender;      
                string attribValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value?.ToString() ?? "";
                string newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
                DataGridBasic.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
                switch (attribValue)
                {
                case "اسم المريض":
                    _binfo.name = newValue;
                    break;
                case "المرض":
                    _binfo.sickness.Add(newValue);
                    break;
                case "الحالة":
                    _binfo.status = newValue; break;
                case "اسم الدكتور المشرف":
                    _binfo.doctors.Add( newValue); break;
                case "التاريخ":
                    _binfo.date = newValue; break;
                }
                
        }
      


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
