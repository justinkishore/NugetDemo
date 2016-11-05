using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NugetDemo;
using HelloWorldHlpr;

namespace TestNugetDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Hello World!";
            string actual = (new Greetings()).msgInEnglish();
            Assert.AreEqual(expected, actual, "Greeting message did not match!");
        }
    }
}
