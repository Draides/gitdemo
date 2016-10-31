using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestForJenkins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 5);
        }
    }
}
