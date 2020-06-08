using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 1;
            int iSum = 0;
            do
            {
                iSum += iNum;
                iNum++;
            }
            while (iNum <= 100);
            Console.WriteLine(iSum);
        }
    }
}
