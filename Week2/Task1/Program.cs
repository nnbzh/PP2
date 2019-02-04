using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Nurik\Desktop\pp2\Week2\test\test.txt");
            System.Console.WriteLine(text);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Nurik\Desktop\pp2\Week2\test\test.txt");
            string word = lines[0];
            string reversed = Reverse(word);
            if (word == reversed)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }

        }
    }
}
