using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestFixture]
    class FizzBuzzTest
    {
        private FizzBuzz.FizzBuzz fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [TestCase(27, 100, "Fizz")]                         //checking the devisibility by 3 only
        [TestCase(25, 100, "Buzz")]                         //checking the devisibility by 5 only
        [TestCase(15, 100, "Fizz Buzz")]                    //checking the devisibility by 3 and 5
        [TestCase(0, 100, null)]                            //checking uncorrect number
        [TestCase(7, 100, "7")]                             //checking non-divisible number
        public void FizzBuzzElementTest(int element, int endNumber, string expectedResult)
        {
            var fizzBuzzArray = fizzBuzz.FizzBuzzArray(endNumber);

            Assert.That(fizzBuzzArray[element], Is.EqualTo(expectedResult));
        }
    }
}