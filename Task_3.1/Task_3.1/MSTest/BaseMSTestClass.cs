using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace Task_3._1.MSTest
{
	[TestClass]
	public class BaseMSTestClass
	{
		//Arrange for all test cases
		public Calculator calculator;

		private TestContext testContextInstance;
		public TestContext TestContext
		{
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}

		[ClassInitialize]
		public void ClassSetup(TestContext testContext)
		{
			TestContext = testContext;
		}

		[TestInitialize]
		public void TestSetup()
		{
			calculator = new Calculator();
			Console.WriteLine("MS Unit test(s) are started.");
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			Console.WriteLine("MS Unit test(s) are completed.");
		}
	}
}