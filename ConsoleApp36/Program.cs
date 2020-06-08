using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("偶数");
            }
            else
            {
                Console.WriteLine("奇数");
            }
        }
    }
}
