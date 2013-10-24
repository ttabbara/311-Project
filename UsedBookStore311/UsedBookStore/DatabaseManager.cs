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

          private static MySqlConnection getNewConnection()
          {
              MySqlConnection conn = null;
              try
              {
                  conn = new MySqlConnection(connectionString);

                  conn.Open();
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

              return conn;
          }

         public static List<KeyValuePair<string, int>> getFacultyCodesWithNames()
         {
             List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();

             MySqlConnection conn = DatabaseManager.getNewConnection();
             if (conn != null)
             {
                 MySqlCommand cmd = conn.CreateCommand();
                 cmd.CommandText = Queries.GET_ALL_FACULTY;

                 MySqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     Int32 code = reader.GetInt32("FacultyCode");
                     String name = reader.GetString("FacultyName");

                     KeyValuePair<string, int> pair = new KeyValuePair<string, int>(name, code);
                     result.Add(pair);
                 }

                 conn.Close();
             }

             return result;
         }

         public static List<KeyValuePair<string, int>> getSubjectCodesWithNames(int facultyCd)
         {
             List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();

             MySqlConnection conn = DatabaseManager.getNewConnection();
             if (conn != null)
             {
                 MySqlCommand cmd = conn.CreateCommand();
                 cmd.CommandText = Queries.GET_ALL_SUBJECT;

                 cmd.Parameters.Add("@FC", MySqlDbType.Int32);
                 cmd.Parameters["@FC"].Value = facultyCd;

                 MySqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     Int32 code = reader.GetInt32("SubjectCode");
                     String name = reader.GetString("SubjectName");

                     KeyValuePair<string, int> pair = new KeyValuePair<string, int>(name, code);
                     result.Add(pair);
                 }

                 conn.Close();
             }

             return result;
         }

         public static void createNewListing(Listing newListing)
         {
             MySqlConnection conn = DatabaseManager.getNewConnection();

             if (conn != null)
             {
                 MySqlCommand cmd = conn.CreateCommand();

                 //add the book
                 cmd.CommandText = Queries.createBookQuery(newListing.Book);
                 cmd.ExecuteNonQuery();

                 //get the last book that was added
                 cmd.CommandText = Queries.GET_LAST_BOOK_ID;
                 MySqlDataReader reader = cmd.ExecuteReader();
                 reader.Read();
                 Int32 lastIndex = reader.GetInt32("lastIndex");
                 reader.Close();

                 //add the listing
                 cmd.CommandText = Queries.createListingQuery(newListing, lastIndex);
                 cmd.ExecuteNonQuery();

                 conn.Close();
             }
         }
     }
}
