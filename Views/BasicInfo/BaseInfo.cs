using Emgu.CV.Face;
using Guna.UI2.WinForms;

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
        //private void SwitchToTab(string tabName)
        //{
        //    if (!loadedUserControls.ContainsKey(tabName))
        //    {
        //        // Create and initialize the user control based on the tab name
        //        UserControl userControl = CreateUserControlForTab(tabName);



        //        // Add the user control to the collection
        //        loadedUserControls[tabName] = userControl;
        //    }

        //    // Show the selected user control in the panel
        //    UserControl selectedUserControl = loadedUserControls[tabName];
        //    ShowUserControl(selectedUserControl);
        //}

        //private UserControl CreateUserControlForTab(string tabName)
        //{
        //    // Create and return the appropriate user control based on the tab name
        //    switch (tabName)
        //    {
        //        case "base":
        //            return new UC_Base();
        //        case "connect":
        //            return new UC_Connection();
        //        case "other":
        //            return new UC_Other();
        //        default:
        //            throw new ArgumentException("Invalid user controler.");
        //    }
        //}


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
            // SwitchToTab(tag);
            //ShowUserControl(userControl);
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(baseInfo, connectInfo, otherInfo,statusInfo);

            MessageDialog.Show(patient.ToString());
            this.Close();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            addUserControl(ucStatus);
        }
    }
}
