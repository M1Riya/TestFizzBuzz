using System;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            var endNumber = 100;
            Console.WriteLine(FizzBuzz(endNumber));

        }

        public static string FizzBuzz(int endNumber)
        {
            var result = new StringBuilder();
            for (int i = 1; i < endNumber; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    result.Append("Fizz Buzz, ");
                else if (i % 5 == 0)
                    result.Append("Buzz, ");
                else if (i % 3 == 0)
                    result.Append("Fizz, ");
                else result.Append(i + ", ");
            }
            if ((endNumber % 3 == 0) && (endNumber % 5 == 0))
                result.Append("Fizz Buzz");
            else if (endNumber % 5 == 0)
                result.Append("Buzz");
            else if (endNumber % 3 == 0)
                result.Append("Fizz");
            else result.Append(endNumber);

            return result.ToString();
        }
    }
}
