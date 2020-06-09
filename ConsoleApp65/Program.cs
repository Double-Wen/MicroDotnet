using System;

namespace ConsoleApp65
{
    class Goods
    {
        static Goods()
        {
            Console.WriteLine("Base");
        }
        public string Hello { get; set; }
        public string World { get; set; }
        public void print()
        {
            Console.WriteLine("ferfrwa");
        }
    }
    class Computer:Goods
    {
        static Computer()
        {
            
            Console.WriteLine("Exten");
        }
        
        static void Main(string[] args)
        {
            Computer p = new Computer();
            p.print();
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("fwergeshesdheshereshr");
        }
    }
    class Program
    {
        static Program()
        {
            Console.WriteLine("fesrrfgs");
        }
        
    }
}
