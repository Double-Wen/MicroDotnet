using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while(num <= 100)
            {
                sum += num;
                ++num;
                if(num==50)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
