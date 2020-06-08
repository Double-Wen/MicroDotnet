using System;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            string buff =  "    abc    ";
            string shortStr = buff.Trim();
            Console.WriteLine(buff);
            Console.WriteLine(shortStr);
            char[] t = { '*' };
            string ss = "******abd&*******";
            string shortSs = ss.Trim(t);
            Console.WriteLine(shortSs);
        }
    }
}
