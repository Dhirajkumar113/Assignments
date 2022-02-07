using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment123
{
    class PersonStudent
    {
        static void Main(string[] args)
        {

            Person[] people =   {
                                new Person("Tarun", "Bangalore", "Karnataka", " fundamentals", 2017, 45000.0),
                                new Person("Dhiraj", "Bhagalpur"," Bihar", "Assitant Developer", 35000.0),
                                new Person("Saket", "Dhanbad", "Jharkhand", "Senior Developer", 55000.0),
                                new Person("Soumik", "Kolkata", "West-Bengal", " fundamentals", 2015, 47750.0),
                                new Person("Rohit", "Motihari", "Bihar", "HR", 2011, 33500.0)
                                };
            Console.ReadLine();
        }
    }

    public class Student
    {

        public Student(string name, string city, string state, string school, int year, double fees)
        {
        }
    }
    public class Staff
    {

        public Staff(string name, string city, string state, string Department, double salary)
        {
        }
    }
    public class Person
    {


        public Person(string s1, string s2, string s3, string s4, double s5)
        {
            Console.WriteLine("Staff Details:" + "Name: " + s1 + ", City:" + s2 + ", State: " + s3 + ", School: " + s4 + ", Salary: " + s5);

        }
        public Person(string name, string city, string state, string school, int year, double fees)
        {
            Console.WriteLine("Student Details:" + "Name: " + name + ", City: " + city + ", State: " + state + ", Year: " + year + ", fees:" + fees);
        }


    }
}
