using System;

namespace ConsoleApp60
{
    class Hello
    {
        private int price;
        public Hello()
        {
            price = 0;
        }
        public Hello(int args)
        {
            price = args;
        }

        public int Price { get => price; set => price = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hello hi = new Hello();
            Hello hi2 = new Hello(3);
            Console.WriteLine(hi2.Price);
            Console.WriteLine(hi.GetType());
        }
    }
}
