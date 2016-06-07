using System;
using DbTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralSys.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DbModelTools.GetTableDesc("BaseRolesRsResource");
        }
    }
}
