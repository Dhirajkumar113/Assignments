using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class Trigonometric
{
    static double findSinX(int angleInDegree, int terms)
    {
        double current = Math.PI * angleInDegree / 180f;

        double answer = current;
        double temp = current;

        for (int i = 1; i <= terms; i++)
        {
            temp = ((-temp) * current * current) / ((2 * i) * (2 * i + 1));
            answer = answer + temp;
        }

        return answer;
    }

    static public void Main()
    {
        int angleInDegree1 = 30;

        int terms1 = 10;

        double answer1 = findSinX(angleInDegree1, terms1);

        Console.WriteLine("The value of sin({0}) = {1}", angleInDegree1, answer1);

        int angleInDegree2 = 45;

        int terms2 = 20;

        double answer2 = findSinX(angleInDegree2, terms2);

        Console.WriteLine("The value of sin({0}) = {1}", angleInDegree2, answer2);
      
        int angleInDegree3 = 60;

        int terms3 = 30;

        double answer3 = findSinX(angleInDegree3, terms3);

        Console.WriteLine("The value of sin({0}) = {1}", angleInDegree3, answer3);

        int angleInDegree4 = 90;
        
        int terms4 = 40;

        double result4 = findSinX(angleInDegree4, terms4);

        Console.WriteLine("The value of sin({0}) = {1}", angleInDegree4, result4);


        int angleInDegree5 = 135;

        int terms5 = 50;

        double result5 = findSinX(angleInDegree5, terms5);

        Console.WriteLine("The value of sin({0}) = {1}", angleInDegree5, result5);

        int angleInDegree6 = 180;

        int terms6 = 60;

        double result6 = findSinX(angleInDegree6, terms6);

        Console.WriteLine("The value of sin({0}) = {1}", angleInDegree6, result6);

    }
}
}

