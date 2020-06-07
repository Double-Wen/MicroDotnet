using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] foo = new int[10];
            foo[0] = 12345;
            int[] bar = new int[3] { 1, 2, 3 };
            int[] n = new int[10];
            for(int i=0; i<10; i++)
            {
                n[i] = i + 1;
                Console.Write(n[i]);
            }
            foreach(int j in n)
            {
                Console.Write(j);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
