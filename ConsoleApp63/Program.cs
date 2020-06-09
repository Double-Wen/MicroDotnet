using System;

namespace ConsoleApp63
{
    class Computer
    {
        public string sayHello()
        {
            return "Hello World";
        }
    }
    class Pad:Computer
    {
        public new string sayHello()
        {
            return base.sayHello() + "xueba";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc = new Computer();
            Console.WriteLine(pc.sayHello());
            Pad iPad = new Pad();
            Console.WriteLine(iPad.sayHello());
            Console.WriteLine();
            Computer he = iPad;
            //Pad wo = (Pad)pc;
            //Console.WriteLine(wo.sayHello());
            Console.WriteLine(he.sayHello());
        }
    }
}
