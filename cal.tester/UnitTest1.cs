using maytinh;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace cal.tester
{
    [TestClass]


    public class UnitTest1
    {
        private calculation myCal;

        public TestContext TestContext { get; set; }

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


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"C:\Users\admin\Desktop\ktpm\maytinh\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestDataWithSource()
        {
            int a, b, expected, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());

            calculation c = new calculation(a, b);
            actual = c.ex(operation);
            Assert.AreEqual(expected, actual);
        }
    }
}
