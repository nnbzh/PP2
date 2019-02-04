using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public int id;
        public int year;

        public Student(string name, int id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Berik", 1 , 1);
            s1.PrintInfo();
        }
    }
}
