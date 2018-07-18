using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProject
{
    [TestCategory("Power operations")]
    [TestClass]
    public class CalculatorPowerTests: BaseTest
    {
        
        [TestMethod]
        [DataRow(4d, 2d, 16)]
        [DataRow(2.5, 2.0, 6.25)]
        [DataRow("5", "2", 25)]
        public void PowerTest(object a, object b, double result)
        {
            var actualResult = Calculator.Pow(a, b);

            Assert.AreEqual(result, actualResult);
        }

               [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericDataPowerTest()
        {
            var a = "qqq";
            var b = "10";

            Calculator.Pow(a, b);
        }

        [TestMethod]
        [DataRow(16, 4)]
        [DataRow(6.25, 2.5)]
        [DataRow("25", 5)]
        public void SqrtTest(object a, double result)
        {
            var actualResult = Calculator.Sqrt(a);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericSqrtDataTest()
        {
            var a = "qqq";

            Calculator.Sqrt(a);
        }
    }
}
