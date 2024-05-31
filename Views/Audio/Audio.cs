using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using WTelegramClientTestWF;
using X_ray_Images.Classes;
using X_ray_Images.Views.Share;

namespace X_ray_Images
{
    enum AudioMode
    {
        None = 0,
        Recording = 1,
        Listening = 2,
    };
    public partial class Audio : Form
    {
        AudioMode mode = AudioMode.None;
        WaveInEvent waveIn;
        WaveFileWriter? waveFileWriter;
        WaveFileReader reader;
        WaveOutEvent outputDevice;
        string path = "";
        public Audio(string path, string title)
        {
            InitializeComponent();
            ControlViews();
            this.path = path;
            MainLabel.Text = title;
        }
        // Control View
        void ActivateElement(Control control)
        {
            control.Visible = true;
        }
        void InactivateElement(Control control)
        {
            control.Visible = false;
        }
        void ControlViews()
        {
            if (mode == AudioMode.None)
            {
                ActivateElement(StartPanel);
                ActivateElement(PlayPanel);
                InactivateElement(StopPanel);
                InactivateElement(RecordingLabel);
                InactivateElement(ListeningLabel);
            }
            else if (mode == AudioMode.Listening)
            {
                InactivateElement(StartPanel);
                InactivateElement(PlayPanel);
                ActivateElement(StopPanel);
                InactivateElement(RecordingLabel);
                ActivateElement(ListeningLabel);
            }
            else if (mode == AudioMode.Recording)
            {
                InactivateElement(StartPanel);
                InactivateElement(PlayPanel);
                ActivateElement(StopPanel);
                ActivateElement(RecordingLabel);
                InactivateElement(ListeningLabel);
            }
        }

        // Functionality
        private void Start_Click(object sender, EventArgs e)
        {
            if (mode == AudioMode.None)
            {
                mode = AudioMode.Recording;
                ControlViews();
                if (File.Exists(path)) File.Delete(path);
                waveIn = new WaveInEvent();
                waveFileWriter = null;
                waveIn.WaveFormat = new WaveFormat(44100, 1); // 44100 Hz, mono
                waveIn.DataAvailable += (sender, e) =>
                {
                    // Initialize the WaveFileWriter on the first call to the DataAvailable event
                    Directory.CreateDirectory(Paths.AudioTempDir);
                    waveFileWriter ??= new WaveFileWriter(path, waveIn.WaveFormat);
                    // Write the recorded audio data to the WAV file
                    waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
                };

                waveIn.RecordingStopped += (sender, e) =>
                {
                    if (!waveFileWriter.CanWrite) waveFileWriter.Flush();
                };

                waveIn.StartRecording();
            }
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            if (mode == AudioMode.Recording)
            {
                mode = AudioMode.None;
                ControlViews();
                waveIn.StopRecording();
                waveFileWriter.Close();
                waveFileWriter.Dispose();
                //waveFileWriter = null;
            }
            else if (mode == AudioMode.Listening)
            {
                mode = AudioMode.None;
                ControlViews();
                reader.Close();
                reader.Dispose();
                reader = null;
            }
        }
        private void Play_Click(object sender, EventArgs e)
        {
            if (mode == AudioMode.None)
            {
                if (File.Exists(path))
                {
                    mode = AudioMode.Listening;
                    ControlViews();
                    reader = new WaveFileReader(path);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(reader);
                    outputDevice.Play();
                    outputDevice.PlaybackStopped += (object sender, StoppedEventArgs e) =>
                    {
                        if (mode == AudioMode.Listening)
                        {
                            mode = AudioMode.None;
                            ControlViews();
                            reader.Close();
                        }
                    };
                }
            }
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WhatsAppImage_Click(object sender, EventArgs e)
        {
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

        private void TelegramImage_Click(object sender, EventArgs e)
        {
            Telegram_Share telegram = new Telegram_Share();
            telegram.FilePath = path;
            telegram.Show();
        }
    }
}
