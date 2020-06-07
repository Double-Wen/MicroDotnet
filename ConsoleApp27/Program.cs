using System;

namespace ConsoleApp27
{
    class Program
    {
        enum Days { Sun, Mon};
        static void Main(string[] args)
        {
            Days days = Days.Mon;
            Console.WriteLine(days.ToString());
            Console.WriteLine("Hello World!");
        }
    }
}
