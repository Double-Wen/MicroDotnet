using System;
using System.Threading;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "hello title";
            Console.WriteLine("Hello WOlrdl");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Hello ");
            Thread.Sleep(2000);
        }
    }
}
