using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int foo = Convert.ToInt32(Console.Read());
            switch(foo)
            {
                case 1:
                    Console.WriteLine(1);
                break;
                case 2:
                    Console.WriteLine(2);
                break;
                default:
                    Console.WriteLine("other");
                break;
            }
            switch(foo)
            {
                case 2:
                    Console.WriteLine(2);
                    break;
                default:
                    Console.WriteLine("others");
                    break;
            }
        }
    }
}
