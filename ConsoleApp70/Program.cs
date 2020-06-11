using System;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if( 0 == 0)
                {
                    throw new DivideByZeroException();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
