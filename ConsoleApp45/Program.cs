using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine(arr[0]);
            for(int i=0; i<5; i++)
            {
                arr[i] = 0;
            }
            Console.WriteLine("Sun");
        }
    }
}
