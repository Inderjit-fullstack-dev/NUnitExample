using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void Add_InputTwoIntegers_GetAddition()
        {
            Calculator calculator = new();
            int result = calculator.Add(1, 1);
            Assert.AreEqual(2, result);
        }
    }
}
