using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedBookStore
{
    public class Book
    {
        //Attributes
        private string title;
        private string author;
        private int edition;
        private long isbn;
        

        //Constructor
        public Book(string bkTitle, string bkAuthor, int bkEdition, long bkIsbn)
        {
            title = bkTitle;
            author = bkAuthor;
            edition = bkEdition;
            isbn = bkIsbn;
        }


        //Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Edition
        {
            get { return edition; }
            set { edition = value; }
        }

        public long ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }


    }
}
