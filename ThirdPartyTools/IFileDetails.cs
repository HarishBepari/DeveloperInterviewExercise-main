using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyTools
{
   public interface IFileDetails
    {
        string Version(string filePath);
        int Size(string filePath);
       
    }
}
