using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using X_ray_Images.Views.BasicInfo;

namespace X_ray_Images
{
    /// <summary>
    /// Description of CreateReport.
    /// </summary>
    public partial class CreateReport : Form
    {
        public static bool isBasicOpen = false;
        public static bool isPhotosOpen = false;
        public static bool isAudioOpen = false;

        public CreateReport()
        {
            InitializeComponent();
        }
        private void BasicInfoPanelClick(object sender, EventArgs e)
        {
            if (!isBasicOpen)
            {
                isBasicOpen = true;
                BaseInfo baseInfo = new BaseInfo();
                baseInfo.Show();
            }
        }
        private void PhotosPanelClick(object sender, EventArgs e)
        {
            if (!isPhotosOpen)
            {
                isPhotosOpen = true;
                Photos photos = new Photos();
                photos.Show();
            }
        }
        private void AudioPanelClick(object sender, EventArgs e)
        {
            if (!isAudioOpen)
            {
                isAudioOpen = true;
                Audio audio = new Audio();
                audio.Show();
            }
        }
        private void SaveButtonClick(object sender, EventArgs e)
        {

        }
    }
}
