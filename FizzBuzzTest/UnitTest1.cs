using NUnit.Framework;
using System;

namespace FizzBuzzTest
{
    [TestFixture(1000)]
    [TestFixture(1000000)]
    [TestFixture(100000000)]
    class FizzBuzzTest
    {
        private FizzBuzz.FizzBuzz fizzBuzz;
        private long endNumber;
        public FizzBuzzTest(long endN)
        {
            endNumber = endN;
        }

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz.FizzBuzz();
        }

        [TestCase(693, "Fizz")]                              //devisible by 3 only
        [TestCase(500, "Buzz")]                              //devisible by 5 only
        [TestCase(960, "Fizz Buzz")]                         //devisible by 3 and 5
        [TestCase(401, "401")]                               //non-divisible number
        [TestCase(0, null)]                                  //boundary value array down
        [TestCase(1, "1")]                                   //boundary value down
        [TestCase(1000, "Buzz")]                             //boundary value up for endNumber=1000                                                              
        public void FizzBuzzElementTestPositive(long element, string expectedResult)
        {
            var fizzBuzzArray = fizzBuzz.FizzBuzzArray(endNumber);
            Assert.That(fizzBuzzArray[element], Is.EqualTo(expectedResult));
        }

        [TestCase(-1)]
        [TestCase(1000000000)]
        public void FizzBuzzElementTestNegative(int element)
        {
            var fizzBuzzArray = fizzBuzz.FizzBuzzArray(endNumber);
            string result;
            var ex = Assert.Throws<IndexOutOfRangeException>(() => result = fizzBuzzArray[element]);
        }

        /*[TestCase(15, "Buzz")]
        [TestCase("1", 1)]
        public void FizzBuzzElementTestUser(int element, string expectedResult)
        {
            var fizzBuzzArray = fizzBuzz.FizzBuzzArray(endNumber);
            string result;
            var ex = Assert.Throws<ArgumentException>(() => result = fizzBuzzArray[element]);
        }*/
    }
}