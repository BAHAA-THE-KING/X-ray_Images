using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using X_ray_Images;
using X_ray_Images.Classes;
using X_ray_Images.Views.BasicInfo;
using System.IO.Compression;
using X_ray_Images.Views.Share;
using WTelegramClientTestWF;
using System.Windows.Forms.DataVisualization.Charting;
using TL;

namespace X_ray_Images
{
    public partial class CreateReport : Form
    {
        public static bool isBasicOpen = false;
        public static bool isPhotosOpen = false;
        public static bool isAudioOpen = false;
        Action showHome;
        private string zipPath;
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

        private void SaveZipFile_Click(object sender, EventArgs e)
        {
            string folderToCompress = Paths.CreatePath(BaseInfo.baseInfo.name);


            string destinationFolder = Paths.ReportsPath + "//RARS";
            zipPath = Path.Combine(destinationFolder, BaseInfo.baseInfo.name + ".zip");

            try
            {

                if (Directory.Exists(folderToCompress))
                {
                    // Delete the existing ZIP file if it exists
                    if (File.Exists(zipPath))
                    {
                        File.Delete(zipPath);
                    }


                    if (!Directory.Exists(destinationFolder))
                    {
                        Directory.CreateDirectory(destinationFolder);
                    }


                    ZipFile.CreateFromDirectory(folderToCompress, zipPath, CompressionLevel.Optimal, false);
                    Console.WriteLine("Folder compressed to ZIP archive successfully.");

                }
                else
                {
                    MessageBox.Show("يجب عليك الحفظ أولاً", "Save First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access to the path is denied: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void WhatsAppImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(zipPath))
            {
                MessageBox.Show("يجب عليك حفظ الملف المضغوط أولاً", "Save First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Thread serviceThread = new Thread(() =>
                {
                    try
                    {
                        Whatsapp_Share relnServ = new Whatsapp_Share();
                        relnServ.FilePath = zipPath;
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
        }

        private void TelegramImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(zipPath))
            {
                MessageBox.Show("يجب عليك حفظ الملف المضغوط أولاً", "Save First", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Telegram_Share telegram = new Telegram_Share();
                telegram.FilePath = zipPath;
                telegram.Show();
            }
        }
    }
}

