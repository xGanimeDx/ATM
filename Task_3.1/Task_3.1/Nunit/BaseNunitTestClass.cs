using System;
using NUnit;
using NUnit.Framework;
using CSharpCalculator;

namespace Task_3._1.Nunit
{
    [TestFixture]
    public class BaseNunitTestClass
    {
        public Calculator calculator;
        
        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
            Console.WriteLine("Nunit test(s) are started.");
        }

        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Nunit test(s) are completed.");
        }
    }
}
