using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

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

		/* BLOB INSTRUCTIONS */
		//Blob instructions for reading
		//Byte[] rawImageData = (Byte[]) reader.Items["Image"]; //("Image" is the BLOB column, reader is MySqlDataReader)
		//Turn into image using
		//DatabaseManager.byteArrayToImage(rawImageData); //turns raw byte data into an Image object
		//Turn Image into BLOB using:
		//DatabaseManager.imageToByteArray(img); //turns img of type Image into a byte array for insert/update to a BLOB field

		/* Image manipulation functions */
		public static byte[] imageToByteArray(System.Drawing.Image imageIn)
		{
			MemoryStream ms = new MemoryStream();
			imageIn.Save(ms, imageIn.RawFormat);
			return ms.ToArray();
		}

		public static Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);

            Image returnImage = null;

            try
            {
                returnImage = Image.FromStream(ms);
            }
            catch (Exception imageCannotConvert)
            {
                return DatabaseManager.getDefaultNoImage();
            }

			return returnImage;
		}

		public static bool verifyLogin(string userName, string passWord)
		{
			string query = "SELECT * FROM User WHERE UserName = @value AND PassWord = @pass";
			using (MySqlConnection myConn = new MySqlConnection(connectionString))
			{
				myConn.Open();
				using (MySqlCommand cmd = new MySqlCommand(query, myConn))
				{
					cmd.Parameters.AddWithValue("@value", userName);
					cmd.Parameters.AddWithValue("@pass", passWord);

					if (cmd.ExecuteReader().HasRows)
					{
						return true;
					}
				}
			}
			return false;
		}

        public static User getUserInfo(string username)
        {
            string query = Queries.GET_USER_INFO;
            using (MySqlConnection myConn = new MySqlConnection(connectionString))
            {
                myConn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        return new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                }
            }
        }

        public static User getUserInfo(int userID)
        {
            string query = Queries.GET_USER_INFO_FROM_ID;
            using (MySqlConnection myConn = new MySqlConnection(connectionString))
            {
                myConn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@ID", userID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        return new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                }
            }
        }


		public static bool registerUser(string userName, string passWord, string salt, string phoneNumber, string email)
		{
			using (MySqlConnection myConn = new MySqlConnection(connectionString))
			{
				myConn.Open();
				using (MySqlCommand cmd = new MySqlCommand(Queries.REGISTER_USER, myConn))
				{
					cmd.Parameters.AddWithValue("@user", userName);
					cmd.Parameters.AddWithValue("@pass", passWord);
					cmd.Parameters.AddWithValue("@salt", salt);
					cmd.Parameters.AddWithValue("@phone", phoneNumber);
					cmd.Parameters.AddWithValue("@email", email);

					if (cmd.ExecuteNonQuery() == 1)
					{
						return true;
					}
				}
			}
			return false;
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

		public static void createNewListing(Listing newListing, User currentUser)
		{
			MySqlConnection conn = DatabaseManager.getNewConnection();

			if (conn != null)
			{
				MySqlCommand cmd = conn.CreateCommand();

				//add the book
				cmd.CommandText = Queries.createBookQuery(cmd, newListing.Book);
				cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

				//get the last book that was added
				cmd.CommandText = Queries.GET_LAST_BOOK_ID;
				MySqlDataReader reader = cmd.ExecuteReader();
				reader.Read();
				Int32 lastIndex = reader.GetInt32("lastIndex");
				reader.Close();

				//add the listing
				cmd.CommandText = Queries.createListingQuery(cmd, newListing, lastIndex, currentUser);

                //only if there is an image
                if (newListing.Img != null)
				    cmd.Parameters.AddWithValue("@ImageByteArray", imageToByteArray(newListing.Img));

				cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

				conn.Close();
			}
		}

		public static DataTable getQueryDataSet(string searchText, string searchCriteria)
        {

            MySqlConnection conn = null;

            try
            {
                string query = Queries.createSearchQuery(searchText, searchCriteria);

                conn = DatabaseManager.getNewConnection();

                //query DB and return results inside DataTable

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "SEARCHED_LISTINGS");
                DataTable dt = ds.Tables["SEARCHED_LISTINGS"];

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public static Image getDefaultNoImage()
        {
            string query = "SELECT * FROM Listing WHERE ListingID = 11";
            using (MySqlConnection myConn = new MySqlConnection(connectionString))
            {
                myConn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, myConn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, myConn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "TEST");
                    DataTable dt = ds.Tables["TEST"];

                    return byteArrayToImage(dt.Rows[0]["Image"] as Byte[]);
                }
            }
        }

        public static DataTable getMyListings(int userID)
        {
            string query = Queries.GET_MY_LISTINGS;
            using (MySqlConnection myConn = new MySqlConnection(connectionString))
            {
                myConn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, myConn))
                {                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, myConn);
                    adapter.SelectCommand.Parameters.AddWithValue("@user", userID);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "TEST");
                    DataTable dt = ds.Tables["TEST"];
                    
                    return dt;
                }
            }
        }

        public static int getUserID(string usrnme)
        {
            string query = "SELECT UserID FROM User WHERE UserName = '" + usrnme + "'";
            int ident = 0;

            MySqlConnection conn = DatabaseManager.getNewConnection();
            if (conn != null)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                ident = reader.GetInt32("UserID");
                conn.Close();
            }
            Debug.WriteLine("IDent is " + ident);
            return ident;
        }

        public static void deleteListing(int listingID)
        {
            MySqlConnection conn = DatabaseManager.getNewConnection();
            if (conn != null)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = Queries.DELETE_LISTING_BY_ID;

                cmd.Parameters.AddWithValue("@LID", listingID);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}

