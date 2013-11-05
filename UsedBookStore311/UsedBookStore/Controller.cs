using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsedBookStore
{
    public class Controller
    {
        private NewListingWindow newListingWnd;

         public Controller()
         {
         }

         public void connectDB()
         {
              DatabaseManager.test();
         }

        public void showNewListingWindow()
        {
            newListingWnd = new NewListingWindow(this);
            newListingWnd.Show();
        }

        public bool verifyLogin(string username, string password)
        {
            return DatabaseManager.verifyLogin(username, password);
        }

        public void hideNewListingWindow()
        {
            newListingWnd.Hide();
            newListingWnd.Dispose();
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
            DatabaseManager.createNewListing(newListing);
            this.hideNewListingWindow();

            //bring user to their new listing

        }
	   //searchListings returns a filled DataTable based on the searchBox input
        public DataTable searchListings(string searchText, string searchCriteria)
        {
             string query = Queries.createSearchQuery(searchText, searchCriteria);
		   DataTable searchDT = DatabaseManager.getQueryDataSet(query);
		   return searchDT;
        }

    }
}
