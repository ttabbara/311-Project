using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UsedBookStore
{
     public static class DatabaseManager
     {
          private static readonly int portNumber = 3306;
          private static readonly String host = "www.fasteamwindsor.org";
          private static readonly String hostIP = "50.87.148.158;";
          private static readonly String databaseName = "matthew3_311project;";
          private static readonly String username = "matthew3_311proj;";
          private static readonly String password = "matthew3_311proj;";
          private static readonly String connectionString = "Server=" + hostIP + "Port=" + portNumber + "; Database=" + databaseName + "; Uid=" + username + "; Pwd=" + password;
          //private stati
          public static void test()
          {
               MySqlConnection conn;
               try
               {
                    conn = new MySqlConnection(connectionString);
                   
                    conn.Open();
                    Console.WriteLine("Successfully connected to DB");
                    Console.WriteLine("\n closing connection.");
                    conn.Close();
               }
               catch (MySqlException ex)
               {
                    switch (ex.Number)
                    {
                         case 0:
                              Console.WriteLine("Cannot connect to server.  Contact administrator");
                              break;
                         case 1045:
                              Console.WriteLine("Invalid username/password, please try again");
                              break;
                    }
               }

          }
     }
}
