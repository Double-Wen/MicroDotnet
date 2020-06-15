using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abc";
            Console.WriteLine($"'{s}' is {(s.IsPalindrome() ? "" : "not")} palindrome");
            s = "abcba";
            Console.WriteLine($"'{s}' is {(s.IsPalindrome() ? "" : "not")} palindrome");
            int i = 12340;
            Console.WriteLine($"Reverse of {i} is {i.ReverseDigits()}");
            //查询来自英国（UK）的所有世界冠军，并按胜利场数降序排列
            List<Racer> list = new List<Racer>(Racer.GetChampions());
            list.Sort((a, b) => { return b.Wins - a.Wins; });
            foreach (var racer in list)
            {
                if (racer.Country == "UK")
                    Console.WriteLine($"{racer:A}");
            }
            //使用LINQ方法语法重写这个查询
            var m = from racer in Racer.GetChampions()
                    where racer.Country == "UK"
                    orderby racer.Wins descending
                    select racer;
            foreach (var racer in m)
            {
                Console.WriteLine($"{racer:A}");
            }
            //体会LINQ的推迟查询：首先建立查询query2，查出所有胜利场数超过25，用foreach循环并打印；
            //然后将所有英国（UK）车手的国名改为“United Kingdom”；
            //再次对query2用foreach循环并打印。观赛同一查询的不同执行结果
            var n = from racer in Racer.GetChampions()
                    where racer.Wins > 25
                    orderby racer.Wins descending
                    select racer;
            foreach (var racer in n)
            {
                Console.WriteLine($"{racer:A}");
                if (racer.Country == "UK")
                    racer.Country = "United Kingdom";
            }
            foreach (var racer in n)
            {
                Console.WriteLine($"{racer:A}");
            }
            //查出首发场数超过100，并且胜利场数超过20的车手的姓名（包含名和姓）
            var p = from racer in Racer.GetChampions()
                    where racer.Starts > 100
                    where racer.Wins > 20
                    orderby racer.Wins descending
                    select racer.FirstName + " " + racer.LastName;
            foreach (var racer in p)
            {
                Console.WriteLine($"{racer:A}");
            }
            //基于现有数据，统计德国人的胜利总场数
            var q = from racer in Racer.GetChampions()
                    where racer.Country == "Germany"
                    orderby racer.Wins descending
                    select racer.Wins;
            Console.WriteLine(q.Sum());
            //进行投影查询，对于驾驭法拉利（Ferrari）车型夺冠的车手，输出人名、国别与首发胜率，
            //人名包含名和姓，首发胜率为Wins除以Starts
            var x = from racer in Racer.GetChampions()
                    from car in racer.Cars
                    where car == "Ferrari"
                    orderby racer.Wins descending
                    select racer.FirstName + " " + racer.LastName + "," + racer.Country + "," + (double)racer.Wins / racer.Starts;
            foreach (var racer in x)
            {
                Console.WriteLine($"{racer:A}");
            }
            Console.ReadLine();

        }
    }
    //编写一个静态类MyExtensions，扩展.NET Framework基本类型的功能
    public static class MyExtensions
    {
        //定义一个扩展方法IsPalindrome,判断字符串是否为回文
        public static bool IsPalindrome(this string str)
        {
            int len = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (!str[i].Equals(str[len - 1 - i]))
                    return false;
            }
            return true;
        }
        //定义一个扩展方法ReverseDigits,允许int将自己的值倒置
        public static int ReverseDigits(this int num)
        {
            int[] a = new int[10];
            int j = 0;
            int result = 0;
            for (int i = 0; ; i++)
            {
                if (num == 0)
                    break;
                a[i] = num % 10;
                j++;
                num = num / 10;
            }
            for (int k = 0; k < j; k++)
                result += (int)(a[k] * Math.Pow(10, j - k - 1));
            return result;
        }
    }

    public class Racer : IComparable<Racer>, IFormattable
    {
        public Racer(string firstName = null, string lastName = null, string country = null, int starts = 0, int wins = 0, IEnumerable<int> years = null, IEnumerable<string> cars = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Starts = starts;
            this.Wins = wins;


            var yearsList = new List<int>();
            foreach (var year in years)
            {
                yearsList.Add(year);
            }
            this.Years = yearsList.ToArray();
            var carList = new List<string>();
            foreach (var car in cars)
            {
                carList.Add(car);
            }
            this.Cars = carList.ToArray();


        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Wins { get; set; }//夺冠场数
        public int Starts { get; set; }//首发场数
        public string[] Cars { get; private set; }//赛车手获得冠军那一年使用的所有车型
        public int[] Years { get; private set; }//赛车手获得冠军的年份

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }

        public int CompareTo(Racer other)
        {
            if (other == null) throw new ArgumentNullException("other");

            return this.LastName.CompareTo(other.LastName);
        }

        public string ToString(string format)
        {
            return ToString(format, null);
        }

        public string ToString(string format,
              IFormatProvider formatProvider)
        {
            switch (format)
            {
                case null:
                case "N":
                    return ToString();
                case "F":
                    return FirstName;
                case "L":
                    return LastName;
                case "C":
                    return Country;
                case "S":
                    return Starts.ToString();
                case "W":
                    return Wins.ToString();
                case "A":
                    return String.Format("{0} {1}, {2}; starts: {3}, wins: {4}",
                          FirstName, LastName, Country, Starts, Wins);
                default:
                    throw new FormatException(String.Format("Format {0} not supported", format));
            }
        }

        public static IList<Racer> GetChampions()//1950-2008年一级方程式锦标赛冠军
        {
            IList<Racer> racers = new List<Racer>(40);
            racers.Add(new Racer("Nino", "Farina", "Italy", 33, 5, new int[] { 1950 }, new string[] { "Alfa Romeo" }));
            racers.Add(new Racer("Alberto", "Ascari", "Italy", 32, 10, new int[] { 1952, 1953 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Juan Manuel", "Fangio", "Argentina", 51, 24, new int[] { 1951, 1954, 1955, 1956, 1957 }, new string[] { "Alfa Romeo", "Maserati", "Mercedes", "Ferrari" }));
            racers.Add(new Racer("Mike", "Hawthorn", "UK", 45, 3, new int[] { 1958 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Phil", "Hill", "USA", 48, 3, new int[] { 1961 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("John", "Surtees", "UK", 111, 6, new int[] { 1964 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Jim", "Clark", "UK", 72, 25, new int[] { 1963, 1965 }, new string[] { "Lotus" }));
            racers.Add(new Racer("Jack", "Brabham", "Australia", 125, 14, new int[] { 1959, 1960, 1966 }, new string[] { "Cooper", "Brabham" }));
            racers.Add(new Racer("Denny", "Hulme", "New Zealand", 112, 8, new int[] { 1967 }, new string[] { "Brabham" }));
            racers.Add(new Racer("Graham", "Hill", "UK", 176, 14, new int[] { 1962, 1968 }, new string[] { "BRM", "Lotus" }));
            racers.Add(new Racer("Jochen", "Rindt", "Austria", 60, 6, new int[] { 1970 }, new string[] { "Lotus" }));
            racers.Add(new Racer("Jackie", "Stewart", "UK", 99, 27, new int[] { 1969, 1971, 1973 }, new string[] { "Matra", "Tyrrell" }));
            racers.Add(new Racer("Emerson", "Fittipaldi", "Brazil", 143, 14, new int[] { 1972, 1974 }, new string[] { "Lotus", "McLaren" }));
            racers.Add(new Racer("James", "Hunt", "UK", 91, 10, new int[] { 1976 }, new string[] { "McLaren" }));
            racers.Add(new Racer("Mario", "Andretti", "USA", 128, 12, new int[] { 1978 }, new string[] { "Lotus" }));
            racers.Add(new Racer("Jody", "Scheckter", "South Africa", 112, 10, new int[] { 1979 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Alan", "Jones", "Australia", 115, 12, new int[] { 1980 }, new string[] { "Williams" }));
            racers.Add(new Racer("Keke", "Rosberg", "Finland", 114, 5, new int[] { 1982 }, new string[] { "Williams" }));
            racers.Add(new Racer("Niki", "Lauda", "Austria", 173, 25, new int[] { 1975, 1977, 1984 }, new string[] { "Ferrari", "McLaren" }));
            racers.Add(new Racer("Nelson", "Piquet", "Brazil", 204, 23, new int[] { 1981, 1983, 1987 }, new string[] { "Brabham", "Williams" }));
            racers.Add(new Racer("Ayrton", "Senna", "Brazil", 161, 41, new int[] { 1988, 1990, 1991 }, new string[] { "McLaren" }));
            racers.Add(new Racer("Nigel", "Mansell", "UK", 187, 31, new int[] { 1992 }, new string[] { "Williams" }));
            racers.Add(new Racer("Alain", "Prost", "France", 197, 51, new int[] { 1985, 1986, 1989, 1993 }, new string[] { "McLaren", "Williams" }));
            racers.Add(new Racer("Damon", "Hill", "UK", 114, 22, new int[] { 1996 }, new string[] { "Williams" }));
            racers.Add(new Racer("Jacques", "Villeneuve", "Canada", 165, 11, new int[] { 1997 }, new string[] { "Williams" }));
            racers.Add(new Racer("Mika", "Hakkinen", "Finland", 160, 20, new int[] { 1998, 1999 }, new string[] { "McLaren" }));
            racers.Add(new Racer("Michael", "Schumacher", "Germany", 250, 91, new int[] { 1994, 1995, 2000, 2001, 2002, 2003, 2004 }, new string[] { "Benetton", "Ferrari" }));
            racers.Add(new Racer("Fernando", "Alonso", "Spain", 132, 21, new int[] { 2005, 2006 }, new string[] { "Renault" }));
            racers.Add(new Racer("Kimi", "R?ikk?nen", "Finland", 148, 17, new int[] { 2007 }, new string[] { "Ferrari" }));
            racers.Add(new Racer("Lewis", "Hamilton", "UK", 44, 9, new int[] { 2008 }, new string[] { "McLaren" }));

            return racers;
        }
    }

}

