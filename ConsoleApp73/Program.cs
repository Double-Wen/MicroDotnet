using System;

namespace ConsoleApp73
{
    class Program
    {
        static void Main(string[] args)
        {
            string buff = "123";
            int foo = int.Parse(buff);
            Console.WriteLine(foo);
            int bar = Convert.ToInt32(buff);
            Console.WriteLine(bar);
        }
    }
}
