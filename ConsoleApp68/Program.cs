using System;

namespace ConsoleApp68
{
    interface IPerson
    {
        string Name { get; set; }
        int Aget { get; set; }
        void Speek();
        void Work();
    }
    class Student:IPerson
    {
        public string Name { get; set; }
        private int age;

    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
