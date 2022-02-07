using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class ArrToCsv
    {
        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "Hii";
            files[0, 1] = "Good Moring";
            files[0, 2] = "I";
            files[0, 3] = "Am";
            files[0, 4] = "Dhiraj";

            files[1, 0] = "SOFTWARE";
            files[1, 1] = "DEVELOPER";
            files[1, 2] = "#1";
            files[1, 3] = "Bangalore";
            files[1, 4] = "9775913756";

            StreamWriter sw = File.CreateText("OutputText.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");
                }
                sw.Write("\n");
            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("Data Inserted");

        }
    }
}