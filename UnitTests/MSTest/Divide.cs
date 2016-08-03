using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.MSTest
{
    [TestClass]
    public class Divide
    {
        [TestMethod]
        public void DividePositiveIntegers()
        {
            Assert.AreEqual(1, Calc.Devide(5, 5));
        }

        [TestMethod]
        public void DivideNegativeIntegers()
        {
            Assert.AreEqual(1, Calc.Devide(-5, -5));
        }

        [TestMethod]
        public void DividePositiveNegativeIntegers()
        {
            Assert.AreEqual(-1, Calc.Devide(-5, 5));
        }

        [TestMethod]
        public void DivideZeroPositiveIntegers()
        {
            Assert.AreEqual(0, Calc.Devide(0, 5));
        }

        [TestMethod]
        public void DivideZeroNegativeIntegers()
        {
            Assert.AreEqual(0, Calc.Devide(0, -5));
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideByZero()
        {
            Assert.AreEqual(0, Calc.Devide(5, 0));
        }
    }
}
