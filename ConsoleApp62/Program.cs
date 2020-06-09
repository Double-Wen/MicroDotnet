using System;

namespace ConsoleApp62
{
    class Program
    {
        private static void addsum(int x, int y, out int z)
        {
            z = x + y;
        }
        private static void changenum(ref int x, ref int y)
        {
            x = 888;
            y = 666;
        }
        public static int countsum(params int[] foo)
        {
            int sum = 0;
            foreach(int i in foo)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // int sum = 0;
            int x = 1;
            int y = 2;
            addsum(x, y, out int sum);
            Console.WriteLine(sum);
            changenum(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(countsum(10, 20, 30, 40));
        }
    }
}
