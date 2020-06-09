using System;

namespace ConsoleApp59
{
    class Program
    {
        private string tradecode = "";
        public string TradeCode
        {
            get { Console.WriteLine("beg"); return tradecode; }
            set { Console.WriteLine("fef"); tradecode = value; }
        }

        private int xb = 0;
        public int Xb { get => xb; set => xb = value; }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.TradeCode = "Hello World";
            Console.WriteLine(p.TradeCode);
            p.Xb = 123456;
            Console.WriteLine(p.Xb);
        }
    }
}
