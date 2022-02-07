using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class house
    {
        static void Main(string[] args)
        {
            Home apartment = new Home();
            Person person = new Person("DHIRAJ");
            apartment.door = new House.Door("BLACK");
            person.house = apartment;
            person.ShowData();
            Console.ReadLine();
        }


        public class House
        {
            public int Area { get; set; }
            public Door door;

            public House(int area = 200)
            {
                Area = area;
            }

            public void ShowData()
            {
                Console.WriteLine($"This is my house, my House area is {Area} Metre Square");
            }

            public Door GetDoor()
            {
                return door;
            }

            public class Door
            {
                public string Color { get; set; }

                public Door(string color = "white")
                {
                    Color = color;
                }

                public void ShowData()
                {
                    Console.WriteLine($"House Door color is {Color}");
                }
            }
        }

        public class Home : House
        {
            public Home(int area = 200) : base(area)
            {
            }
        }

        public class Person
        {
            private string name;
            public House house { get; set; }

            public Person(string name)
            {
                this.name = name;
            }

            public void ShowData()
            {
                Console.WriteLine($"A person whose name is {name}");
                Console.WriteLine("Data of house:");
                house.ShowData();
                Console.WriteLine("Data of door:");
                house.GetDoor().ShowData();
            }

        }
    }
}
