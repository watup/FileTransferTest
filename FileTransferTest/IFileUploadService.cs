﻿using System.ServiceModel;

namespace FileTransferTest.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFileUploadService
    {

        [OperationContract]
        void SendFile(FileUpload fileUpload);

    }
    
}
