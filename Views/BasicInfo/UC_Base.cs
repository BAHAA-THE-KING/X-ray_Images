using Emgu.CV.Face;
using System.Globalization;
using System;

namespace X_ray_Images.Views.BasicInfo
{
 
    public partial class UC_Base : UserControl
    {
        string[] fileds = 
        {
             "اسم المريض",
             "المرض",
             "الحالة",
             "اسم الدكتور المشرف",
             "التاريخ"
        };
        private Base _binfo;
        private DateTime datevalue = DateTime.Now;
        private string[] _sickness;
        private string[] _doctors;
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

            DataGridBasic.Rows[4].Cells[1].Value = _binfo.date;


            DataGridBasic.CellEndEdit += DataGridBasic_CellEndEdit;
        }

        private void DataGridBasic_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                var dgv = (DataGridView)sender;      
                string attribValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value?.ToString() ?? "";
                string newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
            DataGridBasic.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;

            if (e.RowIndex == 4)
            {
                bool success = DateTime.TryParseExact(
                    newValue,
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime result
                    );
                if(success)
                    datevalue  = result;
                else
                {
                    MessageBox.Show("التاريخ غير صحيح \n d/M/yyyy ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DataGridBasic.Rows[4].Cells[1].Value = datevalue.ToString("d/M/yyyy");
                 
                }
            }
            if(e.RowIndex == 1)
            {
                _binfo.sickness.Clear();
                 _sickness= newValue.Split('،');

                foreach (string item in _sickness)
                {
                    _binfo.sickness.Add(item.Trim());
                }
            }
              if (e.RowIndex == 3)
            {
                _binfo.doctors.Clear();
                _doctors = newValue.Split('،');

                foreach (string item in _doctors)
                {
                    _binfo.doctors.Add(item.Trim());
                }
            }
                switch (attribValue)
                {
                case "اسم المريض":
                    _binfo.name = newValue;
                    break;
                case "المرض":
                    //_binfo.sickness.Add(newValue); break;
                case "الحالة":
                    _binfo.status = newValue; break;
                case "اسم الدكتور المشرف":
                    //_binfo.doctors.Add( newValue); break;
                case "التاريخ":
                    _binfo.date = datevalue.ToString("d/M/yyyy"); break;
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
