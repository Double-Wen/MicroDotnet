using System;
using System.IO;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\Users\Administrator\Desktop\hello.txt"));
            FileInfo foo = new FileInfo(@"C:\Users\Administrator\Desktop\hello.txt");
            if(foo.Exists)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
