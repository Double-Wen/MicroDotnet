using System;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "我";
            //根据汉字获取编码
            byte[] UTF8Byte = Encoding.GetEncoding("UTF-8").GetBytes(str);
            //foreach(byte i in UTF8Byte)
            //{
            //    Console.WriteLine(i);
            //}
            //UTF8Byte[2] += 1;
            string ss;
            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    ss =  Encoding.UTF8.GetString(UTF8Byte);
                    Console.Write(ss + " ");
                    UTF8Byte[2] += 1;
                }
                Console.WriteLine("");
            }
            string UTF8String = Encoding.UTF8.GetString(UTF8Byte);
            Console.WriteLine(UTF8String);
        }
    }
}
