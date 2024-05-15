namespace X_ray_Images.Views.BasicInfo
{
    public class Cell
    {
     public   string name;
     public string value;

        public Cell(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
    public partial class UC_Base : UserControl
    {
        public List<Cell> cells = new List<Cell>();
        string[] names = new string[]


        {
             "اسم المريض",
             "المرض",
             "الحالة",
             "اسم الدكتور المشرف",
             "التاريخ"
        };
        public string[] dd = new string[5];


        public UC_Base()
        {
            InitializeComponent();

            foreach (string name in names)
            {
                DataGridBasic.Rows.Add(name);
            }

             
            DataGridBasic.CellEndEdit += DataGridBasic_CellEndEdit;
        }
        public List<Cell> GetCells()
        {
            return cells;
        }

        private void DataGridBasic_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                var dgv = (DataGridView)sender;      
                string attribValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value?.ToString() ?? "";
                string newValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString() ?? "";
                DataGridBasic.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newValue;
                 cells.Add(new Cell(attribValue, newValue));
            BaseInfo.PassCellsToOtherFile(cells);


        }
      


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
