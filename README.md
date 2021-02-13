# MySql Connections Information [![Build status](https://ci.appveyor.com/api/projects/status/67ubhtmijuhyhq6q?svg=true)](https://ci.appveyor.com/project/eshohag/MySqlConnect) [![NuGet Badge](https://buildstats.info/nuget/MySqlConnect)](https://www.nuget.org/packages/MySqlConnect)

### Namespace
    using MySqlConnect
    
### Code Syntax-
    using MySql.Data.MySqlClient;
    using MySqlConnect;
    using System;
    
    namespace ConsoleApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                //***************MYSQL Database Connections******************
                MySqlConnection connection = MySQL.Connection("Your Server Name", "Your Database Name", "Your User ID", "Your Password");

                //Do something your code here

                Console.ReadKey();
            }
        }
    }
