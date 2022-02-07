using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class Fibonacci
    {
        static int fib(int index)
        {
            if (index <= 1)
                return index;
            return fib(index - 1) + fib(index - 2);
        }

        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(fib(n));
        }
    }
}

