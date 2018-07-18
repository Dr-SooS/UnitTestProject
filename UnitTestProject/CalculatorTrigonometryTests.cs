using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProject
{
    [TestCategory("Trigonometry operations")]
    [TestClass]
    public class CalculatorTrigonometryTests: BaseTest
    {

        [TestMethod]
        [DataRow(30, -0.99)]
        [DataRow("90", 0.89)]
        public void SinTest(object a, double result)
        {
            var actualResult = Math.Round(Calculator.Sin(a), 2);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericSinDataTest()
        {
            var a = "qqq";

            Calculator.Sin(a);
        }

        [TestMethod]
        [DataRow(30, 0.15)]
        [DataRow("90", -0.45)]
        public void CosTest(object a, double result)
        {
            var actualResult = Math.Round(Calculator.Cos(a), 2);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericCosDataTest()
        {
            var a = "qqq";

            Calculator.Cos(a);
        }
    }
}
