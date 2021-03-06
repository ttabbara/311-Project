﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace UsedBookStore
{
    public static class Queries
    {
        public static readonly string GET_ALL_FACULTY = "SELECT FacultyCode, FacultyName FROM Faculty ORDER BY FacultyName";
        public static readonly string GET_ALL_SUBJECT = "SELECT SubjectCode, SubjectName FROM Subject where FacultyCode = @FC ORDER BY SubjectName";
        public static readonly string GET_LAST_BOOK_ID = "SELECT LAST_INSERT_ID() as lastIndex FROM Book";
        public static readonly string REGISTER_USER = "INSERT INTO User (UserName, PassWord, Salt, PhoneNumber, Email, MemberSince) VALUES (@user,@pass, @salt,@phone,@email, CURRENT_TIMESTAMP)";
        public static readonly string GET_MY_LISTINGS = "SELECT ListingID, Header, BookID, Price, Listing.Desc, Listing.Condition, Image, PosterID FROM Listing WHERE PosterID = @user AND Listing.Deleted IS NULL";
        public static readonly string GET_USER_INFO = "SELECT UserID, UserName, PhoneNumber, Email FROM User WHERE UserName = @userName";
        public static readonly string GET_USER_INFO_FROM_ID = "SELECT UserID, UserName, PhoneNumber, Email FROM User WHERE UserID = @ID";
        public static readonly string DELETE_LISTING_BY_ID = "UPDATE Listing SET Deleted = NOW() WHERE ListingID = @LID";


        //TODO: add faculty and subject and course to book
        public static string createBookQuery(MySqlCommand cmd, Book newBook)
        {
            string query = "INSERT INTO Book VALUES (DEFAULT(BookID), @title, @author, @edition, @isbn, NULL)";

            cmd.Parameters.AddWithValue("@title", newBook.Title);
            cmd.Parameters.AddWithValue("@author", newBook.Author);
            cmd.Parameters.AddWithValue("@edition", newBook.Edition);
            cmd.Parameters.AddWithValue("@isbn", newBook.ISBN);

            return query;
        }

        //createBookQuery must be called directly before this query
        public static string createListingQuery(MySqlCommand cmd, Listing newListing, Int32 lastIndex, User currentUser)
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

            string query = "INSERT INTO Listing VALUES (DEFAULT(ListingID), @header, @bookid, @price, @desc, @cond, @image, DEFAULT(DELETED), @posterid)";

            cmd.Parameters.AddWithValue("@header", newListing.AdHeader);
            cmd.Parameters.AddWithValue("@bookid", lastIndex);
            cmd.Parameters.AddWithValue("@price", newListing.Price);
            cmd.Parameters.AddWithValue("@desc", newListing.Description);
            cmd.Parameters.AddWithValue("@cond", condition);
            
            cmd.Parameters.AddWithValue("@image", DatabaseManager.imageToByteArray(newListing.Img));

            cmd.Parameters.AddWithValue("@posterid", currentUser.ID);

            return query;
        }

        public static string createSearchQuery(string searchText, string searchCriteria)
        {
             string query = null;

             switch (searchCriteria)
             {
                  case "Author":
                       query = "SELECT * FROM Listing L Where L.Deleted IS NULL AND L.BookID IN (SELECT B.BookID FROM Book B WHERE B.Author COLLATE UTF8_GENERAL_CI LIKE " + "'%" + searchText + "%')";
                       break;
                  case "Course Code":
                        //TODO
                       break;
                  case "ISBN":
                       query = "SELECT * FROM Listing L WHERE L.Deleted IS NULL AND L.BookID IN (SELECT B.BookID FROM Book B WHERE B.ISBN = " + "'" + searchText + "')";
                       break;
                  case "Title":
                       query = "SELECT * FROM Listing L WHERE L.Deleted IS NULL AND L.BookID IN (SELECT B.BookID FROM Book B WHERE B.Title COLLATE UTF8_GENERAL_CI LIKE " + "'%" + searchText + "%')";
                       break;
                  default:
                       break;
             }
             return query;
        }

    }
}
