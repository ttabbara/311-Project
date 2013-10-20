using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedBookStore
{
    class User
    {
        //Attributes of user
        private string username;
        private string password;
        private List<Listing> userListings;
        private DateTime memberSince;

        public User(string userName, string passWord)
        {
            username = userName;
            password = passWord;
            memberSince = DateTime.Now;
            userListings = new List<Listing>();
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public DateTime MemberSince
        {
            get { return memberSince; }
        }

    }
}
