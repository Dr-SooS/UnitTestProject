using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    public class BaseTest
    {
        public Calculator Calculator { get; set; }
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestSetup()
        {
            Console.WriteLine("Addition Test Started");
            Calculator = new Calculator();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Console.WriteLine("Test Ended");
        }
    }
}
