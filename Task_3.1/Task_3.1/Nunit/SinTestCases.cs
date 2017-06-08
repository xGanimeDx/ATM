using System;
using NUnit;
using NUnit.Framework;

namespace Task_3._1.Nunit
{
    [TestFixture]
    public class SinTestCases : BaseNunitTestClass
    {
        [Test]
        [TestCase(10)]
        [TestCase(-10)]
        public void CheckSinInt(int number)
        {
            //Assert
            Assert.AreEqual(Math.Sin(number), calculator.Sin(number));
        }

        [Test]
        [TestCase(10.1)]
        [TestCase(-10.1)]
        public void CheckSinDouble(double number)
        {
            //Assert
            Assert.AreEqual(Math.Sin(number), calculator.Sin(number));
        }

        [Test]
        public void CheckSinIntZero()
        {
            int number = 0;
            //Assert
            Assert.AreEqual(Math.Sin(number), calculator.Sin(number));
        }

        [Test]
        public void CheckSinDoubleZero()
        {
            double number = 0.0;
            //Assert
            Assert.AreEqual(Math.Sin(number), calculator.Sin(number));
        }

        [Test]
        [TestCase("10")]
        [TestCase("-10")]
        public void CheckSinStringInt(string number)
        {
            //Assert
            Assert.AreEqual(Math.Sin(Convert.ToInt32(number)), calculator.Sin(number));
        }

        [Test]
        [TestCase("10.1")]
        [TestCase("-10.1")]
        public void CheckSinStringDouble(string number)
        {
            //Assert
            Assert.AreEqual(Math.Sin(Convert.ToDouble(number)), calculator.Sin(number));
        }

        [Test]
        public void CheckSinStringIntZero()
        {
            string number = "0";
            //Assert
            Assert.AreEqual(Math.Sin(Convert.ToInt32(number)), calculator.Sin(number));
        }

        [Test]
        public void CheckSinStringDoubleZero()
        {
            string number = "0.0";
            //Assert
            Assert.AreEqual(Math.Sin(Convert.ToDouble(number)), calculator.Sin(number));
        }

        [Test]
        public void CheckSinStringValue()
        {
            //Assert
            Assert.Throws<NotFiniteNumberException>(() => calculator.Sin("string"));
        }
    }
}
