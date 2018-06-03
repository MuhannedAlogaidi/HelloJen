using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;
namespace HelloTestJenk
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Jenkins for Test and Deployment", Program.CreateMessage());
        }
    }
}
