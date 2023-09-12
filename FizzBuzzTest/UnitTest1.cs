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

        [TestCase(27, 100, "Fizz")]                         //devisible by 3 only
        [TestCase(25, 100, "Buzz")]                         //devisible by 5 only
        [TestCase(15, 100, "Fizz Buzz")]                    //devisible by 3 and 5
        [TestCase(0, 100, null)]                            //uncorrect number
        [TestCase(41, 100, "41")]                           //non-divisible number
        [TestCase(101, 101, "101")]                         //boundary vale
        public void FizzBuzzElementTest(int element, int endNumber, string expectedResult)
        {
            var fizzBuzzArray = fizzBuzz.FizzBuzzArray(endNumber);

            Assert.That(fizzBuzzArray[element], Is.EqualTo(expectedResult));
        }
    }
}