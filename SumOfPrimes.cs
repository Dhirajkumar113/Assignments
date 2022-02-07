using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class SumOfPrimes
    {
        static bool checkPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int sumofPrimes(int from, int to)
        {
            int sum = 0;
            for (int i = to; i >= from; i--)
            {
                bool isPrime = checkPrime(i);
                if (isPrime)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public static void Main()
        {
            int from = 4, to = 400;

            Console.WriteLine(sumofPrimes(from, to));
        }
    }
}