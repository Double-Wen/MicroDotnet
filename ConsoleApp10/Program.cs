using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 12.34;
            int i = (int)d;
            Console.WriteLine(d);
            Console.WriteLine(i);
            Int64 a = 1;
            Int32 b = (Int32)a; //显式类型转化，可能会有数据丢失
            Int64 c = b;    //隐式类型转化，安全的，从小整型转化为大整型
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
