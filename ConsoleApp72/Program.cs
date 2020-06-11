using System;
using System.IO;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\Users\Administrator\Desktop\hello.txt"));
            FileInfo fileinfo = new FileInfo(@"C:\Users\Administrator\Desktop\hello.txt");
            Console.WriteLine(fileinfo.Exists);
        }
    }
}
