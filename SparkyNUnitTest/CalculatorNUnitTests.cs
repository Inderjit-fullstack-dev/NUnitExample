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

        [Test]
        public void IsOddNumber_InputEvenNumber_ReturnsFalse()
        {
            Calculator calculator = new();
            bool result = calculator.IsOddNumber(2);

            //Different methods to check boolean
            //Assert.IsFalse(result);
            
            //Assert.That(result, Is.EqualTo(false));

            Assert.AreEqual(false, result);
        }

        [Test]
        [TestCase(5)]
        [TestCase(3)]
        [TestCase(7)]
        [TestCase(11)]
        public void IsOddNumber_InputOddNumber_ReturnsTrue(int number)
        {
            Calculator calculator = new();
            bool result = calculator.IsOddNumber(number);
            Assert.IsTrue(result);
        }
    }
}
