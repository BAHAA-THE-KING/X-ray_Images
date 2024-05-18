using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using X_ray_Images.Views.Search;

namespace X_ray_Images
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.Resize += Home_Resize;
        }
        void CreateButtonClick(object sender, EventArgs e)
        {
            CreateReport createReport = new CreateReport();
            createReport.Show();
            Hide();
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            // Calculate the center position based on the current form size
            int centerX = (this.ClientSize.Width - CreateButton.Width) / 2;
            int centerY = (this.ClientSize.Height - CreateButton.Height) / 2;

            // Set the button's location to the calculated center position
            CreateButton.Location = new Point(centerX, centerY);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Search_for_Images(object sender, EventArgs e)
        {
            SearchView searching = new SearchView();
            searching.Show();
            Hide();
        }
    }
}
