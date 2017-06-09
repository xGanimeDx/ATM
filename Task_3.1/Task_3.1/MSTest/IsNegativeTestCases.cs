using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3._1.MSTest
{
    [TestClass]
    public class IsNegativeTestCases : BaseMSTestClass
    {
        [TestMethod]
        public void CheckIsNegativeIntPositive()
        {
            int number = 10;
            Assert.AreEqual(false, calculator.isNegative(number));
        }

        [TestMethod]
        public void CheckIsNegativeIntNegative()
        {
            int number = -10;
            Assert.AreEqual(true, calculator.isNegative(number));
        }

        [TestMethod]
        public void CheckIsNegativeDoublePositive()
        {
            double number = 10.1;
            Assert.AreEqual(false, calculator.isNegative(number));
        }

        [TestMethod]
        public void CheckIsNegativeDoubleNegative()
        {
            double number = -10.1;
            Assert.AreEqual(true, calculator.isNegative(number));
        }

        [TestMethod]
        public void CheckIsNegativeStringIntPositive()
        {
            string number = "10";
            Assert.AreEqual(false, calculator.isNegative(number));
        }

        [TestMethod]
        public void CheckIsNegativeStringIntNegative()
        {
            string number = "-10";
            Assert.AreEqual(true, calculator.isNegative(number));
        }

        [TestMethod]
        public void CheckIsNegativeStringDoublePositive()
        {
            string number = "10.1";
            Assert.AreEqual(false, calculator.isNegative(number));
        }

        [TestMethod]
        public void CheckIsNegativeStringDoubleNegative()
        {
            string number = "-10.1";
            Assert.AreEqual(true, calculator.isNegative(number));
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void CheckIsNegativeString()
        {
            calculator.isNegative("string1");
        }
    }
}
