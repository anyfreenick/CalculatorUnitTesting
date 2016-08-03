using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTests
{
    [TestClass]
    public class Sum
    {
        [TestMethod]
        public void SumPositiveIntegers()
        {
            Assert.AreEqual(10, Calc.Sum(5, 5));
        }

        [TestMethod]
        public void SumPositiveNegativeIntegers()
        {
            Assert.AreEqual(0, Calc.Sum(-5, 5));
        }

        [TestMethod]
        public void SumNegativeIntegers()
        {
            Assert.AreEqual(-10, Calc.Sum(-5, -5));
        }        
    }
}
