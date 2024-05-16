using Emgu.CV.Face;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace X_ray_Images.Views.BasicInfo
{
    public partial class BaseInfo : Form
    {
        public Dictionary<string, UserControl> loadedUserControls = new Dictionary<string, UserControl>();
        public UC_Base ucBase;
        public UC_Connection ucConnection;
        public UC_Other ucOther;
        public UC_Status ucStatus;
        public Base baseInfo;
        public Contact connectInfo;
        public Other otherInfo;
        public Status statusInfo;
        public BaseInfo()
        {
            InitializeComponent();
            baseInfo = new Base();
            otherInfo = new Other();
            connectInfo = new Contact();
            statusInfo = new Status();


            ucBase = new UC_Base(baseInfo);
            ucConnection = new UC_Connection(connectInfo);
            ucOther = new UC_Other(otherInfo);
            ucStatus = new UC_Status(statusInfo);
            addUserControl(ucBase);
        }
     
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaseInfo_Load(object sender, EventArgs e)
        {

        }
        private void ShowUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addUserControl(ucBase);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            addUserControl(ucConnection);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            addUserControl(ucOther);
        }
        private bool ValidateRequiredFields()
        {
            string result = "";
            if (string.IsNullOrWhiteSpace(baseInfo.name) )                  /// name
            {
                result = result + "الرجاء ادخال اسم المريض \n";
            }
            if (baseInfo.sickness.Count == 0)                               //sick
            {
                result = result + "الرجاء ادخال المرض \n"; 
            }
            if (string.IsNullOrWhiteSpace(baseInfo.status))                //status
            {
                result = result + "الرجاء ادخال حالة المريض \n";   
            }
            if (baseInfo.doctors.Count == 0)                                //doctors
            {
                result = result + "الرجاء ادخال اسم الدكتور \n";
            }
            if (string.IsNullOrWhiteSpace(statusInfo.diagnosis))           // diagonsis
            {
                result = result + "الرجاء ادخال تشخيص المريض \n";
            }
            if (string.IsNullOrWhiteSpace(statusInfo.indication))           //indication
            {
                result = result + "الرجاء ادخال استطباب المريض \n";
            }
            if (string.IsNullOrWhiteSpace(connectInfo.phone))                   //phone
            {
                result = result + "الرجاء ادخال رقم هاتف المريض \n";
            }
            else
            {
                return true;
            }
            MessageBox.Show(result, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(baseInfo, connectInfo, otherInfo, statusInfo);
            if (ValidateRequiredFields())
            {
            MessageDialog.Show(patient.ToString());
            }
            else
            {
                MessageDialog.Show(patient.Required());
            }
            this.Close();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            addUserControl(ucStatus);
        }
    }
}
