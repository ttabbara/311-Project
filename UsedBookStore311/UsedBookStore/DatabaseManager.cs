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
          private static readonly String databaseName = "matthew3_311project";
          private static readonly String username = "matthew3_311proj";
          private static readonly String password = "matthew3_311proj";
          private static readonly String connectionString = "Server=" + host + "Port=" + portNumber + "; Database=" + databaseName + "; Uid=" + username + "; Pwd=" + password;
          
          public static void test()
          {
               try
               {

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                         conn.Open();
                         System.Diagnostics.Debug.Write("Successfully connected to DB");
                         System.Diagnostics.Debug.Write("\n closing connection.");
                    }
               }
               catch (MySqlException ex)
               {
                    //switch (ex.Number)
                    //{
                    //     case 0:
                    //          System.Diagnostics.Debug.Write("Cannot connect to server.  Contact administrator");
                    //     case 1045:
                    //          System.Diagnostics.Debug.Write("Invalid username/password, please try again");
                    //}
               }

          }
     }
}
