using System;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=9; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("{0}*{1}={2}", i, j, i * j);
                    if(j!=i)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
