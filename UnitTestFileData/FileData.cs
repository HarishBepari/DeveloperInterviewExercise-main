using System;
using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFileData
{
    [TestClass]
    public class FileData
    {
        #region "Positive senario"
        [TestMethod]
        public void TestValidVersion()
        {
           
            TestBootstrapper.Init();
            Initiator obj = DependencyInjector.Retrieve<Initiator>();
            Assert.IsNotNull(obj.fileVersion("-v"));            
        }
        [TestMethod]
        public void TestValidSize()
        {
            TestBootstrapper.Init();
            Initiator obj = DependencyInjector.Retrieve<Initiator>();
            Assert.IsNotNull(obj.fileSize("C:/test.txt"));
        }
        #endregion

        #region "negetive senario"
        [TestMethod]
        public void TestInValidVersion()
        {
            TestBootstrapper.Init();
            Initiator obj = DependencyInjector.Retrieve<Initiator>();
            Assert.AreNotEqual(obj.fileVersion("-v"),"1.1.1");
        }
        [TestMethod]
        public void TestInValidSize()
        {
            TestBootstrapper.Init();
            Initiator obj = DependencyInjector.Retrieve<Initiator>();
            Assert.AreNotEqual(obj.fileSize("C:/test.txt"), "10000");
        }
        #endregion

    }
}
