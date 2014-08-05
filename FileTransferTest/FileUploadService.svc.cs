using System;
using System.IO;
using System.ServiceModel.Activation;
using System.Text;

namespace FileTransferTest.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FileUploadService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FileUploadService.svc or FileUploadService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class FileUploadService : IFileUploadService
    {
        public void SendFile(FileUpload fileUpload)
        {
            const string folderToPutFilesIn = "files go here";

            // get the location where we want to create the file
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            directoryPath += directoryPath.EndsWith("\\") ? folderToPutFilesIn+"\\" : "\\"+folderToPutFilesIn+"\\";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (var outFile = new StreamWriter(directoryPath + fileUpload.Name))
            {
                outFile.Write(fileUpload.Contents);
            }
        }

    }
}
