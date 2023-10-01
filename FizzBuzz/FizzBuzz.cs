using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string[] FizzBuzzArray(long endNumber)
        {
            var result = new string[endNumber + 1];
            for (int i = 1; i <= endNumber; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    result[i] = "Fizz Buzz";
                else if (i % 5 == 0)
                    result[i] = "Buzz";
                else if (i % 3 == 0)
                    result[i] = "Fizz";
                else result[i] = i.ToString();
            }

            return result;
        }

    }
}
