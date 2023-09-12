using System;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            var endNumber = 100;
            var fizzBuzz = new FizzBuzz();
            var fizzBuzzArray = fizzBuzz.FizzBuzzArray(endNumber);

            for (int i = 1; i < endNumber; i++)
            {
                Console.Write(fizzBuzzArray[i] + ", ");
            }
            Console.Write(fizzBuzzArray[endNumber]);


        }

       
    }
}
