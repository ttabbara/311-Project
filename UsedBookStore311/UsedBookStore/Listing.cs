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
        public enum Condition { Mint, Good, Damaged }

        private string adHeader;
        private int userID;
        private Book book;
        private double bookPrice;
        private bool used;        
        private string description;
        private string condition;
        private DateTime timePosted;
        

        public Listing(string title, Book listedBook, double price, bool isUsed, string adDescription, Condition bookCondition)
        {
            adHeader = title;
            book = listedBook;
            bookPrice = price;
            used = isUsed;
            description = adDescription;
            timePosted = DateTime.Now;

            if (used)
            {
                condition = bookCondition.ToString();
            }
            else
            {
                condition = Condition.Mint.ToString();
            }
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

        public bool Used
        {
            get { return used; }
            set { used = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string BookCondition
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
