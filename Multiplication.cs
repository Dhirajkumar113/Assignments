using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            int number, multiplier;
            Console.WriteLine("ENTER THE NUMBER");
            number = Convert.ToInt32(Console.ReadLine());

            for (multiplier = 1; multiplier <= 10; multiplier++)
            {
                Console.WriteLine(" {0} * {1} = {2} ", number, multiplier, (number * multiplier));
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
