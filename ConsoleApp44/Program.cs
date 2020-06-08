using System;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if(i%2==1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
