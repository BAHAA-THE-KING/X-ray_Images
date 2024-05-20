using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_ray_Images.Views.Search
{
    public partial class SearchView : Form
    {
        private FileInfo[] images = null;
        static private ProgressBarForm progressBarForm;

        Action showHome;
        public SearchView(Action showHome)
        {
            InitializeComponent();

            this.showHome = showHome;

            comboBox_minSize.SelectedIndex = 1;
            comboBox_maxSize.SelectedIndex = 1;

            listView.LargeImageList = imageList;
        }

        private async void filter_button_Click(object sender, EventArgs e)
        {
            string folderPath = Folder_Path.Text;

            long minSize = comboBox_minSize.Text == "MB" ? (long)numeric_minimumSize.Value * 1024 * 1024 : (long)numeric_minimumSize.Value * 1024;
            long maxSize = comboBox_maxSize.Text == "MB" ? (long)numeric_maximumSize.Value * 1024 * 1024 : (long)numeric_maximumSize.Value * 1024;

            DateTime minDate = dateTime_from.Value;
            DateTime maxDate = dateTime_to.Value;

            if (minSize > maxSize)
            {
                MessageBox.Show("minimum image size is greater than maximum size...\nplease correct your input.");
            }
            else if (minDate.Date > maxDate.Date)
            {
                MessageBox.Show("beginning date is after the final date...\ncorrect it please");
            }
            else if (images == null)
            {
                MessageBox.Show("no images in this folder");
            }
            else
            {
                FileInfo[] filtered_images = Classes.Search.FilterImages(images, minSize, maxSize, minDate, maxDate);


                if (filtered_images.Length < 1)
                {
                    listView.Items.Clear();
                    imageList.Images.Clear();
                    MessageBox.Show("no images fulfill the conditions");
                    return;
                }

                Progress<int> progress = startProgress();

                await Task.Run(() => DisplayResults(filtered_images, progress));

                MessageBox.Show(filtered_images.Length.ToString() + " images found after applying filter");
            }
        }

        private async void browse_button_Click(object sender, EventArgs e)
        {
            string old = Folder_Path.Text;

            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                Folder_Path.Text = browser.SelectedPath;
            }

            if(old == Folder_Path.Text)
            {
                return;
            }

            images = Classes.Search.SearchImages(Folder_Path.Text);

            if(images == null || images.Length == 0)
            {
                MessageBox.Show("this folder has no images.");
                return;
            }

            Progress<int> progress = startProgress();

            await Task.Run(() => DisplayResults(images, progress));

            MessageBox.Show(images.Length.ToString() + " images found in folder");
        }

        private void DisplayResults(FileInfo[] files, IProgress<int> progress)
        {

            listView.Invoke((Action)(() =>
            {
                listView.Items.Clear();
                imageList.Images.Clear();
            }));

            int total_files = files.Length;
            int processed_files = 0;

            foreach (var file in files)
            {
                try
                {
                    Image img = Image.FromFile(file.FullName);

                    listView.Invoke((Action)(() =>
                    {
                        imageList.Images.Add(file.Name, img);

                        var listViewItem = new ListViewItem(file.Name);
                        listViewItem.ImageKey = file.Name;
                        listView.Items.Add(listViewItem);
                    }));

                    processed_files++;
                    int percentage = (int)((double)(processed_files *  100 / total_files));

                    progress?.Report(percentage);
                }
                catch (Exception ex)
                {
                    listView.Invoke((Action)(() =>
                    {
                        MessageBox.Show($"Error loading image {file.Name}: {ex.Message}");
                    }));
                }
            }
        }

        static private Progress<int> startProgress()
        {
            progressBarForm = new ProgressBarForm();

            ProgressBar progressBar = progressBarForm.progressBar;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            progressBarForm.Show();

            var progress = new Progress<int>(percent =>
            {
                progressBar.Value = percent;

                if (percent >= 100)
                {
                    progressBarForm.Close();
                }
            });

            return progress;
        }

    }
}
