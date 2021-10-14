using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calculator;
        [TestInitialize]
        public void TestInitialize()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            int result = calculator.Add(10, 15);
            Assert.AreEqual(result, 25);
        }

        [TestMethod]
        public void TestSub()
        {
            int result = calculator.Min(10, 15);
            Assert.AreEqual(result, -5);
        }

        [TestMethod]
        public void TestDiv()
        {
            int result = calculator.Div(10, 15);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivWithZero()
        {
            int result = calculator.Div(10, 0);
        }

        [TestCleanup]
        public void Cleanup()
        {
            calculator = null;
        }
    }
}
