    using Emgu.CV.Face;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using WTelegramClientTestWF;
using X_ray_Images.Classes;
using X_ray_Images.Views.Share;

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
        public static UC_Connection ucConnection;
        public static UC_Other ucOther;
        public static UC_Status ucStatus;
        private Patient patient;
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
        private void ucBase_Click(object sender, EventArgs e)
        {
            addUserControl(ucBase);
        }

        private void ucConnection_Click(object sender, EventArgs e)
        {

            addUserControl(ucConnection);
        }
         private void ucOther_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(connectInfo.phone)) // phone
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
        private void confirmInfo_Click(object sender, EventArgs e)
        {
            patient = new Patient(baseInfo, connectInfo, otherInfo, statusInfo);
            if (ValidateRequiredFields())
            {
                MessageBox.Show("تم تأكيد المعلومات.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                MessageDialog.Show(patient.Required());
            }
        }

        private void ucStatus_Click(object sender, EventArgs e)
        {
            addUserControl(ucStatus);
        }

        private void WhatsAppImage_Click(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                string path = Paths.CreatePath(BaseInfo.baseInfo.name);
                
                if (Directory.Exists(path)) Directory.Delete(path, true);
                Directory.CreateDirectory(path);
                path  = Path.Combine(path, "WhatsAppShare");
                Directory.CreateDirectory(path);

                Patient patient = new Patient(BaseInfo.baseInfo, BaseInfo.connectInfo, BaseInfo.otherInfo, BaseInfo.statusInfo);
                path = Path.Combine(path, "التقربر الطبي.pdf");
                patient.ConvertToPDF(path);
                Thread serviceThread = new Thread(() =>
                {
                    try
                    {
                        Whatsapp_Share relnServ = new Whatsapp_Share();
                        relnServ.FilePath = path;
                        relnServ.IsDoc = true;
                        relnServ.WaitingForSelectChat += () =>
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show("Please Pick A Chat To Send To!", "Waiting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            });
                        };
                        relnServ.FileSent += () =>
                        {
                            // Invoke to ensure the message box is shown on the main UI thread
                            this.Invoke((MethodInvoker)delegate
                            {
                                MessageBox.Show("File has been sent successfully!", "File Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            });
                        };
                        relnServ.OnDebug();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in service thread: " + ex.Message);
                    }
                });

                serviceThread.IsBackground = true;
                serviceThread.Start();
            }
            else
            {
                if (patient != null)
                {
                MessageDialog.Show(patient.Required());

                }
                else
                {
                  
                }
            }
        }   

        private void TelegramImage_Click(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                string path = Paths.CreatePath(BaseInfo.baseInfo.name);

                if (Directory.Exists(path)) Directory.Delete(path, true);
                Directory.CreateDirectory(path);
                path = Path.Combine(path, "TelegramShare");
                Directory.CreateDirectory(path);

                Patient patient = new Patient(BaseInfo.baseInfo, BaseInfo.connectInfo, BaseInfo.otherInfo, BaseInfo.statusInfo);
                path = Path.Combine(path, "التقربر الطبي.pdf");
                patient.ConvertToPDF(path);
                Telegram_Share telegram = new Telegram_Share();
                telegram.FilePath = path;
                telegram.Show();
            }
            else
            {
                if (patient != null)
                {
                    MessageDialog.Show(patient.Required());

                }
                else
                {
                    
                }
            }
        }
    }
}
