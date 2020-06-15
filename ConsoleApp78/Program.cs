using System;
using System.IO;
using System.Net;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Copy(@"C:\Users\Administrator\Desktop\test\hello.txt", @"C:\Users\Administrator\Desktop\test\world.txt", true);
            //FileInfo foo = new FileInfo(@"C:\Users\Administrator\Desktop\test\hello.txt");
            //foo.CopyTo(@"C:\Users\Administrator\Desktop\test\hello.txt");
            //File.Move(@"C:\Users\Administrator\Desktop\test\hello.txt", @"C:\Users\Administrator\Desktop\test\hfewa.txt");
            //FileInfo bar = new FileInfo(@"C:\Users\Administrator\Desktop\test\world.txt");
            //bar.MoveTo(@"C:\Users\Administrator\Desktop\test\wowo.txt");
            //File.Delete(@"C:\Users\Administrator\Desktop\test\wowo.txt");
            FileInfo qux = new FileInfo(@"C:\Users\Administrator\Desktop\test\hfewa.txt");
            qux.Delete();

        }
    }
}
