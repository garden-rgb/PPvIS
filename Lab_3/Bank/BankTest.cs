using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Bank
{
    [TestClass]
    public class BankTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [TestMethod]
        public void TestMethod1()
        {
            SampleBank sample = new SampleBank(15, 200, "Eugene");
            sample.Withdraw(100);
            Assert.ThrowsException<System.ArgumentException>(() => sample.Withdraw(-5));

        }
        [TestMethod]
        public void TestMethod2()
        {
            SampleBank sample = new SampleBank(15, 200, "Eugene");
            sample.CashIn(500);
            Assert.ThrowsException<System.ArgumentException>(() => sample.CashIn(500));
        }
    }
}
