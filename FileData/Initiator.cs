using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class Initiator
    {
       IFileDetails _fileDetails;
        public Initiator(IFileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }
        public string fileVersion(string filePath)
        {
            return _fileDetails.Version(filePath);
        }
        public int fileSize(string filePath)
        {
            return _fileDetails.Size(filePath);
        }
    }
}
