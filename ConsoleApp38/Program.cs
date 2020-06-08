using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.00;
            Double b = 2.00;
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            switch(a)
            {
                case 1:
                    Console.WriteLine(1.00);
                    break;
                case 2.00:
                    Console.WriteLine(2.00);
                    break;
                default:
                    Console.WriteLine("-----");
                    break;
            }
        }
    }
}
