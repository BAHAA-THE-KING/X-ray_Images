using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
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
        public Audio()
        {
            InitializeComponent();
            ControlViews();
        }
        // Control View
        void ActivateElement(Control pictureBox)
        {
            pictureBox.Visible = true;
        }
        void InactivateElement(Control pictureBox)
        {
            pictureBox.Visible = false;
        }
        void ControlViews()
        {
            if (mode == AudioMode.None)
            {
                ActivateElement(StartImage);
                ActivateElement(PlayImage);
                InactivateElement(StopImage);
                InactivateElement(RecordingLabel);
                InactivateElement(ListeningLabel);
            }
            else if (mode == AudioMode.Listening)
            {
                InactivateElement(StartImage);
                InactivateElement(PlayImage);
                ActivateElement(StopImage);
                InactivateElement(RecordingLabel);
                ActivateElement(ListeningLabel);
            }
            else if (mode == AudioMode.Recording)
            {
                InactivateElement(StartImage);
                InactivateElement(PlayImage);
                ActivateElement(StopImage);
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
                if (File.Exists(Paths.AudioTempFile)) File.Delete(Paths.AudioTempFile);
                waveIn = new WaveInEvent();
                waveFileWriter = null;
                waveIn.WaveFormat = new WaveFormat(44100, 1); // 44100 Hz, mono
                waveIn.DataAvailable += (sender, e) =>
                {
                    // Initialize the WaveFileWriter on the first call to the DataAvailable event
                    Directory.CreateDirectory(Paths.AudioTempDir);
                    waveFileWriter ??= new WaveFileWriter(Paths.AudioTempFile, waveIn.WaveFormat);
                    // Write the recorded audio data to the WAV file
                    waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
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
            }
            else if (mode == AudioMode.Listening)
            {
                mode = AudioMode.None;
                ControlViews();
                reader.Close();
            }
        }
        private void Play_Click(object sender, EventArgs e)
        {
            if (mode == AudioMode.None)
            {
                if (File.Exists(Paths.AudioTempFile))
                {
                    mode = AudioMode.Listening;
                    ControlViews();
                    reader = new WaveFileReader(Paths.AudioTempFile);
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
                    relnServ.FilePath = Paths.AudioTempFile;
                    relnServ.IsDoc = true;
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
}
