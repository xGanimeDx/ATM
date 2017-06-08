using System;
using NUnit;
using NUnit.Framework;

namespace Task_3._1.Nunit
{
    [TestFixture]
    public class SubTestCases : BaseNunitTestClass
    {
        [Test]
        [TestCase(10, 15)]
        [TestCase(10, -15)]
        [TestCase(-10, 15)]
        [TestCase(-10, -15)]
        public void CheckSubTwoInt(int number1, int number2)
        {
            int result = number1 - number2;
            //Assert		
            Assert.AreEqual(result, calculator.Sub(number1, number2));
        }

        [Test]
        [TestCase(10.1, 15.1)]
        [TestCase(10.1, -15.1)]
        [TestCase(-10.1, 15.1)]
        [TestCase(-10.1, -15.1)]
        public void CheckSubTwoDouble(double number1, double number2)
        {
            double result = number1 + number2;
            //Assert
            Assert.AreEqual(result, calculator.Sub(number1, number2));
        }

        [Test]
        [TestCase(10, 15.1)]
        [TestCase(10, -15.1)]
        [TestCase(-10, 15.1)]
        [TestCase(-10, -15.1)]
        public void CheckSubIntAndDouble(int number1, double number2)
        {
            double result = number1 + number2;
            //Assert
            Assert.AreEqual(result, calculator.Sub(number1, number2));
        }

        [TestMethod]
        public void CheckAddTwoStringIntPositive()
        {
            string number1 = "10";
            string number2 = "15";
            int result = Convert.ToInt32(number1) + Convert.ToInt32(number2);
            //Assert
            Assert.AreEqual(result, calculator.Add(number1, number2));
        }

        [TestMethod]
        public void CheckAddTwoStringDoublePositive()
        {
            string number1 = "10.1";
            string number2 = "15.1";
            double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            //Assert
            Assert.AreEqual(result, calculator.Add(number1, number2));
        }

        [TestMethod]
        public void CheckAddTwoStringIntNegative()
        {
            string number1 = "-10";
            string number2 = "-15";
            int result = Convert.ToInt32(number1) + Convert.ToInt32(number2);
            //Assert
            Assert.AreEqual(result, calculator.Add(number1, number2));
        }

        [TestMethod]
        public void CheckAddTwoStringDoubleNegative()
        {
            string number1 = "-10.1";
            string number2 = "-15.1";
            double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            //Assert
            Assert.AreEqual(result, calculator.Add(number1, number2));
        }

        [TestMethod]
        public void CheckAddStringIntPositiveStringDoubleNegative()
        {
            string number1 = "10";
            string number2 = "-15.1";
            double result = Convert.ToInt32(number1) + Convert.ToDouble(number2);
            //Assert
            Assert.AreEqual(result, calculator.Add(number1, number2));
        }

        [TestMethod]
        public void CheckAddStringIntNegativeStringDoublePositive()
        {
            string number1 = "-10";
            string number2 = "15.1";
            double result = Convert.ToInt32(number1) + Convert.ToDouble(number2);
            //Assert
            Assert.AreEqual(result, calculator.Add(number1, number2));
        }

        [Test]
        public void CheckSubTwoIntZero()
        {
            int number1 = 0;
            int number2 = 0;
            int result = number1 + number2;
            //Assert
            Assert.AreEqual(result, calculator.Sub(number1, number2));
        }

        [Test]
        public void CheckSubTwoDoubleZero()
        {
            double number1 = 0.0;
            double number2 = 0.0;
            double result = number1 + number2;
            //Assert
            Assert.AreEqual(result, calculator.Sub(number1, number2));
        }

        [Test]
        public void CheckAddStringValue()
        {
            //Assert
            Assert.Throws<NotFiniteNumberException>(() => calculator.Sub("string1", "string2"));
        }
    }
}
