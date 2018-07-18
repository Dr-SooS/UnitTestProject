using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProject
{
    [TestCategory("Zero comporation operations")]
    [TestClass]
    public class CalculatorZeroComporationTests: BaseTest
    {

        [TestMethod]
        [DataRow(30, false)]
        [DataRow("-90", true)]
        [DataRow(0, false)]
        public void IsNegativeTest(object a, bool result)
        {
            var actualResult = Calculator.isNegative(a);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericIsNegativeDataTest()
        {
            var a = "qqq";

            Calculator.isNegative(a);
        }

        [TestMethod]
        [DataRow(30, true)]
        [DataRow("-90", false)]
        [DataRow(0, false)]
        public void IsPositiveTest(object a, bool result)
        {
            var actualResult = Calculator.isPositive(a);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericIsPositiveDataTest()
        {
            var a = "qqq";

            Calculator.isPositive(a);
        }
    }
}
