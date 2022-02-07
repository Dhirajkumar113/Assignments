using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class Shape
    {
        public bool FillStatus { get; set; }
        public string BackColor { get; set; }
        public override string ToString()
        {
            string oldValue = "Shape ";
            string value = "";
            if (FillStatus == true) value = "filled"; else value = "Not Filled";
            oldValue += $"| A Shape  with color {BackColor} and {value}";
            return oldValue;
        }
    }

    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Rectange|A Rectange with width = {Width} and Length = {Length} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }

    class Square : Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Rectange|A Rectange with Breadth = {Breadth} and Length = {Length} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }

    class circle : Shape
    {
        public int Radius { get; set; }
        public int Diameter { get; set; }
        public override string ToString()
        {
            string baseValue = base.ToString();
            string value = $"Circle|A Circle with radius = {Radius} and Diameter = {Diameter} and is a subclass of {this.GetType().BaseType.Name}";
            return value;
        }
    }
    internal class ShapeCRT
    {
        static void Main(string[] args)
        {
            Shape xxx = new Shape { BackColor = "Yellow", FillStatus = true };
            Console.WriteLine(xxx);

            xxx = new Rectangle { Length = 200, Width = 300 };
            Console.WriteLine(xxx);

            Shape yyy = new Shape { BackColor = "Red", FillStatus = true };
            Console.WriteLine(yyy);

            yyy = new circle { Radius = 10, Diameter = 20 };
            Console.WriteLine(yyy);

            Shape zzz = new Shape { BackColor = "Blue", FillStatus = true };
            Console.WriteLine(zzz);

            zzz = new Square { Length = 100, Breadth = 200 };
            Console.WriteLine(zzz);
        }
    }
}