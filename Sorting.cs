using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class Sorting
    {
        static void Main()
        {
            Sortingthreenumbers(2, 10, 1);
            Sortingthreenumbers(10, 20, 1);
            Sortingthreenumbers(100, 10, 2);
        }
        static void Sortingthreenumbers(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                if (b < c)
                {
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", a, c, b);
                }
            }
            else if (b < a && b < c)
            {
                if (a < c)
                {
                    Console.WriteLine("{0},{1},{2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", b, c, a);
                }
            }
            else
            {
                if (c < a && c < b)
                {
                    if (a < b)
                    {
                        Console.WriteLine("{0},{1},{2}", c, a, b);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", c, b, a);
                    }
                }
            }
        }
    }
}