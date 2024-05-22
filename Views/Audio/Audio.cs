using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
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
        static AudioMode mode = AudioMode.None;
        static WaveInEvent waveIn = new WaveInEvent();
        static WaveFileWriter waveFileWriter = null;
        static WaveOutEvent outputDevice = new WaveOutEvent();
        public Audio()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (mode == AudioMode.None)
            {
                mode = AudioMode.Recording;
                File.Delete("C:\\Temp\\audio.wav");
                waveIn.WaveFormat = new WaveFormat(44100, 1); // 44100 Hz, mono
                waveIn.DataAvailable += (sender, e) =>
                {
                    // Initialize the WaveFileWriter on the first call to the DataAvailable event
                    Directory.CreateDirectory("C:\\Temp");
                    waveFileWriter ??= new WaveFileWriter("C:\\Temp\\audio.wav", waveIn.WaveFormat);
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
                waveIn.StopRecording();
                waveFileWriter?.Dispose();
            }
            else if (mode == AudioMode.Listening)
            {
                mode = AudioMode.None;
                outputDevice.Stop();
            }
        }
        private void Play_Click(object sender, EventArgs e)
        {
            if (mode == AudioMode.None)
            {
                if (File.Exists("C:\\Temp\\audio.wav"))
                {
                    mode = AudioMode.Listening;
                    WaveFileReader reader = new WaveFileReader("C:\\Temp\\audio.wav");
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(reader);
                    outputDevice.Play();
                    outputDevice.PlaybackStopped += (object sender, StoppedEventArgs e) =>
                    {
                        if (mode == AudioMode.Listening)
                        {
                            mode = AudioMode.None;
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
                    relnServ.FilePath = "C:\\Temp\\audio.wav";
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
