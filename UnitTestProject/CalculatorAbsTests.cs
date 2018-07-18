using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProject
{
    [TestCategory("Abs operations")]
    [TestClass]
    public class CalculatorAbsTests: BaseTest
    {

        [TestMethod]
        [DataRow(4, 4)]
        [DataRow(-2.5, 2.5)]
        [DataRow("-5", 5)]
        public void AbsTest(object a, double result)
        {
            var actualResult = Calculator.Abs(a);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericDataTest()
        {
            var a = "qqq";

            Calculator.Abs(a);
        }
    }
}
