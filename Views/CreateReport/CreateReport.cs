using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using X_ray_Images;
using X_ray_Images.Classes;
using X_ray_Images.Views.BasicInfo;

namespace X_ray_Images
{
    public partial class CreateReport : Form
    {
        public static bool isBasicOpen = false;
        public static bool isPhotosOpen = false;
        public static bool isAudioOpen = false;
        Action showHome;
        public CreateReport(Action showHome)
        {
            InitializeComponent();
            this.showHome = showHome;
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
                Audio audio = new Audio(Paths.AudioTempFile);
                audio.Show();
            }
        }
        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (!BaseInfo.ValidateRequiredFields())
            {
                return;
            }
            if (Photos.images.Count == 0)
            {
                MessageBox.Show("يجب إدخال صورة واحدة على الأقل");
                return;
            }
            if (!File.Exists(Paths.AudioTempFile))
            {
                MessageBox.Show("يجب إضافة تسجيل صوتي لوصف الحالة");
            }
            string path = Paths.CreatePath(BaseInfo.baseInfo.name);
            Directory.CreateDirectory(path);

            Patient patient = new Patient(BaseInfo.baseInfo, BaseInfo.connectInfo, BaseInfo.otherInfo, BaseInfo.statusInfo);
            patient.ConvertToPDF(Path.Combine(path, "التقربر الطبي.pdf"));

            for (int i = 0; i < Photos.images.Count; i++)
            {
                Image image = Photos.images[i];
                image.Save(Path.Join(path, "صورة " + i + ".png"), ImageFormat.Png);
            }

            File.Copy(Paths.AudioTempFile, Path.Combine(path, "وصف الحالة.wav"));
        }
        private void CompressButtonClick(object sender, EventArgs e)
        {
            if (!BaseInfo.ValidateRequiredFields())
            {
                return;
            }
            if (Photos.images.Count == 0)
            {
                MessageBox.Show("يجب إدخال صورة واحدة على الأقل");
                return;
            }
            if (!File.Exists(Paths.AudioTempFile))
            {
                MessageBox.Show("يجب إضافة تسجيل صوتي لوصف الحالة");
            }
            string path = Paths.CreatePath(BaseInfo.baseInfo.name);
            Directory.CreateDirectory(path);

            Patient patient = new Patient(BaseInfo.baseInfo, BaseInfo.connectInfo, BaseInfo.otherInfo, BaseInfo.statusInfo);
            patient.ConvertToPDF(Path.Combine(path, "التقربر الطبي.pdf"));
            Compressor.CompressPdf(Path.Combine(path, "التقربر الطبي.pdf"), Path.Combine(path, "التقربر الطبي.pdf"));

            for (int i = 0; i < Photos.images.Count; i++)
            {
                Image image = Photos.images[i];
                image.Save(Path.Join(path, "صورة " + i + ".png"), ImageFormat.Png);
                Compressor.CompressImage(Path.Join(path, "صورة " + i + ".png"), Path.Join(path, "صورة " + i + ".jpeg"), 100);
                File.Delete(Path.Join(path, "صورة " + i + ".png"));
            }

            Compressor.CompressAudioFile(Paths.AudioTempFile, Path.Combine(path, "وصف الحالة.mp3"));
        }
    }
}
