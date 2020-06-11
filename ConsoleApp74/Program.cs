using System;
using System.Net;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            string IP;
            string name;
            for(int i=1; i<255; i++)
            {
                IP = "192.168.123." + i;
                try
                {
                    IPHostEntry host = Dns.GetHostEntry(IP);
                    name = host.HostName.ToString();
                    Console.WriteLine(IP + " " + name);
                }
                catch(Exception ex)
                {
                    //Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
