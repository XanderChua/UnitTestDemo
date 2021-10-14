using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestDemo;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        Mock<ICalculator> calculatormock;
        [TestInitialize]
        public void Initialize()
        {
            Program.addResult = Program.divResult = Program.mulResult = Program.minResult = 0;
            calculatormock = new Mock<ICalculator>(MockBehavior.Default);
            calculatormock.CallBase = false;
            calculatormock.Setup(x => x.Add(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Min(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Mul(10, 15)).Returns(10);
            calculatormock.Setup(x => x.Div(10, 15)).Returns(10);
            Program.calc = calculatormock.Object;
        }

        [TestMethod]
        public void TestAddition()
        {
            Program.CallCalculatorMethods(10, 15);
            //Assert.AreEqual(Program.addResult, 25);
            //Assert.AreEqual(Program.divResult, 0);
            //Assert.AreEqual(Program.mulResult, 150);
            //Assert.AreEqual(Program.minResult, -5);
            Assert.AreEqual(Program.addResult, 10);
            Assert.AreEqual(Program.divResult, 10);
            Assert.AreEqual(Program.mulResult, 10);
            Assert.AreEqual(Program.minResult, 10);
        }

        [TestCleanup]
        public void Cleanup()
        {
            calculatormock.VerifyAll();
        }

    }
}
