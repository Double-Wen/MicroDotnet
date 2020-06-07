using System;

namespace ConsoleApp15
{
    class Program
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 100;
            int b = 200;
            Console.WriteLine("{0} {1}", a, b);
            //p.swap(ref a, ref b);
            p.swap(ref a, ref b);
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
