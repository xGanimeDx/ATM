using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3._1.MSTest
{
	[TestClass]
	public class AbsTestCases : BaseMSTestClass
	{
		[TestMethod]
		public void CheckAbsIntPositiveValue()
		{
			int number = 10;
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsDoublePositiveValue()
		{
			double number = 10.1;
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringIntPositiveValue()
		{
			string number = "10";
			Assert.AreEqual(Math.Abs(Convert.ToInt32(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringDoublePositiveValue()
		{
			string number = "10.1";
			Assert.AreEqual(Math.Abs(Convert.ToDouble(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsIntNegativeValue()
		{
			int number = -10;
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsDoubleNegativeValue()
		{
			double number = -10.1;
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringIntNegativeValue()
		{
			string number = "-10";
			Assert.AreEqual(Math.Abs(Convert.ToInt32(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringDoubleNegativeValue()
		{
			string number = "-10.1";
			Assert.AreEqual(Math.Abs(Convert.ToDouble(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsIntZeroValue()
		{
			int number = 0;
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsDoubleZeroValue()
		{
			double number = 0.0;
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringIntZeroValue()
		{
			string number = "0";
			Assert.AreEqual(Math.Abs(Convert.ToInt32(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringDoubleZeroValue()
		{
			string number = "0.0";
			Assert.AreEqual(Math.Abs(Convert.ToDouble(number)), calculator.Abs(number));
		}

		[TestMethod]
		[ExpectedException(typeof(NotFiniteNumberException))]
		public void CheckAbsInvalidStringValue()
		{
			string testString = "some text";
			calculator.Abs(testString);			
		}
	}
}
