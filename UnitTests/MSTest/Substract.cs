using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTests
{
    [TestClass]
    public class Substract
    {
        [TestMethod]
        public void SubstractPositiveIntegers()
        {
            Assert.AreEqual(0, Calc.Substract(5, 5));
        }

        [TestMethod]
        public void SubstractPositiveNegativeIntegers()
        {
            Assert.AreEqual(10, Calc.Substract(5, -5));
        }

        [TestMethod]
        public void SubstractNegativeIntegers()
        {
            Assert.AreEqual(0, Calc.Substract(-5, -5));
        }
    }
}
