using System;

namespace ConsoleApp66
{
    class Person
    {
        public virtual void Move()
        {
            Console.WriteLine("All person can move");
        }
    }
    class Student:Person
    {
        public override void Move()
        {
            Console.WriteLine("Student is Moving");
        }
    }
    class Teacher:Person
    {
        public override void Move()
        {
            Console.WriteLine("Teacher is Moving");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student();
            Person p2 = new Teacher();
            p1.Move();
            p2.Move();
        }
    }
}
