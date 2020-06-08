using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 1;
            int iSum = 0;
            while(iNum <= 100)
            {
                iSum += iNum;
                iNum++;
            }
            Console.WriteLine(iSum);
            Console.ReadLine();
        }
    }
}
