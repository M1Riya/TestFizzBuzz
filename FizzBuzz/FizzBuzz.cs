using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string[] FizzBuzzArray(int endNumber)
        {
            var result = new string[endNumber+1];
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

        
        /*public static string FizzBuzzStringBuilder(int endNumber)
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
        }*/

    }
}
