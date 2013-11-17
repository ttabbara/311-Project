﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UsedBookStore
{
    public static class Queries
    {
        public static readonly string GET_ALL_FACULTY = "SELECT FacultyCode, FacultyName FROM Faculty ORDER BY FacultyName";
        public static readonly string GET_ALL_SUBJECT = "SELECT SubjectCode, SubjectName FROM Subject where FacultyCode = @FC ORDER BY SubjectName";
        public static readonly string GET_LAST_BOOK_ID = "SELECT LAST_INSERT_ID() as lastIndex FROM Book";
        public static readonly string REGISTER_USER = "INSERT INTO User (UserName, PassWord, Salt, PhoneNumber, Email, MemberSince) VALUES (@user,@pass, @salt,@phone,@email, CURRENT_TIMESTAMP)";
        public static readonly string GET_MY_LISTINGS = "SELECT ListingID, Header, BookID, Price, Listing.Desc, Listing.Condition, Image, PosterID FROM Listing WHERE PosterID = @user";
        public static readonly string GET_USER_INFO = "SELECT UserID, UserName, PhoneNumber, Email FROM User WHERE UserName = @userName";
        public static readonly string GET_USER_INFO_FROM_ID = "SELECT UserID, UserName, PhoneNumber, Email FROM User WHERE UserID = @ID";

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
        public static string createListingQuery(Listing newListing, Int32 lastIndex, User currentUser)
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

  //          query += currentUser.ID + ", '";
            query += newListing.AdHeader + "', ";
            query += lastIndex + ", ";
            query += newListing.Price + ", '";
            query += newListing.Description + "', '";
            query += condition + "', ";
            

            //output the BLOB (byte array) into the listing
            if (newListing.Img == null)
            {
                query += "DEFAULT(Image), ";
            }
            else
            {
                query += "@ImageByteArray, ";
            }

            //deleted date is null by default
            query += "DEFAULT(Deleted), ";

            query += "'" + currentUser.ID + "')";

            //Debug.WriteLine(query);

            return query;
        }

        public static string createSearchQuery(string searchText, string searchCriteria)
        {
             string query = null;

             switch (searchCriteria)
             {
                  case "Author":
                       query = "SELECT * FROM Listing L Where L.BookID IN (SELECT B.BookID FROM Book B WHERE B.Author COLLATE UTF8_GENERAL_CI LIKE " + "'%" + searchText + "%')";
                       break;
                  case "Course Code":
                       break;
                  case "ISBN":
                       query = "SELECT * FROM Listing L WHERE L.BookID IN (SELECT B.BookID FROM Book B WHERE B.ISBN = " + "'" + searchText+ "')";
                       break;
                  case "Title":
                       query = "SELECT * FROM Listing L WHERE L.BookID IN (SELECT B.BookID FROM Book B WHERE B.Title COLLATE UTF8_GENERAL_CI LIKE " + "'%" + searchText + "%')";
                       break;
                  default:
                       break;
             }
             return query;
        }

    }
}
