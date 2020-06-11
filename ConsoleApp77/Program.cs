using System;
using System.IO;

namespace ConsoleApp77
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foo = File.Exists(@"C:\Users\Administrator\Desktop\hello.txt");
            Console.WriteLine(foo);
            FileInfo bar = new FileInfo(@"C:\Users\Administrator\Desktop\hello.txt");
            Console.WriteLine(bar.Exists);
            File.Create(@"C:\Users\Administrator\Desktop\bar.txt");
            
        }
    }
}
