using System;

namespace ConsoleApp61
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("this is static");
        }
        private Program()
        {
            Console.WriteLine("init Program");
        }
        ~Program()
        {
            Console.WriteLine("automatic destroy");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            
        }
    }
}
