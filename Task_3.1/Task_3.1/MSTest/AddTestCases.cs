using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3._1.MSTest
{
	[TestClass]
	public class AddTestCases : BaseMSTestClass
	{
		[TestMethod]
		public void CheckAddTwoIntPositive()
		{
			int number1 = 10;
			int number2 = 15;
			int result = number1 + number2;	

			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoDoublePositive()
		{
			double number1 = 10.1;
			double number2 = 15.1;
			double result = number1 + number2;

			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoIntNegative()
		{
			int number1 = -10;
			int number2 = -15;
			int result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoDoubleNegative()
		{
			double number1 = -10.1;
			double number2 = -15.1;
			double result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddIntPositiveAndNegative()
		{
			int number1 = 10;
			int number2 = -15;
			int result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddDoublePositiveAndNegative()
		{
			double number1 = 10.1;
			double number2 = -15.1;
			double result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddIntPositiveDoublePositive()
		{
			int number1 = 10;
			double number2 = 15.1;
			double result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddIntNegativeDoubleNegative()
		{
			int number1 = -10;
			double number2 = -15.1;
			double result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddIntPositiveDoubleNegative()
		{
			int number1 = 10;
			double number2 = -15.1;
			double result = number1 + number2;

			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddIntNegativeDoublePositive()
		{
			int number1 = -10;
			double number2 = 15.1;
			double result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoStringIntPositive()
		{
			string number1 = "10";
			string number2 = "15";
			int result = Convert.ToInt32(number1) + Convert.ToInt32(number2);
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoStringDoublePositive()
		{
			string number1 = "10.1";
			string number2 = "15.1";
			double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoStringIntNegative()
		{
			string number1 = "-10";
			string number2 = "-15";
			int result = Convert.ToInt32(number1) + Convert.ToInt32(number2);
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoStringDoubleNegative()
		{
			string number1 = "-10.1";
			string number2 = "-15.1";
			double result = Convert.ToDouble(number1) + Convert.ToDouble(number2);
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddStringIntPositiveStringDoubleNegative()
		{
			string number1 = "10";
			string number2 = "-15.1";
			double result = Convert.ToInt32(number1) + Convert.ToDouble(number2);
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddStringIntNegativeStringDoublePositive()
		{
			string number1 = "-10";
			string number2 = "15.1";
			double result = Convert.ToInt32(number1) + Convert.ToDouble(number2);
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoIntZero()
		{
			int number1 = 0;
			int number2 = 0;
			int result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		public void CheckAddTwoDoubleZero()
		{
			double number1 = 0.0;
			double number2 = 0.0;
			double result = number1 + number2;
			
			Assert.AreEqual(result, calculator.Add(number1, number2));
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void CheckAddStringValue()
		{			
			calculator.Add("string1", "string2");
		}
	}
}
