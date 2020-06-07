using System;

namespace ConsoleApp16
{
    class Program
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 100;
            Console.WriteLine(a);
            p.getValue(out a);
            Console.WriteLine(a);
        }
    }
}
