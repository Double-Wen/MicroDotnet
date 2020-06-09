using System;

namespace ConsoleApp64
{
    class Stock
    {
        public string FullName
        {
            get;
            set;
        }
        public void Show()
        {
            Console.WriteLine("name");
            Console.WriteLine(FullName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stock ss = new Stock();
            ss.FullName = "xueba";
            ss.Show();
            Console.WriteLine();
            
        }
    }
}
