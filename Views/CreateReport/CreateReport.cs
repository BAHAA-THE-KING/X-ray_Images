using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace X_ray_Images
{
	/// <summary>
	/// Description of CreateReport.
	/// </summary>
	public partial class CreateReport : Form
	{
		static bool isBasicOpen = false;
		static bool isPhotosOpen = false;
		static bool isAudioOpen = false;

		public CreateReport()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void BasicInfoPanelClick(object sender, EventArgs e)
		{

		}
		private void PhotosPanelClick(object sender, EventArgs e)
		{
			if (!isPhotosOpen)
			{
				isPhotosOpen = true;
				Photos photos = new Photos();
				photos.Show();
				//Hide();
			}
		}
		private void AudioPanelClick(object sender, EventArgs e)
		{

		}
	}
}
