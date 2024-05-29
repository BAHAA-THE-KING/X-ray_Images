using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
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
            if (Directory.Exists(path)) Directory.Delete(path, true);
            Directory.CreateDirectory(path);

            Patient patient = new Patient(BaseInfo.baseInfo, BaseInfo.connectInfo, BaseInfo.otherInfo, BaseInfo.statusInfo);
            patient.ConvertToPDF(Path.Combine(path, "التقربر الطبي.pdf"));

            for (int i = 0; i < Photos.images.Count; i++)
            {
                Image image = Photos.images[i];
                image.Save(Path.Join(path, "صورة " + i + ".png"), ImageFormat.Png);
                string recording = Photos.recordings[i];
                if (!recording.Equals(""))
                {
                    File.Copy(recording, Path.Combine(path, "تسجيل " + i + ".wav"));
                }
            }

            while (true)
            {
                try
                {
                    File.Copy(Paths.AudioTempFile, Path.Combine(path, "وصف الحالة.wav"));
                }
                catch
                {
                    Thread.Sleep(500);
                    continue;
                }
                break;
            }
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
            if (Directory.Exists(path)) Directory.Delete(path, true);
            Directory.CreateDirectory(path);


            Patient patient = new Patient(BaseInfo.baseInfo, BaseInfo.connectInfo, BaseInfo.otherInfo, BaseInfo.statusInfo);
            patient.ConvertToPDF(Path.Combine(path, "temppdf.pdf"));

            while (true)
            {
                try
                {
                    Compressor.CompressPdf(Path.Combine(path, "temppdf.pdf"), Path.Combine(path, "التقربر الطبي.pdf"));
                }
                catch
                {
                    Thread.Sleep(500);
                    continue;
                }
                break;
            }

            while (true)
            {
                try
                {
                    File.Delete(Path.Combine(path, "temppdf.pdf"));
                }
                catch
                {
                    Thread.Sleep(500);
                    continue;
                }
                break;
            }


            for (int i = 0; i < Photos.images.Count; i++)
            {
                Image image = Photos.images[i];
                image.Save(Path.Join(path, "صورة " + i + ".png"), ImageFormat.Png);

                while (true)
                {
                    try
                    {
                        Compressor.CompressImage(Path.Join(path, "صورة " + i + ".png"), Path.Join(path, "صورة " + i + ".jpeg"), 100);
                    }
                    catch
                    {
                        Thread.Sleep(500);
                        continue;
                    }
                    break;
                }


                while (true)
                {
                    try
                    {
                        File.Delete(Path.Join(path, "صورة " + i + ".png"));
                    }
                    catch
                    {
                        Thread.Sleep(500);
                        continue;
                    }
                    break;
                }

                string recording = Photos.recordings[i];
                if (!recording.Equals(""))
                {
                    while (true)
                    {
                        try
                        {
                            Compressor.CompressAudioFile(recording, Path.Combine(path, "تسجيل " + i + ".mp3"));
                        }
                        catch
                        {
                            Thread.Sleep(500);
                            continue;
                        }
                        break;
                    }
                }
            }

            while (true)
            {
                try
                {
                    Compressor.CompressAudioFile(Paths.AudioTempFile, Path.Combine(path, "وصف الحالة.mp3"));
                }
                catch
                {
                    Thread.Sleep(500);
                    continue;
                }
                break;
            }
        }
    }
}

