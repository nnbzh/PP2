using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{

    class Program
    {
        public class SimpleFileCopyandDelete
        {
            static void Main()
            {
                string fileName = "file.txt";
                string sourcePath = @"C:\Users\Nurik\Desktop\pp2\Week2\path";
                string targetPath = @"C:\Users\Nurik\Desktop\pp2\Week2\path2";

                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);

                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }

                System.IO.File.Copy(sourceFile, destFile, true);

                if (System.IO.File.Exists(@"C:\Users\Nurik\Desktop\pp2\Week2\path\file.txt"))
                {
                    try
                    {
                        System.IO.File.Delete(@"C:\Users\Nurik\Desktop\pp2\Week2\path\file.txt");
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
        }
    }
}