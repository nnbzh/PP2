using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int ss = int.Parse(x);
            for (int i = 1; i <= ss; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
