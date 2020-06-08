using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine(a++);
            Console.WriteLine(a);
            int c = a++;
            Console.WriteLine(c);
            int b = 1;
            Console.WriteLine(++b);
            Console.WriteLine(b);
            int d = ++b;
            Console.WriteLine(d);
        }
    }
}
