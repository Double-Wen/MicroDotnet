using System;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "Hello World";
            Console.WriteLine(ss.ToUpper());
            Console.WriteLine(ss.ToLower());
            Console.WriteLine(string.Format("{0:C}", 123));
            Console.WriteLine(string.Format("{0:E}", 123.01010101));
        }
    }
}
