using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class Program
    {
        //定义一个Circle类
        //Circle类继承Ellipse类,将其中的重复代码删去
        class Circle : Ellipse
        {

            public double Radius { set; get; }
            //构造方法:以指定的x，y，radius来构造
            public Circle(double x, double y, double radius) : base(0, 0, 0, 0)
            {
                X = x;
                Y = y;
                Radius = radius;
            }

            //一个只读属性Area，获取圆面积
            new public double Area
            {
                get
                {
                    return Math.PI * Math.Pow(Radius, 2.0);
                }
            }
            //一个只读属性Perimeter，获取圆周长
            public double Perimeter
            {
                get
                {
                    return Math.PI * Radius * 2;
                }
            }
            //方法:如果指定的点(x, y)处于本圆内，返回true
            new public bool Contains(double x, double y)
            {
                if (Math.Sqrt(Math.Pow((X - x), 2.0) + Math.Pow((Y - y), 2.0)) < Radius)
                    return true;
                else
                    return false;
            }
            //方法:如果指定的圆circle包含在本圆内，返回true
            public bool Contains(Circle circle)
            {
                bool a = Contains(circle.X, circle.Y);
                if (a && (circle.Radius < this.Radius))
                    return true;
                else
                    return false;

            }
            //方法:半径扩大（加上range），输出扩大后的newCircle，返回true。
            //如果Radius+range为负，无法扩大，则输出原来的圆，且返回false。
            public bool Extend(double range, out Circle newCircle)
            {
                newCircle = null;
                Console.WriteLine("Create new circle:");
                Console.WriteLine(this.X);
                Console.WriteLine(this.Y);

                if (this.Radius + range < 0)
                {

                    Console.WriteLine(this.Radius);
                    Console.WriteLine("If create successfully");
                    return false;
                }

                else
                {
                    Console.WriteLine(this.Radius + range);
                    Console.WriteLine("If create successfully");
                    return true;
                }


            }
        }
        //Ellipse（椭圆）类

        public class Ellipse
        {
            //X, Y, MajorRadius(a), MinorRadius(b)属性
            public double X { set; get; }
            public double Y { set; get; }
            //在MajorRadius, MinorRadius属性的set访问器中，对value进行检查
            //如果value<=0，抛出异常（throw new ArgumentException("主轴长度不能为负");）
            //并保证MajorRadius>=MinorRadius
            private double MajorRadius;
            public double Major
            {
                get { return MajorRadius; }
                set
                {
                    MajorRadius = value;
                    if (value <= 0)
                        throw new ArgumentException("主轴长度不能为负");

                }
            }
            private double MinorRadius;
            public double Minor
            {
                get { return MinorRadius; }
                set
                {
                    MinorRadius = value;
                    if (MajorRadius < value)
                        throw new ArgumentException("主轴长度不能小于副轴长度");

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
            //两个Ellipse构造方法，一个调用另一个
            public Ellipse(double x, double y, double majorRadius, double minorRadius)
            {
                X = x;
                Y = y;
                MajorRadius = majorRadius;
                MinorRadius = minorRadius;
            }
            public Ellipse() : this(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))
            {
                Console.WriteLine("根据输入构造椭圆");

            }
            //实例方法bool Contains(double x, double y)判断点是否在椭圆内
            public bool Contains(double x, double y)
            {
                double r = Math.Pow(X - x, 2) / Math.Pow(MajorRadius, 2) + Math.Pow(Y - y, 2) / Math.Pow(MinorRadius, 2);
                return r < 1;
            }
            //实例方法string ToString()
            //返回字符串，包含x,y和两轴半径等信息

            override public string ToString()
            {
                return X.ToString() + " " + Y.ToString() + " " + MajorRadius.ToString() + " " + MinorRadius.ToString();
            }


        }

        //对上述功能进行测试
        static void Main(string[] args)
        {
            //圆
            /*
            Console.WriteLine("Input X，Y，Radius in order：");
            Circle e1 = new Circle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Area:" + e1.Area);
            Console.WriteLine("Perimeter:" + e1.Perimeter);
            Console.WriteLine("Input X，Y：");
            bool a = e1.Contains(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("If the point in the circle:");
            Console.WriteLine(a);
            Console.WriteLine("Another circle:");
            Circle e2 = new Circle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            bool b = e1.Contains(e2);
            Console.WriteLine("If the circle in that circle:");
            Console.WriteLine(b);
            Console.WriteLine("Input range：");
            Circle e3 = new Circle(e1.X, e1.Y, e1.Radius + double.Parse(Console.ReadLine()));
            bool c = e1.Extend(e3.Radius - e1.Radius, out e3);
            Console.WriteLine(c);
            Console.WriteLine(e3); */
            //椭圆
            int flag = 1;
            Console.WriteLine("Input X, Y, MajorRadius, MinorRadius in order：");
            Ellipse c1 = new Ellipse();
            Ellipse c2 = new Ellipse(c1.X, c1.Y, c1.Major, c1.Minor);
            try
            {
                c1.Major = c2.Major;
                c1.Minor = c2.Minor;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                flag = -1;
            }
            if (flag == 1)
            {
                Console.WriteLine("Output X, Y, MajorRadius, MinorRadius in order：");
                Console.WriteLine("{0}", c1);
                Console.WriteLine("Area:" + c1.Area);
                Console.WriteLine("Input X，Y：");
                bool d = c1.Contains(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine("If the point in the ellipse:");
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }


    }
}

