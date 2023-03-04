using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparky;

namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_InputTwoNumbers_GetAddition()
        {
            Calculator calculator = new();
            int result = calculator.Add(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}
