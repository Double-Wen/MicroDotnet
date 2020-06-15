using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp84
{

    class Program
    {


        static void Main(string[] args)
        {
            List<int> aaa = new List<int>();
            Random ddd = new Random();
            for (int i = 0; i < 10; i++) aaa.Add(ddd.Next(1, 10));

            Func<int> f1 = () => DateTime.Now.Year;
            Func<int, double> f2 = (int r) => Math.Sqrt(r);
            Func<int, int, double> f3 = (int a, int b) => Math.Sqrt(a * a + b * b);
            Predicate<int> s1 = (int a) => a > 5 ? true : false;
            Console.WriteLine("{0} {1} {2} {3}", f1(), f2(5), f3(3, 4), s1(ddd.Next(0, 10)));

            Action<string> d1 = (string a) => Console.WriteLine(a);
            d1("123");

            Action<int, List<int>> d2 = (int a, List<int> bbb) => Console.WriteLine(a >= bbb[3] ? "大" : "小");
            d2(5, aaa);


        }

    }
}

