using System;
using System.IO;
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

        bool hasError = false;
        string error = "";

       Image img = null;

        public void displayError()
        {
            //create message box to display error
            MessageBox.Show("Fix the following to increase ad views:\n" + error);
        }

        public void addError(string msg)
        {
            hasError = true;
            error += "- " + msg + "\n";
        }

        public void clearError()
        {
            hasError = false;
            error = "";
        }


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
            string title = this.HeadlineInput.Text;
            if (title.Length == 0)
            {
                this.addError("Please provide a book title.");
            }

            string author = this.AuthorInput.Text;
            if (author.Length == 0)
            {
                this.addError("Please provide the book's author.");
            }

            int editionNum = this.EditionInput.SelectedIndex + 1;

            string isbn = this.ISBNInput.Text;
            long isbnNum = 0;
            if (isbn.Length != 0)
            {
                try
                {
                    isbnNum = Convert.ToInt64(isbn);
                }
                catch (Exception except)
                {
                    this.addError("Please provide a proper ISBN value.");
                }
            }

            //TODO
            //faculty
            //department
            //course

            Book listedBook = new Book(title, author, editionNum, isbnNum);
            if (listedBook == null)
            {
                this.addError("Error 1001: The book object could not be created.");
            }

            //create the listing
            string header = this.HeadlineInput.Text;
            if (header.Length < 5)
            {
                this.addError("This headline is too short. Please give a headline 5 or more characters.");
            }

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
                this.addError("This is not a valid price.");
            }

            string description = this.DescriptionInput.Text;
            if (description.Length == 0)
            {
                this.addError("Please provide a description.");
            }
    
            Listing.Condition conditionEnum = (Listing.Condition) this.ConditionInput.SelectedValue;

            //create listing using raw image data, whether null or not (check null in insert query)
            Listing newListing = new Listing(title, listedBook, priceNum, description, conditionEnum, img, controller.getUser().ID);
            if (newListing == null)
            {
                this.addError("Error 1002: The listing could not be created.");
            }

            if (this.hasError) //one or more errors, display them
            {
                this.displayError();
                this.clearError();
            }
            else //has no errors
            {
                //Send the listing to the database
                this.controller.createNewListing(newListing);

                //TODO: move user to the new listing that they just inserted?
            }
        }

        private void FacultyCdInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<string, int> pair = (KeyValuePair<string, int>) this.FacultyCdInput.SelectedItem;

            int facultyCd = pair.Value;

            this.updateDepartmentList(facultyCd);
        }

        private void initFacultyList()
        {
            //query and add all faculty codes with names (should return List<KeyValuePairs<string, int>>) (sort it in the SQL)
            
            List<KeyValuePair<string, int>> facultyCodes = this.controller.getFacultyCodesWithNames();
              
            this.FacultyCdInput.DataSource = new BindingSource(facultyCodes, null);
            this.FacultyCdInput.DisplayMember = "Key";
            this.FacultyCdInput.ValueMember = "Value";
        
            //first index is automatically selected and the change event is fired
            
        }

        private void updateDepartmentList(int facultyCd)
        {
            //query and add all Subject codes with names (should return List<KeyValuePairs<string, int>>) (sort it in the SQL)

            List<KeyValuePair<string, int>> subjectCodes = this.controller.getSubjectCodesWithNames(facultyCd);
              
            this.SubjectCdInput.DataSource = new BindingSource(subjectCodes, null);
            this.SubjectCdInput.DisplayMember = "Key";
            this.SubjectCdInput.ValueMember = "Value";

            //already selects the first index
            
        }

        private void UploadFileBtn_Click(object sender, EventArgs e)
        {
            UploadFileDialog.Filter = "Image|*.jpeg;*.jpg;*.png;*.gif;*.bmp";
            DialogResult result = UploadFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = UploadFileDialog.FileName;

                img = Image.FromFile(filename);
                if (img == null)
                {
                    MessageBox.Show("Could not convert image.");
                }
                else
                {
                    //Image too large
                    Size imgSize = img.Size;
                    if (imgSize.Height * imgSize.Width > 1048576)
                    {
                        MessageBox.Show("Image is too large, 1024x1024 pixel limit.");
                        img = null;
                    }
                    else //Everything was okay
                    {
                        FileNameLbl.Text = filename;
                    }
                }
            }
            else //Dialog not okay
            {
                img = null;
            }
        }
    }
}
