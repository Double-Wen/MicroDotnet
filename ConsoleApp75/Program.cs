using System;
using System.Data;

//using Mysql.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApp75
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"server=mysql.liuwenwen.net;port=10136;userid=root;password=Ali123456;database=study";

            using var con = new MySqlConnection(cs);
            con.Open();

            Console.WriteLine($"MySQL version : {con.ServerVersion}");
        }
    }
}
