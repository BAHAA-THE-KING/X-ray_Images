using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_ray_Images.Views.BasicInfo
{
    public partial class BaseInfo : Form
    {
        // Dictionary to store loaded user controls by tab name
        private Dictionary<string, UserControl> loadedUserControls = new Dictionary<string, UserControl>();

        public BaseInfo()
        {
            InitializeComponent();
            UC_Base uc = new UC_Base();
            addUserControl(uc, "base");
        }
        private void SwitchToTab(string tabName)
        {
            if (!loadedUserControls.ContainsKey(tabName))
            {
                // Create and initialize the user control based on the tab name
                UserControl userControl = CreateUserControlForTab(tabName);

                // Add the user control to the collection
                loadedUserControls[tabName] = userControl;
            }

            // Show the selected user control in the panel
            UserControl selectedUserControl = loadedUserControls[tabName];
            ShowUserControl(selectedUserControl);
        }

        private UserControl CreateUserControlForTab(string tabName)
        {
            // Create and return the appropriate user control based on the tab name
            switch (tabName)
            {
                case "base":
                    return new UC_Base(); 
                case "connect":
                    return new UC_Counction();
                case "other":
                    return new UC_Other();
                default:
                    throw new ArgumentException("Invalid user controler.");
            }
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

        private void addUserControl(UserControl userControl,string tag)
        {
            SwitchToTab(tag);
            ShowUserControl(userControl);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Base uc = new UC_Base();
            addUserControl(uc,"base");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Counction uc = new UC_Counction();
            addUserControl(uc, "connect");
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Other uc = new UC_Other();
            addUserControl(uc, "other");
        }
    }
}
