using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsDemo;

namespace JenkinsDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMessage_Returns_Correct_String()
        {
            Assert.AreEqual(Program.GetMessage(), "Hello Jenkins!");
        }
    }
}
