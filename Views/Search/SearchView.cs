using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_ray_Images.Views.Search
{
    public partial class SearchView : Form
    {
        Action showHome;
        public SearchView(Action showHome)
        {
            InitializeComponent();

            this.showHome = showHome;

            comboBox_minSize.SelectedIndex = 1;
            comboBox_maxSize.SelectedIndex = 1;

            listView.LargeImageList = imageList;
        }

        private void search_button_Click(object sender, EventArgs e)
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
            else
            {
                FileInfo[] images = Classes.Search.SearchImages(folderPath, minSize, maxSize, minDate, maxDate);
                MessageBox.Show(images.Length.ToString() + " images was found");
                DisplayResults(images);
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                Folder_Path.Text = browser.SelectedPath;
            }
        }

        private void DisplayResults(FileInfo[] files)
        {
            listView.Items.Clear();
            imageList.Images.Clear();

            foreach (var file in files)
            {
                try
                {
                    Image img = Image.FromFile(file.FullName);
                    imageList.Images.Add(file.Name, img);

                    var listViewItem = new ListViewItem(file.Name);
                    listViewItem.ImageKey = file.Name;
                    listView.Items.Add(listViewItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image {file.Name}: {ex.Message}");
                }
            }
        }

    }
}
