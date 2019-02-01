using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int ss = int.Parse(x);
            int[] array = new int[ss];
            string str = Console.ReadLine();
            array = str.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                Console.Write(array[i] + " ");
            }
        }
    }
}
