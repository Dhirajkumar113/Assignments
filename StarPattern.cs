﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class StarPattern
    {
        public static void Main()
        {
            int i, j, rows;
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}

