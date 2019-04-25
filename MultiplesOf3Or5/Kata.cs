using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3Or5
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            
            //Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

            //Note: If the number is a multiple of both 3 and 5, only count it once.
            List<int> numbers = new List<int>();

            for (int n = 1; n < value; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    numbers.Add(n);
                }
            }
            value = numbers.Sum();

            return value;
        }
    }
}
