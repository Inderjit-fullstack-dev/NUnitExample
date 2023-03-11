using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;

        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineName_InputFirstNameAndLastName_ReturnsFullName()
        {
            Customer customer = new Customer();

            var result = customer.CombineName("Inderjit", "Singh");
            //Assert.AreEqual("Inderjit Singh", result);
            //Assert.That(result, Is.EqualTo("Inderjit Singh"));
            //Assert.That(result, Does.Contain("inderjit").IgnoreCase);
            //Assert.That(result, Does.StartWith("inderjit").IgnoreCase);
            Assert.That(result, Does.EndWith("singh").IgnoreCase);
        }

        [Test]
        public void CombineName_NotCombined_ReturnNull()
        {
            // arrange
            //Customer customer = new();

            // act
            //customer.CombineName("Inderjit", "Singh");
            
            
            //assert 
            Assert.IsNull(customer.GreetMessage);
        }

    }
}
