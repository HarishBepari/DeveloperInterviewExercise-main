using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace UnitTestFileData
{
    public static class TestBootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IFileDetails, TestFileDetails>();
        }
    }
}
