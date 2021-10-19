using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IFileDetails, FileDetails>();
        }
    }
}
