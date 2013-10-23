using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedBookStore
{
    class Listing
    {
        //Book conditions
        public enum Condition { NotUsed, Mint, Good, Damaged }

        private string adHeader;
        private int userID;
        private Book book;
        private double bookPrice;    
        private string description;
        private DateTime timePosted;
        private Condition condition;

        public Listing(string title, Book listedBook, double price, string adDescription, Condition bookCondition)
        {
            adHeader = title;
            book = listedBook;
            bookPrice = price;
            description = adDescription;
            timePosted = DateTime.Now;
            condition = bookCondition;
        }


        public string AdHeader
        {
            get { return adHeader; }
            set { adHeader = value; }
        }
        public int UserID
        {
             get { return userID; }
             set { userID = value; }
        }

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        public double Price
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Condition BookCondition
        {
            get { return condition; }
            set { condition = value; }
        }

        public DateTime TimePosted
        {
             get { return timePosted; }
        }

    }
}
