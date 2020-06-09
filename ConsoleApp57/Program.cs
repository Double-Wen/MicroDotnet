using System;
using System.Text;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder SBuilder = new StringBuilder("Hello");
            SBuilder.Append(" World");
            Console.WriteLine(SBuilder);
            SBuilder.Insert(0, "fesfr");
            Console.WriteLine(SBuilder);
            SBuilder.Remove(10, SBuilder.Length - 10);
            Console.WriteLine(SBuilder);
        }
    }
}
