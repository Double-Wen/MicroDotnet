using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            string ss = "We are the world";
            int size = ss.IndexOf('e');
            Console.WriteLine(size);
            int s2 = ss.IndexOf('e', size + 1);
            Console.WriteLine(s2);
            Console.Write("\n\n\n\n\n\\n\n\n\n");
            int last = ss.LastIndexOf('e');
            Console.WriteLine(last);
            string a = "dream is possible";
            Console.WriteLine(a.StartsWith("Dream"));
            Console.WriteLine(a.StartsWith("Dream" ,true, null));
            Console.WriteLine("fresgresgesg" +
                "gresrrgsgresg" +
                "gresgesgresgrs" +
                "" +
                "gresgesrg" +
                "gresges");
            string s1 = "hello World";
            string s3 = "hello World";
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1.Equals(s3));

        }
    }
}
