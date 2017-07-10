# MySqlConnect

      using MySql.Data.MySqlClient;

      namespace MySqlConnect
      {
          public abstract class MySql
          {
              public static MySqlConnection Connection(string serverName, string databaseName, string userId, string password)
              {
                  string connectionString = "SERVER=" + serverName + ";" + "DATABASE=" + databaseName + ";" + "UID=" + userId + ";" + "PASSWORD=" + password + ";";
                  MySqlConnection connection = new MySqlConnection(connectionString);
                  return connection;
              }

          }
      }



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

