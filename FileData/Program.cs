using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Task 1 
                //dependency resolved
                Bootstrapper.Init();

                //generic class for dependency Retrieve
                Initiator obj = DependencyInjector.Retrieve<Initiator>();
               
                if (args[0]=="-v" || args[0] == "--v" || args[0] == "/v" || args[0] == "--version")
                {

                    Console.WriteLine("{0}", obj.fileVersion(args[0]));
                }
                //Task 2 
                else if (args[0] == "-s" || args[0] == "--s" || args[0] == "/s" || args[0] == "--size")
                {
                    Console.WriteLine("{0}", obj.fileSize(args[1]));
                } 
                Console.ReadKey();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
