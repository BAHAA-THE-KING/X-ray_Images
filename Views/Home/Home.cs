using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace X_ray_Images
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}
		void CreateButtonClick(object sender, EventArgs e)
		{
			CreateReport createReport = new CreateReport();
			createReport.Show();
			Hide();
		}
	}
}
