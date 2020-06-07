// runoob 方法 递归方法调用
using System;

namespace ConsoleApp14
{
    class Program
    {
        public int fact(int num)
        {
            int result;
            if(num==1)
            {
                return 1;
            }
            else
            {
                result = fact(num - 1) * num;
                return result;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.fact(5));
        }
    }
}
