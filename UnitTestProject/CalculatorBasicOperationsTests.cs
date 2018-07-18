using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProject
{
    [TestCategory("Basic Operations")]
    [TestClass]
    public class CalculatorBasicOperationsTests: BaseTest
    {
        [DeploymentItem("Resources")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "SubstractionData.csv",
            "SubstractionData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void SubstractionTest()
        {
            var a = TestContext.DataRow["firstNum"];
            var b = TestContext.DataRow["secondNum"];
            var expectedResult = TestContext.DataRow["expectedResult"];
            
            var actualAdditionResult = Calculator.Sub(a, b);

            Assert.AreEqual(Convert.ToDouble(expectedResult), actualAdditionResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void NonNumericSubstractionDataTest()
        {
            var a = "qqq";
            var b = "10";

            Calculator.Sub(a, b);
        }

        [TestMethod]
        [DataRow(6d, 5d, 11)]
        [DataRow(7.5, -7.5, 0)]
        [DataRow("3", "15", 18)]
        public void AdditionTest(object a, object b, double result)
        {
            var actualResult = Calculator.Add(a, b);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void NonNumericAdditionDataTest()
        {
            var a = "qqq";
            var b = "10";

            Calculator.Add(a, b);
        }
        
        [TestMethod]
        [DataRow(6, 5, 30)]
        [DataRow(7, 7, 49)]
        [DataRow("2.5", "2.5", 6.25)]
        public void MultiplicationTest(double a, double b, double result)
        {
            var actualResult = Calculator.Multiply(a, b);

            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [DataRow(30, 6, 5)]
        [DataRow(6.25, 2.5, 2.5)]
        [DataRow("15", "3", 5)]
        public void DivisionTest(double a, double b, double result)
        {
            var actualResult = Calculator.Divide(a, b);

            Assert.AreEqual(result, actualResult);
        }
    }
}
