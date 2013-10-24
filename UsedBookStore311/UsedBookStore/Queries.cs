using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedBookStore
{
    public static class Queries
    {
        public static readonly string GET_ALL_FACULTY = "SELECT FacultyCode, FacultyName FROM Faculty ORDER BY FacultyName";
        public static readonly string GET_ALL_SUBJECT = "SELECT SubjectCode, SubjectName FROM Subject where FacultyCode = @FC ORDER BY SubjectName";

        public static readonly string GET_LAST_BOOK_ID = "SELECT LAST_INSERT_ID() as lastIndex FROM Book";

        //TODO: add faculty and subject and course to book
        public static string createBookQuery(Book newBook)
        {
            string query = "INSERT INTO Book VALUES (DEFAULT(BookID), '";
            query += newBook.Title + "', '";
            query += newBook.Author + "', ";
            query += newBook.Edition + ", ";
            query += newBook.ISBN + ", ";

            query += "NULL)";

            return query;
        }

        //createBookQuery must be called directly before this query
        public static string createListingQuery(Listing newListing, Int32 lastIndex)
        {
            string condition = "Good";

            switch (newListing.BookCondition)
            {
                case Listing.Condition.NotUsed:
                    condition = "NotUsed";
                    break;
                case Listing.Condition.Mint:
                    condition = "Mint";
                    break;
                case Listing.Condition.Good:
                    condition = "Good";
                    break;
                case Listing.Condition.Damaged:
                    condition = "Damaged";
                    break;
                default:
                    condition = "Good";
                    break;
            }

            string query = "INSERT INTO Listing VALUES (DEFAULT(ListingID), '";

            query += newListing.AdHeader + "', ";
            query += lastIndex + ", ";
            query += newListing.Price + ", '";
            query += newListing.Description + "', '";
            query += condition + "', ";
            query += "NULL)";

            return query;
        }

    }
}
