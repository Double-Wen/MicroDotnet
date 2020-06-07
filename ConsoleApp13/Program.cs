// runoob 方法
using System;

namespace ConsoleApp13
{
    class Program
    {
        public int FindMax(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            Program p = new Program();
            ret = p.FindMax(a, b);
            Console.WriteLine(ret);
            Console.ReadLine();
        }
    }
}
