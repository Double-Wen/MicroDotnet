using System;

namespace ConsoleApp58
{
    class Program
    {
        static double r;
        const double PI = 3.14;
        static void Main(string[] args)
        {
            Program.r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(PI*Math.Pow(r, 2));
            Console.ReadLine();
        }
    }
}
