using System;
using GeneralSys.Infrastructure.Log;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralSys.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LoggerFactory.Debug("as");
        }
    }
}
