using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            a = Convert.ToByte(a + 1);
            Console.WriteLine(a);
            int one = 1;
            int two = 2;
            Console.WriteLine("Result: " + (one < two));

        }
    }
}
