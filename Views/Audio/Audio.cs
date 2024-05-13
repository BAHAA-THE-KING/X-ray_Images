using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;

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
	}
}
