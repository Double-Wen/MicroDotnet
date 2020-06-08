using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFile = "Program.cs";
            string fileName = strFile.Substring(0, strFile.IndexOf('.'));
            string extName = strFile.Substring(strFile.IndexOf('.'));
            Console.WriteLine(fileName);
            Console.WriteLine(extName);
            string ss = "fre;fresf;fres;;fresfgres;gesr;gres";
            char[] sep = { ';' };
            string[] splitStrings = ss.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            foreach(string buff in splitStrings)
            {
                Console.WriteLine(buff);
            }
        }
    }
}
