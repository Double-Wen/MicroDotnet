using System;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = 10 - i;
            }
            Array.Sort(nums);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nums[i]);
            }
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Object[] objs = new object[2] { null, null };
            foreach (object obj in objs)
            {
                Console.WriteLine(obj);
            }
            int[] bar=null;
            foreach(int x in bar)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(nums.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            int[][] foo = new int[3][];
            foo[0] = new int[1];
            foo[1] = new int[2];
            foo[2] = new int[4];
            //Console.WriteLine(foo.GetLength(1));
        }
    }
}
