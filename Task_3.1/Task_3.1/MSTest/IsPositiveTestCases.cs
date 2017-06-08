using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3._1.MSTest
{
    [TestClass]
    public class IsPositiveTestCases : BaseMSTestClass
    {
        [TestMethod]
        public void CheckIsPositiveIntPositive()
        {
            int number = 10;
            //Assert
            Assert.AreEqual(true, calculator.isPositive(number));
        }

        [TestMethod]
        public void CheckIsPositiveIntNegative()
        {
            int number = -10;
            //Assert
            Assert.AreEqual(false, calculator.isPositive(number));
        }

        [TestMethod]
        public void CheckIsPositiveDoublePositive()
        {
            double number = 10.1;
            //Assert
            Assert.AreEqual(true, calculator.isPositive(number));
        }

        [TestMethod]
        public void CheckIsPositiveDoubleNegative()
        {
            double number = -10.1;
            //Assert
            Assert.AreEqual(false, calculator.isPositive(number));
        }

        [TestMethod]
        public void CheckIsPositiveStringIntPositive()
        {
            string number = "10";
            //Assert
            Assert.AreEqual(true, calculator.isPositive(number));
        }

        [TestMethod]
        public void CheckIsPositiveStringIntNegative()
        {
            string number = "-10";
            //Assert
            Assert.AreEqual(false, calculator.isPositive(number));
        }

        [TestMethod]
        public void CheckIsPositiveStringDoublePositive()
        {
            string number = "10.1";
            //Assert
            Assert.AreEqual(true, calculator.isPositive(number));
        }

        [TestMethod]
        public void CheckIsPositiveStringDoubleNegative()
        {
            string number = "-10.1";
            //Assert
            Assert.AreEqual(false, calculator.isPositive(number));
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void CheckIsPositiveString()
        {
            //Assert
            calculator.isPositive("string1");
        }
    }
}
