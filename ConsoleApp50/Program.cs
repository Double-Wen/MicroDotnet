using System;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = null;
            Console.WriteLine(st);
            string goo;
            char[] foo = { 't', 'i', 'm', 'e', 'h', 'e', ';' };
            string ss = new string(foo, 4, 2);
            Console.WriteLine(ss);
            string num = "243243242";
            int size = num.Length;
            Console.WriteLine(size);
            string s = "fresgrsgsg";
            char ch = s[5];
            Console.WriteLine(ch);


        }
    }
}
