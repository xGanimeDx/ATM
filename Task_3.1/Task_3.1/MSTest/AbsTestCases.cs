using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_3._1.MSTest
{
	[TestClass]
	public class AbsTestCases : BaseMSTestClass
	{
		//[TestMethod]
		//[DeploymentItem("ValidNumberValues.xml")]
		//[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
		//		   "|DataDirectory|\\ValidNumberValues.xml",
		//		   "Numbers",
		//			DataAccessMethod.Sequential)]
		//public void CheckValidNumbers()
		//{
		//	//Arrange
		//	var number = TestContext.DataRow["Number"];

		//	//Act
		//	var resultMath = Math.Abs(Convert.ToInt32(number));
		//	var resultCalc = calculator.Abs(number);
		//	Console.WriteLine("Value that was used: " + number);

		//	//Assert
		//	Assert.AreEqual(resultMath, resultCalc);
		//}

		[TestMethod]
		public void CheckAbsValidIntPositiveValue()
		{
			int number = 10;
			//Assert
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsValidDoublePositiveValue()
		{
			double number = 10.1;
			//Assert 
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsValidStringIntPositiveValue()
		{
			string number = "10";
			//Assert
			Assert.AreEqual(Math.Abs(Convert.ToInt32(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsValidStringDoublePositiveValue()
		{
			string number = "10.1";
			//Assert
			Assert.AreEqual(Math.Abs(Convert.ToDouble(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsValidIntNegativeValue()
		{
			int number = -10;
			//Assert
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsValidDoubleNegativeValue()
		{
			double number = -10.1;
			//Assert
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsValidStringIntNegativeValue()
		{
			string number = "-10";
			//Assert
			Assert.AreEqual(Math.Abs(Convert.ToInt32(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsValidStringDoubleNegativeValue()
		{
			string number = "-10.1";
			//Assert 
			Assert.AreEqual(Math.Abs(Convert.ToDouble(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsIntZeroValue()
		{
			int number = 0;
			//Assert
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsDoubleZeroValue()
		{
			double number = 0.0;
			//Assert
			Assert.AreEqual(Math.Abs(number), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringIntZeroValue()
		{
			string number = "0";
			//Assert
			Assert.AreEqual(Math.Abs(Convert.ToInt32(number)), calculator.Abs(number));
		}

		[TestMethod]
		public void CheckAbsStringDoubleZeroValue()
		{
			string number = "0.0";
			//Assert
			Assert.AreEqual(Math.Abs(Convert.ToDouble(number)), calculator.Abs(number));
		}

		[TestMethod]
		[ExpectedException(typeof(NotFiniteNumberException))]
		public void CheckAbsInvalidStringValue()
		{
			string testString = "some text";
			//Act and Assert
			calculator.Abs(testString);			
		}
	}
}
