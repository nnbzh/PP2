using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static bool primeN(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int cnt = 0;
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            string s = Console.ReadLine();
            arr = s.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (primeN(arr[i]) == true)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < arr.Length; i++)
            {
                if (primeN(arr[i]) == true)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
