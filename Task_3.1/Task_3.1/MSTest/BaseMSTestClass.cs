using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace Task_3._1.MSTest
{
	[TestClass]
	public class BaseMSTestClass
	{
		public Calculator calculator;

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