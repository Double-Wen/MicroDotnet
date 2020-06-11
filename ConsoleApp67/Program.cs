using System;

namespace ConsoleApp67
{
    public abstract class Market
    {
        public string Name { get; set; }
        public abstract void Shop();
    }
    public class TMall:Market
    {
        public override void Shop()
        {
            Console.WriteLine(Name);
        }
    }
    public class JD:Market
    {
        public override void Shop()
        {
            Console.WriteLine(Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Market m1 = new TMall();
            m1.Name = "tianmao";
            Market m2 = new TMall();
            m2.Name = "jingdong";
            m1.Shop();
            m2.Shop();
        }
    }
}
