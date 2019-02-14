using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"C:\Users\Nurik\Desktop\pp2",
           "*.*",
           SearchOption.AllDirectories);

            // Display all the files.
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }

}