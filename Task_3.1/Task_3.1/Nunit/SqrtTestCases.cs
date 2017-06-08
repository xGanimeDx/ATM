﻿using System;
using NUnit;
using NUnit.Framework;

namespace Task_3._1.Nunit
{
    [TestFixture]
    public class SqrtTestCases : BaseNunitTestClass
    {
        [Test]
        [TestCase(10)]
        [TestCase(-10)]
        public void CheckSqrtInt(int number)
        {
            //Assert
            Assert.AreEqual(Math.Sqrt(number), calculator.Sqrt(number));
        }

        [Test]
        [TestCase(10.1)]
        [TestCase(-10.1)]
        public void CheckSqrtDouble(double number)
        {
            //Assert 
            Assert.AreEqual(Math.Sqrt(number), calculator.Sqrt(number));
        }

        [Test]
        [TestCase("10")]
        [TestCase("-10")]
        public void CheckSqrtStringInt(string number)
        {
            //Assert
            Assert.AreEqual(Math.Sqrt(Convert.ToInt32(number)), calculator.Sqrt(number));
        }

        [Test]
        [TestCase("10.1")]
        [TestCase("-10.1")]
        public void CheckSqrtStringDouble(string number)
        {
            //Assert
            Assert.AreEqual(Math.Sqrt(Convert.ToDouble(number)), calculator.Sqrt(number));
        }

        [Test]
        public void CheckSqrtIntZero()
        {
            int number = 0;
            //Assert
            Assert.AreEqual(Math.Sqrt(number), calculator.Sqrt(number));
        }

        [Test]
        public void CheckSqrtDoubleZero()
        {
            double number = 0.0;
            //Assert
            Assert.AreEqual(Math.Sqrt(number), calculator.Sqrt(number));
        }

        [Test]
        public void CheckSqrtStringIntZero()
        {
            string number = "0";
            //Assert
            Assert.AreEqual(Math.Sqrt(Convert.ToInt32(number)), calculator.Sqrt(number));
        }

        [Test]
        public void CheckSqrtStringDoubleZero()
        {
            string number = "0.0";
            //Assert
            Assert.AreEqual(Math.Sqrt(Convert.ToDouble(number)), calculator.Sqrt(number));
        }

        [Test]
        public void CheckSqrtString()
        {
            //Assert
            Assert.Throws<FormatException>(() => calculator.Sqrt("string"));
        }
    }
}
