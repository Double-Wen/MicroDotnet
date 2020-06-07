using System;

namespace ConsoleApp18
{
    class Program
    {
        private int length;
        private int width;
        
        public Program(int len, int wid)
        {
            this.length = len;
            this.width = wid;
        }

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public static Program operator+ (Program b, Program c)
        {
            Program p = new Program(0, 0);
            p.Length = b.Length + c.Length;
            p.Width = b.Width + c.Width;
            return p;
        }
        static void Main(string[] args)
        {
            Program a = new Program(1, 2);
            Program b = new Program(2, 3);
            Program c = a + b;
            Console.WriteLine(c.length);
            Console.WriteLine(c.width);
        }
    } 
} 