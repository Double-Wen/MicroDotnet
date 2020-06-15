using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp83
{
    class Program
    {

        //定义一个Circle类
        //接口继承
        class Circle : Ellipse, IComparable<Circle>
        {
            public double Radius { set; get; }
            //构造方法:以指定的x，y，radius来构造
            public Circle(double x, double y, double radius) : base(0, 0, 0, 0)
            {
                X = x;
                Y = y;
                Radius = radius;
            }
            //实现接口
            public int CompareTo(Circle other)
            {
                return this.Radius.CompareTo(other.Radius);
            }
            override public string ToString()
            {
                return X.ToString() + " " + Y.ToString() + " " + Radius.ToString();
            }
        }
        //Ellipse（椭圆）类
        public class Ellipse
        {
            //X, Y, MajorRadius(a), MinorRadius(b)属性
            public double X { set; get; }
            public double Y { set; get; }

            private double MajorRadius;
            public double Major
            {
                get { return MajorRadius; }
                set
                {
                    MajorRadius = value;
                }
            }
            private double MinorRadius;
            public double Minor
            {
                get { return MinorRadius; }
                set
                {
                    MinorRadius = value;
                }
            }
            //只读属性Area
            public double Area
            {
                get
                {
                    return Math.PI * MajorRadius * MinorRadius;
                }
            }

            public Ellipse(double x, double y, double majorRadius, double minorRadius)
            {
                X = x;
                Y = y;
                MajorRadius = majorRadius;
                MinorRadius = minorRadius;
            }
            //实例方法string ToString()
            //返回字符串，包含x,y和两轴半径等信息
            override public string ToString()
            {
                return X.ToString() + " " + Y.ToString() + " " + MajorRadius.ToString() + " " + MinorRadius.ToString();
            }


        }
        //基于Ellipse生成一个比较器类
        //继承IComparer<Ellipse>
        class EllipseComparer : IComparer<Ellipse>
        {
            public int CompareType { get; set; }

            public int Compare(Ellipse x, Ellipse y)
            {
                if (CompareType == 0)
                    return x.Major.CompareTo(y.Major);
                else if (CompareType == 1)
                    return x.Minor.CompareTo(y.Minor);
                else if (CompareType == 2)
                    return x.Area.CompareTo(y.Area);
                else
                    return 0;
            }
        }
        //进行测试
        static void Main(string[] args)
        {
            //比较圆
            Random rd = new Random();
            List<Circle> c = new List<Circle>();
            for (int n = 0; n < 5; n++)
            {
                Circle i = new Circle(rd.Next(0, 50), rd.Next(0, 50), rd.Next(1, 50));
                c.Add(i);
            }
            c.Sort();
            Console.WriteLine("Circle:x,y,Radius");
            foreach (Circle i in c)
            {
                Console.WriteLine(i);
            }
            //比较椭圆
            List<Ellipse> e = new List<Ellipse>();
            for (int m = 0; m < 5; m++)
            {
                Ellipse j = new Ellipse(rd.Next(1, 50), rd.Next(1, 50), rd.Next(31, 50), rd.Next(1, 30));
                e.Add(j);

            }
            Console.WriteLine("Ellipse:x,y,Major,Minor");
            for (int i = 0; i < 3; i++)
            {
                EllipseComparer r = new EllipseComparer();
                Console.WriteLine("Compare choose 0:Major 1:Minor 2:Area");
                string op = Console.ReadLine();
                if (op == "0")
                {
                    r.CompareType = 0;
                    e.Sort(r);
                }
                else if (op == "1")
                {
                    r.CompareType = 1;
                    e.Sort(r);
                }
                else if (op == "2")
                {
                    r.CompareType = 2;
                    e.Sort(r);
                }

                foreach (Ellipse j in e)
                {
                    Console.WriteLine(j + " " + "Area:" + Math.Round(j.Area));

                }
            }
            Console.ReadLine();
        }
    }
}

