using System;
using NUnit;
using NUnit.Framework;

namespace Task_3._1.Nunit
{
    [TestFixture]
    public class MultiplyTestCases : BaseNunitTestClass
    {
        [TestCase(10, 15)]
        [TestCase(-10, -15)]
        [TestCase(-10, 15)]
        public void CheckMultiplyTwoInt(int number1, int number2)
        {
            int result = number1 * number2;
            //Assert
            Assert.AreEqual(result, calculator.Multiply(number1, number2));
        }

        [TestCase(10.1, 15.1)]
        [TestCase(-10.1, -15.1)]
        [TestCase(-10.1, 15.1)]
        public void CheckMultiplyTwoDouble(double number1, double number2)
        {
            double result = number1 * number2;
            //Assert
            Assert.AreEqual(result, calculator.Multiply(number1, number2));
        }

        [TestCase(10, 15.1)]
        [TestCase(-10, -15.1)]
        [TestCase(-10, 15.1)]
        [TestCase(10, -15.1)]
        public void CheckMultiplyIntAndDouble(int number1, double number2)
        {
            double result = number1 * number2;
            //Assert
            Assert.AreEqual(result, calculator.Multiply(number1, number2));
        }

        [TestCase(10, 0)]
        [TestCase(-10, 0)]
        public void CheckMultiplyZeroInt(int number1, int number2)
        {
            int result = number1 * number2;
            //Assert
            Assert.AreEqual(result, calculator.Multiply(number1, number2));
        }

        [TestCase(10.1, 0.0)]
        [TestCase(-10.1, 0.0)]
        public void CheckMultiplyZeroDouble(double number1, double number2)
        {
            double result = number1 * number2;
            //Assert
            Assert.AreEqual(result, calculator.Multiply(number1, number2));
        }
    }
}
