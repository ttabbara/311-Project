using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsedBookStore
{
    public class Controller
    {
         public Controller()
         {
         }

         public void connectDB()
         {
              DatabaseManager.test();
         }

        public void showNewListingWindow()
        {
            NewListingWindow newListingWnd = new NewListingWindow(this);
            newListingWnd.Show();
        }

    }
}
