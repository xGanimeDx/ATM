using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3._1.MSTest
{
	[TestClass]
	public class DivideTestCases : BaseMSTestClass
	{
        [TestMethod]
        public void CheckDivideTwoIntPositive()
        {
            int number1 = 10;
            int number2 = 15;
            double result = number1 / number2;
            		
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideTwoDoublePositive()
        {
            double number1 = 10.1;
            double number2 = 15.1;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideTwoIntNegative()
        {
            int number1 = -10;
            int number2 = -15;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideTwoDoubleNegative()
        {
            double number1 = -10.1;
            double number2 = -15.1;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

		[Ignore]
        [TestMethod]
        public void CheckDivideIntPositiveAndNegative()
        {
            int number1 = 10;
            int number2 = -15;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideDoublePositiveAndNegative()
        {
            double number1 = 10.1;
            double number2 = -15.1;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideIntPositiveDoublePositive()
        {
            int number1 = 10;
            double number2 = 15.1;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideIntNegativeDoubleNegative()
        {
            int number1 = -10;
            double number2 = -15.1;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideIntPositiveDoubleNegative()
        {
            int number1 = 10;
            double number2 = -15.1;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideIntNegativeDoublePositive()
        {
            int number1 = -10;
            double number2 = 15.1;
            double result = number1 / number2;
            
            Assert.AreEqual(result, calculator.Divide(number1, number2));
        }

        [TestMethod]
        public void CheckDivideTwoStringIntPositive()
        {
            string number1 = "10";
            string number2 = "15";
			double result = Convert.ToInt32(number1) / Convert.ToInt32(number2);
            
            Assert.AreEqual(result, calculator.Divide(Convert.ToInt32(number1), Convert.ToInt32(number2)));
        }

        [TestMethod]
        public void CheckDivideTwoStringDoublePositive()
        {
            string number1 = "10.1";
            string number2 = "15.1";
            double result = Convert.ToDouble(number1) / Convert.ToDouble(number2);
            
            Assert.AreEqual(result, calculator.Divide(Convert.ToDouble(number1), Convert.ToDouble(number2)));
        }

        [TestMethod]
        public void CheckDivideTwoStringIntNegative()
        {
            string number1 = "-10";
            string number2 = "-15";
			double result = Convert.ToInt32(number1) / Convert.ToInt32(number2);
            
            Assert.AreEqual(result, calculator.Divide(Convert.ToInt32(number1), Convert.ToInt32(number2)));
        }

        [TestMethod]
        public void CheckDivideTwoStringDoubleNegative()
        {
            string number1 = "-10.1";
            string number2 = "-15.1";
            double result = Convert.ToDouble(number1) / Convert.ToDouble(number2);
            
            Assert.AreEqual(result, calculator.Divide(Convert.ToDouble(number1), Convert.ToDouble(number2)));
        }

        [TestMethod]
        public void CheckDivideStringIntPositiveStringDoubleNegative()
        {
            string number1 = "10";
            string number2 = "-15.1";
            double result = Convert.ToInt32(number1) / Convert.ToDouble(number2);
            
            Assert.AreEqual(result, calculator.Divide(Convert.ToInt32(number1), Convert.ToDouble(number2)));
        }

        [TestMethod]
        public void CheckDivideStringIntNegativeStringDoublePositive()
        {
            string number1 = "-10";
            string number2 = "15.1";
            double result = Convert.ToInt32(number1) / Convert.ToDouble(number2);
            
            Assert.AreEqual(result, calculator.Divide(Convert.ToInt32(number1), Convert.ToDouble(number2)));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CheckDivideTwoIntZero()
        {
            int number1 = 0;
            int number2 = 0;
            
            calculator.Divide(number1, number2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CheckDivideTwoDoubleZero()
        {
            double number1 = 0.0;
            double number2 = 0.0;
            
            calculator.Divide(number1, number2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CheckDivideIntPositiveIntZero()
        {
            int number1 = 10;
            int number2 = 0;
            
            calculator.Divide(number1, number2);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CheckDivideIntNegativeIntZero()
        {
            int number1 = -10;
            int number2 = 0;
            
            calculator.Divide(number1, number2);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CheckDivideDoublePositiveIntZero()
        {
            double number1 = 10.1;
            int number2 = 0;
            
            calculator.Divide(number1, number2);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CheckDivideDoubleNegativeIntZero()
        {
            double number1 = -10.1;
            int number2 = 0;
            
            calculator.Divide(number1, number2);

        }
    }
}
