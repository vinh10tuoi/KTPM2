using maytinh;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace cal.tester
{
    [TestClass]
    public class UnitTest1
    {
        private calculation myCal;

        [TestInitialize]
        public void SetUp()
        {
            this.myCal = new calculation(10, 5);
        }

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(myCal.ex("+"), 15);
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(myCal.ex("-"), 5);
        }

        [TestMethod]
        public void TestMul()
        {
            Assert.AreEqual(myCal.ex("*"), 50);
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(myCal.ex("/"), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideZero()
        {
            calculation c = new calculation(10, 0);
            c.ex("/");
        }
    }
}
