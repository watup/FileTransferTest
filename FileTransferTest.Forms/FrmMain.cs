using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FileTransferTest.Forms.FileUploader;
using System.Linq;

namespace FileTransferTest.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // figure out the path we want to read the files from and cram it into the text box
            const string folderToPutFilesIn = "files come from here";

            var filesToSendLocation = AppDomain.CurrentDomain.BaseDirectory;
            filesToSendLocation += filesToSendLocation.EndsWith("\\") ? folderToPutFilesIn+ "\\" : "\\" + folderToPutFilesIn + "\\";

            txtFilesToSendLocation.Text = filesToSendLocation;
        }

        private void btnSendTheCrap_Click(object sender, EventArgs e)
        {
            var filesToSend = GetAllFileData();

            if (filesToSend.Any())
            {
                SendTheFiles(filesToSend);
                lblSendResponse.Text = string.Format("it looks like we sent {0} files. Way to go.", filesToSend.Count());
            }
            else
            {
                lblSendResponse.Text = "No files to send :(";
            }
        }

        /// <summary>
        /// contact the webservice and send some files
        /// </summary>
        /// <param name="filesToSend"></param>
        private void SendTheFiles(IEnumerable<FileUpload> filesToSend)
        {
            var serviceClient = new FileUploader.FileUploadServiceClient(); 
            foreach (var file in filesToSend)
            {
                // you know, why not just send a collection of files :/
                serviceClient.SendFile(file);
            }
        }

        /// <summary>
        /// get a collection of all the files with thier info that we want to send
        /// </summary>
        /// <returns></returns>
        private IEnumerable<FileUpload> GetAllFileData()
        {
            var filesToSend = new List<FileUpload>();

            var folderPath = txtFilesToSendLocation.Text;
            if (Directory.Exists(folderPath))
            {
                var dirInfo = new DirectoryInfo(folderPath);

                foreach (var file in dirInfo.GetFiles())
                {
                    using (var sr = new StreamReader(file.FullName))
                    {
                        string allTheData = sr.ReadToEnd();
                        filesToSend.Add(new FileUpload
                                           {
                                               Name = file.Name,
                                               Contents = allTheData
                                           });
                    }
                }
            }
            else
            {
                MessageBox.Show("idiot");
            }

            return filesToSend;
        }
    }
}
