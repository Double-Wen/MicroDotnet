using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj;
            obj = 100; //装箱
            Object foo;
            foo = 200; //装箱
            int bar = (int)foo; //拆箱？
            Console.WriteLine(bar);
            Console.WriteLine(foo);
            Console.WriteLine(obj);
            //暂时还不知道object和Object的区别
            dynamic d = 20;
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());
            String str = "Hello C#";
            Console.WriteLine(str);
            String hello = @"\n\n\n\n\n\r";
            //@就类似于Python里面的r
            Console.WriteLine(hello);
        }
    }
}
