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
        public void IsOddNumber_InputOddNumber_ReturnsTrue(int number)
        {
            Calculator calculator = new();
            bool result = calculator.IsOddNumber(number);
            //Assert.IsTrue(result);
            Assert.That(result, Is.EqualTo(true));
        }

        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddNumber_InputNumber_ReturnTrueIfOdd(int number)
        {
            Calculator calculator = new();
            return calculator.IsOddNumber(number);
        }

        [TestCase(5.0, 1.1)]
        [TestCase(5.2, 1.6)]
        [TestCase(5.1, 1.9)]
        public void AddDouble_InputTwoDouble_ReturnsAddtion(double a, double b)
        {
            Calculator calculator = new();
            var result = calculator.AddDouble(a, b);

            // if the different between 6.1 and output result is 1 or less than 1 passed otherwise fail.
            Assert.AreEqual(6.1, result, 1); 
        }


    }
}
