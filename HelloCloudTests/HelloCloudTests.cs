using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloCloud;

namespace HelloCloudTests
{
    [TestClass]
    public class HelloCloudTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Cloud", Program.CreateMessage());
        }
    }
}
