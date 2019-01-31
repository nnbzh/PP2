using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
