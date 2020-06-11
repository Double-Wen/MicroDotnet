using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Object obj = null;
                int i = (int)obj;
            }
            catch(Exception ex)
            {
                Console.WriteLine("fedr" + ex);
            }
            finally
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
