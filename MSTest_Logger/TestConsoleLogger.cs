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
            
        }


        private void PrepareChannel()
        {
            _logManager.AddChannel("console", new Logger.ChannelConsole());
        }
    }
}

