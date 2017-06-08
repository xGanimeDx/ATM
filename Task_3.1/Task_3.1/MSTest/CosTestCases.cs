using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3._1.MSTest
{
	[TestClass]
	public class CosTestCases : BaseMSTestClass
	{
		[TestMethod]
		public void CheckCosIntPositive()
		{
			int number = 10;
			//Assert
			Assert.AreEqual(Math.Cos(number), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosIntNegative()
		{
			int number = -10;
			//Assert
			Assert.AreEqual(Math.Cos(number), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosDoublePositive()
		{
			double number = 10.1;
			//Assert
			Assert.AreEqual(Math.Cos(number), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosDoubleNegative()
		{
			double number = -10.1;
			//Assert
			Assert.AreEqual(Math.Cos(number), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosIntZero()
		{
			int number = 0;
			//Assert
			Assert.AreEqual(Math.Cos(number), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosDoubleZero()
		{
			double number = 0.0;
			//Assert
			Assert.AreEqual(Math.Cos(number), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosStringIntPositive()
		{
			string number = "10";
			//Assert
			Assert.AreEqual(Math.Cos(Convert.ToInt32(number)), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosStringIntNegative()
		{
			string number = "-10";
			//Assert
			Assert.AreEqual(Math.Cos(Convert.ToInt32(number)), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosStringDoublePositive()
		{
			string number = "10.1";
			//Assert
			Assert.AreEqual(Math.Cos(Convert.ToDouble(number)), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosStringDoubleNegative()
		{
			string number = "-10.1";
			//Assert
			Assert.AreEqual(Math.Cos(Convert.ToDouble(number)), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosStringIntZero()
		{
			string number = "0";
			//Assert
			Assert.AreEqual(Math.Cos(Convert.ToInt32(number)), calculator.Cos(number));
		}

		[TestMethod]
		public void CheckCosStringDoubleZero()
		{
			string number = "0.0";
			//Assert
			Assert.AreEqual(Math.Cos(Convert.ToDouble(number)), calculator.Cos(number));
		}

		[TestMethod]
		[ExpectedException(typeof(NotFiniteNumberException))]
		public void CheckCosStringValue()
		{
			calculator.Cos("string");
		}
	}
}