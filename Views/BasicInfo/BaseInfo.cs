using Emgu.CV.Face;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using X_ray_Images.Classes;

namespace X_ray_Images.Views.BasicInfo
{
    public partial class BaseInfo : Form
    {
        public Dictionary<string, UserControl> loadedUserControls = new Dictionary<string, UserControl>();
        public static Base baseInfo = new Base();
        public static Contact connectInfo = new Contact();
        public static Other otherInfo = new Other();
        public static Status statusInfo = new Status();
        public static UC_Base ucBase; 
        public static UC_Connection ucConnection ;
        public static UC_Other ucOther ;
        public static UC_Status ucStatus;
        public BaseInfo()
        {
            InitializeComponent();
            InitializeUserControls();
            addUserControl(ucBase);
        }
        private void InitializeUserControls()
        {
            ucBase = new UC_Base(baseInfo);
            ucConnection = new UC_Connection(connectInfo);
            ucOther = new UC_Other(otherInfo);
            ucStatus = new UC_Status(statusInfo);
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
        public static bool ValidateRequiredFields()
        {
            string result = "";
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(baseInfo.name)) // name
            {
                result += "الرجاء ادخال اسم المريض \n";
                isValid = false;
            }
            if (baseInfo.sickness.Count == 0) // sickness
            {
                result += "الرجاء ادخال المرض \n";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(baseInfo.status)) // status
            {
                result += "الرجاء ادخال حالة المريض \n";
                isValid = false;
            }
            if (baseInfo.doctors.Count == 0) // doctors
            {
                result += "الرجاء ادخال اسم الدكتور \n";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(statusInfo.diagnosis)) // diagnosis
            {
                result += "الرجاء ادخال تشخيص المريض \n";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(statusInfo.indication)) // indication
            {
                result += "الرجاء ادخال استطباب المريض \n";
                isValid = false;
            }
            if (connectInfo.phone == "-1") // phone
            {
                result += "الرجاء ادخال رقم هاتف المريض \n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(result, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(baseInfo, connectInfo, otherInfo, statusInfo);
            if (ValidateRequiredFields())
            {
                this.Close();
            }
            else
            {
                MessageDialog.Show(patient.Required());
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            addUserControl(ucStatus);
        }
    }
}
