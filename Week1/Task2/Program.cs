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

        public Student(string name, int id, int year) //constructor
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }

        public void PrintInfo() //method to access ID, name and year
        {
            Console.WriteLine("Student ID is: "+id);
            Console.WriteLine("The name of the student is: " + name);
            Console.WriteLine("He/She is " + year + " student.");
        }

        
    }
    class Program
    {
        public static Student incYear(Student student)
        {
            student.year = student.year + 1;
            return student;
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Berik", 1, 1);
            Student s2 = new Student("Nurik", 2, 1);
            s1.PrintInfo();
            incYear(s1);
            s1.PrintInfo();
        }
    }
}
