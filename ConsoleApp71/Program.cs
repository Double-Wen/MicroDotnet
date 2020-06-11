using System;
using System.IO;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo finfo = new FileInfo(@"C:\Users\Administrator\Desktop\hello.txt");
            Console.WriteLine(File.Exists(@"C:\Users\Administrator\Desktop\hello.txt"));
            Console.WriteLine(finfo.Exists);
        }

    }
}
