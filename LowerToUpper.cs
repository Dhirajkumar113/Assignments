using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assesment123
{
    class LowerToUpper
    {
        static void Main()
        {

            string name = @"C:\Users\Dhiraj\source\repos\Assesment123\Assesment123\SampleData.csv";

            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                    {
                        fileWr.WriteLine(line.ToUpper());
                        Console.WriteLine(line.ToUpper());
                    }
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}