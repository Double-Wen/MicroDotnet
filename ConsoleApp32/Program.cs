using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = (int)(4.5);
            Console.WriteLine(a);
            long longint = 3000000000;
            try:
                int y = Convert.ToInt32(longint);
                
            Console.WriteLine(y);
        }
    }
}
