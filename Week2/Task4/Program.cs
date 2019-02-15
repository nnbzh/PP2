using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            F3();
        }

        private static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string line = new string(' ', k);
            line = line + fsi.Name;
            Console.WriteLine(line);

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                var items = (fsi as DirectoryInfo).GetFileSystemInfos();
                foreach (var i in items)
                {
                    PrintInfo(i, k + 2);
                }
            }
        }

        private static void F3()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Nurik\Desktop\pp2\Week3");
            PrintInfo(dir, 1);
        }
    }
}