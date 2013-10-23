using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedBookStore
{
    public partial class NewListingWindow : Form
    {
        Controller controller;

        public NewListingWindow(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

            this.initFacultyList();

            //Int32 facultyCd = (Int32) this.FacultyCdInput.SelectedValue;
            //this.updateDepartmentList(facultyCd);

            //fill edition drop-down
            for (int i = 1; i <= 20; i++)
            {
                this.EditionInput.Items.Add(i);
            }

            if (this.EditionInput.Items.Count > 0)
                this.EditionInput.SelectedIndex = 0;

            //fill condition drop-down
            List<KeyValuePair<string, Listing.Condition>> condValues = new List<KeyValuePair<string, Listing.Condition>>();
            condValues.Add(new KeyValuePair<string, Listing.Condition>("Brand New", Listing.Condition.NotUsed));
            condValues.Add(new KeyValuePair<string, Listing.Condition>("Mint", Listing.Condition.Mint));
            condValues.Add(new KeyValuePair<string, Listing.Condition>("Good", Listing.Condition.Good));
            condValues.Add(new KeyValuePair<string, Listing.Condition>("Damaged", Listing.Condition.Damaged));

            this.ConditionInput.DataSource = new BindingSource(condValues, null);
            this.ConditionInput.DisplayMember = "Key";
            this.ConditionInput.ValueMember = "Value";
        }

        private void CreateListingBtn_Click(object sender, EventArgs e)
        {
            //create the book
            string title = this.TitleInput.Text;
            string author = this.AuthorInput.Text;

            string edition = this.EditionInput.SelectedText;
            int editionNum = Convert.ToInt32(edition);

            string isbn = this.ISBNInput.Text;
            long isbnNum = Convert.ToInt64(isbn);

            Book listedBook = new Book(title, author, editionNum, isbnNum);

            //create the listing
            string header = this.HeadlineInput.Text;

            string price = this.PriceInput.Text;
            double priceNum = 0.0;
            //******************************************************
            //TODO: format price text for more appropriate formatting
            //******************************************************
            try
            {
                priceNum = Convert.ToDouble(price);
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }

            string description = this.DescriptionInput.Text;
    
            Listing.Condition conditionEnum = (Listing.Condition) this.ConditionInput.SelectedValue;

            Listing newListing = new Listing(title, listedBook, priceNum, description, conditionEnum);

            //TODO: Send the listing to the database
            //DatabaseManager.createListing(newListing);

            //move user to the new listing that they just inserted?
        }

        private void FacultyCdInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int facultyCd = (int) this.FacultyCdInput.SelectedValue;
            this.updateDepartmentList(facultyCd);
        }

        private void initFacultyList()
        {
            //TODO
            //query and add all faculty codes with names (should return List<KeyValuePairs<string, int>>) (sort it in the SQL)
            /*
             * List<KeyValuePair<string, int>> facultyCodes = DatabaseManager.getFacultyCodesWithNames();
             * 
             * this.FacultyCdInput.DataSource = new BindingSource(facultyCodes, null);
             * this.FacultyCdInput.DisplayMember = "Key";
             * this.FacultyCdInput.ValueMember = "Value";
             * 
             * //set index to the first
            */
        }

        private void updateDepartmentList(int facultyCd)
        {
            //query and add all dept codes with names (should return List<KeyValuePairs<string, int>>) (sort it in the SQL)
            /*
             * List<string> departmentCodes = DatabaseManager.getDepartmentCodesWithNames((int) this.FacultyCdInput.SelectedItem.Value);
             * 
             * this.DepartmentCdInput.DataSource = new BindingSource(facultyCodes, null);
             * this.DepartmentCdInput.DisplayMember = "Key";
             * this.DepartmentCdInput.ValueMember = "Value";
            */
        }
    }
}
