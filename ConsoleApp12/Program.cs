using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 5;
            // int b = Convert.ToInt32(Console.ReadLine());
            int hello = Console.Read();
            Console.WriteLine(hello);
            for(int i=0; i<10; i++)
            {
                String buffer = Console.ReadLine();
                Console.WriteLine(typeof(Buffer));
                Console.WriteLine(buffer.GetType());
                Console.WriteLine(buffer);
            }
        }
    }
}
