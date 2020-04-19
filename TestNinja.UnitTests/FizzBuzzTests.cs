using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {

        [Test]
        public void GetOutput_IfInputDivisibleBy5and3_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(3 * 5);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_IfInputDivisibleBy3Only_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_IfInputDivisibleBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_IfInputNotDividedBy5and3_ReturnInput()
        {
            var input = 2;
            var result = FizzBuzz.GetOutput(2);

            Assert.That(result, Is.EqualTo(input.ToString()));
        }
    }
}
