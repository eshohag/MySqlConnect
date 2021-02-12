# MySql Connections Information
[![Build status](https://ci.appveyor.com/api/projects/status/67ubhtmijuhyhq6q?svg=true)](https://ci.appveyor.com/project/eshohag/MySqlConnect)
[![NuGet Badge](https://buildstats.info/nuget/MySqlConnect)](https://www.nuget.org/packages/MySqlConnect)

# Test to run this package on Console app -

using MySql.Data.MySqlClient;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection connection = MySqlConnect.MySql.Connection("Your Server Name", "Your Database Name", "Your User ID", "Your Password");

            //Do something your code here

            Console.ReadKey();
        }
    }
}
