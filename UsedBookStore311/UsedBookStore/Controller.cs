using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedBookStore
{
    public class Controller
    {
        private NewListingWindow newListingWnd;
        private frmMainWindow mainWindow;
        private User currentUser;

         public Controller()
         {
             mainWindow = new frmMainWindow(this);
         }

         public void userLogin(User user)
         {
             this.currentUser = user;
             this.currentUser.ID = DatabaseManager.getUserID(this.currentUser.Username);
             this.mainWindow.toggleLoginButton();
             this.mainWindow.toggleGreeting(user.Username);
         }

         public void userLogout()
         {
             this.currentUser = null;
             this.mainWindow.toggleLoginButton();
         }

         public void setMainWindow(frmMainWindow wnd)
         {
             this.mainWindow = wnd;
         }

         public bool isUserLoggedIn()
         {
             return (currentUser != null);
         }

         public User getUser()
         {
             return currentUser;
         }

         public void showLoginMessage()
         {
             MessageBox.Show("Please login to use this feature.");
         }

        public void showNewListingWindow()
        {
            if (this.isUserLoggedIn())
            {
                newListingWnd = new NewListingWindow(this);
                newListingWnd.Show();
            }
            else
            {
                this.showLoginMessage();
            }
        }

        public bool verifyLogin(string username, string password)
        {
            return DatabaseManager.verifyLogin(username, password);
        }


        /**
         * New Listing Code
         */
        public List<KeyValuePair<string, int>> getFacultyCodesWithNames()
        {
            return DatabaseManager.getFacultyCodesWithNames();
        }

        public List<KeyValuePair<string, int>> getSubjectCodesWithNames(int facultyCd)
        {
            return DatabaseManager.getSubjectCodesWithNames(facultyCd);
        }

        public void createNewListing(Listing newListing)
        {
            DatabaseManager.createNewListing(newListing, this.currentUser);
            this.hideNewListingWindow();

            //bring user to their new listing
        }

        public void hideNewListingWindow()
        {
            newListingWnd.Hide();
            newListingWnd.Dispose();
        }

	   //searchListings returns a filled DataTable based on the searchBox input
        public DataTable searchListings(string searchText, string searchCriteria)
        {
           string query = Queries.createSearchQuery(searchText, searchCriteria);
		   DataTable searchDT = DatabaseManager.getQueryDataSet(query);
		   return searchDT;
        }

        public bool tryRegister(string txtRegUser, string txtRegPW, string todo, string txtPhone, string txtEmail)
        {
            if (DatabaseManager.registerUser(txtRegUser, txtRegPW, todo, txtPhone, txtEmail))
            {
                this.userLogin(DatabaseManager.getUserInfo(txtRegUser));
                return true;
            }

            return false;
        }

        public bool tryLogin(string txtUser, string txtPass)
        {
            if (DatabaseManager.verifyLogin(txtUser, txtPass))
            {
                this.userLogin(DatabaseManager.getUserInfo(txtUser));
                return true;
            }

            return false;
        }

        public DataTable getMyListings(int userID)
        {
            return DatabaseManager.getMyListings(userID);
        }
    }
}
