using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.MSTest
{
    [TestClass]
    public class Multiply
    {
        [TestMethod]
        public void MultiplyPositiveIntegers()
        {
            Assert.AreEqual(25, Calc.Multiply(5, 5));
        }

        [TestMethod]
        public void MultiplyPositiveZeroIntegers()
        {
            Assert.AreEqual(0, Calc.Multiply(5, 0));
        }

        [TestMethod]
        public void MultiplyPositiveNegativeIntegers()
        {
            Assert.AreEqual(-25, Calc.Multiply(5, -5));
        }

        [TestMethod]
        public void MultiplyNegativeIntegers()
        {
            Assert.AreEqual(25, Calc.Multiply(-5, -5));
        }

        [TestMethod]
        public void MultiplyNegativeZeroIntegers()
        {
            Assert.AreEqual(0, Calc.Multiply(0, -5));
        }
    }
}
