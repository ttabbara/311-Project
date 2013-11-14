using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedBookStore
{
    public class User
    {
        //Attributes of user
        
        private int userID;
        private string username;
        private string userPhoneNumber;
        private string userEmail;
        private List<Listing> userListings;
        private DateTime lastLogin;
        private DateTime memberSince;
          
        public User(string userName, string phoneNumber, string email)
        {
            username = userName;
            memberSince = DateTime.Now;
            userEmail = email;
            userPhoneNumber = phoneNumber;
            userListings = new List<Listing>();
        }

        public User(string userName)
        {            
            username = userName;
        }

        public int ID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public DateTime MemberSince
        {
            get { return memberSince; }
        }

        public string UserEmail
        {
             get { return userEmail; }
        }

        public string UserPhoneNumber
        {
             get { return userPhoneNumber; }
        }


        public DateTime LastLogin
        {
             get { return lastLogin; }
        }

    }
}
