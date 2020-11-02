using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_WebScraper
{
    public partial class FormWebScraper : Form
    {
        List<string> imagesList = new List<string>();
        public FormWebScraper()
        {
            InitializeComponent();

            textBoxURL.KeyDown += TextBoxURL_KeyDown;
            imagesList = new List<string>();
            buttonDownloadImages.Enabled = false;
        }

        private async Task<List<string>> DownloadImages(string path, string url, List<string> images)
        {
            List<string> exceptionMessages = new List<string>();
            String downloadFolderName = path;
            Directory.CreateDirectory(downloadFolderName);
            List<Task<byte[]>> taskList = new List<Task<byte[]>>();
            List<ImageDownload> downloadsList = new List<ImageDownload>();

            foreach (string image in images)
            {
                if (image.Contains("bmp") || image.Contains("png") || image.Contains("gif") || image.Contains("jpg") || image.Contains("jpeg"))
                {
                    string imageURL = image;
                    if (!image.Contains("http") && !image.Contains("//"))
                    {
                        string urlBase = url;
                        if (urlBase[urlBase.Length - 1] != '/' && image[0] != '/')
                        {
                            imageURL = urlBase + '/' + image;
                        }
                        else
                        {
                            imageURL = urlBase + image;
                        }
                    }
                    try
                    {
                        Uri imageURI = new Uri(imageURL);
                        HttpClient httpClient = new HttpClient();
                        Task<byte[]> imageBytes = httpClient.GetByteArrayAsync(imageURI);
                        taskList.Add(imageBytes);
                        downloadsList.Add(new ImageDownload(imageBytes, imageURI));
                    }
                    catch (Exception e)
                    {
                        exceptionMessages.Add("File URL: " + imageURL + "\nError Message: " + e.Message);
                    }
                }
            }

            while (taskList.Count > 0)
            {
                Task<byte[]> imageBytes = await Task.WhenAny(taskList.ToArray());
                Uri imageURI = null;

                for (int i = 0; i < downloadsList.Count; ++i)
                {
                    if (downloadsList[i].DownloadTask == imageBytes)
                    {
                        imageURI = downloadsList[i].URI;
                        downloadsList.RemoveAt(i);
                        break;
                    }
                }

                if (imageURI != null)
                {
                    CancellationTokenSource cancellationToken = new CancellationTokenSource();
                    using (FileStream fs = new FileStream(downloadFolderName + "//" + Path.GetFileName(imageURI.LocalPath), FileMode.Create))
                    {
                        await fs.WriteAsync(imageBytes.Result, 0, imageBytes.Result.Length);
                    }
                    cancellationToken.Token.ThrowIfCancellationRequested();
                }

                taskList.Remove(imageBytes);
            }

            return exceptionMessages;
        }

        private async Task ScrapeWebsite(string url)
        {
            try
            {
                CancellationTokenSource cancellationToken = new CancellationTokenSource();
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage request = await httpClient.GetAsync(url);
                cancellationToken.Token.ThrowIfCancellationRequested();

                Stream response = await request.Content.ReadAsStreamAsync();
                cancellationToken.Token.ThrowIfCancellationRequested();
                StreamReader reader = new StreamReader(response);

                HtmlRegExSearcher searcher = new HtmlRegExSearcher(reader.ReadToEnd());
                imagesList = searcher.GetImages();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateImageCount()
        {
            labelImagesFound.Text = imagesList.Count.ToString();
            richTextBoxLinks.Text = "";

            if (imagesList.Count > 0)
            {
                buttonDownloadImages.Enabled = true;

                foreach (string image in imagesList)
                {
                    richTextBoxLinks.AppendText(image + "\n");
                }
            }
        }

        private async void buttonExtractImages_Click(object sender, EventArgs e)
        {
            buttonDownloadImages.Enabled = false;
            await ScrapeWebsite(textBoxURL.Text);
            UpdateImageCount();
        }

        private async void TextBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonDownloadImages.Enabled = false;
                labelImagesFoundCount.Text = "";
                await ScrapeWebsite(textBoxURL.Text);
                UpdateImageCount();
            }
        }

        private async void buttonDownloadImages_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> exceptions = await DownloadImages(folderBrowserDialog.SelectedPath, textBoxURL.Text, imagesList);

                    if (exceptions.Count > 0)
                    {
                        StringBuilder errors = new StringBuilder();

                        foreach (String exception in exceptions)
                        {
                            errors.Append(exception + "\n\n");
                        }

                        MessageBox.Show(errors.ToString(), "Image Download Error(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Image Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    
 