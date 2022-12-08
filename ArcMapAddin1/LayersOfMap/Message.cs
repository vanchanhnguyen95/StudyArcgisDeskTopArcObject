using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayersOfMap
{
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private async void BtnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxFilePath.Text = openFileDialog1.FileName;
                await Task.Run(() => UploadFileAsync(txtBoxFilePath.Text));
            }
        }

        public static async Task UploadFileAsync(string path)
        {
            HttpClient client = new HttpClient();
            // we need to send a request with multipart/form-data
            var multiForm = new MultipartFormDataContent();

            // add file and directly upload it
            System.IO.FileStream fs = File.OpenRead(path);
            multiForm.Add(new StreamContent(fs), "files", Path.GetFileName(path));

            // send request to API
            var url = "https://localhost:5001/api/v1/FileSpeedProvider/UploadFile";
            var response = await client.PostAsync(url, multiForm);
            if (response.IsSuccessStatusCode)
            {
                var contents = await response.Content.ReadAsStringAsync();
                var responseData = JsonConvert.DeserializeObject<ResponseData>(contents);
                MessageBox.Show(responseData.Status);
            }
            else
            {
                MessageBox.Show(response.ToString());
            }

        }

        public class ResponseData
        {
            public string Status { get; set; }
            public string Data { get; set; }
            public string FilePath { get; set; }
            public string Message { get; set; }

        }

    }
}
