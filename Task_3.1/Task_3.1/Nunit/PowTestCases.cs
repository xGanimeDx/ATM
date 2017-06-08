using System;
using NUnit;
using NUnit.Framework;

namespace Task_3._1.Nunit
{
    [TestFixture]
    public class PowTestCases : BaseNunitTestClass
    {
        [Test]
        [TestCase(100, 3)]
        [TestCase(100, -3)]
        [TestCase(-100, 3)]
        [TestCase(-100, -3)]
        public void CheckPowTwoInt(int number1, int number2)
        {
            double result = Math.Pow(number1, number2);
            //Assert
            Assert.AreEqual(result, calculator.Pow(number1, number2));
        }

        [Test]
        [TestCase(100.1, 3.1)]
        [TestCase(100.1, -3.1)]
        [TestCase(-100.1, 3.1)]
        [TestCase(-100.1, -3.1)]
        public void CheckPowTwoDouble(double number1, double number2)
        {
            double result = Math.Pow(number1, number2);
            //Assert
            Assert.AreEqual(result, calculator.Pow(number1, number2));
        }

        [Test]
        [TestCase(100, 3.1)]
        [TestCase(100, -3.1)]
        [TestCase(-100, 3.1)]
        [TestCase(-100, -3.1)]
        public void CheckPowIntAndDoublePow(int number1, double number2)
        {
            double result = Math.Pow(number1, number2);
            //Assert
            Assert.AreEqual(result, calculator.Pow(number1, number2));
        }

        [Test]
        [TestCase(100.1, 3)]
        [TestCase(100.1, -3)]
        [TestCase(-100.1, 3)]
        [TestCase(-100.1, -3)]
        public void CheckPowDoubleAndIntPow(double number1, int number2)
        {
            double result = Math.Pow(number1, number2);
            //Assert
            Assert.AreEqual(result, calculator.Pow(number1, number2));
        }

        [Test]
        [TestCase("100", "3")]
        [TestCase("100", "-3")]
        [TestCase("-100", "3")]
        [TestCase("-100", "-3")]
        public void CheckPowTwoStringInt(string number1, string number2)
        {
            double result = Math.Pow(Convert.ToInt32(number1), Convert.ToInt32(number2));
            //Assert
            Assert.AreEqual(result, calculator.Pow(number1, number2));
        }

        [Test]
        [TestCase("100.1", "3.1")]
        [TestCase("100.1", "-3.1")]
        [TestCase("-100.1", "3.1")]
        [TestCase("-100.1", "-3.1")]
        public void CheckPowTwoStringDouble(string number1, string number2)
        {
            double result = Math.Pow(Convert.ToDouble(number1), Convert.ToDouble(number2));
            //Assert
            Assert.AreEqual(result, calculator.Pow(number1, number2));
        }

        [Test]
        public void CheckPowStrings()
        {
            string someText1 = "some text";
            string someText2 = "some text";
            //Assert
            Assert.Throws<NotFiniteNumberException>(() => calculator.Pow(someText1, someText2));
        }
    }
}
