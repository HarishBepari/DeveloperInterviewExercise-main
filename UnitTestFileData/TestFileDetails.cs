using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace UnitTestFileData
{
    public class TestFileDetails :IFileDetails
    {
        private readonly Random _random = new Random();

        public string Version(string filePath)
        {
            return string.Format("{0}.{1}.{2}", _random.Next(5), _random.Next(8), _random.Next(22));            
        }

        public int Size(string filePath)
        {
            return _random.Next(100000) + 1000000;
        }
    }
}
