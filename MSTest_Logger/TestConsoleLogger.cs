using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;

namespace MSTest_Logger
{
    [TestClass]
    public class TestConsoleLogger
    {
        private Logger.LogManager _logManager = Logger.LogManager.Instance;
        [TestMethod]
        public void Test_Info()
        {
            _logManager.Info("Console", "Test nachricht INFO");
        }
        [TestMethod]
        public void Test_Debug1()
        {
            _logManager.Info("Console", "Test nachricht DEBUG1");
        }
        

        
    }
}

